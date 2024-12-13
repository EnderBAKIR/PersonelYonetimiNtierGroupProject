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
            btnApprove = new Button();
            btnPersonel = new Button();
            btnPremision = new Button();
            btnDepartment = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelForms = new Panel();
            panelsubMain = new Panel();
            panelSubMenuPersonel = new Panel();
            btnSalaryTracking = new Button();
            btnSalaryAssignment = new Button();
            btnPersonelAdd = new Button();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelForms.SuspendLayout();
            panelsubMain.SuspendLayout();
            panelSubMenuPersonel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(40, 45, 62);
            panelMenu.Controls.Add(btnRaport);
            panelMenu.Controls.Add(btnApprove);
            panelMenu.Controls.Add(btnPersonel);
            panelMenu.Controls.Add(btnPremision);
            panelMenu.Controls.Add(btnDepartment);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
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
            btnRaport.Location = new Point(0, 320);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(220, 60);
            btnRaport.TabIndex = 5;
            btnRaport.Text = "Raporlama";
            btnRaport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRaport.UseVisualStyleBackColor = true;
            btnRaport.Click += btnRaport_Click;
            // 
            // btnApprove
            // 
            btnApprove.Dock = DockStyle.Top;
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnApprove.ForeColor = Color.Gainsboro;
            btnApprove.Image = (Image)resources.GetObject("btnApprove.Image");
            btnApprove.ImageAlign = ContentAlignment.MiddleLeft;
            btnApprove.Location = new Point(0, 260);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(220, 60);
            btnApprove.TabIndex = 4;
            btnApprove.Text = " İzin Onay";
            btnApprove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
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
            btnPersonel.Text = " Personel İşlemleri  >";
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
            btnDepartment.Font = new Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            panelTitleBar.Size = new Size(580, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(108, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(387, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PERSONEL YÖNETİM SİSTEMİ";
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
            panelSubMenuPersonel.Location = new Point(0, 135);
            panelSubMenuPersonel.Name = "panelSubMenuPersonel";
            panelSubMenuPersonel.Size = new Size(160, 127);
            panelSubMenuPersonel.TabIndex = 0;
            panelSubMenuPersonel.Paint += panelSubMenuPersonel_Paint;
            // 
            // btnSalaryTracking
            // 
            btnSalaryTracking.BackColor = Color.FromArgb(40, 45, 62);
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
            btnSalaryAssignment.BackColor = Color.FromArgb(40, 45, 62);
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
            btnPersonelAdd.BackColor = Color.FromArgb(40, 45, 62);
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
        private Button btnDepartment;
        private Button btnApprove;
        private Button btnPersonel;
        private Button btnPremision;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelForms;
        private Panel panelSubMenuPersonel;
        private Button btnPersonelAdd;
        private Button btnSalaryTracking;
        private Button btnSalaryAssignment;
        private Panel panel1;
        private Panel panelsubMain;
        private Button btnRaport;
    }
}