﻿using System;
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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetBookmarkItems();
            listBoxBookmarkManager.Items.Clear();

            foreach (var item in items)
            {
                listBoxBookmarkManager.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetBookmarkItems();
            listBoxBookmarkManager.Items.Clear();

            foreach (var item in items)
            {
                if (item.URL.Contains(SearchTextBox.Text))
                {
                    listBoxBookmarkManager.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }

}
