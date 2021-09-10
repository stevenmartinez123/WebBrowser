
namespace WebBrowser.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripForwardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripHomeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBookMarkButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripGoButton = new System.Windows.Forms.ToolStripButton();
            this.AddressBarTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControlTabs1 = new WebBrowser.UI.UserControlTabs();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1753, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeCurrentTabToolStripMenuItem,
            this.savePageAsHTMLToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.exitWebBrowserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(121, 57);
            this.fileToolStripMenuItem.Text = "&File: ";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(533, 66);
            this.newTabToolStripMenuItem.Text = "New Tab:";
            // 
            // closeCurrentTabToolStripMenuItem
            // 
            this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
            this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(533, 66);
            this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab:";
            // 
            // savePageAsHTMLToolStripMenuItem
            // 
            this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
            this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(533, 66);
            this.savePageAsHTMLToolStripMenuItem.Text = "Save Page as HTML:";
            // 
            // printPageToolStripMenuItem
            // 
            this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
            this.printPageToolStripMenuItem.Size = new System.Drawing.Size(533, 66);
            this.printPageToolStripMenuItem.Text = "Print Page:";
            // 
            // exitWebBrowserToolStripMenuItem
            // 
            this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
            this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(533, 66);
            this.exitWebBrowserToolStripMenuItem.Text = "Exit Web Browser: ";
            this.exitWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitWebBrowserToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(129, 57);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // manageHistoryToolStripMenuItem
            // 
            this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
            this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(550, 66);
            this.manageHistoryToolStripMenuItem.Text = "Manage History: ";
            // 
            // manageBookmarksToolStripMenuItem
            // 
            this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
            this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(550, 66);
            this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks: ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(131, 57);
            this.helpToolStripMenuItem.Text = "&Help:";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(315, 66);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton,
            this.toolStripForwardButton,
            this.toolStripRefreshButton,
            this.toolStripHomeButton,
            this.toolStripBookMarkButton,
            this.toolStripGoButton,
            this.AddressBarTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 56);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1753, 61);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackButton.Image")));
            this.toolStripBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(69, 52);
            this.toolStripBackButton.Text = "Back";
            // 
            // toolStripForwardButton
            // 
            this.toolStripForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripForwardButton.Image")));
            this.toolStripForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripForwardButton.Name = "toolStripForwardButton";
            this.toolStripForwardButton.Size = new System.Drawing.Size(69, 52);
            this.toolStripForwardButton.Text = "Forward";
            // 
            // toolStripRefreshButton
            // 
            this.toolStripRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefreshButton.Image")));
            this.toolStripRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefreshButton.Name = "toolStripRefreshButton";
            this.toolStripRefreshButton.Size = new System.Drawing.Size(69, 52);
            this.toolStripRefreshButton.Text = "Refresh";
            // 
            // toolStripHomeButton
            // 
            this.toolStripHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHomeButton.Image")));
            this.toolStripHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHomeButton.Name = "toolStripHomeButton";
            this.toolStripHomeButton.Size = new System.Drawing.Size(69, 52);
            this.toolStripHomeButton.Text = "Home";
            // 
            // toolStripBookMarkButton
            // 
            this.toolStripBookMarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBookMarkButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBookMarkButton.Image")));
            this.toolStripBookMarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBookMarkButton.Name = "toolStripBookMarkButton";
            this.toolStripBookMarkButton.Size = new System.Drawing.Size(69, 52);
            this.toolStripBookMarkButton.Text = "Bookmark";
            // 
            // toolStripGoButton
            // 
            this.toolStripGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGoButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGoButton.Image")));
            this.toolStripGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGoButton.Name = "toolStripGoButton";
            this.toolStripGoButton.Size = new System.Drawing.Size(69, 52);
            this.toolStripGoButton.Text = "Go";
            this.toolStripGoButton.Click += new System.EventHandler(this.AddressBarTextBox_Click);
            // 
            // AddressBarTextBox
            // 
            this.AddressBarTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddressBarTextBox.AutoSize = false;
            this.AddressBarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBarTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressBarTextBox.Name = "AddressBarTextBox";
            this.AddressBarTextBox.Size = new System.Drawing.Size(400, 55);
            this.AddressBarTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBarTextBox_KeyDown);
            this.AddressBarTextBox.Click += new System.EventHandler(this.AddressBarTextBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1753, 624);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userControlTabs1);
            this.tabPage1.Location = new System.Drawing.Point(12, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1729, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControlTabs1
            // 
            this.userControlTabs1.Location = new System.Drawing.Point(117, 0);
            this.userControlTabs1.Name = "userControlTabs1";
            this.userControlTabs1.Size = new System.Drawing.Size(1197, 873);
            this.userControlTabs1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private System.Windows.Forms.ToolStripButton toolStripForwardButton;
        private System.Windows.Forms.ToolStripButton toolStripRefreshButton;
        private System.Windows.Forms.ToolStripButton toolStripHomeButton;
        private System.Windows.Forms.ToolStripTextBox AddressBarTextBox;
        private System.Windows.Forms.ToolStripButton toolStripGoButton;
        private System.Windows.Forms.ToolStripButton toolStripBookMarkButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControlTabs userControlTabs1;
    }
}

