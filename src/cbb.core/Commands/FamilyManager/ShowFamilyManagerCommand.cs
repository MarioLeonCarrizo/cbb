using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace cbb.core
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class ShowFamilyManagerCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var dpid = new DockablePaneId(PaneIdentifiers.ManagerPaneIdentifier());
            var dp = commandData.Application.GetDockablePane(dpid);
            dp.Show();

            return Result.Succeeded;
        }

        public static string GetPath()
        {
            return typeof(ShowFamilyManagerCommand).Namespace + "." + nameof(ShowFamilyManagerCommand);
        }
    }
}
