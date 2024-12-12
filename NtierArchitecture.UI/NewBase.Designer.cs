namespace NtierArchitecture.UI.Forms
{
    partial class NewBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBase));
            panelMenu = new Panel();
            button3 = new Button();
            btnPersonel = new Button();
            btnDepartman = new Button();
            btnIzin = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelForms = new Panel();
            panelsubMain = new Panel();
            panelSubMenuPersonel = new Panel();
            btnSalaryTracking = new Button();
            btnSalaryAssignment = new Button();
            btnPersonelAdd = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelForms.SuspendLayout();
            panelsubMain.SuspendLayout();
            panelSubMenuPersonel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(40, 45, 62);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnPersonel);
            panelMenu.Controls.Add(btnDepartman);
            panelMenu.Controls.Add(btnIzin);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 260);
            button3.Name = "button3";
            button3.Size = new Size(220, 60);
            button3.TabIndex = 4;
            button3.Text = "İzinler";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnPersonel
            // 
            btnPersonel.Dock = DockStyle.Top;
            btnPersonel.FlatAppearance.BorderSize = 0;
            btnPersonel.FlatStyle = FlatStyle.Flat;
            btnPersonel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPersonel.ForeColor = Color.Gainsboro;
            btnPersonel.Image = (Image)resources.GetObject("btnPersonel.Image");
            btnPersonel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonel.Location = new Point(0, 200);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(220, 60);
            btnPersonel.TabIndex = 3;
            btnPersonel.Text = "Personel İşlemleri             >";
            btnPersonel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPersonel.UseVisualStyleBackColor = true;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnDepartman
            // 
            btnDepartman.Dock = DockStyle.Top;
            btnDepartman.FlatAppearance.BorderSize = 0;
            btnDepartman.FlatStyle = FlatStyle.Flat;
            btnDepartman.ForeColor = Color.Gainsboro;
            btnDepartman.Image = (Image)resources.GetObject("btnDepartman.Image");
            btnDepartman.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartman.Location = new Point(0, 140);
            btnDepartman.Name = "btnDepartman";
            btnDepartman.Size = new Size(220, 60);
            btnDepartman.TabIndex = 2;
            btnDepartman.Text = "İzinler";
            btnDepartman.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepartman.UseVisualStyleBackColor = true;
            // 
            // btnIzin
            // 
            btnIzin.Dock = DockStyle.Top;
            btnIzin.FlatAppearance.BorderSize = 0;
            btnIzin.FlatStyle = FlatStyle.Flat;
            btnIzin.ForeColor = Color.Gainsboro;
            btnIzin.Image = (Image)resources.GetObject("btnIzin.Image");
            btnIzin.ImageAlign = ContentAlignment.MiddleLeft;
            btnIzin.Location = new Point(0, 80);
            btnIzin.Name = "btnIzin";
            btnIzin.Size = new Size(220, 60);
            btnIzin.TabIndex = 1;
            btnIzin.Text = "İzinler";
            btnIzin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIzin.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 1;
            label1.Text = "Personel Yönetim Sistemi";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.DarkGray;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(580, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(252, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelForms
            // 
            panelForms.AllowDrop = true;
            panelForms.Controls.Add(panelsubMain);
            panelForms.Dock = DockStyle.Fill;
            panelForms.Location = new Point(220, 80);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(580, 370);
            panelForms.TabIndex = 2;
            // 
            // panelsubMain
            // 
            panelsubMain.Controls.Add(panelSubMenuPersonel);
            panelsubMain.Dock = DockStyle.Left;
            panelsubMain.Location = new Point(0, 0);
            panelsubMain.Name = "panelsubMain";
            panelsubMain.Size = new Size(160, 370);
            panelsubMain.TabIndex = 3;
            panelsubMain.Paint += panelsubMain_Paint;
            // 
            // panelSubMenuPersonel
            // 
            panelSubMenuPersonel.AllowDrop = true;
            panelSubMenuPersonel.Controls.Add(btnSalaryTracking);
            panelSubMenuPersonel.Controls.Add(btnSalaryAssignment);
            panelSubMenuPersonel.Controls.Add(btnPersonelAdd);
            panelSubMenuPersonel.Location = new Point(0, 92);
            panelSubMenuPersonel.Name = "panelSubMenuPersonel";
            panelSubMenuPersonel.Size = new Size(160, 127);
            panelSubMenuPersonel.TabIndex = 0;
            panelSubMenuPersonel.Paint += panelSubMenuPersonel_Paint;
            // 
            // btnSalaryTracking
            // 
            btnSalaryTracking.BackColor = Color.FromArgb(136, 145, 178);
            btnSalaryTracking.Dock = DockStyle.Top;
            btnSalaryTracking.FlatAppearance.BorderColor = Color.FromArgb(40, 45, 62);
            btnSalaryTracking.FlatAppearance.BorderSize = 0;
            btnSalaryTracking.FlatStyle = FlatStyle.Flat;
            btnSalaryTracking.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSalaryTracking.ForeColor = Color.Gainsboro;
            btnSalaryTracking.Location = new Point(0, 80);
            btnSalaryTracking.Name = "btnSalaryTracking";
            btnSalaryTracking.Size = new Size(160, 40);
            btnSalaryTracking.TabIndex = 2;
            btnSalaryTracking.Text = "Çalışan Maaş Takibi";
            btnSalaryTracking.TextAlign = ContentAlignment.MiddleLeft;
            btnSalaryTracking.UseVisualStyleBackColor = false;
            btnSalaryTracking.Click += btnSalaryTracking_Click;
            // 
            // btnSalaryAssignment
            // 
            btnSalaryAssignment.BackColor = Color.FromArgb(136, 145, 178);
            btnSalaryAssignment.Dock = DockStyle.Top;
            btnSalaryAssignment.FlatAppearance.BorderColor = Color.White;
            btnSalaryAssignment.FlatStyle = FlatStyle.Flat;
            btnSalaryAssignment.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSalaryAssignment.ForeColor = Color.Gainsboro;
            btnSalaryAssignment.Location = new Point(0, 40);
            btnSalaryAssignment.Name = "btnSalaryAssignment";
            btnSalaryAssignment.Size = new Size(160, 40);
            btnSalaryAssignment.TabIndex = 1;
            btnSalaryAssignment.Text = "Maaş Atama";
            btnSalaryAssignment.TextAlign = ContentAlignment.MiddleLeft;
            btnSalaryAssignment.UseVisualStyleBackColor = false;
            btnSalaryAssignment.Click += btnSalaryAssignment_Click;
            // 
            // btnPersonelAdd
            // 
            btnPersonelAdd.BackColor = Color.FromArgb(136, 145, 178);
            btnPersonelAdd.Dock = DockStyle.Top;
            btnPersonelAdd.FlatAppearance.BorderColor = Color.FromArgb(40, 45, 62);
            btnPersonelAdd.FlatAppearance.BorderSize = 0;
            btnPersonelAdd.FlatStyle = FlatStyle.Flat;
            btnPersonelAdd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonelAdd.ForeColor = Color.Gainsboro;
            btnPersonelAdd.Location = new Point(0, 0);
            btnPersonelAdd.Name = "btnPersonelAdd";
            btnPersonelAdd.Size = new Size(160, 40);
            btnPersonelAdd.TabIndex = 0;
            btnPersonelAdd.Text = "Personel Ekleme";
            btnPersonelAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonelAdd.UseVisualStyleBackColor = false;
            btnPersonelAdd.Click += btnPersonelAdd_Click;
            // 
            // NewBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "NewBase";
            Text = "NewBase";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelForms.ResumeLayout(false);
            panelsubMain.ResumeLayout(false);
            panelSubMenuPersonel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnIzin;
        private Button button3;
        private Button btnPersonel;
        private Button btnDepartman;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelForms;
        private Panel panelSubMenuPersonel;
        private Button btnPersonelAdd;
        private Button btnSalaryTracking;
        private Button btnSalaryAssignment;
        private Panel panel1;
        private Panel panelsubMain;
    }
}