
namespace RandomSampler
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel samplesInLIstToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel samplesCountToolStripStatusLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button getSamplesButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox sequentialSaveCheckBox;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TableLayoutPanel samplesTableLayoutPanel;
        private System.Windows.Forms.NumericUpDown samplesNumericUpDown;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sixteenButton;
        private System.Windows.Forms.Button thirtyTwoButton;
        private System.Windows.Forms.Button fortyEightButton;
        private System.Windows.Forms.Button sixtyFourButton;
        private System.Windows.Forms.ToolStripMenuItem addcheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOnClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFileExtensionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip samplesListViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanSubdirectoriesToolStripMenuItem;
        private System.Windows.Forms.ListView samplesListView;
        private System.Windows.Forms.ColumnHeader samplesColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel eligibleSamplesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel eligibleSamplesCountToolStripStatusLabel;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addcheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOnClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLastDirectoryOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneclickPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanSubdirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFileExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.samplesInLIstToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.samplesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eligibleSamplesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eligibleSamplesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.browseButton = new System.Windows.Forms.Button();
            this.getSamplesButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.sequentialSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.samplesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.samplesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eightButton = new System.Windows.Forms.Button();
            this.sixteenButton = new System.Windows.Forms.Button();
            this.thirtyTwoButton = new System.Windows.Forms.Button();
            this.fortyEightButton = new System.Windows.Forms.Button();
            this.sixtyFourButton = new System.Windows.Forms.Button();
            this.samplesListView = new System.Windows.Forms.ListView();
            this.samplesColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.samplesListViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favButton = new System.Windows.Forms.Button();
            this.favoriteDirectoryContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setFavoriteDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.samplesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericUpDown)).BeginInit();
            this.samplesListViewContextMenuStrip.SuspendLayout();
            this.favoriteDirectoryContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem1,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(319, 24);
            this.mainMenuStrip.TabIndex = 47;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem1,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator1,
                                    this.saveToolStripMenuItem,
                                    this.saveallToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem1.Text = "&New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnBrowseButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // saveallToolStripMenuItem
            // 
            this.saveallToolStripMenuItem.Name = "saveallToolStripMenuItem";
            this.saveallToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.saveallToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveallToolStripMenuItem.Text = "Save &all";
            this.saveallToolStripMenuItem.Click += new System.EventHandler(this.OnSaveallToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem,
                                    this.addcheckedToolStripMenuItem,
                                    this.checkOnClickToolStripMenuItem,
                                    this.loadLastDirectoryOnStartToolStripMenuItem,
                                    this.oneclickPreviewToolStripMenuItem,
                                    this.scanSubdirectoriesToolStripMenuItem,
                                    this.setFileExtensionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // addcheckedToolStripMenuItem
            // 
            this.addcheckedToolStripMenuItem.Checked = true;
            this.addcheckedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addcheckedToolStripMenuItem.Name = "addcheckedToolStripMenuItem";
            this.addcheckedToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addcheckedToolStripMenuItem.Text = "Add &checked";
            // 
            // checkOnClickToolStripMenuItem
            // 
            this.checkOnClickToolStripMenuItem.Name = "checkOnClickToolStripMenuItem";
            this.checkOnClickToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.checkOnClickToolStripMenuItem.Text = "&Check on click";
            // 
            // loadLastDirectoryOnStartToolStripMenuItem
            // 
            this.loadLastDirectoryOnStartToolStripMenuItem.Checked = true;
            this.loadLastDirectoryOnStartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loadLastDirectoryOnStartToolStripMenuItem.Name = "loadLastDirectoryOnStartToolStripMenuItem";
            this.loadLastDirectoryOnStartToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.loadLastDirectoryOnStartToolStripMenuItem.Text = "&Load last directory on start";
            // 
            // oneclickPreviewToolStripMenuItem
            // 
            this.oneclickPreviewToolStripMenuItem.Checked = true;
            this.oneclickPreviewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.oneclickPreviewToolStripMenuItem.Name = "oneclickPreviewToolStripMenuItem";
            this.oneclickPreviewToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.oneclickPreviewToolStripMenuItem.Text = "&One-click preview";
            // 
            // scanSubdirectoriesToolStripMenuItem
            // 
            this.scanSubdirectoriesToolStripMenuItem.Checked = true;
            this.scanSubdirectoriesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scanSubdirectoriesToolStripMenuItem.Name = "scanSubdirectoriesToolStripMenuItem";
            this.scanSubdirectoriesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.scanSubdirectoriesToolStripMenuItem.Text = "Scan s&ubdirectories";
            // 
            // setFileExtensionsToolStripMenuItem
            // 
            this.setFileExtensionsToolStripMenuItem.Name = "setFileExtensionsToolStripMenuItem";
            this.setFileExtensionsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.setFileExtensionsToolStripMenuItem.Text = "&Set file extensions";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainisToolStripMenuItem,
                                    this.originalThreadDonationCodercomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainisToolStripMenuItem
            // 
            this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
            this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
            // 
            // originalThreadDonationCodercomToolStripMenuItem
            // 
            this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
            this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
            this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
            this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.samplesInLIstToolStripStatusLabel,
                                    this.samplesCountToolStripStatusLabel,
                                    this.eligibleSamplesToolStripStatusLabel,
                                    this.eligibleSamplesCountToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 419);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(319, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 46;
            // 
            // samplesInLIstToolStripStatusLabel
            // 
            this.samplesInLIstToolStripStatusLabel.Name = "samplesInLIstToolStripStatusLabel";
            this.samplesInLIstToolStripStatusLabel.Size = new System.Drawing.Size(85, 17);
            this.samplesInLIstToolStripStatusLabel.Text = "Samples in list:";
            // 
            // samplesCountToolStripStatusLabel
            // 
            this.samplesCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.samplesCountToolStripStatusLabel.Name = "samplesCountToolStripStatusLabel";
            this.samplesCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.samplesCountToolStripStatusLabel.Text = "0";
            // 
            // eligibleSamplesToolStripStatusLabel
            // 
            this.eligibleSamplesToolStripStatusLabel.Name = "eligibleSamplesToolStripStatusLabel";
            this.eligibleSamplesToolStripStatusLabel.Size = new System.Drawing.Size(94, 17);
            this.eligibleSamplesToolStripStatusLabel.Text = "Eligible samples:";
            // 
            // eligibleSamplesCountToolStripStatusLabel
            // 
            this.eligibleSamplesCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.eligibleSamplesCountToolStripStatusLabel.Name = "eligibleSamplesCountToolStripStatusLabel";
            this.eligibleSamplesCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.eligibleSamplesCountToolStripStatusLabel.Text = "0";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.mainTableLayoutPanel.Controls.Add(this.browseButton, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.getSamplesButton, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.saveButton, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.sequentialSaveCheckBox, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.previewButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.deleteButton, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.samplesTableLayoutPanel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.samplesListView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.favButton, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(319, 395);
            this.mainTableLayoutPanel.TabIndex = 48;
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(3, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(228, 29);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse for directory";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
            // 
            // getSamplesButton
            // 
            this.getSamplesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getSamplesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSamplesButton.Location = new System.Drawing.Point(3, 358);
            this.getSamplesButton.Name = "getSamplesButton";
            this.getSamplesButton.Size = new System.Drawing.Size(228, 34);
            this.getSamplesButton.TabIndex = 1;
            this.getSamplesButton.Text = "GET SAMPLES";
            this.getSamplesButton.UseVisualStyleBackColor = true;
            this.getSamplesButton.Click += new System.EventHandler(this.OnGetSamplesButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(237, 358);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 34);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // sequentialSaveCheckBox
            // 
            this.sequentialSaveCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.sequentialSaveCheckBox.Checked = true;
            this.sequentialSaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sequentialSaveCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sequentialSaveCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sequentialSaveCheckBox.Location = new System.Drawing.Point(237, 325);
            this.sequentialSaveCheckBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.sequentialSaveCheckBox.Name = "sequentialSaveCheckBox";
            this.sequentialSaveCheckBox.Size = new System.Drawing.Size(79, 30);
            this.sequentialSaveCheckBox.TabIndex = 4;
            this.sequentialSaveCheckBox.Text = "Seq.";
            this.sequentialSaveCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sequentialSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // previewButton
            // 
            this.previewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.previewButton.Location = new System.Drawing.Point(3, 293);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(228, 29);
            this.previewButton.TabIndex = 5;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.OnPreviewButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(237, 293);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 29);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Del";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // samplesTableLayoutPanel
            // 
            this.samplesTableLayoutPanel.ColumnCount = 6;
            this.samplesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.samplesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.samplesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.samplesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.samplesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.samplesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.samplesTableLayoutPanel.Controls.Add(this.samplesNumericUpDown, 0, 0);
            this.samplesTableLayoutPanel.Controls.Add(this.eightButton, 1, 0);
            this.samplesTableLayoutPanel.Controls.Add(this.sixteenButton, 2, 0);
            this.samplesTableLayoutPanel.Controls.Add(this.thirtyTwoButton, 3, 0);
            this.samplesTableLayoutPanel.Controls.Add(this.fortyEightButton, 4, 0);
            this.samplesTableLayoutPanel.Controls.Add(this.sixtyFourButton, 5, 0);
            this.samplesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesTableLayoutPanel.Location = new System.Drawing.Point(3, 328);
            this.samplesTableLayoutPanel.Name = "samplesTableLayoutPanel";
            this.samplesTableLayoutPanel.RowCount = 1;
            this.samplesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.samplesTableLayoutPanel.Size = new System.Drawing.Size(228, 24);
            this.samplesTableLayoutPanel.TabIndex = 7;
            // 
            // samplesNumericUpDown
            // 
            this.samplesNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samplesNumericUpDown.Location = new System.Drawing.Point(3, 0);
            this.samplesNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.samplesNumericUpDown.Name = "samplesNumericUpDown";
            this.samplesNumericUpDown.Size = new System.Drawing.Size(47, 26);
            this.samplesNumericUpDown.TabIndex = 0;
            this.samplesNumericUpDown.Value = new decimal(new int[] {
                                    16,
                                    0,
                                    0,
                                    0});
            // 
            // eightButton
            // 
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(50, 0);
            this.eightButton.Margin = new System.Windows.Forms.Padding(0);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(35, 24);
            this.eightButton.TabIndex = 1;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.OnEightButtonClick);
            // 
            // sixteenButton
            // 
            this.sixteenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixteenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixteenButton.Location = new System.Drawing.Point(85, 0);
            this.sixteenButton.Margin = new System.Windows.Forms.Padding(0);
            this.sixteenButton.Name = "sixteenButton";
            this.sixteenButton.Size = new System.Drawing.Size(35, 24);
            this.sixteenButton.TabIndex = 2;
            this.sixteenButton.Text = "16";
            this.sixteenButton.UseVisualStyleBackColor = true;
            this.sixteenButton.Click += new System.EventHandler(this.OnSixteenButtonClick);
            // 
            // thirtyTwoButton
            // 
            this.thirtyTwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirtyTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirtyTwoButton.Location = new System.Drawing.Point(120, 0);
            this.thirtyTwoButton.Margin = new System.Windows.Forms.Padding(0);
            this.thirtyTwoButton.Name = "thirtyTwoButton";
            this.thirtyTwoButton.Size = new System.Drawing.Size(35, 24);
            this.thirtyTwoButton.TabIndex = 3;
            this.thirtyTwoButton.Text = "32";
            this.thirtyTwoButton.UseVisualStyleBackColor = true;
            this.thirtyTwoButton.Click += new System.EventHandler(this.OnThirtyTwoButtonClick);
            // 
            // fortyEightButton
            // 
            this.fortyEightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fortyEightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fortyEightButton.Location = new System.Drawing.Point(155, 0);
            this.fortyEightButton.Margin = new System.Windows.Forms.Padding(0);
            this.fortyEightButton.Name = "fortyEightButton";
            this.fortyEightButton.Size = new System.Drawing.Size(35, 24);
            this.fortyEightButton.TabIndex = 4;
            this.fortyEightButton.Text = "48";
            this.fortyEightButton.UseVisualStyleBackColor = true;
            this.fortyEightButton.Click += new System.EventHandler(this.OnFortyEightButtonClick);
            // 
            // sixtyFourButton
            // 
            this.sixtyFourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixtyFourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixtyFourButton.Location = new System.Drawing.Point(190, 0);
            this.sixtyFourButton.Margin = new System.Windows.Forms.Padding(0);
            this.sixtyFourButton.Name = "sixtyFourButton";
            this.sixtyFourButton.Size = new System.Drawing.Size(38, 24);
            this.sixtyFourButton.TabIndex = 5;
            this.sixtyFourButton.Text = "64";
            this.sixtyFourButton.UseVisualStyleBackColor = true;
            this.sixtyFourButton.Click += new System.EventHandler(this.OnSixtyFourButtonClick);
            // 
            // samplesListView
            // 
            this.samplesListView.CheckBoxes = true;
            this.samplesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                    this.samplesColumnHeader});
            this.mainTableLayoutPanel.SetColumnSpan(this.samplesListView, 2);
            this.samplesListView.ContextMenuStrip = this.samplesListViewContextMenuStrip;
            this.samplesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesListView.FullRowSelect = true;
            this.samplesListView.Location = new System.Drawing.Point(3, 38);
            this.samplesListView.Name = "samplesListView";
            this.samplesListView.Size = new System.Drawing.Size(313, 249);
            this.samplesListView.TabIndex = 8;
            this.samplesListView.UseCompatibleStateImageBehavior = false;
            this.samplesListView.View = System.Windows.Forms.View.Details;
            this.samplesListView.SelectedIndexChanged += new System.EventHandler(this.OnSamplesListViewSelectedIndexChanged);
            this.samplesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnSamplesListViewMouseClick);
            // 
            // samplesColumnHeader
            // 
            this.samplesColumnHeader.Text = "Samples";
            this.samplesColumnHeader.Width = 290;
            // 
            // samplesListViewContextMenuStrip
            // 
            this.samplesListViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.checkAllToolStripMenuItem,
                                    this.uncheckAllToolStripMenuItem,
                                    this.toggleCheckToolStripMenuItem,
                                    this.deleteToolStripMenuItem});
            this.samplesListViewContextMenuStrip.Name = "randomItemsListContextMenuStrip";
            this.samplesListViewContextMenuStrip.Size = new System.Drawing.Size(146, 92);
            this.samplesListViewContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnSamplesListViewContextMenuStripItemClicked);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.checkAllToolStripMenuItem.Text = "&Check all";
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.uncheckAllToolStripMenuItem.Text = "&Uncheck all";
            // 
            // toggleCheckToolStripMenuItem
            // 
            this.toggleCheckToolStripMenuItem.Name = "toggleCheckToolStripMenuItem";
            this.toggleCheckToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toggleCheckToolStripMenuItem.Text = "&Toggle check";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.checkedToolStripMenuItem,
                                    this.uncheckedToolStripMenuItem,
                                    this.allItemsToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnDeleteToolStripMenuItemDropDownItemClicked);
            // 
            // checkedToolStripMenuItem
            // 
            this.checkedToolStripMenuItem.Name = "checkedToolStripMenuItem";
            this.checkedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.checkedToolStripMenuItem.Text = "&Checked";
            // 
            // uncheckedToolStripMenuItem
            // 
            this.uncheckedToolStripMenuItem.Name = "uncheckedToolStripMenuItem";
            this.uncheckedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.uncheckedToolStripMenuItem.Text = "&Unchecked";
            // 
            // allItemsToolStripMenuItem
            // 
            this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
            this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.allItemsToolStripMenuItem.Text = "&All items";
            // 
            // favButton
            // 
            this.favButton.ContextMenuStrip = this.favoriteDirectoryContextMenuStrip;
            this.favButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.favButton.Location = new System.Drawing.Point(237, 3);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(79, 29);
            this.favButton.TabIndex = 0;
            this.favButton.Text = "&Fav";
            this.favButton.UseVisualStyleBackColor = true;
            this.favButton.Click += new System.EventHandler(this.OnFavButtonClick);
            // 
            // favoriteDirectoryContextMenuStrip
            // 
            this.favoriteDirectoryContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.setFavoriteDirectoryToolStripMenuItem,
                                    this.clearDirectoryToolStripMenuItem});
            this.favoriteDirectoryContextMenuStrip.Name = "favoriteDirectoryContextMenuStrip";
            this.favoriteDirectoryContextMenuStrip.Size = new System.Drawing.Size(184, 48);
            this.favoriteDirectoryContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnFavoriteDirectoryContextMenuStripItemClicked);
            // 
            // setFavoriteDirectoryToolStripMenuItem
            // 
            this.setFavoriteDirectoryToolStripMenuItem.Name = "setFavoriteDirectoryToolStripMenuItem";
            this.setFavoriteDirectoryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.setFavoriteDirectoryToolStripMenuItem.Text = "&Set favorite directory";
            // 
            // clearDirectoryToolStripMenuItem
            // 
            this.clearDirectoryToolStripMenuItem.Name = "clearDirectoryToolStripMenuItem";
            this.clearDirectoryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearDirectoryToolStripMenuItem.Text = "&Clear directory";
            // 
            // MainForm
            // 
            this.AcceptButton = this.getSamplesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 441);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomSampler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.samplesTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericUpDown)).EndInit();
            this.samplesListViewContextMenuStrip.ResumeLayout(false);
            this.favoriteDirectoryContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem setFavoriteDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDirectoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip favoriteDirectoryContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadLastDirectoryOnStartToolStripMenuItem;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.ToolStripMenuItem oneclickPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveallToolStripMenuItem;
    }
}
