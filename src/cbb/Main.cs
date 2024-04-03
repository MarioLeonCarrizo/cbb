namespace cbb
{
    using System;
    using System.Reflection;
    using System.Windows.Media.Imaging;
    using Autodesk.Revit.DB;
    using Autodesk.Revit.DB.Events;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.ApplicationServices;

    using cbb.ui;
    /// <summary>
    /// Pluggins Main
    /// </summary>
    public class Main : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            var ui = new SetupInterface();
            ui.Initialize(application);

            application.ControlledApplication.ApplicationInitialized += DockablePaneRegisters;

            return Result.Succeeded;
        }

        private void DockablePaneRegisters(object sender, ApplicationInitializedEventArgs e)
        {
            var familyManager = new RegisterFamilyManagerCommand();
            familyManager.Execute(new UIApplication(sender as Application));
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
