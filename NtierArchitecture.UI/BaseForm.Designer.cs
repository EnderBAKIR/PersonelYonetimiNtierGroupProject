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
			personelFormlarıToolStripMenuItem = new ToolStripMenuItem();
			izinFormuToolStripMenuItem = new ToolStripMenuItem();
			izinFormuToolStripMenuItem1 = new ToolStripMenuItem();
			departmanFormuToolStripMenuItem = new ToolStripMenuItem();
			departmanlarToolStripMenuItem = new ToolStripMenuItem();
			raporlamaToolStripMenuItem = new ToolStripMenuItem();
			maaşFormuToolStripMenuItem = new ToolStripMenuItem();
			raporlarToolStripMenuItem = new ToolStripMenuItem();
			izinOnayToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.NavajoWhite;
			menuStrip1.Font = new Font("Segoe UI", 12F);
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { personelFormlarıToolStripMenuItem, departmanFormuToolStripMenuItem, raporlamaToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1040, 40);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// personelFormlarıToolStripMenuItem
			// 
			personelFormlarıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { izinFormuToolStripMenuItem, izinFormuToolStripMenuItem1 });
			personelFormlarıToolStripMenuItem.Name = "personelFormlarıToolStripMenuItem";
			personelFormlarıToolStripMenuItem.Size = new Size(214, 36);
			personelFormlarıToolStripMenuItem.Text = "Personel Formları";
			// 
			// izinFormuToolStripMenuItem
			// 
			izinFormuToolStripMenuItem.BackColor = Color.BurlyWood;
			izinFormuToolStripMenuItem.Name = "izinFormuToolStripMenuItem";
			izinFormuToolStripMenuItem.Size = new Size(270, 40);
			izinFormuToolStripMenuItem.Text = "Personeller";
			izinFormuToolStripMenuItem.Click += izinFormuToolStripMenuItem_Click;
			// 
			// izinFormuToolStripMenuItem1
			// 
			izinFormuToolStripMenuItem1.BackColor = Color.BurlyWood;
			izinFormuToolStripMenuItem1.Name = "izinFormuToolStripMenuItem1";
			izinFormuToolStripMenuItem1.Size = new Size(270, 40);
			izinFormuToolStripMenuItem1.Text = "İzin Talep ";
			izinFormuToolStripMenuItem1.Click += izinFormuToolStripMenuItem1_Click;
			// 
			// departmanFormuToolStripMenuItem
			// 
			departmanFormuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { departmanlarToolStripMenuItem });
			departmanFormuToolStripMenuItem.Name = "departmanFormuToolStripMenuItem";
			departmanFormuToolStripMenuItem.Size = new Size(225, 36);
			departmanFormuToolStripMenuItem.Text = "Departman Formu";
			// 
			// departmanlarToolStripMenuItem
			// 
			departmanlarToolStripMenuItem.BackColor = Color.BurlyWood;
			departmanlarToolStripMenuItem.Name = "departmanlarToolStripMenuItem";
			departmanlarToolStripMenuItem.Size = new Size(270, 40);
			departmanlarToolStripMenuItem.Text = "Departmanlar";
			departmanlarToolStripMenuItem.Click += departmanlarToolStripMenuItem_Click;
			// 
			// raporlamaToolStripMenuItem
			// 
			raporlamaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maaşFormuToolStripMenuItem, raporlarToolStripMenuItem, izinOnayToolStripMenuItem });
			raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
			raporlamaToolStripMenuItem.Size = new Size(143, 36);
			raporlamaToolStripMenuItem.Text = "Raporlama";
			// 
			// maaşFormuToolStripMenuItem
			// 
			maaşFormuToolStripMenuItem.BackColor = Color.BurlyWood;
			maaşFormuToolStripMenuItem.Name = "maaşFormuToolStripMenuItem";
			maaşFormuToolStripMenuItem.Size = new Size(218, 40);
			maaşFormuToolStripMenuItem.Text = "Maaş";
			maaşFormuToolStripMenuItem.Click += maaşFormuToolStripMenuItem_Click;
			// 
			// raporlarToolStripMenuItem
			// 
			raporlarToolStripMenuItem.BackColor = Color.BurlyWood;
			raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
			raporlarToolStripMenuItem.Size = new Size(218, 40);
			raporlarToolStripMenuItem.Text = "Raporlar";
			raporlarToolStripMenuItem.Click += raporlarToolStripMenuItem_Click;
			// 
			// izinOnayToolStripMenuItem
			// 
			izinOnayToolStripMenuItem.BackColor = Color.BurlyWood;
			izinOnayToolStripMenuItem.Name = "izinOnayToolStripMenuItem";
			izinOnayToolStripMenuItem.Size = new Size(270, 40);
			izinOnayToolStripMenuItem.Text = "İzin Onay";
			izinOnayToolStripMenuItem.Click += izinOnayToolStripMenuItem_Click;
			// 
			// BaseForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LemonChiffon;
			ClientSize = new Size(1040, 576);
			Controls.Add(menuStrip1);
			Font = new Font("Segoe UI", 12F);
			ForeColor = SystemColors.ControlText;
			MainMenuStrip = menuStrip1;
			Margin = new Padding(4);
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
		private ToolStripMenuItem departmanlarToolStripMenuItem;
		private ToolStripMenuItem maaşFormuToolStripMenuItem;
		private ToolStripMenuItem raporlarToolStripMenuItem;
		private ToolStripMenuItem izinOnayToolStripMenuItem;
	}
}
