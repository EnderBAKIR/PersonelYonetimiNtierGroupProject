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
			textBox1 = new TextBox();
			button1 = new Button();
			label3 = new Label();
			label4 = new Label();
			button2 = new Button();
			LstBilgi = new ListBox();
			label5 = new Label();
			textBox2 = new TextBox();
			label6 = new Label();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.Red;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(284, 32);
			label1.TabIndex = 0;
			label1.Text = "İzin Devamsızlık Yönetimi";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 80);
			label2.Name = "label2";
			label2.Size = new Size(189, 32);
			label2.TabIndex = 1;
			label2.Text = "Ad Soyad Giriniz";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(227, 73);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(234, 39);
			textBox1.TabIndex = 2;
			// 
			// button1
			// 
			button1.Location = new Point(767, 372);
			button1.Name = "button1";
			button1.Size = new Size(270, 62);
			button1.TabIndex = 3;
			button1.Text = "İzin Talep Et";
			button1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 155);
			label3.Name = "label3";
			label3.Size = new Size(520, 32);
			label3.TabIndex = 4;
			label3.Text = "Personelin işe devam etmektedir/Etmemektedir";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 252);
			label4.Name = "label4";
			label4.Size = new Size(195, 32);
			label4.TabIndex = 5;
			label4.Text = "Çalışanın Bilgileri";
			// 
			// button2
			// 
			button2.Location = new Point(238, 231);
			button2.Name = "button2";
			button2.Size = new Size(142, 74);
			button2.TabIndex = 6;
			button2.Text = "Bilgileri Getir";
			button2.UseVisualStyleBackColor = true;
			// 
			// LstBilgi
			// 
			LstBilgi.FormattingEnabled = true;
			LstBilgi.ItemHeight = 32;
			LstBilgi.Location = new Point(12, 323);
			LstBilgi.Name = "LstBilgi";
			LstBilgi.Size = new Size(507, 196);
			LstBilgi.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(614, 117);
			label5.Name = "label5";
			label5.Size = new Size(274, 32);
			label5.TabIndex = 8;
			label5.Text = "İzin Talebinizi Açıklayınız";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(614, 152);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(521, 91);
			textBox2.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(614, 285);
			label6.Name = "label6";
			label6.Size = new Size(374, 32);
			label6.TabIndex = 10;
			label6.Text = "Talep Ettiğiniz gün sayısını Seçiniz";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(994, 282);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(141, 40);
			comboBox1.TabIndex = 11;
			// 
			// IzinForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(1175, 592);
			Controls.Add(comboBox1);
			Controls.Add(label6);
			Controls.Add(textBox2);
			Controls.Add(label5);
			Controls.Add(LstBilgi);
			Controls.Add(button2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4, 4, 4, 4);
			Name = "IzinForm";
			Text = "IzinForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox textBox1;
		private Button button1;
		private Label label3;
		private Label label4;
		private Button button2;
		private ListBox LstBilgi;
		private Label label5;
		private TextBox textBox2;
		private Label label6;
		private ComboBox comboBox1;
	}
}