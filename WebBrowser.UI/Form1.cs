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
    public partial class Form1 : Form
    {
        public Form1()
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
            UserControlTabs tb = new UserControlTabs();

            if (e.Control && e.KeyCode == Keys.T)
            {
                this.tabControl1.TabPages.Add(new TabPage("New Tab"));
                
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
            this.tabControl1.TabPages.Add(new TabPage("New Tab"));
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }
    }
}
