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
            btnRaport = new Button();
            button3 = new Button();
            btnApprove = new Button();
            btnSalaryAssignment1 = new Button();
            button1 = new Button();
            btnPersonel = new Button();
            btnPremision = new Button();
            btnDepartment = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelForms = new Panel();
            panelSubMenuPersonel = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(40, 45, 62);
            panelMenu.Controls.Add(btnRaport);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnApprove);
            panelMenu.Controls.Add(btnSalaryAssignment1);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnPersonel);
            panelMenu.Controls.Add(btnPremision);
            panelMenu.Controls.Add(btnDepartment);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 630);
            panelMenu.TabIndex = 0;
            // 
            // btnRaport
            // 
            btnRaport.Dock = DockStyle.Top;
            btnRaport.FlatAppearance.BorderSize = 0;
            btnRaport.FlatStyle = FlatStyle.Flat;
            btnRaport.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRaport.ForeColor = Color.Gainsboro;
            btnRaport.Image = (Image)resources.GetObject("btnRaport.Image");
            btnRaport.ImageAlign = ContentAlignment.MiddleLeft;
            btnRaport.Location = new Point(0, 350);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(220, 60);
            btnRaport.TabIndex = 5;
            btnRaport.Text = "Raporlama";
            btnRaport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRaport.UseVisualStyleBackColor = true;
            btnRaport.Click += btnRaport_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Gainsboro;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 320);
            button3.Name = "button3";
            button3.Size = new Size(220, 30);
            button3.TabIndex = 6;
            button3.Text = "     Çalışan Maaş Takibi";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSalaryTracking_Click;
            // 
            // btnApprove
            // 
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnApprove.ForeColor = Color.Gainsboro;
            btnApprove.Image = (Image)resources.GetObject("btnApprove.Image");
            btnApprove.ImageAlign = ContentAlignment.MiddleLeft;
            btnApprove.Location = new Point(3, 416);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(214, 60);
            btnApprove.TabIndex = 4;
            btnApprove.Text = " İzin Onay";
            btnApprove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnSalaryAssignment1
            // 
            btnSalaryAssignment1.Dock = DockStyle.Top;
            btnSalaryAssignment1.FlatAppearance.BorderSize = 0;
            btnSalaryAssignment1.FlatStyle = FlatStyle.Flat;
            btnSalaryAssignment1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSalaryAssignment1.ForeColor = Color.Gainsboro;
            btnSalaryAssignment1.Image = (Image)resources.GetObject("btnSalaryAssignment1.Image");
            btnSalaryAssignment1.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalaryAssignment1.Location = new Point(0, 290);
            btnSalaryAssignment1.Name = "btnSalaryAssignment1";
            btnSalaryAssignment1.Size = new Size(220, 30);
            btnSalaryAssignment1.TabIndex = 5;
            btnSalaryAssignment1.Text = "     Maaş Atama";
            btnSalaryAssignment1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalaryAssignment1.UseVisualStyleBackColor = true;
            btnSalaryAssignment1.Click += btnSalaryAssignment_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 260);
            button1.Name = "button1";
            button1.Size = new Size(220, 30);
            button1.TabIndex = 4;
            button1.Text = "     Personel Ekleme";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPersonelAdd_Click;
            // 
            // btnPersonel
            // 
            btnPersonel.Dock = DockStyle.Top;
            btnPersonel.FlatAppearance.BorderSize = 0;
            btnPersonel.FlatStyle = FlatStyle.Flat;
            btnPersonel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonel.ForeColor = Color.Gainsboro;
            btnPersonel.Image = (Image)resources.GetObject("btnPersonel.Image");
            btnPersonel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonel.Location = new Point(0, 200);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(220, 60);
            btnPersonel.TabIndex = 3;
            btnPersonel.Text = " Personel İşlemleri  ";
            btnPersonel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPersonel.UseVisualStyleBackColor = true;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnPremision
            // 
            btnPremision.Dock = DockStyle.Top;
            btnPremision.FlatAppearance.BorderSize = 0;
            btnPremision.FlatStyle = FlatStyle.Flat;
            btnPremision.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPremision.ForeColor = Color.Gainsboro;
            btnPremision.Image = Properties.Resources.calendar;
            btnPremision.ImageAlign = ContentAlignment.MiddleLeft;
            btnPremision.Location = new Point(0, 140);
            btnPremision.Name = "btnPremision";
            btnPremision.Size = new Size(220, 60);
            btnPremision.TabIndex = 2;
            btnPremision.Text = " İzinler";
            btnPremision.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPremision.UseVisualStyleBackColor = true;
            btnPremision.Click += btnPremision_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Dock = DockStyle.Top;
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDepartment.ForeColor = Color.Gainsboro;
            btnDepartment.Image = (Image)resources.GetObject("btnDepartment.Image");
            btnDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartment.Location = new Point(0, 80);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(220, 60);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = " Departman İşlemleri";
            btnDepartment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(40, 45, 62);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(562, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(99, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(387, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PERSONEL YÖNETİM SİSTEMİ";
            // 
            // panelForms
            // 
            panelForms.AllowDrop = true;
            panelForms.AutoSize = true;
            panelForms.BackgroundImage = (Image)resources.GetObject("panelForms.BackgroundImage");
            panelForms.Controls.Add(panelSubMenuPersonel);
            panelForms.Dock = DockStyle.Fill;
            panelForms.Location = new Point(220, 80);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(562, 550);
            panelForms.TabIndex = 2;
            // 
            // panelSubMenuPersonel
            // 
            panelSubMenuPersonel.AllowDrop = true;
            panelSubMenuPersonel.Location = new Point(567, 3);
            panelSubMenuPersonel.Name = "panelSubMenuPersonel";
            panelSubMenuPersonel.Size = new Size(10, 10);
            panelSubMenuPersonel.TabIndex = 0;
            panelSubMenuPersonel.Paint += panelSubMenuPersonel_Paint;
            // 
            // NewBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(782, 630);
            Controls.Add(panelForms);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "NewBase";
            Text = "NewBase";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelForms.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnDepartment;
        private Button btnApprove;
        private Button btnPersonel;
        private Button btnPremision;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelForms;
        private Button button1;
        private Panel panel1;
        private Button btnRaport;
        private Button btnPersonelAdd;
        private Button button3;
        private Button btnSalaryAssignment1;
        private Panel panelSubMenuPersonel;
    }
}