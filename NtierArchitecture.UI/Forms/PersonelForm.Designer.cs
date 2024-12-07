namespace NtierArchitecture.UI.Formlar
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            toolStrip1 = new ToolStrip();
            txtSearchBox = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            label2.ForeColor = Color.SaddleBrown;
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
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(79, 87);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(27, 138);
            label4.Name = "label4";
            label4.Size = new Size(177, 33);
            label4.TabIndex = 3;
            label4.Text = "T.C Kimlik Numarası";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.SaddleBrown;
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
            label6.ForeColor = Color.SaddleBrown;
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
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(69, 327);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Telefon";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(51, 380);
            label8.Name = "label8";
            label8.Size = new Size(153, 30);
            label8.TabIndex = 7;
            label8.Text = "Pozisyon Seçimi";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.Goldenrod;
            btnDetail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDetail.ForeColor = Color.White;
            btnDetail.Location = new Point(21, 327);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(166, 47);
            btnDetail.TabIndex = 13;
            btnDetail.Text = "Personel Detayı";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
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
            lstPersonelList.Location = new Point(21, 74);
            lstPersonelList.Name = "lstPersonelList";
            lstPersonelList.Size = new Size(534, 184);
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
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(234, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(214, 52);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Personel Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = Color.SaddleBrown;
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
            groupBox2.BackColor = Color.PaleGoldenrod;
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(lstPersonelList);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btnDetail);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Location = new Point(582, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(576, 569);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Görüntüleme Değişiklik İşlemleri";
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.LemonChiffon;
            toolStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Font = new Font("Segoe UI", 12F);
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtSearchBox, toolStripLabel1, toolStripSeparator1, toolStripComboBox1 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(21, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(534, 25);
            toolStrip1.TabIndex = 29;
            toolStrip1.Text = "toolStrip1";
            // 
            // txtSearchBox
            // 
            txtSearchBox.Alignment = ToolStripItemAlignment.Right;
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(200, 25);
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ActiveLinkColor = Color.Red;
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.ForeColor = SystemColors.MenuHighlight;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(32, 22);
            toolStripLabel1.Text = "🔍";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(170, 25);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(453, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 52);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateGray;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(327, 264);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 52);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // PersonelForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
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
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnDelete;
        private ToolStrip toolStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox txtSearchBox;
        private ToolStripLabel toolStripLabel1;
    }
}