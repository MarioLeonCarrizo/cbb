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
                {
                    foreach (var f in fs)
                    {
                        if (ItemTypeHelper.GetType(f) != ItemType.None)
                            items.Add(new FamilyItem { FullPath = path });
                    }
                }
            }
            catch { }

            return items;
        }
    }
}
