namespace NtierArchitecture.UI
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			departmanFormuToolStripMenuItem = new ToolStripMenuItem();
			personelFormlarıToolStripMenuItem = new ToolStripMenuItem();
			izinFormuToolStripMenuItem = new ToolStripMenuItem();
			izinFormuToolStripMenuItem1 = new ToolStripMenuItem();
			çalışanMaaşTakibiToolStripMenuItem = new ToolStripMenuItem();
			izinTalepToolStripMenuItem = new ToolStripMenuItem();
			izinOnaylamaToolStripMenuItem = new ToolStripMenuItem();
			raporlamaToolStripMenuItem = new ToolStripMenuItem();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.MediumAquamarine;
			menuStrip1.Font = new Font("Segoe UI", 12F);
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { departmanFormuToolStripMenuItem, personelFormlarıToolStripMenuItem, izinTalepToolStripMenuItem, izinOnaylamaToolStripMenuItem, raporlamaToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(8, 2, 0, 2);
			menuStrip1.Size = new Size(1440, 40);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// departmanFormuToolStripMenuItem
			// 
			departmanFormuToolStripMenuItem.Name = "departmanFormuToolStripMenuItem";
			departmanFormuToolStripMenuItem.Size = new Size(245, 36);
			departmanFormuToolStripMenuItem.Text = "Departman İşlemleri";
			departmanFormuToolStripMenuItem.Click += departmanFormuToolStripMenuItem_Click;
			// 
			// personelFormlarıToolStripMenuItem
			// 
			personelFormlarıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { izinFormuToolStripMenuItem, izinFormuToolStripMenuItem1, çalışanMaaşTakibiToolStripMenuItem });
			personelFormlarıToolStripMenuItem.Name = "personelFormlarıToolStripMenuItem";
			personelFormlarıToolStripMenuItem.Size = new Size(216, 36);
			personelFormlarıToolStripMenuItem.Text = "Personel İşlemleri";
			// 
			// izinFormuToolStripMenuItem
			// 
			izinFormuToolStripMenuItem.BackColor = Color.LightSeaGreen;
			izinFormuToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
			izinFormuToolStripMenuItem.Name = "izinFormuToolStripMenuItem";
			izinFormuToolStripMenuItem.Size = new Size(323, 40);
			izinFormuToolStripMenuItem.Text = "Personel Ekleme ";
			izinFormuToolStripMenuItem.Click += izinFormuToolStripMenuItem_Click;
			// 
			// izinFormuToolStripMenuItem1
			// 
			izinFormuToolStripMenuItem1.BackColor = Color.LightSeaGreen;
			izinFormuToolStripMenuItem1.Name = "izinFormuToolStripMenuItem1";
			izinFormuToolStripMenuItem1.Size = new Size(323, 40);
			izinFormuToolStripMenuItem1.Text = "Maaş Atama ";
			izinFormuToolStripMenuItem1.Click += izinFormuToolStripMenuItem1_Click;
			// 
			// çalışanMaaşTakibiToolStripMenuItem
			// 
			çalışanMaaşTakibiToolStripMenuItem.BackColor = Color.LightSeaGreen;
			çalışanMaaşTakibiToolStripMenuItem.Name = "çalışanMaaşTakibiToolStripMenuItem";
			çalışanMaaşTakibiToolStripMenuItem.Size = new Size(323, 40);
			çalışanMaaşTakibiToolStripMenuItem.Text = "Çalışan Maaş Takibi";
			çalışanMaaşTakibiToolStripMenuItem.Click += çalışanMaaşTakibiToolStripMenuItem_Click;
			// 
			// izinTalepToolStripMenuItem
			// 
			izinTalepToolStripMenuItem.Name = "izinTalepToolStripMenuItem";
			izinTalepToolStripMenuItem.Size = new Size(190, 36);
			izinTalepToolStripMenuItem.Text = "İzin Talep Etme";
			izinTalepToolStripMenuItem.Click += izinTalepToolStripMenuItem_Click;
			// 
			// izinOnaylamaToolStripMenuItem
			// 
			izinOnaylamaToolStripMenuItem.Name = "izinOnaylamaToolStripMenuItem";
			izinOnaylamaToolStripMenuItem.Size = new Size(181, 36);
			izinOnaylamaToolStripMenuItem.Text = "İzin Onaylama";
			izinOnaylamaToolStripMenuItem.Click += izinOnaylamaToolStripMenuItem_Click;
			// 
			// raporlamaToolStripMenuItem
			// 
			raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
			raporlamaToolStripMenuItem.Size = new Size(143, 36);
			raporlamaToolStripMenuItem.Text = "Raporlama";
			raporlamaToolStripMenuItem.Click += raporlamaToolStripMenuItem_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Bisque;
			label1.Font = new Font("Niagara Engraved", 62F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			label1.Location = new Point(295, 244);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(861, 133);
			label1.TabIndex = 1;
			label1.Text = "PERSONEL TAKİP SİSTEMİ ";
			// 
			// label2
			// 
			label2.BackColor = Color.OrangeRed;
			label2.Font = new Font("Niagara Engraved", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(16, 512);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(454, 97);
			label2.TabIndex = 2;
			label2.Text = "Ender Mahsuni BAKIR";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.BackColor = Color.FromArgb(128, 255, 128);
			label3.Font = new Font("Niagara Engraved", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = SystemColors.ControlText;
			label3.Location = new Point(1024, 512);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(398, 97);
			label3.TabIndex = 3;
			label3.Text = "Esranur Betül ÖZ";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.BackColor = Color.Red;
			label4.Font = new Font("Niagara Engraved", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(646, 512);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(244, 97);
			label4.TabIndex = 4;
			label4.Text = "Elif OKUR";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.BackColor = Color.FromArgb(255, 128, 255);
			label5.Font = new Font("Niagara Engraved", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(830, 632);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(326, 92);
			label5.TabIndex = 5;
			label5.Text = "Kübra AYKOL";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.BackColor = Color.FromArgb(192, 0, 192);
			label6.Font = new Font("Niagara Engraved", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(332, 632);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(340, 92);
			label6.TabIndex = 6;
			label6.Text = "Meryem YAVUZ";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BaseForm
			// 
			AutoScaleDimensions = new SizeF(18F, 45F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Linen;
			ClientSize = new Size(1440, 810);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(menuStrip1);
			Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
			ForeColor = SystemColors.ControlText;
			MainMenuStrip = menuStrip1;
			Margin = new Padding(6);
			Name = "BaseForm";
			Text = "Form1";
			Load += BaseForm_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem personelFormlarıToolStripMenuItem;
		private ToolStripMenuItem izinFormuToolStripMenuItem;
		private ToolStripMenuItem departmanFormuToolStripMenuItem;
		private ToolStripMenuItem raporlamaToolStripMenuItem;
		private ToolStripMenuItem izinFormuToolStripMenuItem1;
		private ToolStripMenuItem çalışanMaaşTakibiToolStripMenuItem;
		private ToolStripMenuItem izinTalepToolStripMenuItem;
		private ToolStripMenuItem izinOnaylamaToolStripMenuItem;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
	}
}
