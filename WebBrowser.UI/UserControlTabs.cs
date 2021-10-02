using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class UserControlTabs : UserControl
    {
        TabPage tab = new TabPage();
        public string title = "";

        public UserControlTabs()
        {
            InitializeComponent();
        }

        public UserControlTabs(TabPage tab)
        {
            InitializeComponent();
            this.tab = tab;
            this.title = tab.Text;
            this.Dock = DockStyle.Fill;
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
      
        }

        private void AddressBarTextBox_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressBarTextBox.Text.ToString());
        }

        private void AddressBarTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(AddressBarTextBox.Text.ToString());
                e.SuppressKeyPress = true;
                webBrowser1.ScriptErrorsSuppressed = true;
                string title = WebTitle(AddressBarTextBox.Text.ToString());
                HistoryManager.AddHistoryItem(AddressBarTextBox.Text, title);
                
            }
        }

        private string WebTitle(string url)
        {
            string[] titleSplit = url.ToString().Split('.');
            string title = "";

            if (titleSplit[0].ToLower().Equals("www"))
            {
                title = titleSplit[1];
            }
            else
            {
                title = titleSplit[0];
            }
            return title;
        }

        private void toolStripGoButton_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate(AddressBarTextBox.Text);
            string title = WebTitle(AddressBarTextBox.Text);
            HistoryManager.AddHistoryItem(AddressBarTextBox.Text, title);

        }

        private void toolStripRefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }

        private void toolStripBackButton_Click(object sender, EventArgs e)
        {

            webBrowser1.GoBack();
        }

        private void toolStripForwardButton_Click(object sender, EventArgs e)
        {

            webBrowser1.GoForward();
        }

        private void toolStripBookMarkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newBookmark = new BookmarkItem();
                newBookmark.URL = AddressBarTextBox.Text;
                newBookmark.Title = WebTitle(AddressBarTextBox.Text);

                if (!containsBookmark(newBookmark.URL))
                {
                    BookmarkManager.AddBookmarkItem(newBookmark);
                }
            } catch
            {
                MessageBox.Show("Please enter correct web address.");
            }
        }

        private bool containsBookmark(string url)
        {
            var list = BookmarkManager.GetBookmarkItems(); 

            foreach (var item in list)
            {
                if (item.URL.Equals(url))
                {
                    MessageBox.Show("Bookmark already exists");
                    return true; 
                } 
            } return false; 
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_ProgressChanged_1(object sender, WebBrowserProgressChangedEventArgs e)
        {
            var maxP = (int)e.MaximumProgress;
            var curr = (int)e.CurrentProgress;
            ProgressBar.Maximum = maxP;
            ProgressBar.Minimum = 0;

            if (curr > 0 && curr <= maxP)
            {
                ProgressBar.Value = curr;
                toolStripStatusProgressLabel.Text = "loading";

            }

            if (e.CurrentProgress == maxP || e.CurrentProgress == 0)
            {
                toolStripStatusProgressLabel.Text = "Done";
            }


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void ProgressBar_MouseHover(object sender, EventArgs e)
        {
            
            toolStripStatusLabel1.Text = AddressBarTextBox.Text; 
        }

        private void toolStripHomeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("google.com");
        }
    }
}