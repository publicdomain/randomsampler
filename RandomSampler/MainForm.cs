// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace RandomSampler
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using Microsoft.VisualBasic;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// The samples path list.
        /// </summary>
        private List<string> samplesPathList = new List<string>();

        /// <summary>
        /// The random.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// The current directory.
        /// </summary>
        private string currentDirectory = Application.StartupPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:RandomSampler.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

            /* Settings data */

            // Populate GUI with settings, with new or existing 
            this.SettingsToGui(!File.Exists(this.settingsDataPath));
        }

        /// <summary>
        /// Settingses to GUI.
        /// </summary>
        private void SettingsToGui(bool newSettings)
        {
            // Check for new settings
            if (newSettings)
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);

            // Set GUI
            this.alwaysOnTopToolStripMenuItem.Checked = this.settingsData.AlwaysOnTop;
            this.addcheckedToolStripMenuItem.Checked = this.settingsData.AddChecked;
            this.checkOnClickToolStripMenuItem.Checked = this.settingsData.CheckOnClick;
            this.scanSubdirectoriesToolStripMenuItem.Checked = this.settingsData.ScanSubdirectories;
            this.samplesNumericUpDown.Value = this.settingsData.Samples;
            this.sequentialSaveCheckBox.Checked = this.settingsData.SequentialSave;

            // Set topmost
            this.TopMost = this.settingsData.AlwaysOnTop;
        }

        /// <summary>
        /// Handles the browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            // Set description
            this.folderBrowserDialog.Description = "Set samples directory";

            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Clear lists
                this.samplesListView.Items.Clear();

                // Populate samples path list
                foreach (var fileExtension in this.settingsData.FileExtensions.Split(','))
                {
                    foreach (string file in Directory.GetFiles(this.folderBrowserDialog.SelectedPath, $"*.{fileExtension}", this.scanSubdirectoriesToolStripMenuItem.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
                    {
                        // Add current file
                        this.samplesPathList.Add(file);
                    }
                }

                // Set samples directory
                this.settingsData.samplesDirectory = this.folderBrowserDialog.SelectedPath;

                // Get samples
                this.GetSamples();
            }
        }

        /// <summary>
        /// Gets the samples.
        /// </summary>
        private void GetSamples()
        {
            // Check for samples
            if (this.samplesPathList.Count == 0)
            {
                // Advise user
                MessageBox.Show("No samples in path list.", "Get samples", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Halt flow
                return;
            }

            // Populate samples list view
            while (this.samplesListView.Items.Count < this.samplesNumericUpDown.Value)
            {
                // Set random sample file index
                int index = random.Next(0, this.samplesPathList.Count);

                // Set current random sample file path
                string file = this.samplesPathList[index];

                // Set item to file name 
                ListViewItem item = new ListViewItem(Path.GetFileName(file))
                {
                    // Store full path as tag
                    Tag = file
                };

                // Add item to list 
                this.samplesListView.Items.Add(item);

                // Remove file from path list
                this.samplesPathList.RemoveAt(index);

                // Check for viable samples amount
                if (this.samplesPathList.Count == 0)
                {
                    // Halt flow
                    break;
                }
            }

            // Set column width
            this.samplesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Update samples count
            this.samplesCountToolStripStatusLabel.Text = this.samplesListView.Items.Count.ToString();
            this.eligibleSamplesCountToolStripStatusLabel.Text = this.samplesPathList.Count.ToString();
        }

        /// <summary>
        /// Handles the preview button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPreviewButtonClick(object sender, EventArgs e)
        {
            // Check for something selected
            if (this.samplesListView.SelectedItems.Count > 0)
            {
                // Launch selected item(s)
                foreach (ListViewItem item in this.samplesListView.SelectedItems)
                {
                    // Launch current one
                    Process.Start(item.Tag.ToString());
                }
            }
        }

        /// <summary>
        /// Handles the delete button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDeleteButtonClick(object sender, EventArgs e)
        {
            // Prevent drawing
            this.samplesListView.BeginUpdate();

            // Remove all selected items
            while (this.samplesListView.SelectedItems.Count > 0)
            {
                this.samplesListView.Items.RemoveAt(this.samplesListView.SelectedIndices[0]);
            }

            // Resume drawing
            this.samplesListView.EndUpdate();

            // Update samples count
            this.samplesCountToolStripStatusLabel.Text = this.samplesListView.Items.Count.ToString();
        }

        /// <summary>
        /// Handles the eight button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnEightButtonClick(object sender, EventArgs e)
        {
            // Set samples value
            this.samplesNumericUpDown.Value = 8;
        }

        /// <summary>
        /// Handles the sixteen button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSixteenButtonClick(object sender, EventArgs e)
        {
            // Set samples value
            this.samplesNumericUpDown.Value = 16;
        }

        /// <summary>
        /// Handles the thirty two button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnThirtyTwoButtonClick(object sender, EventArgs e)
        {
            // Set samples value
            this.samplesNumericUpDown.Value = 32;
        }

        /// <summary>
        /// Handles the forty eight button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFortyEightButtonClick(object sender, EventArgs e)
        {
            // Set samples value
            this.samplesNumericUpDown.Value = 48;
        }

        /// <summary>
        /// Handles the sixty four button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSixtyFourButtonClick(object sender, EventArgs e)
        {
            // Set samples value
            this.samplesNumericUpDown.Value = 64;
        }

        /// <summary>
        /// Handles the get samples button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGetSamplesButtonClick(object sender, EventArgs e)
        {
            // Trigger get samples
            this.GetSamples();
        }

        /// <summary>
        /// Handles the save button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            // Check for checked files
            if (this.samplesListView.CheckedItems.Count == 0)
            {
                // Advise user
                MessageBox.Show("No checked samples to save.", "No files", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Halt flow    
                return;
            }

            try
            {
                // Check for sequential save
                if (this.sequentialSaveCheckBox.Checked)
                {
                    // Set directory info
                    var directoryInfo = new DirectoryInfo(this.currentDirectory);

                    // Try to parse as int
                    int firstDirectoryDescInt = 0;

                    // Check for subdirectories
                    if (directoryInfo.GetDirectories().Length > 0)
                    {
                        // Determine the highest
                        string firstDirectoryDesc = new DirectoryInfo(this.currentDirectory)
                        .GetDirectories()
                        .OrderByDescending(d => d.Name)
                        .FirstOrDefault()
                        .ToString();

                        int.TryParse(Path.GetFileNameWithoutExtension(firstDirectoryDesc), out firstDirectoryDescInt);
                    }

                    string targetDirectory = Path.Combine(this.currentDirectory, (firstDirectoryDescInt + 1).ToString());

                    Directory.CreateDirectory(targetDirectory);

                    foreach (ListViewItem item in this.samplesListView.CheckedItems)
                    {
                        // Save to target directory
                        File.Copy(item.Tag.ToString(), Path.Combine(targetDirectory, Path.GetFileName(item.Tag.ToString())));
                    }
                }
                else
                {
                    // Set description
                    this.folderBrowserDialog.Description = "Save samples to directory";

                    // Reset selected path
                    this.folderBrowserDialog.SelectedPath = string.Empty;

                    // Show folder browser dialog
                    if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
                    {
                        foreach (ListViewItem item in this.samplesListView.CheckedItems)
                        {
                            // Save to selected directory
                            File.Copy(item.Tag.ToString(), Path.Combine(this.folderBrowserDialog.SelectedPath, Path.GetFileName(item.Tag.ToString())));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show(ex.Message, "Sequential save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Ask user for resetting settings data
            if (MessageBox.Show("Reset all settings afresh?", "New settings data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Generate new settings and use them for GUI
                this.SettingsToGui(true);
            }
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set clicked item
            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            // Set file extensions
            if (clickedItem.Name == "setFileExtensionsToolStripMenuItem")
            {
                // TODO Prevent z-order [Can be made conditional]
                this.TopMost = false;

                // Set file extensions from user input
                string fileExtensions = Interaction.InputBox("Enter samples' file extensions (comma-separated):", "Set file extensions", this.settingsData.FileExtensions);

                // TODO Check it's not empty [Can have further / specialized checks]
                if (fileExtensions.Length > 0)
                {
                    // Split by non alphanumeric characters
                    this.settingsData.FileExtensions = string.Join(",", Regex.Split(fileExtensions.ToLower(), @"[^a-zA-Z0-9]").Where(s => s != String.Empty).ToArray<string>());
                }
            }
            else
            {
                // Toggle checked
                clickedItem.Checked = !clickedItem.Checked;

                // TODO Set topmost [Can be tested for topmost menu item click]
                this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
            }
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open orignal thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=52122.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/randomsampler");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Shuffle icon by raphaelsilva - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/shuffle-icon-player-button-outline-2297766/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P.{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: Beth UK{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #36, Week #05 @ February 05, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error when saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Set GUI
            this.settingsData.AlwaysOnTop = this.alwaysOnTopToolStripMenuItem.Checked;
            this.settingsData.AddChecked = this.addcheckedToolStripMenuItem.Checked;
            this.settingsData.CheckOnClick = this.checkOnClickToolStripMenuItem.Checked;
            this.settingsData.ScanSubdirectories = this.scanSubdirectoriesToolStripMenuItem.Checked;
            this.settingsData.Samples = this.samplesNumericUpDown.Value;
            this.settingsData.SequentialSave = this.sequentialSaveCheckBox.Checked;

            // Save settings data to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
