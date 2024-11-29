namespace NtierArchitecture.UI.Formlar
{
	partial class RaporlamaForm
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
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			label3 = new Label();
			LstBilgi = new ListBox();
			LstDepartmanBilgi = new ListBox();
			dataGridView1 = new DataGridView();
			button3 = new Button();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Silver;
			label2.ForeColor = Color.Black;
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(255, 32);
			label2.TabIndex = 1;
			label2.Text = "Raporlama ve İstatikler";
			// 
			// button1
			// 
			button1.Location = new Point(12, 44);
			button1.Name = "button1";
			button1.Size = new Size(232, 61);
			button1.TabIndex = 2;
			button1.Text = "Personel Bilgileri";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(12, 247);
			button2.Name = "button2";
			button2.Size = new Size(255, 57);
			button2.TabIndex = 3;
			button2.Text = "Departman Bilgileri";
			button2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.Location = new Point(520, 454);
			label3.Name = "label3";
			label3.Size = new Size(395, 161);
			label3.TabIndex = 4;
			label3.Text = "departamana göre personel sayısını gösteren ve süreç içerisinde departmana işçi alımı veya çıkarımını gösteren liste olabilir \r\n";
			// 
			// LstBilgi
			// 
			LstBilgi.FormattingEnabled = true;
			LstBilgi.ItemHeight = 32;
			LstBilgi.Location = new Point(12, 109);
			LstBilgi.Name = "LstBilgi";
			LstBilgi.Size = new Size(442, 132);
			LstBilgi.TabIndex = 5;
			// 
			// LstDepartmanBilgi
			// 
			LstDepartmanBilgi.FormattingEnabled = true;
			LstDepartmanBilgi.ItemHeight = 32;
			LstDepartmanBilgi.Location = new Point(12, 310);
			LstDepartmanBilgi.Name = "LstDepartmanBilgi";
			LstDepartmanBilgi.Size = new Size(502, 260);
			LstDepartmanBilgi.TabIndex = 6;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(623, 126);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.Size = new Size(509, 315);
			dataGridView1.TabIndex = 7;
			// 
			// button3
			// 
			button3.Location = new Point(960, 59);
			button3.Name = "button3";
			button3.Size = new Size(200, 61);
			button3.TabIndex = 8;
			button3.Text = "Maaş Bilgileri";
			button3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(571, 73);
			label4.Name = "label4";
			label4.Size = new Size(383, 32);
			label4.TabIndex = 9;
			label4.Text = "Departman ve Genel Maaş Bilgileri";
			// 
			// RaporlamaForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(1172, 591);
			Controls.Add(label4);
			Controls.Add(button3);
			Controls.Add(dataGridView1);
			Controls.Add(LstDepartmanBilgi);
			Controls.Add(LstBilgi);
			Controls.Add(label3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Font = new Font("Segoe UI", 12F);
			ForeColor = Color.FromArgb(128, 64, 64);
			Margin = new Padding(4);
			Name = "RaporlamaForm";
			Text = "RaporlamaForm";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label2;
		private Button button1;
		private Button button2;
		private Label label3;
		private ListBox LstBilgi;
		private ListBox LstDepartmanBilgi;
		private DataGridView dataGridView1;
		private Button button3;
		private Label label4;
	}
}