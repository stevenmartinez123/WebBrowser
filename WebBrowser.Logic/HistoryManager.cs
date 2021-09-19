﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;
using WebBrowser.Data.BrowserDataSetTableAdapters;

namespace WebBrowser.Logic
{
    class HistoryManager
    {

        public static void AddHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        public static List<HistoryItem> GetHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

                foreach (var row in rows)
                {
                    var item = new HistoryItem(row.URL, row.Title, row.Date);
                    results.Add(item);
            }
            return results;
        } 
       
        }

    }

