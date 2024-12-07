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
			label4 = new Label();
			label2 = new Label();
			label5 = new Label();
			comboBox1 = new ComboBox();
			btnYenile = new Button();
			textBox2 = new TextBox();
			btnPer = new Button();
			groupBox2 = new GroupBox();
			txtmaskedTC = new MaskedTextBox();
			LstPersonelBilgileri = new ListBox();
			groupBox1 = new GroupBox();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(18, 247);
			label4.Name = "label4";
			label4.Size = new Size(196, 32);
			label4.TabIndex = 3;
			label4.Text = "Yeni Maaş Atama";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 99);
			label2.Name = "label2";
			label2.Size = new Size(214, 32);
			label2.TabIndex = 1;
			label2.Text = "Departman Seçiniz";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(49, 48);
			label5.Name = "label5";
			label5.Size = new Size(115, 32);
			label5.TabIndex = 4;
			label5.Text = "TC Giriniz";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(252, 96);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(256, 40);
			comboBox1.TabIndex = 7;
			// 
			// btnYenile
			// 
			btnYenile.Location = new Point(168, 332);
			btnYenile.Name = "btnYenile";
			btnYenile.Size = new Size(181, 55);
			btnYenile.TabIndex = 10;
			btnYenile.Text = "Güncelle";
			btnYenile.UseVisualStyleBackColor = true;
			btnYenile.Click += btnYenile_Click_1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(252, 240);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(256, 39);
			textBox2.TabIndex = 9;
			// 
			// btnPer
			// 
			btnPer.Location = new Point(156, 99);
			btnPer.Name = "btnPer";
			btnPer.Size = new Size(211, 51);
			btnPer.TabIndex = 11;
			btnPer.Text = "Personel getir";
			btnPer.UseVisualStyleBackColor = true;
			btnPer.Click += btnPer_Click_1;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(txtmaskedTC);
			groupBox2.Controls.Add(LstPersonelBilgileri);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(btnPer);
			groupBox2.Location = new Point(611, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(505, 585);
			groupBox2.TabIndex = 15;
			groupBox2.TabStop = false;
			groupBox2.Text = "PersonelBilgileri";
			// 
			// txtmaskedTC
			// 
			txtmaskedTC.Location = new Point(186, 41);
			txtmaskedTC.Mask = "00000000000";
			txtmaskedTC.Name = "txtmaskedTC";
			txtmaskedTC.Size = new Size(298, 39);
			txtmaskedTC.TabIndex = 13;
			txtmaskedTC.ValidatingType = typeof(int);
			// 
			// LstPersonelBilgileri
			// 
			LstPersonelBilgileri.FormattingEnabled = true;
			LstPersonelBilgileri.ItemHeight = 32;
			LstPersonelBilgileri.Location = new Point(19, 173);
			LstPersonelBilgileri.Name = "LstPersonelBilgileri";
			LstPersonelBilgileri.Size = new Size(465, 388);
			LstPersonelBilgileri.TabIndex = 12;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnYenile);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(547, 585);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			groupBox1.Text = "Maaş İşlemleri ve Özlük";
			// 
			// MaasForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 192);
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
			ResumeLayout(false);
		}

		#endregion

		private Label label4;
		private Label label2;
		private Label label5;
		private ComboBox comboBox1;
		private Button btnYenile;
		private TextBox textBox2;
		private Button btnPer;
		private GroupBox groupBox2;
		private ListBox LstPersonelBilgileri;
		private GroupBox groupBox1;
		private MaskedTextBox txtmaskedTC;
	}
}