using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;
using WebBrowser.Data.BrowserDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {

        public static void AddHistoryItem(string url, string title)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(url, title, DateTime.Now);
        }

        public static List<HistoryItem> GetHistoryItems()
        {

            
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                results.Add(item);
            }
            return results;
        }

        }

    }

