
namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.searchTermTextBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 37;
            this.listBoxHistory.Location = new System.Drawing.Point(0, 245);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(1326, 522);
            this.listBoxHistory.TabIndex = 0;
            // 
            // searchTermTextBox
            // 
            this.searchTermTextBox.Location = new System.Drawing.Point(255, 87);
            this.searchTermTextBox.Name = "searchTermTextBox";
            this.searchTermTextBox.Size = new System.Drawing.Size(442, 44);
            this.searchTermTextBox.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(0, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(197, 84);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(727, 63);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(197, 84);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearHistory.Location = new System.Drawing.Point(952, 63);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(374, 84);
            this.buttonClearHistory.TabIndex = 4;
            this.buttonClearHistory.Text = "Clear History";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 767);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchTermTextBox);
            this.Controls.Add(this.listBoxHistory);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManager";
            this.Load += new System.EventHandler(this.HistoryManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.TextBox searchTermTextBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClearHistory;
    }
}