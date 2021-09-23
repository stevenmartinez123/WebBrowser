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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManager_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetHistoryItems();
            listBoxHistory.Items.Clear();

            foreach (var item in items)
            {
                listBoxHistory.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL)); 
            }
                      
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = searchTermTextBox.Text.Equals("") ? null : searchTermTextBox.Text.Trim(); 

            if(text != null)
            {
                var items = HistoryManager.GetHistoryItems();
                listBoxHistory.Items.Clear();
                
               foreach (var item in items)
                {
                    if (item.URL.Contains(text) || item.Title.Contains(text))
                    {
                        listBoxHistory.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                    } 
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxHistory.SelectedIndex >= 0)
            {
                string selectedHistory = listBoxHistory.GetItemText(listBoxHistory.SelectedItem);

            }
        }
    }
}
