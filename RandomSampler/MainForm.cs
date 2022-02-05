﻿// <copyright file="MainForm.cs" company="PublicDomain.is">
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
            this.sequentialCheckBox.Checked = this.settingsData.SequentialSave;

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
            for (int i = 0; i < Math.Min(this.samplesNumericUpDown.Value, this.samplesPathList.Count); i++)
            {
                // TODO Check if list view items are complete to account for repeated samples requests [Can be made differently / more efficiently]
                if (this.samplesListView.Items.Count >= this.samplesNumericUpDown.Value)
                {
                    // Halt flow
                    break;
                }

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
            }

            // Set column width
            this.samplesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Update file count
            this.fileCountToolStripStatusLabel.Text = this.samplesListView.Items.Count.ToString();
        }

        /// <summary>
        /// Handles the preview button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPreviewButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
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

            // Update file count
            this.fileCountToolStripStatusLabel.Text = this.samplesListView.Items.Count.ToString();
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
            // TODO Add code
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
            // TODO Add code
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
            this.settingsData.SequentialSave = this.sequentialCheckBox.Checked;

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
