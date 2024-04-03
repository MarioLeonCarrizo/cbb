namespace cbb.core
{
    using Autodesk.Revit.UI;
    using Autodesk.Revit.DB;

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class TagWallLayerCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var wnd = new TaskDialog("info")
            {
                MainContent = "test comand",
                MainIcon = TaskDialogIcon.TaskDialogIconInformation,
                CommonButtons = TaskDialogCommonButtons.Ok,
            };
            wnd.Show();
            return Result.Succeeded;
        }

        public static string GetPath()
        {
            return typeof(TagWallLayerCommand).Namespace + "." + nameof(TagWallLayerCommand);
        }
    }
}
