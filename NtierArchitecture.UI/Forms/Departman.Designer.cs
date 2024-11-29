namespace NtierArchitecture.UI.Formlar
{
	partial class Departman
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
			btnshow = new Button();
			button2 = new Button();
			btnnewshow = new Button();
			btnDelete = new Button();
			dataGridView1 = new DataGridView();
			lstDepartmants = new ListBox();
			txtdepartmans = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.ForeColor = Color.Black;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(264, 38);
			label1.TabIndex = 0;
			label1.Text = "DEPARTMAN İŞLEMLERİ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 47);
			label2.Name = "label2";
			label2.Size = new Size(474, 32);
			label2.TabIndex = 1;
			label2.Text = "Departmanları Görüntülemek için Tıklayınız";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(574, 47);
			label3.Name = "label3";
			label3.Size = new Size(232, 32);
			label3.TabIndex = 2;
			label3.Text = "Departman Ekleyiniz";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(574, 175);
			label4.Name = "label4";
			label4.Size = new Size(370, 32);
			label4.TabIndex = 3;
			label4.Text = "Eklenen Departmanları Görüntüle";
			// 
			// btnshow
			// 
			btnshow.Location = new Point(125, 94);
			btnshow.Name = "btnshow";
			btnshow.Size = new Size(236, 47);
			btnshow.TabIndex = 4;
			btnshow.Text = "Departmanlar";
			btnshow.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(728, 94);
			button2.Name = "button2";
			button2.Size = new Size(243, 47);
			button2.TabIndex = 5;
			button2.Text = "Departman Ekle";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// btnnewshow
			// 
			btnnewshow.Location = new Point(969, 168);
			btnnewshow.Name = "btnnewshow";
			btnnewshow.Size = new Size(181, 47);
			btnnewshow.TabIndex = 6;
			btnnewshow.Text = "Görüntüleme";
			btnnewshow.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(167, 509);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(150, 58);
			btnDelete.TabIndex = 8;
			btnDelete.Text = "Sil";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(592, 230);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.Size = new Size(544, 273);
			dataGridView1.TabIndex = 9;
			// 
			// lstDepartmants
			// 
			lstDepartmants.FormattingEnabled = true;
			lstDepartmants.ItemHeight = 32;
			lstDepartmants.Location = new Point(38, 147);
			lstDepartmants.Name = "lstDepartmants";
			lstDepartmants.Size = new Size(421, 356);
			lstDepartmants.TabIndex = 10;
			// 
			// txtdepartmans
			// 
			txtdepartmans.Location = new Point(835, 44);
			txtdepartmans.Name = "txtdepartmans";
			txtdepartmans.Size = new Size(342, 39);
			txtdepartmans.TabIndex = 11;
			// 
			// Departman
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumAquamarine;
			ClientSize = new Size(1189, 576);
			Controls.Add(txtdepartmans);
			Controls.Add(lstDepartmants);
			Controls.Add(dataGridView1);
			Controls.Add(btnDelete);
			Controls.Add(btnnewshow);
			Controls.Add(button2);
			Controls.Add(btnshow);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			ForeColor = Color.DarkRed;
			Margin = new Padding(4);
			Name = "Departman";
			Text = "Departman";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button btnshow;
		private Button button2;
		private Button btnnewshow;
		private Button btnDelete;
		private DataGridView dataGridView1;
		private ListBox lstDepartmants;
		private TextBox txtdepartmans;
	}
}