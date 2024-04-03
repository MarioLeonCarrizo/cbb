using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    using Autodesk.Revit.UI.Selection;
    using Autodesk.Revit.DB;

    public class SelectionFilterByCategory : ISelectionFilter
    {
        private string mCategory = "";

        public SelectionFilterByCategory(string category)
        {
            mCategory = category;
        }

        public bool AllowElement(Element elem)
        {
            if(elem.Category == null)
                return false;

            if (elem.Category.Name == mCategory)
            {
                return true;
            }

            return false;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }
    }
}
