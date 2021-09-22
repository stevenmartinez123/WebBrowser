
namespace WebBrowser.UI
{
    partial class UserControlTabs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTabs));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripForwardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripHomeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBookMarkButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripGoButton = new System.Windows.Forms.ToolStripButton();
            this.AddressBarTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStripUserControlTab = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1.SuspendLayout();
            this.statusStripUserControlTab.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1197, 75);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackButton.Image")));
            this.toolStripBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(69, 66);
            this.toolStripBackButton.Text = "Back";
            this.toolStripBackButton.Click += new System.EventHandler(this.toolStripBackButton_Click);
            // 
            // toolStripForwardButton
            // 
            this.toolStripForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripForwardButton.Image")));
            this.toolStripForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripForwardButton.Name = "toolStripForwardButton";
            this.toolStripForwardButton.Size = new System.Drawing.Size(69, 66);
            this.toolStripForwardButton.Text = "Forward";
            this.toolStripForwardButton.Click += new System.EventHandler(this.toolStripForwardButton_Click);
            // 
            // toolStripRefreshButton
            // 
            this.toolStripRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefreshButton.Image")));
            this.toolStripRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefreshButton.Name = "toolStripRefreshButton";
            this.toolStripRefreshButton.Size = new System.Drawing.Size(69, 66);
            this.toolStripRefreshButton.Text = "Refresh";
            this.toolStripRefreshButton.Click += new System.EventHandler(this.toolStripRefreshButton_Click);
            // 
            // toolStripHomeButton
            // 
            this.toolStripHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHomeButton.Image")));
            this.toolStripHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHomeButton.Name = "toolStripHomeButton";
            this.toolStripHomeButton.Size = new System.Drawing.Size(69, 66);
            this.toolStripHomeButton.Text = "Home";
            // 
            // toolStripBookMarkButton
            // 
            this.toolStripBookMarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBookMarkButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBookMarkButton.Image")));
            this.toolStripBookMarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBookMarkButton.Name = "toolStripBookMarkButton";
            this.toolStripBookMarkButton.Size = new System.Drawing.Size(69, 66);
            this.toolStripBookMarkButton.Text = "Bookmark";
            this.toolStripBookMarkButton.Click += new System.EventHandler(this.toolStripBookMarkButton_Click);
            // 
            // toolStripGoButton
            // 
            this.toolStripGoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGoButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGoButton.Image")));
            this.toolStripGoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGoButton.Name = "toolStripGoButton";
            this.toolStripGoButton.Size = new System.Drawing.Size(69, 66);
            this.toolStripGoButton.Text = "Go";
            this.toolStripGoButton.Click += new System.EventHandler(this.toolStripGoButton_Click);
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
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 75);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1197, 798);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // statusStripUserControlTab
            // 
            this.statusStripUserControlTab.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.statusStripUserControlTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStripUserControlTab.Location = new System.Drawing.Point(0, 815);
            this.statusStripUserControlTab.Name = "statusStripUserControlTab";
            this.statusStripUserControlTab.Size = new System.Drawing.Size(1197, 58);
            this.statusStripUserControlTab.TabIndex = 4;
            this.statusStripUserControlTab.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 40);
            // 
            // UserControlTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStripUserControlTab);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UserControlTabs";
            this.Size = new System.Drawing.Size(1197, 873);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStripUserControlTab.ResumeLayout(false);
            this.statusStripUserControlTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private System.Windows.Forms.ToolStripButton toolStripForwardButton;
        private System.Windows.Forms.ToolStripButton toolStripRefreshButton;
        private System.Windows.Forms.ToolStripButton toolStripHomeButton;
        private System.Windows.Forms.ToolStripButton toolStripBookMarkButton;
        private System.Windows.Forms.ToolStripButton toolStripGoButton;
        private System.Windows.Forms.ToolStripTextBox AddressBarTextBox;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStripUserControlTab;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}
