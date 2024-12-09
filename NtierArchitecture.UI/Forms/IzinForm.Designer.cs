namespace NtierArchitecture.UI.Formlar
{
	partial class IzinForm
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
            txtTc = new TextBox();
            btnCreateLeave = new Button();
            label4 = new Label();
            btnGetInfo = new Button();
            LstBilgi = new ListBox();
            label5 = new Label();
            txtLeaveDescription = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            lstLeaveList = new ListBox();
            label7 = new Label();
            btnLeaveCancel = new Button();
            btnLeaveUpdate = new Button();
            nmrLeaveDay = new NumericUpDown();
            lblDurum = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtEndDate = new DateTimePicker();
            label10 = new Label();
            dtStartDate = new DateTimePicker();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrLeaveDay).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 0;
            label1.Text = "İzin Devamsızlık Yönetimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "TC Giriniz";
            label2.Click += label2_Click;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(238, 73);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(234, 29);
            txtTc.TabIndex = 2;
            // 
            // btnCreateLeave
            // 
            btnCreateLeave.Location = new Point(52, 274);
            btnCreateLeave.Name = "btnCreateLeave";
            btnCreateLeave.Size = new Size(182, 46);
            btnCreateLeave.TabIndex = 3;
            btnCreateLeave.Text = "İzin Talep Et";
            btnCreateLeave.UseVisualStyleBackColor = true;
            btnCreateLeave.Click += btnCreateLeave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 294);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 5;
            label4.Text = "Çalışanın Bilgileri";
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(238, 171);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(142, 74);
            btnGetInfo.TabIndex = 6;
            btnGetInfo.Text = "Giriş Yap";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // LstBilgi
            // 
            LstBilgi.FormattingEnabled = true;
            LstBilgi.ItemHeight = 21;
            LstBilgi.Location = new Point(12, 318);
            LstBilgi.Name = "LstBilgi";
            LstBilgi.Size = new Size(507, 193);
            LstBilgi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 23);
            label5.Name = "label5";
            label5.Size = new Size(178, 21);
            label5.TabIndex = 8;
            label5.Text = "İzin Talebinizi Açıklayınız";
            // 
            // txtLeaveDescription
            // 
            txtLeaveDescription.Location = new Point(614, 80);
            txtLeaveDescription.Multiline = true;
            txtLeaveDescription.Name = "txtLeaveDescription";
            txtLeaveDescription.Size = new Size(521, 91);
            txtLeaveDescription.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 150);
            label6.Name = "label6";
            label6.Size = new Size(242, 21);
            label6.TabIndex = 10;
            label6.Text = "Talep Ettiğiniz gün sayısını Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 130);
            label3.Name = "label3";
            label3.Size = new Size(168, 21);
            label3.TabIndex = 12;
            label3.Text = "Tanımlı Şifrenizi Giriniz";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(238, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 29);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lstLeaveList
            // 
            lstLeaveList.FormattingEnabled = true;
            lstLeaveList.ItemHeight = 21;
            lstLeaveList.Location = new Point(52, 343);
            lstLeaveList.Name = "lstLeaveList";
            lstLeaveList.Size = new Size(521, 193);
            lstLeaveList.TabIndex = 14;
            lstLeaveList.SelectedIndexChanged += lstLeaveList_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 319);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 15;
            label7.Text = "Talep Detayları";
            // 
            // btnLeaveCancel
            // 
            btnLeaveCancel.Location = new Point(404, 274);
            btnLeaveCancel.Name = "btnLeaveCancel";
            btnLeaveCancel.Size = new Size(173, 46);
            btnLeaveCancel.TabIndex = 16;
            btnLeaveCancel.Text = "Talepi İptal Et";
            btnLeaveCancel.UseVisualStyleBackColor = true;
            btnLeaveCancel.Click += btnLeaveCancel_Click;
            // 
            // btnLeaveUpdate
            // 
            btnLeaveUpdate.Location = new Point(240, 274);
            btnLeaveUpdate.Name = "btnLeaveUpdate";
            btnLeaveUpdate.Size = new Size(154, 46);
            btnLeaveUpdate.TabIndex = 17;
            btnLeaveUpdate.Text = "Talebi Güncelle";
            btnLeaveUpdate.UseVisualStyleBackColor = true;
            btnLeaveUpdate.Click += btnLeaveUpdate_Click;
            // 
            // nmrLeaveDay
            // 
            nmrLeaveDay.Location = new Point(315, 148);
            nmrLeaveDay.Name = "nmrLeaveDay";
            nmrLeaveDay.Size = new Size(141, 29);
            nmrLeaveDay.TabIndex = 18;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(52, 539);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(137, 21);
            lblDurum.TabIndex = 19;
            lblDurum.Text = "İzin Onay Durumu";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 580);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çalışan Girişi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nmrLeaveDay);
            groupBox2.Controls.Add(dtEndDate);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtStartDate);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblDurum);
            groupBox2.Controls.Add(btnLeaveUpdate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnLeaveCancel);
            groupBox2.Controls.Add(lstLeaveList);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnCreateLeave);
            groupBox2.Location = new Point(562, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(583, 580);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "İzin Talebleri";
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(314, 226);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(200, 29);
            dtEndDate.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(207, 232);
            label10.Name = "label10";
            label10.Size = new Size(87, 21);
            label10.TabIndex = 22;
            label10.Text = "Bitiş Tarihi :";
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(315, 189);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(200, 29);
            dtStartDate.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(171, 191);
            label9.Name = "label9";
            label9.Size = new Size(123, 21);
            label9.TabIndex = 20;
            label9.Text = "Başlangıç Tarihi :";
            // 
            // IzinForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1175, 620);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtLeaveDescription);
            Controls.Add(LstBilgi);
            Controls.Add(btnGetInfo);
            Controls.Add(label4);
            Controls.Add(txtTc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 12F);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "IzinForm";
            Text = "IzinForm";
            Load += IzinForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrLeaveDay).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private TextBox txtTc;
		private Button btnCreateLeave;
		private Label label4;
		private Button btnGetInfo;
		private ListBox LstBilgi;
		private Label label5;
		private TextBox txtLeaveDescription;
		private Label label6;
        private Label label3;
        private TextBox txtPassword;
        private ListBox lstLeaveList;
        private Label label7;
        private Button btnLeaveCancel;
        private Button btnLeaveUpdate;
        private NumericUpDown nmrLeaveDay;
        private Label lblDurum;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label9;
        private DateTimePicker dtEndDate;
        private Label label10;
        private DateTimePicker dtStartDate;
    }
}