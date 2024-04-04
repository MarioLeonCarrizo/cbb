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
    using cbb.core;
    using System.IO;
    using System.Collections.Generic;

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

            if(!PreferencesFileExists())
            {
                var prefs = new Preferences()
                {
                    Repository = new List<string>
                    {
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    }
                };
                prefs.Save();
            }
            else
            {

            }
        }

        private bool PreferencesFileExists()
        {
            return File.Exists(Path.Combine(Path.GetDirectoryName(CoreAssembly.GetAssemblyLocation().ToString()), "prefs.cbb"));
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
