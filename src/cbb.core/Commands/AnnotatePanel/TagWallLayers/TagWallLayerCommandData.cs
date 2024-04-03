using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace cbb.core
{
    public class TagWallLayerCommandData
    {
        public bool Function {  get; set; }
        public bool Name { get; set; }
        public bool Thickness { get; set; }
        public ElementId TextTypeId { get; set; }
        public LengthUnitType UnitType { get; set; }
        public int Decimals { get; set; }

        public TagWallLayerCommandData()
        {

        }
    }
}
