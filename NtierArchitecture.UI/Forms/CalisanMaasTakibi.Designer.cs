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
            btnGetByDate = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbYear = new ComboBox();
            cmbMonth = new ComboBox();
            groupBox2 = new GroupBox();
            dgwEmployees = new DataGridView();
            Departman = new DataGridViewTextBoxColumn();
            Tc = new DataGridViewTextBoxColumn();
            AdSoyad = new DataGridViewTextBoxColumn();
            Odeme = new DataGridViewTextBoxColumn();
            label6 = new Label();
            btnPay = new Button();
            lblPersonelTc = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            cmbDepartments = new ComboBox();
            groupBox3 = new GroupBox();
            btnTazminatOdeme = new Button();
            lstTazminatControl = new ListBox();
            btnTazminatAtama = new Button();
            label9 = new Label();
            lblTazminat = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwEmployees).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetByDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(cmbMonth);
            groupBox1.Location = new Point(19, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt oluşturma";
            // 
            // btnGetByDate
            // 
            btnGetByDate.BackColor = Color.Silver;
            btnGetByDate.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGetByDate.ForeColor = SystemColors.ActiveCaptionText;
            btnGetByDate.Location = new Point(248, 20);
            btnGetByDate.Name = "btnGetByDate";
            btnGetByDate.Size = new Size(104, 63);
            btnGetByDate.TabIndex = 2;
            btnGetByDate.Text = "Tüm Çalışanları Getir";
            btnGetByDate.UseVisualStyleBackColor = false;
            btnGetByDate.Click += btnGetByDate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Yıl seçiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Ay seçiniz";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(98, 49);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(121, 23);
            cmbYear.TabIndex = 0;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(98, 20);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(121, 23);
            cmbMonth.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwEmployees);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnPay);
            groupBox2.Controls.Add(lblPersonelTc);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbDepartments);
            groupBox2.Location = new Point(22, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 300);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödeme Durumu Görüntüleme";
            // 
            // dgwEmployees
            // 
            dgwEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployees.Columns.AddRange(new DataGridViewColumn[] { Departman, Tc, AdSoyad, Odeme });
            dgwEmployees.Location = new Point(32, 84);
            dgwEmployees.Name = "dgwEmployees";
            dgwEmployees.Size = new Size(317, 110);
            dgwEmployees.TabIndex = 7;
            dgwEmployees.CellClick += dgwEmployees_CellClick;
            // 
            // Departman
            // 
            Departman.HeaderText = "Departman";
            Departman.Name = "Departman";
            // 
            // Tc
            // 
            Tc.HeaderText = "Tc";
            Tc.Name = "Tc";
            // 
            // AdSoyad
            // 
            AdSoyad.HeaderText = "Ad Soyad";
            AdSoyad.Name = "AdSoyad";
            // 
            // Odeme
            // 
            Odeme.HeaderText = "Ödeme";
            Odeme.Name = "Odeme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 31);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 1;
            label6.Text = "Departmanlar";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Silver;
            btnPay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPay.Location = new Point(192, 217);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(145, 44);
            btnPay.TabIndex = 6;
            btnPay.Text = "Ödeme tamamlandı";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblPersonelTc
            // 
            lblPersonelTc.Location = new Point(43, 224);
            lblPersonelTc.Name = "lblPersonelTc";
            lblPersonelTc.Size = new Size(120, 37);
            lblPersonelTc.TabIndex = 5;
            lblPersonelTc.Text = "Tc veya personel no";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(32, 55);
            label4.Name = "label4";
            label4.Size = new Size(27, 23);
            label4.TabIndex = 3;
            label4.Text = "🔍";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(88, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(261, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 28);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 1;
            // 
            // cmbDepartments
            // 
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Location = new Point(88, 28);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(261, 23);
            cmbDepartments.TabIndex = 0;
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTazminatOdeme);
            groupBox3.Controls.Add(lstTazminatControl);
            groupBox3.Controls.Add(btnTazminatAtama);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lblTazminat);
            groupBox3.Location = new Point(427, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 392);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tazminat Ödeme";
            // 
            // btnTazminatOdeme
            // 
            btnTazminatOdeme.BackColor = Color.Silver;
            btnTazminatOdeme.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTazminatOdeme.Location = new Point(64, 265);
            btnTazminatOdeme.Name = "btnTazminatOdeme";
            btnTazminatOdeme.Size = new Size(169, 44);
            btnTazminatOdeme.TabIndex = 8;
            btnTazminatOdeme.Text = "Ödeme Tamamlandı";
            btnTazminatOdeme.UseVisualStyleBackColor = false;
            btnTazminatOdeme.Click += btnTazminatOdeme_Click;
            // 
            // lstTazminatControl
            // 
            lstTazminatControl.FormattingEnabled = true;
            lstTazminatControl.ItemHeight = 15;
            lstTazminatControl.Location = new Point(19, 39);
            lstTazminatControl.Name = "lstTazminatControl";
            lstTazminatControl.Size = new Size(286, 109);
            lstTazminatControl.TabIndex = 7;
            lstTazminatControl.SelectedIndexChanged += lstTazminatControl_SelectedIndexChanged;
            // 
            // btnTazminatAtama
            // 
            btnTazminatAtama.AutoSize = true;
            btnTazminatAtama.BackColor = Color.Honeydew;
            btnTazminatAtama.Location = new Point(200, 176);
            btnTazminatAtama.Name = "btnTazminatAtama";
            btnTazminatAtama.Size = new Size(105, 31);
            btnTazminatAtama.TabIndex = 4;
            btnTazminatAtama.Text = "Tazminat Ata";
            btnTazminatAtama.UseVisualStyleBackColor = false;
            btnTazminatAtama.Click += btnTazminatAtama_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 184);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 3;
            label9.Text = "Tazminat";
            // 
            // lblTazminat
            // 
            lblTazminat.AutoSize = true;
            lblTazminat.Location = new Point(90, 184);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwEmployees).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGetByDate;
        private Label label2;
        private Label label1;
        private ComboBox cmbYear;
        private ComboBox cmbMonth;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtSearch;
        private Label label3;
        private ComboBox cmbDepartments;
        private Button btnPay;
        private Label lblPersonelTc;
        private DataGridView dgwEmployees;
        private DataGridViewTextBoxColumn Departman;
        private DataGridViewTextBoxColumn Tc;
        private DataGridViewTextBoxColumn AdSoyad;
        private DataGridViewTextBoxColumn Odeme;
        private Label label6;
        private GroupBox groupBox3;
        private Label label9;
        private Label lblTazminat;
        private Button btnTazminatAtama;
        private ListBox lstTazminatControl;
        private Button btnTazminatOdeme;
    }
}