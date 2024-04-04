using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public class FamilyList
    {
        public static List<FamilyItem> GetItems(string path)
        {
            var items = new List<FamilyItem>();

            try
            {
                var fs = Directory.GetFiles(path);

                // Check if directory has file items.
                // Cast file items to the more specific FamilyItem.
                if (fs.Length > 0)
                    items.AddRange(fs.Select(file => new FamilyItem { FullPath = file }));
            }
            catch { }

            return items;
        }
    }
}
