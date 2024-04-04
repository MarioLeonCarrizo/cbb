using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public class FamilyItem
    {
        public string FullPath { get; set; }
        public string Name => PathHelpers.GetFileName(FullPath);
        public ItemType Type => ItemTypeHelper.GetType(FullPath);

        public FamilyItem()
        {

        }
    }
}
