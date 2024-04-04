using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public static class ItemTypeHelper
    {
        public static ItemType GetType(string fullPath)
        {
            // check if provided full path is valid.
            if (string.IsNullOrEmpty(fullPath))
                return ItemType.None;

            // Determine item type.
            if (fullPath.Contains(".rvt") || fullPath.Contains(".rte"))
                return ItemType.Project;
            else if (fullPath.Contains(".rfa"))
                return ItemType.Family;
            else if (fullPath.Contains(".dwg") || fullPath.Contains(".dxf") || fullPath.Contains(".sat"))
                return ItemType.Cad;
            else if (fullPath.Contains(".doc") || fullPath.Contains(".docx") || fullPath.Contains(".pdf") || fullPath.Contains(".txt") || fullPath.Contains(".csv"))
                return ItemType.Document;
            else
                return ItemType.None;
        }
    }
}
