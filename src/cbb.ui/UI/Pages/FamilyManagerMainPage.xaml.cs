using System;
using System.Windows;
using System.Windows.Controls;

using Autodesk.Revit.UI;

using cbb.core;

namespace cbb.ui
{
    public partial class FamilyManagerMainPage : Page, IDisposable, IDockablePaneProvider
    {
        public FamilyManagerMainPage()
        {
            InitializeComponent();

            DataContext = new FamilyManagerMainPageViewModel();
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElement = this as FrameworkElement;
            data.InitialState = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };
        }
    }
}
