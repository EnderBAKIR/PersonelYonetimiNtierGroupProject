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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departman));
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
            DepartmantsShow.Image = (Image)resources.GetObject("DepartmantsShow.Image");
            DepartmantsShow.Location = new Point(761, 3);
            DepartmantsShow.Name = "DepartmantsShow";
            DepartmantsShow.Size = new Size(50, 59);
            DepartmantsShow.TabIndex = 4;
            DepartmantsShow.UseVisualStyleBackColor = true;
            DepartmantsShow.Click += DepartmantsShow_Click;
            // 
            // AddDepart
            // 
            AddDepart.Image = (Image)resources.GetObject("AddDepart.Image");
            AddDepart.Location = new Point(144, 77);
            AddDepart.Name = "AddDepart";
            AddDepart.Size = new Size(60, 56);
            AddDepart.TabIndex = 5;
            AddDepart.UseVisualStyleBackColor = true;
            AddDepart.Click += AddDepart_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(272, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 59);
            btnDelete.TabIndex = 8;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstDepartmants
            // 
            lstDepartmants.FormattingEnabled = true;
            lstDepartmants.ItemHeight = 28;
            lstDepartmants.Location = new Point(761, 74);
            lstDepartmants.Name = "lstDepartmants";
            lstDepartmants.Size = new Size(262, 452);
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
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(409, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(55, 53);
            btnUpdate.TabIndex = 12;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Departman
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1022, 529);
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