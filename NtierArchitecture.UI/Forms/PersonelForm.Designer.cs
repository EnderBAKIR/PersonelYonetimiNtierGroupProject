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
            dataGridView1 = new DataGridView();
            lstPersonelList = new ListBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtAdress = new TextBox();
            cmbPosition = new ComboBox();
            maskedtxtBirth = new MaskedTextBox();
            maskedtxtTC = new MaskedTextBox();
            maskedtxtTel = new MaskedTextBox();
            maskedtxtPswrd = new MaskedTextBox();
            groupBox1 = new GroupBox();
            btnAdd1 = new Krypton.Toolkit.KryptonButton();
            label7 = new Label();
            label6 = new Label();
            label12 = new Label();
            label5 = new Label();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            rdInactive = new RadioButton();
            rdActive = new RadioButton();
            groupBox2 = new GroupBox();
            btnDelete1 = new Krypton.Toolkit.KryptonButton();
            btnUpdate1 = new Krypton.Toolkit.KryptonButton();
            btnDetail1 = new Krypton.Toolkit.KryptonButton();
            toolStrip1 = new ToolStrip();
            txtSearchBox = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
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
            groupBox1.Controls.Add(btnAdd1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(rdInactive);
            groupBox1.Controls.Add(rdActive);
            groupBox1.Controls.Add(cmbPosition);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maskedtxtTel);
            groupBox1.Controls.Add(maskedtxtPswrd);
            groupBox1.Controls.Add(maskedtxtTC);
            groupBox1.Controls.Add(maskedtxtBirth);
            groupBox1.Controls.Add(txtAdress);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 575);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Ekleme İşlemleri";
            // 
            // btnAdd1
            // 
            btnAdd1.Location = new Point(230, 473);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnAdd1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnAdd1.OverrideDefault.Back.ColorAngle = 45F;
            btnAdd1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnAdd1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnAdd1.OverrideDefault.Border.ColorAngle = 45F;
            btnAdd1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd1.OverrideDefault.Border.Rounding = 17F;
            btnAdd1.OverrideDefault.Border.Width = 2;
            btnAdd1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAdd1.Size = new Size(163, 43);
            btnAdd1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnAdd1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnAdd1.StateCommon.Back.ColorAngle = 45F;
            btnAdd1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnAdd1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnAdd1.StateCommon.Border.ColorAngle = 45F;
            btnAdd1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd1.StateCommon.Border.Rounding = 17F;
            btnAdd1.StateCommon.Border.Width = 2;
            btnAdd1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAdd1.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAdd1.StateCommon.Content.ShortText.Font = new Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd1.StateDisabled.Border.Width = 2;
            btnAdd1.StateNormal.Border.Width = 2;
            btnAdd1.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            btnAdd1.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            btnAdd1.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            btnAdd1.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            btnAdd1.StatePressed.Border.Rounding = 17F;
            btnAdd1.StatePressed.Border.Width = 2;
            btnAdd1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnAdd1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnAdd1.StateTracking.Back.ColorAngle = 45F;
            btnAdd1.StateTracking.Border.ColorAngle = 45F;
            btnAdd1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd1.StateTracking.Border.Rounding = 17F;
            btnAdd1.StateTracking.Border.Width = 2;
            btnAdd1.TabIndex = 38;
            btnAdd1.Values.DropDownArrowColor = Color.Empty;
            btnAdd1.Values.Text = "Personel Ekle";
            btnAdd1.Click += btnAdd1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(66, 433);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 37;
            label7.Text = "Çalışıyor Mu?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(51, 386);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 36;
            label6.Text = "Pozisyon Seçimi:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(79, 330);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 35;
            label12.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(85, 280);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 34;
            label5.Text = "Adres:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(79, 235);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 33;
            label10.Text = "Doğum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(91, 180);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 32;
            label4.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(36, 138);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 31;
            label3.Text = "T.C Kimlik Numarası:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(79, 84);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 30;
            label2.Text = "Soyad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(85, 41);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 29;
            label11.Text = "Ad:";
            // 
            // rdInactive
            // 
            rdInactive.AutoSize = true;
            rdInactive.Location = new Point(310, 433);
            rdInactive.Name = "rdInactive";
            rdInactive.Size = new Size(63, 24);
            rdInactive.TabIndex = 28;
            rdInactive.TabStop = true;
            rdInactive.Text = "Hayır";
            rdInactive.UseVisualStyleBackColor = true;
            // 
            // rdActive
            // 
            rdActive.AutoSize = true;
            rdActive.Location = new Point(230, 433);
            rdActive.Name = "rdActive";
            rdActive.Size = new Size(59, 24);
            rdActive.TabIndex = 28;
            rdActive.TabStop = true;
            rdActive.Text = "Evet";
            rdActive.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(249, 250, 252);
            groupBox2.Controls.Add(btnDelete1);
            groupBox2.Controls.Add(btnUpdate1);
            groupBox2.Controls.Add(btnDetail1);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Controls.Add(lstPersonelList);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(582, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(576, 569);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Görüntüleme Değişiklik İşlemleri";
            // 
            // btnDelete1
            // 
            btnDelete1.Location = new Point(460, 269);
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
            btnDelete1.StateCommon.Content.ShortText.Font = new Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnDelete1.TabIndex = 32;
            btnDelete1.Values.DropDownArrowColor = Color.Empty;
            btnDelete1.Values.Text = "Sil";
            btnDelete1.Click += btnDelete1_Click;
            // 
            // btnUpdate1
            // 
            btnUpdate1.Location = new Point(313, 271);
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
            btnUpdate1.StateCommon.Content.ShortText.Font = new Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnUpdate1.TabIndex = 31;
            btnUpdate1.Values.DropDownArrowColor = Color.Empty;
            btnUpdate1.Values.Text = "Güncelle";
            btnUpdate1.Click += btnUpdate1_Click;
            // 
            // btnDetail1
            // 
            btnDetail1.Location = new Point(21, 331);
            btnDetail1.Name = "btnDetail1";
            btnDetail1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnDetail1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnDetail1.OverrideDefault.Back.ColorAngle = 45F;
            btnDetail1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnDetail1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnDetail1.OverrideDefault.Border.ColorAngle = 45F;
            btnDetail1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDetail1.OverrideDefault.Border.Rounding = 17F;
            btnDetail1.OverrideDefault.Border.Width = 2;
            btnDetail1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnDetail1.Size = new Size(165, 43);
            btnDetail1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnDetail1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnDetail1.StateCommon.Back.ColorAngle = 45F;
            btnDetail1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnDetail1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnDetail1.StateCommon.Border.ColorAngle = 45F;
            btnDetail1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDetail1.StateCommon.Border.Rounding = 17F;
            btnDetail1.StateCommon.Border.Width = 2;
            btnDetail1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDetail1.StateCommon.Content.ShortText.Color2 = Color.White;
            btnDetail1.StateCommon.Content.ShortText.Font = new Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail1.StateDisabled.Border.Width = 2;
            btnDetail1.StateNormal.Border.Width = 2;
            btnDetail1.StatePressed.Back.Color1 = Color.FromArgb(181, 132, 68);
            btnDetail1.StatePressed.Back.Color2 = Color.FromArgb(147, 108, 57);
            btnDetail1.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnDetail1.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnDetail1.StatePressed.Border.Rounding = 17F;
            btnDetail1.StatePressed.Border.Width = 2;
            btnDetail1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnDetail1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnDetail1.StateTracking.Back.ColorAngle = 45F;
            btnDetail1.StateTracking.Border.ColorAngle = 45F;
            btnDetail1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDetail1.StateTracking.Border.Rounding = 17F;
            btnDetail1.StateTracking.Border.Width = 2;
            btnDetail1.TabIndex = 30;
            btnDetail1.Values.DropDownArrowColor = Color.Empty;
            btnDetail1.Values.Text = "Personel Detayı";
            btnDetail1.Click += btnDetail1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.LemonChiffon;
            toolStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Font = new Font("Segoe UI", 9F);
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
            toolStripLabel1.Size = new Size(19, 22);
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
            // PersonelForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 252);
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
		private Button button3;
		private DataGridView dataGridView1;
		private ListBox lstPersonelList;
		private TextBox txtName;
		private TextBox txtSurname;
		private TextBox txtAdress;
		private ComboBox cmbPosition;
		private MaskedTextBox maskedtxtBirth;
		private MaskedTextBox maskedtxtTC;
		private MaskedTextBox maskedtxtTel;
        private MaskedTextBox maskedtxtPswrd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStrip toolStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox txtSearchBox;
        private ToolStripLabel toolStripLabel1;
        private RadioButton rdInactive;
        private RadioButton rdActive;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label12;
        private Label label5;
        private Label label10;
        private Label label4;
        private Krypton.Toolkit.KryptonButton btnAdd1;
        private Krypton.Toolkit.KryptonButton btnDetail1;
        private Krypton.Toolkit.KryptonButton btnUpdate1;
        private Krypton.Toolkit.KryptonButton btnDelete1;
    }
}