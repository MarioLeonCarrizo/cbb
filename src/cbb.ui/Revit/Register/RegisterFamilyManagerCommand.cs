using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;
using cbb.core;
using cbb.ui;

namespace cbb.ui
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class RegisterFamilyManagerCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            return Execute(commandData.Application);
        }

        public Result Execute(UIApplication uIApplication)
        {
            var data = new DockablePaneProviderData();
            var managerPage = new FamilyManagerMainPage();

            data.FrameworkElement = managerPage as FrameworkElement;
            var state = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };

            var dpid = new DockablePaneId(PaneIdentifiers.ManagerPaneIdentifier());
            uIApplication.RegisterDockablePane(dpid, "Family Manager", managerPage as IDockablePaneProvider);

            return Result.Succeeded;
        }
    }
}
