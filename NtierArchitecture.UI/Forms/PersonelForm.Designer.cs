﻿namespace NtierArchitecture.UI.Formlar
{
	partial class PersonelForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnDetail = new Button();
            dataGridView1 = new DataGridView();
            lstPersonelList = new ListBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtAdress = new TextBox();
            cmbPosition = new ComboBox();
            maskedtxtBirth = new MaskedTextBox();
            maskedtxtTC = new MaskedTextBox();
            maskedtxtTel = new MaskedTextBox();
            btnAdd = new Button();
            label10 = new Label();
            maskedtxtPswrd = new MaskedTextBox();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(104, -21);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel Ekleme İşlemleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(85, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(79, 87);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(27, 138);
            label4.Name = "label4";
            label4.Size = new Size(177, 33);
            label4.TabIndex = 3;
            label4.Text = "T.C Kimlik Numarası";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(69, 235);
            label5.Name = "label5";
            label5.Size = new Size(104, 32);
            label5.TabIndex = 4;
            label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(79, 280);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Adres";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(69, 327);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Telefon";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.Location = new Point(51, 380);
            label8.Name = "label8";
            label8.Size = new Size(153, 30);
            label8.TabIndex = 7;
            label8.Text = "Pozisyon Seçimi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(21, 50);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 8;
            label9.Text = "Personel Ara 🔍";
            // 
            // btnDetail
            // 
            btnDetail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDetail.Location = new Point(21, 327);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(166, 47);
            btnDetail.TabIndex = 13;
            btnDetail.Text = "Personel Detayı";
            btnDetail.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 380);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(534, 180);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lstPersonelList
            // 
            lstPersonelList.FormattingEnabled = true;
            lstPersonelList.ItemHeight = 20;
            lstPersonelList.Location = new Point(21, 94);
            lstPersonelList.Name = "lstPersonelList";
            lstPersonelList.Size = new Size(534, 164);
            lstPersonelList.TabIndex = 15;
            lstPersonelList.SelectedIndexChanged += lstPersonelList_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 26);
            txtName.TabIndex = 17;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(214, 81);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(260, 26);
            txtSurname.TabIndex = 18;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(214, 277);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(260, 26);
            txtAdress.TabIndex = 21;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(214, 382);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(260, 28);
            cmbPosition.TabIndex = 23;
            cmbPosition.SelectedIndexChanged += cmbPosition_SelectedIndexChanged;
            // 
            // maskedtxtBirth
            // 
            maskedtxtBirth.Location = new Point(214, 232);
            maskedtxtBirth.Mask = "00/00/0000";
            maskedtxtBirth.Name = "maskedtxtBirth";
            maskedtxtBirth.Size = new Size(260, 26);
            maskedtxtBirth.TabIndex = 24;
            maskedtxtBirth.ValidatingType = typeof(DateTime);
            // 
            // maskedtxtTC
            // 
            maskedtxtTC.Location = new Point(214, 135);
            maskedtxtTC.Mask = "00000000000";
            maskedtxtTC.Name = "maskedtxtTC";
            maskedtxtTC.Size = new Size(260, 26);
            maskedtxtTC.TabIndex = 25;
            maskedtxtTC.ValidatingType = typeof(int);
            // 
            // maskedtxtTel
            // 
            maskedtxtTel.Location = new Point(214, 327);
            maskedtxtTel.Mask = "(999) 000-0000";
            maskedtxtTel.Name = "maskedtxtTel";
            maskedtxtTel.Size = new Size(260, 26);
            maskedtxtTel.TabIndex = 26;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.ForestGreen;
            btnAdd.Location = new Point(234, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(214, 52);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Personel Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.Location = new Point(85, 177);
            label10.Name = "label10";
            label10.Size = new Size(53, 33);
            label10.TabIndex = 3;
            label10.Text = "Şifre";
            // 
            // maskedtxtPswrd
            // 
            maskedtxtPswrd.Location = new Point(214, 177);
            maskedtxtPswrd.Mask = "00000000000";
            maskedtxtPswrd.Name = "maskedtxtPswrd";
            maskedtxtPswrd.Size = new Size(260, 26);
            maskedtxtPswrd.TabIndex = 25;
            maskedtxtPswrd.ValidatingType = typeof(int);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(156, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(358, 26);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPosition);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedtxtTel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maskedtxtPswrd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedtxtTC);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(maskedtxtBirth);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAdress);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 575);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Ekleme İşlemleri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(lstPersonelList);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btnDetail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Location = new Point(551, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(576, 569);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Görüntüleme Değişiklik İşlemleri";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(327, 264);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 52);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(453, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 52);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // PersonelForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1194, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PersonelForm";
            Text = "PersonelForm";
            Load += PersonelForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Button button3;
		private Button btnDetail;
		private DataGridView dataGridView1;
		private ListBox lstPersonelList;
		private TextBox txtName;
		private TextBox txtSurname;
		private TextBox txtAdress;
		private ComboBox cmbPosition;
		private MaskedTextBox maskedtxtBirth;
		private MaskedTextBox maskedtxtTC;
		private MaskedTextBox maskedtxtTel;
        private Button btnAdd;
        private Label label10;
        private MaskedTextBox maskedtxtPswrd;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnDelete;
    }
}