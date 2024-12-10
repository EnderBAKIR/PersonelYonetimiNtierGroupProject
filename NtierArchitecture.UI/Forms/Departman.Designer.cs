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
            txtDepartmanName = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Verdana Pro Cond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(276, 28);
            label3.TabIndex = 2;
            label3.Text = "Departman Adını Yazınız:";
            // 
            // DepartmantsShow
            // 
            DepartmantsShow.Image = Properties.Resources.Adsız_tasarım__4_;
            DepartmantsShow.Location = new Point(549, 390);
            DepartmantsShow.Name = "DepartmantsShow";
            DepartmantsShow.Size = new Size(107, 99);
            DepartmantsShow.TabIndex = 4;
            DepartmantsShow.UseVisualStyleBackColor = true;
            DepartmantsShow.Click += DepartmantsShow_Click;
            // 
            // AddDepart
            // 
            AddDepart.Image = Properties.Resources.Adsız_tasarım__1_;
            AddDepart.Location = new Point(39, 401);
            AddDepart.Name = "AddDepart";
            AddDepart.Size = new Size(96, 78);
            AddDepart.TabIndex = 5;
            AddDepart.UseVisualStyleBackColor = true;
            AddDepart.Click += AddDepart_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.Adsız_tasarım__2_;
            btnDelete.Location = new Point(212, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 101);
            btnDelete.TabIndex = 8;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstDepartmants
            // 
            lstDepartmants.FormattingEnabled = true;
            lstDepartmants.ItemHeight = 28;
            lstDepartmants.Location = new Point(500, 66);
            lstDepartmants.Name = "lstDepartmants";
            lstDepartmants.Size = new Size(253, 312);
            lstDepartmants.TabIndex = 10;
            lstDepartmants.SelectedIndexChanged += lstDepartmants_SelectedIndexChanged;
            // 
            // txtDepartmanName
            // 
            txtDepartmanName.Location = new Point(285, 12);
            txtDepartmanName.Name = "txtDepartmanName";
            txtDepartmanName.Size = new Size(224, 34);
            txtDepartmanName.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Adsız_tasarım__3_;
            btnUpdate.Location = new Point(376, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 101);
            btnUpdate.TabIndex = 12;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Departman
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = Properties.Resources.departmansicon;
            ClientSize = new Size(752, 521);
            Controls.Add(btnUpdate);
            Controls.Add(txtDepartmanName);
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
		private TextBox txtDepartmanName;
        private Button btnUpdate;
    }
}