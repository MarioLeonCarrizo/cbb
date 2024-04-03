using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace cbb.core
{
    public partial class TagWallLayerForm : System.Windows.Forms.Form
    {
        private UIDocument uidoc = null;
        private ElementId textTypeId = null;
        private LengthUnitType unitType = LengthUnitType.milimeter;
        private int decimals = 1;

        public TagWallLayerForm(UIDocument uiDocument)
        {
            InitializeComponent();
            uidoc = uiDocument;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbTextNoteElementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textTypeId = ((KeyValuePair<string, ElementId>)cmbTextNoteElementType.SelectedItem).Value;
        }

        private void cbUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitType = (LengthUnitType)cbUnitType.SelectedValue;
        }

        private void cbDecimalPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimals = (int)cbDecimalPlaces.SelectedValue;
        }

        private void TagWallLayerForm_Load(object sender, EventArgs e)
        {
            PopulateTextNoteTypeList();
            PopulateUnitTypeList();
            PopulateDecimalPlacesList();
        }

        public TagWallLayerCommandData GetInformation()
        {
            var information = new TagWallLayerCommandData()
            {
                Function = cbFunction.Checked,
                Name = cbName.Checked,
                Thickness = cbThickness.Checked,
                TextTypeId = textTypeId,
                UnitType = unitType,
                Decimals = decimals,
            };

            return information;
        }

        private void PopulateTextNoteTypeList()
        {
            var doc = uidoc.Document;

            // Get all Text Element Types in project.
            var allTextElementTypes = new FilteredElementCollector(doc).OfClass(typeof(TextElementType));

            var list = new List<KeyValuePair<string, ElementId>>();

            foreach (var item in allTextElementTypes)
                list.Add(new KeyValuePair<string, ElementId>(item.Name, item.Id));

            cmbTextNoteElementType.DataSource = null;
            cmbTextNoteElementType.DataSource = new BindingSource(list, null);
            cmbTextNoteElementType.DisplayMember = "Key";
            cmbTextNoteElementType.ValueMember = "Value";
        }

        private void PopulateUnitTypeList()
        {
            cbUnitType.DataSource = Enum.GetValues(typeof(LengthUnitType));
        }

        private void PopulateDecimalPlacesList()
        {
            var values = new List<int>() { 0, 1, 2, 3 };

            var source = new BindingSource
            {
                DataSource = values,
            };

            cbDecimalPlaces.DataSource = source.DataSource;
            cbDecimalPlaces.SelectedItem = values[2];
        }
    }
}
