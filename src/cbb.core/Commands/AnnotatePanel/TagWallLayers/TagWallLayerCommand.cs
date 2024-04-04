namespace cbb.core
{
    using System.Text;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.UI.Selection;
    using Autodesk.Revit.DB;

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class TagWallLayerCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //var wnd = new TaskDialog("info")
            //{
            //    MainContent = "test comand",
            //    MainIcon = TaskDialogIcon.TaskDialogIconInformation,
            //    CommonButtons = TaskDialogCommonButtons.Ok,
            //};
            //wnd.Show();

            var uidoc = commandData.Application.ActiveUIDocument;
            var doc = uidoc.Document;

            if(doc.IsFamilyDocument)
            {
                Message.Display("Can't use command in family document", WindowType.Warning);
                return Result.Cancelled;
            }

            var activeView = uidoc.ActiveView;
            bool canCreateTextNoteInView = false;
            switch (activeView.ViewType)
            {
                case ViewType.FloorPlan:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.CeilingPlan:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Detail:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Elevation:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Section:
                    canCreateTextNoteInView = true;
                    break;
            }

            var userInfo = new TagWallLayerCommandData();

            if (!canCreateTextNoteInView)
            {
                Message.Display("Text Note element can't be created in the current view.", WindowType.Error); 
                return Result.Cancelled;
            }

            using (var window = new TagWallLayerForm(uidoc))
            {
                window.ShowDialog();

                if (window.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }

                userInfo = window.GetInformation();
            }

            Reference selectionReference;
            Element selectionElement;

            try
            {
                selectionReference = uidoc.Selection.PickObject(ObjectType.Element, new SelectionFilterByCategory(BuiltInCategory.OST_Walls), "Select one basic wall.");
                selectionElement = doc.GetElement(selectionReference);
            }
            catch (Autodesk.Revit.Exceptions.OperationCanceledException)
            {
                return Result.Cancelled;
            }

            var wall = selectionElement as Wall;

            if (wall.IsStackedWall)
            {
                Message.Display("Wall you selected is category of the Stacked Wall.", WindowType.Warning);
                return Result.Cancelled;
            }

            var layers = wall.WallType.GetCompoundStructure().GetLayers();

            var msg = new StringBuilder();
            foreach ( var layer in layers )
            {
                var material = doc.GetElement(layer.MaterialId) as Material;
                msg.AppendLine(); 

                if(userInfo.Function)
                    msg.AppendLine(layer.Function.ToString());

                if (userInfo.Name)
                {
                    if (material != null)
                        msg.Append(" " + material.Name);
                    else
                        msg.Append("  <by category>");
                }

                if (userInfo.Thickness)
                    msg.AppendLine(" " + LengthUnitConverter.ConvertToMetric(layer.Width, userInfo.UnitType, userInfo.Decimals).ToString());
            }

            var textNoteOptions = new TextNoteOptions
            {
                VerticalAlignment = VerticalTextAlignment.Top,
                HorizontalAlignment = HorizontalTextAlignment.Left,
                TypeId = userInfo.TextTypeId
            };

            using(var transaction = new Transaction(doc))
            {
                transaction.Start("Tag Wall Layers Command");

                var pt = new XYZ();

                // Construct sketch plane for user to pick point if we are in elevation or section view.
                if (activeView.ViewType == ViewType.Elevation || activeView.ViewType == ViewType.Section)
                {
                    var plane = Plane.CreateByNormalAndOrigin(activeView.ViewDirection, activeView.Origin);
                    var sketchPlane = SketchPlane.Create(doc, plane);
                    activeView.SketchPlane = sketchPlane;

                    // Ask user to pick location point for the Text Note Element
                    pt = uidoc.Selection.PickPoint("Pick text note location point");
                }
                else
                {
                    // Ask user to pick location point for the Text Note Element
                    pt = uidoc.Selection.PickPoint("Pick text note location point");
                }


                var textNote = TextNote.Create(doc, activeView.Id, pt, msg.ToString(), textNoteOptions);
                transaction.Commit();

            }

            return Result.Succeeded;
        }

        public static string GetPath()
        {
            return typeof(TagWallLayerCommand).Namespace + "." + nameof(TagWallLayerCommand);
        }
    }
}
