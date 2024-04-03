using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using cbb.ui;
using cbb.res;
using cbb.core;

namespace cbb
{
    public class SetupInterface
    {
        public SetupInterface()
        {

        }

        public void Initialize(UIControlledApplication app)
        {
            string tabName = "Circle's Bin Blog";
            app.CreateRibbonTab(tabName);

            var panel = app.CreateRibbonPanel(tabName, "Annotation Commands");

            var TagWallButtonData = new RevitPushButtonDataModel
            {
                Label = "Tag Wall",
                Panel = panel,
                ToolTip = "This is some sample text, hello!",
                CommandNamespace = TagWallLayerCommand.GetPath(),
                IconImageName = "32_px.png",
                ToolTipImageName = "windows_128_px.png"
            };

            var tagWallButon = RevitPushButton.Create(TagWallButtonData);
        }
    }
}
