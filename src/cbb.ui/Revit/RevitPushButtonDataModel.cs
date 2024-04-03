using Autodesk.Revit.UI;

namespace cbb.ui
{
    public class RevitPushButtonDataModel
    {
        public string Label {  get; set; }
        public RibbonPanel Panel { get; set; }
        public string CommandNamespace { get; set; }
        public string ToolTip { get; set; }
        public string IconImageName { get; set; }
        public string ToolTipImageName { get; set; }

        public RevitPushButtonDataModel() 
        {
            
        }
    }
}
