namespace NtierArchitecture.UI.Forms
{
    partial class CalisanMaasTakibi
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label6 = new Label();
            btnGetByDate = new Krypton.Toolkit.KryptonButton();
            cmbYear = new ComboBox();
            cmbMonth = new ComboBox();
            groupBox2 = new GroupBox();
            lblPersonelTc = new Label();
            label5 = new Label();
            btnPay = new Krypton.Toolkit.KryptonButton();
            txtSearch = new Krypton.Toolkit.KryptonTextBox();
            cmbDepartments = new Krypton.Toolkit.KryptonComboBox();
            dgwEmployees = new DataGridView();
            Departman = new DataGridViewTextBoxColumn();
            Tc = new DataGridViewTextBoxColumn();
            AdSoyad = new DataGridViewTextBoxColumn();
            Odeme = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label2 = new Label();
            btnTazminatAtama = new Krypton.Toolkit.KryptonButton();
            btnTazminatOdeme = new Krypton.Toolkit.KryptonButton();
            lstTazminatControl = new ListBox();
            lblTazminat = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwEmployees).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnGetByDate);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(cmbMonth);
            groupBox1.Location = new Point(19, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt oluşturma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(8, 49);
            label1.Name = "label1";
            label1.Size = new Size(40, 24);
            label1.TabIndex = 22;
            label1.Text = "Yıl :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(8, 18);
            label6.Name = "label6";
            label6.Size = new Size(37, 24);
            label6.TabIndex = 21;
            label6.Text = "Ay:";
            // 
            // btnGetByDate
            // 
            btnGetByDate.Location = new Point(209, 31);
            btnGetByDate.Margin = new Padding(3, 2, 3, 2);
            btnGetByDate.Name = "btnGetByDate";
            btnGetByDate.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnGetByDate.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnGetByDate.OverrideDefault.Back.ColorAngle = 45F;
            btnGetByDate.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnGetByDate.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnGetByDate.OverrideDefault.Border.ColorAngle = 45F;
            btnGetByDate.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGetByDate.OverrideDefault.Border.Rounding = 17F;
            btnGetByDate.OverrideDefault.Border.Width = 2;
            btnGetByDate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGetByDate.Size = new Size(154, 28);
            btnGetByDate.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnGetByDate.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnGetByDate.StateCommon.Back.ColorAngle = 45F;
            btnGetByDate.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnGetByDate.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnGetByDate.StateCommon.Border.ColorAngle = 45F;
            btnGetByDate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGetByDate.StateCommon.Border.Rounding = 17F;
            btnGetByDate.StateCommon.Border.Width = 2;
            btnGetByDate.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGetByDate.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGetByDate.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetByDate.StateDisabled.Border.Width = 2;
            btnGetByDate.StateNormal.Border.Width = 2;
            btnGetByDate.StatePressed.Back.Color1 = Color.FromArgb(181, 132, 68);
            btnGetByDate.StatePressed.Back.Color2 = Color.FromArgb(147, 108, 57);
            btnGetByDate.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnGetByDate.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnGetByDate.StatePressed.Border.Rounding = 17F;
            btnGetByDate.StatePressed.Border.Width = 2;
            btnGetByDate.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnGetByDate.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnGetByDate.StateTracking.Back.ColorAngle = 45F;
            btnGetByDate.StateTracking.Border.ColorAngle = 45F;
            btnGetByDate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGetByDate.StateTracking.Border.Rounding = 17F;
            btnGetByDate.StateTracking.Border.Width = 2;
            btnGetByDate.TabIndex = 15;
            btnGetByDate.Values.DropDownArrowColor = Color.Empty;
            btnGetByDate.Values.Text = "Tümünü Listele";
            btnGetByDate.Click += btnGetByDate_Click;
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(67, 49);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(112, 23);
            cmbYear.TabIndex = 0;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(67, 18);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(112, 23);
            cmbMonth.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPersonelTc);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnPay);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(cmbDepartments);
            groupBox2.Controls.Add(dgwEmployees);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(22, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 329);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödeme Durumu Görüntüleme";
            // 
            // lblPersonelTc
            // 
            lblPersonelTc.AutoSize = true;
            lblPersonelTc.BackColor = Color.White;
            lblPersonelTc.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPersonelTc.ForeColor = Color.FromArgb(64, 64, 64);
            lblPersonelTc.Location = new Point(21, 235);
            lblPersonelTc.Name = "lblPersonelTc";
            lblPersonelTc.Size = new Size(194, 24);
            lblPersonelTc.TabIndex = 21;
            lblPersonelTc.Text = "TC veya Personel No ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SeaShell;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(5, 22);
            label5.Name = "label5";
            label5.Size = new Size(127, 24);
            label5.TabIndex = 20;
            label5.Text = "Departmanlar:";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(182, 280);
            btnPay.Margin = new Padding(3, 2, 3, 2);
            btnPay.Name = "btnPay";
            btnPay.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnPay.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnPay.OverrideDefault.Back.ColorAngle = 45F;
            btnPay.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnPay.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnPay.OverrideDefault.Border.ColorAngle = 45F;
            btnPay.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPay.OverrideDefault.Border.Rounding = 17F;
            btnPay.OverrideDefault.Border.Width = 2;
            btnPay.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnPay.Size = new Size(200, 32);
            btnPay.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnPay.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnPay.StateCommon.Back.ColorAngle = 45F;
            btnPay.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnPay.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnPay.StateCommon.Border.ColorAngle = 45F;
            btnPay.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPay.StateCommon.Border.Rounding = 17F;
            btnPay.StateCommon.Border.Width = 2;
            btnPay.StateCommon.Content.ShortText.Color1 = Color.White;
            btnPay.StateCommon.Content.ShortText.Color2 = Color.White;
            btnPay.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.StateDisabled.Border.Width = 2;
            btnPay.StateNormal.Border.Width = 2;
            btnPay.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            btnPay.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            btnPay.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            btnPay.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            btnPay.StatePressed.Border.Rounding = 17F;
            btnPay.StatePressed.Border.Width = 2;
            btnPay.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnPay.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnPay.StateTracking.Back.ColorAngle = 45F;
            btnPay.StateTracking.Border.ColorAngle = 45F;
            btnPay.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPay.StateTracking.Border.Rounding = 17F;
            btnPay.StateTracking.Border.Width = 2;
            btnPay.TabIndex = 19;
            btnPay.Values.DropDownArrowColor = Color.Empty;
            btnPay.Values.Text = "Ödeme Tamamlandı";
            btnPay.Click += btnPay_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(153, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(229, 25);
            txtSearch.StateCommon.Back.Color1 = Color.White;
            txtSearch.StateCommon.Border.Color1 = Color.FromArgb(141, 182, 252);
            txtSearch.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtSearch.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearch.StateCommon.Border.Rounding = 8F;
            txtSearch.StateCommon.Content.Color1 = Color.DimGray;
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbDepartments
            // 
            cmbDepartments.DropDownWidth = 121;
            cmbDepartments.IntegralHeight = false;
            cmbDepartments.Location = new Point(154, 21);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(228, 28);
            cmbDepartments.StateCommon.ComboBox.Border.Rounding = 8F;
            cmbDepartments.StateCommon.ComboBox.Border.Width = 1;
            cmbDepartments.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbDepartments.TabIndex = 17;
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            // 
            // dgwEmployees
            // 
            dgwEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployees.Columns.AddRange(new DataGridViewColumn[] { Departman, Tc, AdSoyad, Odeme });
            dgwEmployees.Location = new Point(21, 101);
            dgwEmployees.Name = "dgwEmployees";
            dgwEmployees.RowHeadersWidth = 51;
            dgwEmployees.Size = new Size(361, 110);
            dgwEmployees.TabIndex = 7;
            dgwEmployees.CellClick += dgwEmployees_CellClick;
            // 
            // Departman
            // 
            Departman.HeaderText = "Departman";
            Departman.MinimumWidth = 6;
            Departman.Name = "Departman";
            Departman.Width = 125;
            // 
            // Tc
            // 
            Tc.HeaderText = "Tc";
            Tc.MinimumWidth = 6;
            Tc.Name = "Tc";
            Tc.Width = 125;
            // 
            // AdSoyad
            // 
            AdSoyad.HeaderText = "Ad Soyad";
            AdSoyad.MinimumWidth = 6;
            AdSoyad.Name = "AdSoyad";
            AdSoyad.Width = 125;
            // 
            // Odeme
            // 
            Odeme.HeaderText = "Ödeme";
            Odeme.MinimumWidth = 6;
            Odeme.Name = "Odeme";
            Odeme.Width = 125;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(48, 60);
            label4.Name = "label4";
            label4.Size = new Size(27, 23);
            label4.TabIndex = 3;
            label4.Text = "🔍";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 28);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnTazminatAtama);
            groupBox3.Controls.Add(btnTazminatOdeme);
            groupBox3.Controls.Add(lstTazminatControl);
            groupBox3.Controls.Add(lblTazminat);
            groupBox3.Location = new Point(442, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(312, 392);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tazminat Ödeme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(16, 160);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 22;
            label2.Text = "Tazminat:";
            // 
            // btnTazminatAtama
            // 
            btnTazminatAtama.Location = new Point(158, 160);
            btnTazminatAtama.Margin = new Padding(3, 2, 3, 2);
            btnTazminatAtama.Name = "btnTazminatAtama";
            btnTazminatAtama.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnTazminatAtama.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnTazminatAtama.OverrideDefault.Back.ColorAngle = 45F;
            btnTazminatAtama.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnTazminatAtama.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnTazminatAtama.OverrideDefault.Border.ColorAngle = 45F;
            btnTazminatAtama.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTazminatAtama.OverrideDefault.Border.Rounding = 17F;
            btnTazminatAtama.OverrideDefault.Border.Width = 2;
            btnTazminatAtama.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTazminatAtama.Size = new Size(133, 34);
            btnTazminatAtama.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnTazminatAtama.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnTazminatAtama.StateCommon.Back.ColorAngle = 45F;
            btnTazminatAtama.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnTazminatAtama.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnTazminatAtama.StateCommon.Border.ColorAngle = 45F;
            btnTazminatAtama.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTazminatAtama.StateCommon.Border.Rounding = 17F;
            btnTazminatAtama.StateCommon.Border.Width = 2;
            btnTazminatAtama.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTazminatAtama.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTazminatAtama.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTazminatAtama.StateDisabled.Border.Width = 2;
            btnTazminatAtama.StateNormal.Border.Width = 2;
            btnTazminatAtama.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            btnTazminatAtama.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            btnTazminatAtama.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            btnTazminatAtama.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            btnTazminatAtama.StatePressed.Border.Rounding = 17F;
            btnTazminatAtama.StatePressed.Border.Width = 2;
            btnTazminatAtama.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnTazminatAtama.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnTazminatAtama.StateTracking.Back.ColorAngle = 45F;
            btnTazminatAtama.StateTracking.Border.ColorAngle = 45F;
            btnTazminatAtama.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTazminatAtama.StateTracking.Border.Rounding = 17F;
            btnTazminatAtama.StateTracking.Border.Width = 2;
            btnTazminatAtama.TabIndex = 21;
            btnTazminatAtama.Values.DropDownArrowColor = Color.Empty;
            btnTazminatAtama.Values.Text = "Tazminat Atama";
            btnTazminatAtama.Click += btnTazminatAtama_Click;
            // 
            // btnTazminatOdeme
            // 
            btnTazminatOdeme.Location = new Point(68, 307);
            btnTazminatOdeme.Margin = new Padding(3, 2, 3, 2);
            btnTazminatOdeme.Name = "btnTazminatOdeme";
            btnTazminatOdeme.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnTazminatOdeme.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnTazminatOdeme.OverrideDefault.Back.ColorAngle = 45F;
            btnTazminatOdeme.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnTazminatOdeme.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnTazminatOdeme.OverrideDefault.Border.ColorAngle = 45F;
            btnTazminatOdeme.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTazminatOdeme.OverrideDefault.Border.Rounding = 17F;
            btnTazminatOdeme.OverrideDefault.Border.Width = 2;
            btnTazminatOdeme.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTazminatOdeme.Size = new Size(200, 32);
            btnTazminatOdeme.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnTazminatOdeme.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnTazminatOdeme.StateCommon.Back.ColorAngle = 45F;
            btnTazminatOdeme.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnTazminatOdeme.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnTazminatOdeme.StateCommon.Border.ColorAngle = 45F;
            btnTazminatOdeme.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTazminatOdeme.StateCommon.Border.Rounding = 17F;
            btnTazminatOdeme.StateCommon.Border.Width = 2;
            btnTazminatOdeme.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTazminatOdeme.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTazminatOdeme.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTazminatOdeme.StateDisabled.Border.Width = 2;
            btnTazminatOdeme.StateNormal.Border.Width = 2;
            btnTazminatOdeme.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            btnTazminatOdeme.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            btnTazminatOdeme.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            btnTazminatOdeme.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            btnTazminatOdeme.StatePressed.Border.Rounding = 17F;
            btnTazminatOdeme.StatePressed.Border.Width = 2;
            btnTazminatOdeme.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnTazminatOdeme.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnTazminatOdeme.StateTracking.Back.ColorAngle = 45F;
            btnTazminatOdeme.StateTracking.Border.ColorAngle = 45F;
            btnTazminatOdeme.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTazminatOdeme.StateTracking.Border.Rounding = 17F;
            btnTazminatOdeme.StateTracking.Border.Width = 2;
            btnTazminatOdeme.TabIndex = 20;
            btnTazminatOdeme.Values.DropDownArrowColor = Color.Empty;
            btnTazminatOdeme.Values.Text = "Ödeme Tamamlandı";
            btnTazminatOdeme.Click += btnTazminatOdeme_Click;
            // 
            // lstTazminatControl
            // 
            lstTazminatControl.FormattingEnabled = true;
            lstTazminatControl.ItemHeight = 15;
            lstTazminatControl.Location = new Point(16, 21);
            lstTazminatControl.Name = "lstTazminatControl";
            lstTazminatControl.Size = new Size(290, 124);
            lstTazminatControl.TabIndex = 7;
            lstTazminatControl.SelectedIndexChanged += lstTazminatControl_SelectedIndexChanged;
            // 
            // lblTazminat
            // 
            lblTazminat.AutoSize = true;
            lblTazminat.Location = new Point(123, 167);
            lblTazminat.Name = "lblTazminat";
            lblTazminat.Size = new Size(28, 15);
            lblTazminat.TabIndex = 2;
            lblTazminat.Text = ".....₺";
            // 
            // CalisanMaasTakibi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CalisanMaasTakibi";
            Text = "CalisanMaasTakibi";
            Load += CalisanMaasTakibi_Load;
            Resize += CalisanMaasTakibi_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwEmployees).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbYear;
        private ComboBox cmbMonth;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private DataGridView dgwEmployees;
        private DataGridViewTextBoxColumn Departman;
        private DataGridViewTextBoxColumn Tc;
        private DataGridViewTextBoxColumn AdSoyad;
        private DataGridViewTextBoxColumn Odeme;
        private GroupBox groupBox3;
        private Label lblTazminat;
        private ListBox lstTazminatControl;
        
        private Krypton.Toolkit.KryptonComboBox cmbDepartments;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonButton btnGetByDate;
        private Krypton.Toolkit.KryptonButton btnPay;
        private Krypton.Toolkit.KryptonButton btnTazminatOdeme;
        private Krypton.Toolkit.KryptonButton btnTazminatAtama;
        private Label label5;
        private Label label1;
        private Label label6;
        private Label lblPersonelTc;
        private Label label2;
    }
}