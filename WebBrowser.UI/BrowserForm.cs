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
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Browser Project: By Steven Martinez ID: 904170238");

        }

        private void AddressBarTextBox_Click(object sender, EventArgs e)
        {
       
            
        }

        private void AddressBarTextBox_KeyDown(object sender, KeyEventArgs e)
        {

          

            if (e.Control && e.KeyCode == Keys.T)
            {
                TabPage myTab = new TabPage("New Tab");
                tabControl1.TabPages.Add(myTab);
                UserControlTabs newTab = new UserControlTabs(myTab);
                newTab.Dock = DockStyle.Fill;
                myTab.Controls.Add(new UserControlTabs(myTab));
                

            }

            if (e.Control && e.KeyCode == Keys.W)
            {
                this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage myTab = new TabPage("New Tab");
            tabControl1.TabPages.Add(myTab);
            UserControlTabs newTab = new UserControlTabs(myTab);
            newTab.Dock = DockStyle.Fill;
            myTab.Controls.Add(new UserControlTabs(myTab));

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyManager = new HistoryManagerForm();
            historyManager.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkManager = new BookmarkManagerForm();
            bookmarkManager.ShowDialog(); 
        }

        private void userControlTabs1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void userControlTabs1_MouseHover(object sender, EventArgs e)
        {

        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.DeleteHistory();
        }
    }
}
