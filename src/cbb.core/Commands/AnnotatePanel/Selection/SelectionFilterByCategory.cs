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
        private BuiltInCategory mCategory = BuiltInCategory.INVALID;

        public SelectionFilterByCategory(BuiltInCategory category)
        {
            mCategory = category;
        }

        public bool AllowElement(Element elem)
        {
            if(elem.Category == null)
                return false;

            if (elem.Category.Id.IntegerValue == (int)mCategory)
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
