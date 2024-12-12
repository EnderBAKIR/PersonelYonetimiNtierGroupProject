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
            DepartmantsShow = new Button();
            AddDepart = new Button();
            btnDelete = new Button();
            lstDepartmants = new ListBox();
            btnUpdate = new Button();
            txtDepartmentName1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Verdana Pro Cond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 2;
            label3.Text = "Departman Adı:";
            // 
            // DepartmantsShow
            // 
            DepartmantsShow.Location = new Point(543, 85);
            DepartmantsShow.Name = "DepartmantsShow";
            DepartmantsShow.Size = new Size(165, 59);
            DepartmantsShow.TabIndex = 4;
            DepartmantsShow.Text = "listele";
            DepartmantsShow.UseVisualStyleBackColor = true;
            DepartmantsShow.Click += DepartmantsShow_Click;
            // 
            // AddDepart
            // 
            AddDepart.Location = new Point(3, 82);
            AddDepart.Name = "AddDepart";
            AddDepart.Size = new Size(141, 56);
            AddDepart.TabIndex = 5;
            AddDepart.Text = "ekle";
            AddDepart.UseVisualStyleBackColor = true;
            AddDepart.Click += AddDepart_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(181, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 59);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstDepartmants
            // 
            lstDepartmants.FormattingEnabled = true;
            lstDepartmants.ItemHeight = 28;
            lstDepartmants.Location = new Point(730, 32);
            lstDepartmants.Name = "lstDepartmants";
            lstDepartmants.Size = new Size(262, 452);
            lstDepartmants.TabIndex = 10;
            lstDepartmants.SelectedIndexChanged += lstDepartmants_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(342, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 53);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDepartmentName1
            // 
            txtDepartmentName1.Location = new Point(185, 10);
            txtDepartmentName1.Name = "txtDepartmentName1";
            txtDepartmentName1.Size = new Size(353, 35);
            txtDepartmentName1.StateCommon.Back.Color1 = Color.White;
            txtDepartmentName1.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtDepartmentName1.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtDepartmentName1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDepartmentName1.StateCommon.Border.Rounding = 20F;
            txtDepartmentName1.StateCommon.Content.Color1 = Color.DimGray;
            txtDepartmentName1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDepartmentName1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDepartmentName1.TabIndex = 13;
            txtDepartmentName1.TextChanged += txtDepartmentName1_TextChanged;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(12, 190);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.DarkSlateGray;
            kryptonButton1.OverrideDefault.Back.Color2 = Color.DarkSlateGray;
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.DarkSlateGray;
            kryptonButton1.OverrideDefault.Border.Color2 = Color.Black;
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.OverrideDefault.Border.Rounding = 18F;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(155, 49);
            kryptonButton1.StateCommon.Back.Color1 = Color.DarkSlateGray;
            kryptonButton1.StateCommon.Back.Color2 = Color.DarkSlateGray;
            kryptonButton1.StateCommon.Border.Color1 = Color.DarkSlateGray;
            kryptonButton1.StateCommon.Border.Color2 = Color.DarkSlateGray;
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 18F;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kryptonButton1.StatePressed.Back.Color1 = Color.DarkGray;
            kryptonButton1.StatePressed.Back.Color2 = Color.Gray;
            kryptonButton1.StatePressed.Border.Color1 = Color.DarkGray;
            kryptonButton1.StatePressed.Border.Color2 = Color.Gray;
            kryptonButton1.StatePressed.Border.Rounding = 18F;
            kryptonButton1.StatePressed.Border.Width = 1;
            kryptonButton1.StateTracking.Back.Color1 = Color.DarkSlateGray;
            kryptonButton1.StateTracking.Back.Color2 = Color.DarkSlateGray;
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateTracking.Border.Rounding = 18F;
            kryptonButton1.StateTracking.Border.Width = 1;
            kryptonButton1.TabIndex = 14;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Ekle";
            // 
            // Departman
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1022, 529);
            Controls.Add(kryptonButton1);
            Controls.Add(txtDepartmentName1);
            Controls.Add(btnUpdate);
            Controls.Add(lstDepartmants);
            Controls.Add(btnDelete);
            Controls.Add(AddDepart);
            Controls.Add(DepartmantsShow);
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
		private Button DepartmantsShow;
		private Button AddDepart;
		private Button btnDelete;
		private ListBox lstDepartmants;
        private Button btnUpdate;
        private Krypton.Toolkit.KryptonTextBox txtDepartmentName1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}