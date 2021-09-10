using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class UserControlTabs : UserControl
    {

        Stack<string> pastHistory = new Stack<string>();
        Stack<string> newHistory = new Stack<string>(); 
        public UserControlTabs()
        {
            InitializeComponent();
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
                pastHistory.Push(AddressBarTextBox.Text.ToString());
                newHistory.Push(AddressBarTextBox.Text.ToString());
            }
        }

        private void toolStripGoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressBarTextBox.Text.ToString());
            pastHistory.Push(AddressBarTextBox.Text.ToString());
            newHistory.Push(AddressBarTextBox.Text.ToString());
        }

        private void toolStripRefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }

        private void toolStripBackButton_Click(object sender, EventArgs e)
        {
            try
            {
                string url = AddressBarTextBox.Text.ToString();
                newHistory.Push(url);
                string newUrl = pastHistory.Pop();
                webBrowser1.Navigate(newUrl);
                AddressBarTextBox.Text = newUrl; 

            } catch
            {
                MessageBox.Show("Already at end of history");
            }
        }

        private void toolStripForwardButton_Click(object sender, EventArgs e)
        {
            try
            {
                string url = AddressBarTextBox.Text.ToString();
                pastHistory.Push(url);

                string newUrl = newHistory.Pop();
                webBrowser1.Navigate(newUrl);
                AddressBarTextBox.Text = newUrl;
            } catch {
                MessageBox.Show("At the most current web page");
            }
        }
    }
}
