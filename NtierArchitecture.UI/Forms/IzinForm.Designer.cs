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
            txtTc = new TextBox();
            LstBilgi = new ListBox();
            label5 = new Label();
            txtLeaveDescription = new TextBox();
            txtPassword = new TextBox();
            lstLeaveList = new ListBox();
            nmrLeaveDay = new NumericUpDown();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnGetInfo = new Krypton.Toolkit.KryptonButton();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label7 = new Label();
            label11 = new Label();
            btnLeaveCancel = new Krypton.Toolkit.KryptonButton();
            btnCreateLeave = new Krypton.Toolkit.KryptonButton();
            btnLeaveUpdate = new Krypton.Toolkit.KryptonButton();
            lblDurum = new Label();
            label6 = new Label();
            dtEndDate = new DateTimePicker();
            dtStartDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nmrLeaveDay).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "İzin Devamsızlık Yönetimi";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(282, 40);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(234, 34);
            txtTc.TabIndex = 2;
            // 
            // LstBilgi
            // 
            LstBilgi.FormattingEnabled = true;
            LstBilgi.ItemHeight = 28;
            LstBilgi.Location = new Point(12, 346);
            LstBilgi.Name = "LstBilgi";
            LstBilgi.Size = new Size(507, 144);
            LstBilgi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 23);
            label5.Name = "label5";
            label5.Size = new Size(224, 28);
            label5.TabIndex = 8;
            label5.Text = "İzin Talebinizi Açıklayınız";
            // 
            // txtLeaveDescription
            // 
            txtLeaveDescription.Location = new Point(52, 54);
            txtLeaveDescription.Multiline = true;
            txtLeaveDescription.Name = "txtLeaveDescription";
            txtLeaveDescription.Size = new Size(521, 59);
            txtLeaveDescription.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(282, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 34);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lstLeaveList
            // 
            lstLeaveList.FormattingEnabled = true;
            lstLeaveList.ItemHeight = 28;
            lstLeaveList.Location = new Point(52, 399);
            lstLeaveList.Name = "lstLeaveList";
            lstLeaveList.Size = new Size(521, 116);
            lstLeaveList.TabIndex = 14;
            lstLeaveList.SelectedIndexChanged += lstLeaveList_SelectedIndexChanged;
            // 
            // nmrLeaveDay
            // 
            nmrLeaveDay.Location = new Point(345, 141);
            nmrLeaveDay.Name = "nmrLeaveDay";
            nmrLeaveDay.Size = new Size(141, 34);
            nmrLeaveDay.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Controls.Add(btnGetInfo);
            groupBox1.Location = new Point(3, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 580);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çalışan Girişi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(20, 264);
            label8.Name = "label8";
            label8.Size = new Size(171, 29);
            label8.TabIndex = 18;
            label8.Text = "Çalışan Bilgisi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(20, 97);
            label3.Name = "label3";
            label3.Size = new Size(265, 29);
            label3.TabIndex = 17;
            label3.Text = "Tanımlı Şifrenizi Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 45);
            label2.Name = "label2";
            label2.Size = new Size(162, 29);
            label2.TabIndex = 16;
            label2.Text = "TC Kimlik No:";
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(272, 172);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnGetInfo.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnGetInfo.OverrideDefault.Back.ColorAngle = 45F;
            btnGetInfo.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnGetInfo.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnGetInfo.OverrideDefault.Border.ColorAngle = 45F;
            btnGetInfo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGetInfo.OverrideDefault.Border.Rounding = 17F;
            btnGetInfo.OverrideDefault.Border.Width = 2;
            btnGetInfo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGetInfo.Size = new Size(158, 47);
            btnGetInfo.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnGetInfo.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnGetInfo.StateCommon.Back.ColorAngle = 45F;
            btnGetInfo.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnGetInfo.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnGetInfo.StateCommon.Border.ColorAngle = 45F;
            btnGetInfo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGetInfo.StateCommon.Border.Rounding = 17F;
            btnGetInfo.StateCommon.Border.Width = 2;
            btnGetInfo.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGetInfo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGetInfo.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetInfo.StateDisabled.Border.Width = 2;
            btnGetInfo.StateNormal.Border.Width = 2;
            btnGetInfo.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            btnGetInfo.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            btnGetInfo.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            btnGetInfo.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            btnGetInfo.StatePressed.Border.Rounding = 17F;
            btnGetInfo.StatePressed.Border.Width = 2;
            btnGetInfo.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnGetInfo.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnGetInfo.StateTracking.Back.ColorAngle = 45F;
            btnGetInfo.StateTracking.Border.ColorAngle = 45F;
            btnGetInfo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGetInfo.StateTracking.Border.Rounding = 17F;
            btnGetInfo.StateTracking.Border.Width = 2;
            btnGetInfo.TabIndex = 15;
            btnGetInfo.Values.DropDownArrowColor = Color.Empty;
            btnGetInfo.Values.Text = "Giriş Yapınız";
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnLeaveCancel);
            groupBox2.Controls.Add(btnCreateLeave);
            groupBox2.Controls.Add(btnLeaveUpdate);
            groupBox2.Controls.Add(lblDurum);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtLeaveDescription);
            groupBox2.Controls.Add(nmrLeaveDay);
            groupBox2.Controls.Add(dtEndDate);
            groupBox2.Controls.Add(dtStartDate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lstLeaveList);
            groupBox2.Location = new Point(562, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(583, 580);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "İzin Talebleri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(116, 226);
            label9.Name = "label9";
            label9.Size = new Size(133, 29);
            label9.TabIndex = 30;
            label9.Text = "Bitiş Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(116, 189);
            label7.Name = "label7";
            label7.Size = new Size(192, 29);
            label7.TabIndex = 30;
            label7.Text = "Başlangıç Tarihi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(227, 351);
            label11.Name = "label11";
            label11.Size = new Size(176, 29);
            label11.TabIndex = 29;
            label11.Text = "Talep Detayları";
            // 
            // btnLeaveCancel
            // 
            btnLeaveCancel.Location = new Point(400, 277);
            btnLeaveCancel.Name = "btnLeaveCancel";
            btnLeaveCancel.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnLeaveCancel.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnLeaveCancel.OverrideDefault.Back.ColorAngle = 45F;
            btnLeaveCancel.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnLeaveCancel.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnLeaveCancel.OverrideDefault.Border.ColorAngle = 45F;
            btnLeaveCancel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLeaveCancel.OverrideDefault.Border.Rounding = 17F;
            btnLeaveCancel.OverrideDefault.Border.Width = 2;
            btnLeaveCancel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLeaveCancel.Size = new Size(173, 45);
            btnLeaveCancel.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnLeaveCancel.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnLeaveCancel.StateCommon.Back.ColorAngle = 45F;
            btnLeaveCancel.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnLeaveCancel.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnLeaveCancel.StateCommon.Border.ColorAngle = 45F;
            btnLeaveCancel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLeaveCancel.StateCommon.Border.Rounding = 15F;
            btnLeaveCancel.StateCommon.Border.Width = 2;
            btnLeaveCancel.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLeaveCancel.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLeaveCancel.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaveCancel.StateDisabled.Border.Width = 2;
            btnLeaveCancel.StateNormal.Border.Width = 2;
            btnLeaveCancel.StatePressed.Back.Color1 = Color.Brown;
            btnLeaveCancel.StatePressed.Back.Color2 = Color.Firebrick;
            btnLeaveCancel.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnLeaveCancel.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnLeaveCancel.StatePressed.Border.Rounding = 15F;
            btnLeaveCancel.StatePressed.Border.Width = 2;
            btnLeaveCancel.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnLeaveCancel.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnLeaveCancel.StateTracking.Back.ColorAngle = 45F;
            btnLeaveCancel.StateTracking.Border.ColorAngle = 45F;
            btnLeaveCancel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLeaveCancel.StateTracking.Border.Rounding = 17F;
            btnLeaveCancel.StateTracking.Border.Width = 2;
            btnLeaveCancel.TabIndex = 28;
            btnLeaveCancel.Values.DropDownArrowColor = Color.Empty;
            btnLeaveCancel.Values.Text = "Talebi İptal Et";
            btnLeaveCancel.Click += btnLeaveCancel_Click;
            // 
            // btnCreateLeave
            // 
            btnCreateLeave.Location = new Point(28, 277);
            btnCreateLeave.Name = "btnCreateLeave";
            btnCreateLeave.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnCreateLeave.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnCreateLeave.OverrideDefault.Back.ColorAngle = 45F;
            btnCreateLeave.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnCreateLeave.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnCreateLeave.OverrideDefault.Border.ColorAngle = 45F;
            btnCreateLeave.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCreateLeave.OverrideDefault.Border.Rounding = 17F;
            btnCreateLeave.OverrideDefault.Border.Width = 2;
            btnCreateLeave.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCreateLeave.Size = new Size(163, 43);
            btnCreateLeave.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnCreateLeave.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnCreateLeave.StateCommon.Back.ColorAngle = 45F;
            btnCreateLeave.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnCreateLeave.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnCreateLeave.StateCommon.Border.ColorAngle = 45F;
            btnCreateLeave.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCreateLeave.StateCommon.Border.Rounding = 17F;
            btnCreateLeave.StateCommon.Border.Width = 2;
            btnCreateLeave.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCreateLeave.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCreateLeave.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateLeave.StateDisabled.Border.Width = 2;
            btnCreateLeave.StateNormal.Border.Width = 2;
            btnCreateLeave.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            btnCreateLeave.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            btnCreateLeave.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            btnCreateLeave.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            btnCreateLeave.StatePressed.Border.Rounding = 17F;
            btnCreateLeave.StatePressed.Border.Width = 2;
            btnCreateLeave.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnCreateLeave.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnCreateLeave.StateTracking.Back.ColorAngle = 45F;
            btnCreateLeave.StateTracking.Border.ColorAngle = 45F;
            btnCreateLeave.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCreateLeave.StateTracking.Border.Rounding = 17F;
            btnCreateLeave.StateTracking.Border.Width = 2;
            btnCreateLeave.TabIndex = 27;
            btnCreateLeave.Values.DropDownArrowColor = Color.Empty;
            btnCreateLeave.Values.Text = "Talebi Ekle";
            btnCreateLeave.Click += btnCreateLeave_Click;
            // 
            // btnLeaveUpdate
            // 
            btnLeaveUpdate.Location = new Point(207, 277);
            btnLeaveUpdate.Name = "btnLeaveUpdate";
            btnLeaveUpdate.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnLeaveUpdate.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnLeaveUpdate.OverrideDefault.Back.ColorAngle = 45F;
            btnLeaveUpdate.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnLeaveUpdate.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnLeaveUpdate.OverrideDefault.Border.ColorAngle = 45F;
            btnLeaveUpdate.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLeaveUpdate.OverrideDefault.Border.Rounding = 17F;
            btnLeaveUpdate.OverrideDefault.Border.Width = 2;
            btnLeaveUpdate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLeaveUpdate.Size = new Size(182, 43);
            btnLeaveUpdate.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnLeaveUpdate.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnLeaveUpdate.StateCommon.Back.ColorAngle = 45F;
            btnLeaveUpdate.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnLeaveUpdate.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnLeaveUpdate.StateCommon.Border.ColorAngle = 45F;
            btnLeaveUpdate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLeaveUpdate.StateCommon.Border.Rounding = 17F;
            btnLeaveUpdate.StateCommon.Border.Width = 2;
            btnLeaveUpdate.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLeaveUpdate.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLeaveUpdate.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaveUpdate.StateDisabled.Border.Width = 2;
            btnLeaveUpdate.StateNormal.Border.Width = 2;
            btnLeaveUpdate.StatePressed.Back.Color1 = Color.FromArgb(237, 232, 97);
            btnLeaveUpdate.StatePressed.Back.Color2 = Color.FromArgb(216, 208, 56);
            btnLeaveUpdate.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnLeaveUpdate.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnLeaveUpdate.StatePressed.Border.Rounding = 17F;
            btnLeaveUpdate.StatePressed.Border.Width = 2;
            btnLeaveUpdate.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnLeaveUpdate.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnLeaveUpdate.StateTracking.Back.ColorAngle = 45F;
            btnLeaveUpdate.StateTracking.Border.ColorAngle = 45F;
            btnLeaveUpdate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLeaveUpdate.StateTracking.Border.Rounding = 17F;
            btnLeaveUpdate.StateTracking.Border.Width = 2;
            btnLeaveUpdate.TabIndex = 26;
            btnLeaveUpdate.Values.DropDownArrowColor = Color.Empty;
            btnLeaveUpdate.Values.Text = "Talebi Güncelle";
            btnLeaveUpdate.Click += btnLeaveUpdate_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.BackColor = Color.White;
            lblDurum.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDurum.ForeColor = Color.FromArgb(64, 64, 64);
            lblDurum.Location = new Point(52, 539);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(207, 29);
            lblDurum.TabIndex = 25;
            lblDurum.Text = "izin Onay Durumu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(52, 146);
            label6.Name = "label6";
            label6.Size = new Size(277, 29);
            label6.TabIndex = 24;
            label6.Text = "Talep Edilen Gün Sayısı:";
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(314, 226);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(263, 34);
            dtEndDate.TabIndex = 23;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(315, 189);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(262, 34);
            dtStartDate.TabIndex = 21;
            // 
            // IzinForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1175, 771);
            Controls.Add(LstBilgi);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TextBox txtTc;
		private ListBox LstBilgi;
		private Label label5;
		private TextBox txtLeaveDescription;
        private TextBox txtPassword;
        private ListBox lstLeaveList;
        private NumericUpDown nmrLeaveDay;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtEndDate;
        private DateTimePicker dtStartDate;
        private Krypton.Toolkit.KryptonButton btnGetInfo;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label lblDurum;
        private Label label6;
        private Krypton.Toolkit.KryptonButton btnLeaveUpdate;
        private Krypton.Toolkit.KryptonButton btnCreateLeave;
        private Label label11;
        private Krypton.Toolkit.KryptonButton btnLeaveCancel;
        private Label label9;
        private Label label7;
    }
}