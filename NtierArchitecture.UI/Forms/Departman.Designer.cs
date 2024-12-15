namespace NtierArchitecture.UI.Formlar
{
	partial class Departman
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
            label3 = new Label();
            txtDepartmentName1 = new Krypton.Toolkit.KryptonTextBox();
            AddDepart1 = new Krypton.Toolkit.KryptonButton();
            lstDepartmants1 = new Krypton.Toolkit.KryptonListBox();
            DepartmantsShow1 = new Krypton.Toolkit.KryptonButton();
            btnDelete1 = new Krypton.Toolkit.KryptonButton();
            btnUpdate1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(39, 31);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 2;
            label3.Text = "Departman Adı:";
            // 
            // txtDepartmentName1
            // 
            txtDepartmentName1.Location = new Point(223, 25);
            txtDepartmentName1.Name = "txtDepartmentName1";
            txtDepartmentName1.Size = new Size(443, 31);
            txtDepartmentName1.StateCommon.Back.Color1 = Color.White;
            txtDepartmentName1.StateCommon.Border.Color1 = Color.FromArgb(141, 182, 252);
            txtDepartmentName1.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtDepartmentName1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDepartmentName1.StateCommon.Border.Rounding = 20F;
            txtDepartmentName1.StateCommon.Content.Color1 = Color.DimGray;
            txtDepartmentName1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDepartmentName1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDepartmentName1.TabIndex = 13;
            txtDepartmentName1.TextChanged += txtDepartmentName1_TextChanged;
            // 
            // AddDepart1
            // 
            AddDepart1.Location = new Point(270, 98);
            AddDepart1.Name = "AddDepart1";
            AddDepart1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            AddDepart1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            AddDepart1.OverrideDefault.Back.ColorAngle = 45F;
            AddDepart1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            AddDepart1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            AddDepart1.OverrideDefault.Border.ColorAngle = 45F;
            AddDepart1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            AddDepart1.OverrideDefault.Border.Rounding = 17F;
            AddDepart1.OverrideDefault.Border.Width = 2;
            AddDepart1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            AddDepart1.Size = new Size(124, 43);
            AddDepart1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            AddDepart1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            AddDepart1.StateCommon.Back.ColorAngle = 45F;
            AddDepart1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            AddDepart1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            AddDepart1.StateCommon.Border.ColorAngle = 45F;
            AddDepart1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            AddDepart1.StateCommon.Border.Rounding = 17F;
            AddDepart1.StateCommon.Border.Width = 2;
            AddDepart1.StateCommon.Content.ShortText.Color1 = Color.White;
            AddDepart1.StateCommon.Content.ShortText.Color2 = Color.White;
            AddDepart1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddDepart1.StateDisabled.Border.Width = 2;
            AddDepart1.StateNormal.Border.Width = 2;
            AddDepart1.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            AddDepart1.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            AddDepart1.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            AddDepart1.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            AddDepart1.StatePressed.Border.Rounding = 17F;
            AddDepart1.StatePressed.Border.Width = 2;
            AddDepart1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            AddDepart1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            AddDepart1.StateTracking.Back.ColorAngle = 45F;
            AddDepart1.StateTracking.Border.ColorAngle = 45F;
            AddDepart1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            AddDepart1.StateTracking.Border.Rounding = 17F;
            AddDepart1.StateTracking.Border.Width = 2;
            AddDepart1.TabIndex = 14;
            AddDepart1.Values.DropDownArrowColor = Color.Empty;
            AddDepart1.Values.Text = "Ekle";
            AddDepart1.Click += AddDepart1_Click;
            // 
            // lstDepartmants1
            // 
            lstDepartmants1.Location = new Point(39, 158);
            lstDepartmants1.Name = "lstDepartmants1";
            lstDepartmants1.Size = new Size(614, 203);
            lstDepartmants1.StateCommon.Back.Color1 = Color.FromArgb(230, 234, 242);
            lstDepartmants1.StateCommon.Border.Color1 = Color.FromArgb(222, 223, 224);
            lstDepartmants1.StateCommon.Border.Rounding = 15F;
            lstDepartmants1.StateCommon.Border.Width = 3;
            lstDepartmants1.TabIndex = 15;
            lstDepartmants1.SelectedIndexChanged += lstDepartmants1_SelectedIndexChanged;
            // 
            // DepartmantsShow1
            // 
            DepartmantsShow1.Location = new Point(400, 98);
            DepartmantsShow1.Name = "DepartmantsShow1";
            DepartmantsShow1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            DepartmantsShow1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            DepartmantsShow1.OverrideDefault.Back.ColorAngle = 45F;
            DepartmantsShow1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            DepartmantsShow1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            DepartmantsShow1.OverrideDefault.Border.ColorAngle = 45F;
            DepartmantsShow1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            DepartmantsShow1.OverrideDefault.Border.Rounding = 17F;
            DepartmantsShow1.OverrideDefault.Border.Width = 2;
            DepartmantsShow1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            DepartmantsShow1.Size = new Size(118, 43);
            DepartmantsShow1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            DepartmantsShow1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            DepartmantsShow1.StateCommon.Back.ColorAngle = 45F;
            DepartmantsShow1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            DepartmantsShow1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            DepartmantsShow1.StateCommon.Border.ColorAngle = 45F;
            DepartmantsShow1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            DepartmantsShow1.StateCommon.Border.Rounding = 17F;
            DepartmantsShow1.StateCommon.Border.Width = 2;
            DepartmantsShow1.StateCommon.Content.ShortText.Color1 = Color.White;
            DepartmantsShow1.StateCommon.Content.ShortText.Color2 = Color.White;
            DepartmantsShow1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmantsShow1.StateDisabled.Border.Width = 2;
            DepartmantsShow1.StateNormal.Border.Width = 2;
            DepartmantsShow1.StatePressed.Back.Color1 = Color.FromArgb(181, 132, 68);
            DepartmantsShow1.StatePressed.Back.Color2 = Color.FromArgb(147, 108, 57);
            DepartmantsShow1.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            DepartmantsShow1.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            DepartmantsShow1.StatePressed.Border.Rounding = 17F;
            DepartmantsShow1.StatePressed.Border.Width = 2;
            DepartmantsShow1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            DepartmantsShow1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            DepartmantsShow1.StateTracking.Back.ColorAngle = 45F;
            DepartmantsShow1.StateTracking.Border.ColorAngle = 45F;
            DepartmantsShow1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            DepartmantsShow1.StateTracking.Border.Rounding = 17F;
            DepartmantsShow1.StateTracking.Border.Width = 2;
            DepartmantsShow1.TabIndex = 14;
            DepartmantsShow1.Values.DropDownArrowColor = Color.Empty;
            DepartmantsShow1.Values.Text = "Listele";
            DepartmantsShow1.Click += DepartmantsShow1_Click;
            // 
            // btnDelete1
            // 
            btnDelete1.Location = new Point(557, 376);
            btnDelete1.Name = "btnDelete1";
            btnDelete1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnDelete1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnDelete1.OverrideDefault.Back.ColorAngle = 45F;
            btnDelete1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnDelete1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnDelete1.OverrideDefault.Border.ColorAngle = 45F;
            btnDelete1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete1.OverrideDefault.Border.Rounding = 17F;
            btnDelete1.OverrideDefault.Border.Width = 2;
            btnDelete1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnDelete1.Size = new Size(85, 45);
            btnDelete1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnDelete1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnDelete1.StateCommon.Back.ColorAngle = 45F;
            btnDelete1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnDelete1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnDelete1.StateCommon.Border.ColorAngle = 45F;
            btnDelete1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete1.StateCommon.Border.Rounding = 15F;
            btnDelete1.StateCommon.Border.Width = 2;
            btnDelete1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDelete1.StateCommon.Content.ShortText.Color2 = Color.White;
            btnDelete1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete1.StateDisabled.Border.Width = 2;
            btnDelete1.StateNormal.Border.Width = 2;
            btnDelete1.StatePressed.Back.Color1 = Color.Brown;
            btnDelete1.StatePressed.Back.Color2 = Color.Firebrick;
            btnDelete1.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnDelete1.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnDelete1.StatePressed.Border.Rounding = 15F;
            btnDelete1.StatePressed.Border.Width = 2;
            btnDelete1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnDelete1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnDelete1.StateTracking.Back.ColorAngle = 45F;
            btnDelete1.StateTracking.Border.ColorAngle = 45F;
            btnDelete1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete1.StateTracking.Border.Rounding = 17F;
            btnDelete1.StateTracking.Border.Width = 2;
            btnDelete1.TabIndex = 14;
            btnDelete1.Values.DropDownArrowColor = Color.Empty;
            btnDelete1.Values.Text = "Sil";
            btnDelete1.Click += btnDelete1_Click;
            // 
            // btnUpdate1
            // 
            btnUpdate1.Location = new Point(524, 98);
            btnUpdate1.Name = "btnUpdate1";
            btnUpdate1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnUpdate1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnUpdate1.OverrideDefault.Back.ColorAngle = 45F;
            btnUpdate1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnUpdate1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnUpdate1.OverrideDefault.Border.ColorAngle = 45F;
            btnUpdate1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdate1.OverrideDefault.Border.Rounding = 17F;
            btnUpdate1.OverrideDefault.Border.Width = 2;
            btnUpdate1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnUpdate1.Size = new Size(118, 43);
            btnUpdate1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnUpdate1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnUpdate1.StateCommon.Back.ColorAngle = 45F;
            btnUpdate1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnUpdate1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnUpdate1.StateCommon.Border.ColorAngle = 45F;
            btnUpdate1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdate1.StateCommon.Border.Rounding = 17F;
            btnUpdate1.StateCommon.Border.Width = 2;
            btnUpdate1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnUpdate1.StateCommon.Content.ShortText.Color2 = Color.White;
            btnUpdate1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate1.StateDisabled.Border.Width = 2;
            btnUpdate1.StateNormal.Border.Width = 2;
            btnUpdate1.StatePressed.Back.Color1 = Color.FromArgb(237, 232, 97);
            btnUpdate1.StatePressed.Back.Color2 = Color.FromArgb(216, 208, 56);
            btnUpdate1.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnUpdate1.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnUpdate1.StatePressed.Border.Rounding = 17F;
            btnUpdate1.StatePressed.Border.Width = 2;
            btnUpdate1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnUpdate1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnUpdate1.StateTracking.Back.ColorAngle = 45F;
            btnUpdate1.StateTracking.Border.ColorAngle = 45F;
            btnUpdate1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnUpdate1.StateTracking.Border.Rounding = 17F;
            btnUpdate1.StateTracking.Border.Width = 2;
            btnUpdate1.TabIndex = 14;
            btnUpdate1.Values.DropDownArrowColor = Color.Empty;
            btnUpdate1.Values.Text = "Güncelle";
            btnUpdate1.Click += btnUpdate1_Click;
            // 
            // Departman
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(772, 490);
            Controls.Add(lstDepartmants1);
            Controls.Add(btnDelete1);
            Controls.Add(btnUpdate1);
            Controls.Add(DepartmantsShow1);
            Controls.Add(AddDepart1);
            Controls.Add(txtDepartmentName1);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.DarkRed;
            Margin = new Padding(4);
            Name = "Departman";
            Text = "DEPARTMAN İŞLEMLERİ";
            Load += Departman_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox txtDepartmentName1;
        private Krypton.Toolkit.KryptonButton AddDepart1;
        private Krypton.Toolkit.KryptonListBox lstDepartmants1;
        private Krypton.Toolkit.KryptonButton DepartmantsShow1;
        private Krypton.Toolkit.KryptonButton btnDelete1;
        private Krypton.Toolkit.KryptonButton btnUpdate1;
    }
}