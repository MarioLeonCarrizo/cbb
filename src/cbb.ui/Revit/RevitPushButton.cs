using Autodesk.Revit.UI;
using System;
using cbb.core;
using cbb.res;

namespace cbb.ui
{
    public class RevitPushButton
    {
        public static PushButton Create(RevitPushButtonDataModel data)
        {
            var btnDataName = Guid.NewGuid().ToString();
            var btnData = new PushButtonData(btnDataName, data.Label, CoreAssembly.GetAssemblyLocation(), data.CommandNamespace)
            {
                LargeImage = ResourceImage.GetIcon(data.IconImageName),
                ToolTipImage = ResourceImage.GetIcon(data.ToolTipImageName)
            };
                
            return data.Panel.AddItem(btnData) as PushButton;
        }
    }
}
