namespace NtierArchitecture.UI.Formlar
{
	partial class MaasForm
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
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            btnPer = new Krypton.Toolkit.KryptonButton();
            txtmaskedTC = new MaskedTextBox();
            LstPersonelBilgileri = new ListBox();
            groupBox1 = new GroupBox();
            comboBox1 = new Krypton.Toolkit.KryptonComboBox();
            btnYenile = new Krypton.Toolkit.KryptonButton();
            tcmaskedbox = new MaskedTextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 34);
            textBox2.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnPer);
            groupBox2.Controls.Add(txtmaskedTC);
            groupBox2.Controls.Add(LstPersonelBilgileri);
            groupBox2.Location = new Point(611, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 438);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "PersonelBilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(19, 46);
            label3.Name = "label3";
            label3.Size = new Size(162, 29);
            label3.TabIndex = 16;
            label3.Text = "TC Kimlik No:";
            // 
            // btnPer
            // 
            btnPer.Location = new Point(234, 99);
            btnPer.Name = "btnPer";
            btnPer.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnPer.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnPer.OverrideDefault.Back.ColorAngle = 45F;
            btnPer.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnPer.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnPer.OverrideDefault.Border.ColorAngle = 45F;
            btnPer.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPer.OverrideDefault.Border.Rounding = 17F;
            btnPer.OverrideDefault.Border.Width = 2;
            btnPer.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnPer.Size = new Size(214, 43);
            btnPer.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnPer.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnPer.StateCommon.Back.ColorAngle = 45F;
            btnPer.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnPer.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnPer.StateCommon.Border.ColorAngle = 45F;
            btnPer.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPer.StateCommon.Border.Rounding = 17F;
            btnPer.StateCommon.Border.Width = 2;
            btnPer.StateCommon.Content.ShortText.Color1 = Color.White;
            btnPer.StateCommon.Content.ShortText.Color2 = Color.White;
            btnPer.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPer.StateDisabled.Border.Width = 2;
            btnPer.StateNormal.Border.Width = 2;
            btnPer.StatePressed.Back.Color1 = Color.FromArgb(181, 132, 68);
            btnPer.StatePressed.Back.Color2 = Color.FromArgb(147, 108, 57);
            btnPer.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnPer.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnPer.StatePressed.Border.Rounding = 17F;
            btnPer.StatePressed.Border.Width = 2;
            btnPer.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnPer.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnPer.StateTracking.Back.ColorAngle = 45F;
            btnPer.StateTracking.Border.ColorAngle = 45F;
            btnPer.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPer.StateTracking.Border.Rounding = 17F;
            btnPer.StateTracking.Border.Width = 2;
            btnPer.TabIndex = 15;
            btnPer.Values.DropDownArrowColor = Color.Empty;
            btnPer.Values.Text = "Personel Getir";
            btnPer.Click += btnPer_Click_1;
            // 
            // txtmaskedTC
            // 
            txtmaskedTC.Location = new Point(218, 41);
            txtmaskedTC.Mask = "00000000000";
            txtmaskedTC.Name = "txtmaskedTC";
            txtmaskedTC.Size = new Size(266, 34);
            txtmaskedTC.TabIndex = 13;
            txtmaskedTC.ValidatingType = typeof(int);
            // 
            // LstPersonelBilgileri
            // 
            LstPersonelBilgileri.FormattingEnabled = true;
            LstPersonelBilgileri.ItemHeight = 28;
            LstPersonelBilgileri.Location = new Point(19, 173);
            LstPersonelBilgileri.Name = "LstPersonelBilgileri";
            LstPersonelBilgileri.Size = new Size(465, 228);
            LstPersonelBilgileri.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnYenile);
            groupBox1.Controls.Add(tcmaskedbox);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 438);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Maaş İşlemleri ve Özlük";
            // 
            // comboBox1
            // 
            comboBox1.DropDownWidth = 121;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(252, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 26);
            comboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(289, 313);
            btnYenile.Name = "btnYenile";
            btnYenile.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnYenile.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnYenile.OverrideDefault.Back.ColorAngle = 45F;
            btnYenile.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnYenile.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnYenile.OverrideDefault.Border.ColorAngle = 45F;
            btnYenile.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnYenile.OverrideDefault.Border.Rounding = 17F;
            btnYenile.OverrideDefault.Border.Width = 2;
            btnYenile.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnYenile.Size = new Size(191, 43);
            btnYenile.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnYenile.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnYenile.StateCommon.Back.ColorAngle = 45F;
            btnYenile.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnYenile.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnYenile.StateCommon.Border.ColorAngle = 45F;
            btnYenile.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnYenile.StateCommon.Border.Rounding = 17F;
            btnYenile.StateCommon.Border.Width = 2;
            btnYenile.StateCommon.Content.ShortText.Color1 = Color.White;
            btnYenile.StateCommon.Content.ShortText.Color2 = Color.White;
            btnYenile.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYenile.StateDisabled.Border.Width = 2;
            btnYenile.StateNormal.Border.Width = 2;
            btnYenile.StatePressed.Back.Color1 = Color.FromArgb(237, 232, 97);
            btnYenile.StatePressed.Back.Color2 = Color.FromArgb(216, 208, 56);
            btnYenile.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnYenile.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnYenile.StatePressed.Border.Rounding = 17F;
            btnYenile.StatePressed.Border.Width = 2;
            btnYenile.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnYenile.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnYenile.StateTracking.Back.ColorAngle = 45F;
            btnYenile.StateTracking.Border.ColorAngle = 45F;
            btnYenile.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnYenile.StateTracking.Border.Rounding = 17F;
            btnYenile.StateTracking.Border.Width = 2;
            btnYenile.TabIndex = 15;
            btnYenile.Values.DropDownArrowColor = Color.Empty;
            btnYenile.Values.Text = "Güncelle";
            btnYenile.Click += btnYenile_Click_1;
            // 
            // tcmaskedbox
            // 
            tcmaskedbox.Location = new Point(252, 170);
            tcmaskedbox.Mask = "00000000000";
            tcmaskedbox.Name = "tcmaskedbox";
            tcmaskedbox.Size = new Size(228, 34);
            tcmaskedbox.TabIndex = 12;
            tcmaskedbox.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(27, 96);
            label5.Name = "label5";
            label5.Size = new Size(137, 29);
            label5.TabIndex = 21;
            label5.Text = "Departman:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(27, 175);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 22;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(27, 243);
            label2.Name = "label2";
            label2.Size = new Size(132, 29);
            label2.TabIndex = 23;
            label2.Text = "Yeni Maaş:";
            // 
            // MaasForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 645);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.DarkRed;
            Margin = new Padding(4);
            Name = "MaasForm";
            Text = "MaasForm";
            Load += MaasForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
		private GroupBox groupBox2;
		private ListBox LstPersonelBilgileri;
		private GroupBox groupBox1;
		private MaskedTextBox txtmaskedTC;
		private MaskedTextBox tcmaskedbox;
        private Krypton.Toolkit.KryptonButton btnYenile;
        private Krypton.Toolkit.KryptonComboBox comboBox1;
        private Krypton.Toolkit.KryptonButton btnPer;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label2;
    }
}