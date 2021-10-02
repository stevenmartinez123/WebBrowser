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
using System.IO;

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
            MessageBox.Show("Browser Project: By Steven Martinez ID: 904170238 \n\n " +
                "MNML: A browser that keeps things simple.");

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

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
          

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
           
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
         
        }

        Bitmap bmp, memoryImage;
        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            CaptureScreen();
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Height, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
            
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog html = new SaveFileDialog();
            html.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            html.Title = "Save as image File";
            html.ShowDialog();

            if (html.FileName != "")
            {
                FileStream fs = (FileStream)html.OpenFile();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight,
            IntPtr hdcSrc, int nXsrc, int nYsrc, int dwRop);
       
    }
}
