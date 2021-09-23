using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;
using WebBrowser.Data.BrowserDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddBookmarkItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        public static List<BookmarkItem> GetBookmarkItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();

                item.URL = row.URL;
                item.Title = row.Title;
                results.Add(item);
            }
            return results; 
        }

        public static void DeleteBookmark(string bookmark)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                string match = string.Format(string.Format("{0} ({1})", row.Title, row.URL));

                if (bookmark == match)
                {
                    adapter.Delete(row.Id, row.URL, row.Title);
                }
            }
        }

    }
}
