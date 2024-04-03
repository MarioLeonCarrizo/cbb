namespace cbb.core
{
    partial class TagWallLayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTextNoteElementType = new System.Windows.Forms.ComboBox();
            this.cbThickness = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbFunction = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUnitType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDecimalPlaces = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(193, 320);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(274, 320);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTextNoteElementType);
            this.groupBox1.Controls.Add(this.cbThickness);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.cbFunction);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text Note Type";
            // 
            // cmbTextNoteElementType
            // 
            this.cmbTextNoteElementType.FormattingEnabled = true;
            this.cmbTextNoteElementType.Location = new System.Drawing.Point(6, 137);
            this.cmbTextNoteElementType.Name = "cmbTextNoteElementType";
            this.cmbTextNoteElementType.Size = new System.Drawing.Size(325, 24);
            this.cmbTextNoteElementType.TabIndex = 3;
            this.cmbTextNoteElementType.SelectedIndexChanged += new System.EventHandler(this.cmbTextNoteElementType_SelectedIndexChanged);
            // 
            // cbThickness
            // 
            this.cbThickness.AutoSize = true;
            this.cbThickness.Checked = true;
            this.cbThickness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThickness.Location = new System.Drawing.Point(6, 73);
            this.cbThickness.Name = "cbThickness";
            this.cbThickness.Size = new System.Drawing.Size(91, 20);
            this.cbThickness.TabIndex = 2;
            this.cbThickness.Text = "Thickness";
            this.cbThickness.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Location = new System.Drawing.Point(6, 47);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(66, 20);
            this.cbName.TabIndex = 1;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // cbFunction
            // 
            this.cbFunction.AutoSize = true;
            this.cbFunction.Checked = true;
            this.cbFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFunction.Location = new System.Drawing.Point(6, 21);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(79, 20);
            this.cbFunction.TabIndex = 0;
            this.cbFunction.Text = "Function";
            this.cbFunction.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbDecimalPlaces);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbUnitType);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Units";
            // 
            // cbUnitType
            // 
            this.cbUnitType.FormattingEnabled = true;
            this.cbUnitType.Location = new System.Drawing.Point(6, 40);
            this.cbUnitType.Name = "cbUnitType";
            this.cbUnitType.Size = new System.Drawing.Size(325, 24);
            this.cbUnitType.TabIndex = 0;
            this.cbUnitType.SelectedIndexChanged += new System.EventHandler(this.cbUnitType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unit Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decimal Places";
            // 
            // cbDecimalPlaces
            // 
            this.cbDecimalPlaces.FormattingEnabled = true;
            this.cbDecimalPlaces.Location = new System.Drawing.Point(6, 88);
            this.cbDecimalPlaces.Name = "cbDecimalPlaces";
            this.cbDecimalPlaces.Size = new System.Drawing.Size(325, 24);
            this.cbDecimalPlaces.TabIndex = 6;
            this.cbDecimalPlaces.SelectedIndexChanged += new System.EventHandler(this.cbDecimalPlaces_SelectedIndexChanged);
            // 
            // TagWallLayerForm
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(361, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TagWallLayerForm";
            this.Text = "Tag Options";
            this.Load += new System.EventHandler(this.TagWallLayerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbThickness;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTextNoteElementType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDecimalPlaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUnitType;
    }
}