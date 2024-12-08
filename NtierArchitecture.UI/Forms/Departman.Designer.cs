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
            label1 = new Label();
            label3 = new Label();
            DepartmantsShow = new Button();
            AddDepart = new Button();
            btnDelete = new Button();
            lstDepartmants = new ListBox();
            txtDepartmanName = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 38);
            label1.TabIndex = 0;
            label1.Text = "DEPARTMAN İŞLEMLERİ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(228, 28);
            label3.TabIndex = 2;
            label3.Text = "Departman Adını Yazınız:";
            // 
            // DepartmantsShow
            // 
            DepartmantsShow.Location = new Point(752, 34);
            DepartmantsShow.Name = "DepartmantsShow";
            DepartmantsShow.Size = new Size(338, 82);
            DepartmantsShow.TabIndex = 4;
            DepartmantsShow.Text = "Departmanları Görüntüle";
            DepartmantsShow.UseVisualStyleBackColor = true;
            DepartmantsShow.Click += DepartmantsShow_Click;
            // 
            // AddDepart
            // 
            AddDepart.Location = new Point(12, 139);
            AddDepart.Name = "AddDepart";
            AddDepart.Size = new Size(135, 59);
            AddDepart.TabIndex = 5;
            AddDepart.Text = "Ekle";
            AddDepart.UseVisualStyleBackColor = true;
            AddDepart.Click += AddDepart_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(186, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 58);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstDepartmants
            // 
            lstDepartmants.FormattingEnabled = true;
            lstDepartmants.ItemHeight = 28;
            lstDepartmants.Location = new Point(752, 139);
            lstDepartmants.Name = "lstDepartmants";
            lstDepartmants.Size = new Size(338, 340);
            lstDepartmants.TabIndex = 10;
            lstDepartmants.SelectedIndexChanged += lstDepartmants_SelectedIndexChanged;
            // 
            // txtDepartmanName
            // 
            txtDepartmanName.Location = new Point(255, 61);
            txtDepartmanName.Name = "txtDepartmanName";
            txtDepartmanName.Size = new Size(342, 34);
            txtDepartmanName.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(386, 139);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 58);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Departman
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1189, 576);
            Controls.Add(btnUpdate);
            Controls.Add(txtDepartmanName);
            Controls.Add(lstDepartmants);
            Controls.Add(btnDelete);
            Controls.Add(AddDepart);
            Controls.Add(DepartmantsShow);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.DarkRed;
            Margin = new Padding(4);
            Name = "Departman";
            Text = "Departman";
            Load += Departman_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label3;
		private Button DepartmantsShow;
		private Button AddDepart;
		private Button btnDelete;
		private ListBox lstDepartmants;
		private TextBox txtDepartmanName;
        private Button btnUpdate;
    }
}