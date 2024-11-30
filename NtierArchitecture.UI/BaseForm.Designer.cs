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
            departmanFormuToolStripMenuItem = new ToolStripMenuItem();
            maaşFormuToolStripMenuItem = new ToolStripMenuItem();
            raporlamaToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Size = new Size(1040, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // personelFormlarıToolStripMenuItem
            // 
            personelFormlarıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { izinFormuToolStripMenuItem });
            personelFormlarıToolStripMenuItem.Name = "personelFormlarıToolStripMenuItem";
            personelFormlarıToolStripMenuItem.Size = new Size(144, 25);
            personelFormlarıToolStripMenuItem.Text = "Personel Formları";
            // 
            // izinFormuToolStripMenuItem
            // 
            izinFormuToolStripMenuItem.BackColor = Color.NavajoWhite;
            izinFormuToolStripMenuItem.Name = "izinFormuToolStripMenuItem";
            izinFormuToolStripMenuItem.Size = new Size(154, 26);
            izinFormuToolStripMenuItem.Text = "İzin Formu";
            // 
            // departmanFormuToolStripMenuItem
            // 
            departmanFormuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maaşFormuToolStripMenuItem });
            departmanFormuToolStripMenuItem.Name = "departmanFormuToolStripMenuItem";
            departmanFormuToolStripMenuItem.Size = new Size(150, 25);
            departmanFormuToolStripMenuItem.Text = "Departman Formu";
            // 
            // maaşFormuToolStripMenuItem
            // 
            maaşFormuToolStripMenuItem.BackColor = Color.NavajoWhite;
            maaşFormuToolStripMenuItem.Name = "maaşFormuToolStripMenuItem";
            maaşFormuToolStripMenuItem.Size = new Size(167, 26);
            maaşFormuToolStripMenuItem.Text = "Maaş Formu";
            // 
            // raporlamaToolStripMenuItem
            // 
            raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            raporlamaToolStripMenuItem.Size = new Size(98, 25);
            raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
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
		private ToolStripMenuItem maaşFormuToolStripMenuItem;
		private ToolStripMenuItem raporlamaToolStripMenuItem;
	}
}
