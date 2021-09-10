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
            }
        }

        private void toolStripGoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressBarTextBox.Text.ToString());
        }

        private void toolStripRefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }
    }
}
