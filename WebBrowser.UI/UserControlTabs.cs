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
            string previousURL = AddressBarTextBox.Text;
            string currentURL = AddressBarTextBox.Text = webBrowser1.Url.ToString(); 

            if (!previousURL.Equals(currentURL))
            {
                var newHistoryItem = new HistoryItem(webBrowser1.Url.ToString(), webBrowser1.DocumentTitle, DateTime.Now);
                HistoryManager.AddHistoryItem(newHistoryItem);
                tab.Text = webBrowser1.Document.Title; 
            }
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
 
            }
        }

        private void toolStripGoButton_Click(object sender, EventArgs e)
        {

            string url = AddressBarTextBox.Text;
            try
            {
                webBrowser1.Navigate(url);
            }
            catch
            {
                webBrowser1.Navigate(new Uri("http://" + url));
                AddressBarTextBox.Text = "http://" + url;
            }

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
                newBookmark.URL = webBrowser1.Url.ToString();
                newBookmark.Title = webBrowser1.DocumentTitle;

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

    }
}