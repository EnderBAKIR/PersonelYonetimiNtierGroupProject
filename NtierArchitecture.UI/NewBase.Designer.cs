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
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 600);
            panelMenu.TabIndex = 0;
            // 
            // btnRaport
            // 
            btnRaport.Dock = DockStyle.Top;
            btnRaport.FlatAppearance.BorderSize = 0;
            btnRaport.FlatStyle = FlatStyle.Flat;
            btnRaport.Font = new Font("Verdana Pro Cond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRaport.ForeColor = Color.Gainsboro;
            btnRaport.Image = (Image)resources.GetObject("btnRaport.Image");
            btnRaport.ImageAlign = ContentAlignment.MiddleLeft;
            btnRaport.Location = new Point(0, 427);
            btnRaport.Margin = new Padding(3, 4, 3, 4);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(251, 80);
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
            btnApprove.Font = new Font("Verdana Pro Cond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnApprove.ForeColor = Color.Gainsboro;
            btnApprove.Image = (Image)resources.GetObject("btnApprove.Image");
            btnApprove.ImageAlign = ContentAlignment.MiddleLeft;
            btnApprove.Location = new Point(0, 347);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(251, 80);
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
            btnPersonel.Font = new Font("Verdana Pro Cond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonel.ForeColor = Color.Gainsboro;
            btnPersonel.Image = (Image)resources.GetObject("btnPersonel.Image");
            btnPersonel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonel.Location = new Point(0, 267);
            btnPersonel.Margin = new Padding(3, 4, 3, 4);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(251, 80);
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
            btnPremision.Font = new Font("Verdana Pro Cond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPremision.ForeColor = Color.Gainsboro;
            btnPremision.Image = Properties.Resources.calendar;
            btnPremision.ImageAlign = ContentAlignment.MiddleLeft;
            btnPremision.Location = new Point(0, 187);
            btnPremision.Margin = new Padding(3, 4, 3, 4);
            btnPremision.Name = "btnPremision";
            btnPremision.Size = new Size(251, 80);
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
            btnDepartment.Font = new Font("Verdana Pro Cond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepartment.ForeColor = Color.Gainsboro;
            btnDepartment.Image = (Image)resources.GetObject("btnDepartment.Image");
            btnDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartment.Location = new Point(0, 107);
            btnDepartment.Margin = new Padding(3, 4, 3, 4);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(251, 80);
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
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 107);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(40, 45, 62);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(251, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(663, 107);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana Pro Cond", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(123, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(398, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PERSONEL YÖNETİM SİSTEMİ";
            // 
            // panelForms
            // 
            panelForms.AllowDrop = true;
            panelForms.Controls.Add(panelsubMain);
            panelForms.Dock = DockStyle.Fill;
            panelForms.Location = new Point(251, 107);
            panelForms.Margin = new Padding(3, 4, 3, 4);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(663, 493);
            panelForms.TabIndex = 2;
            // 
            // panelsubMain
            // 
            panelsubMain.Controls.Add(panelSubMenuPersonel);
            panelsubMain.Dock = DockStyle.Left;
            panelsubMain.Location = new Point(0, 0);
            panelsubMain.Margin = new Padding(3, 4, 3, 4);
            panelsubMain.Name = "panelsubMain";
            panelsubMain.Size = new Size(183, 493);
            panelsubMain.TabIndex = 3;
            panelsubMain.Paint += panelsubMain_Paint;
            // 
            // panelSubMenuPersonel
            // 
            panelSubMenuPersonel.AllowDrop = true;
            panelSubMenuPersonel.Controls.Add(btnSalaryTracking);
            panelSubMenuPersonel.Controls.Add(btnSalaryAssignment);
            panelSubMenuPersonel.Controls.Add(btnPersonelAdd);
            panelSubMenuPersonel.Location = new Point(0, 180);
            panelSubMenuPersonel.Margin = new Padding(3, 4, 3, 4);
            panelSubMenuPersonel.Name = "panelSubMenuPersonel";
            panelSubMenuPersonel.Size = new Size(183, 169);
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
            btnSalaryTracking.Location = new Point(0, 106);
            btnSalaryTracking.Margin = new Padding(3, 4, 3, 4);
            btnSalaryTracking.Name = "btnSalaryTracking";
            btnSalaryTracking.Size = new Size(183, 53);
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
            btnSalaryAssignment.Location = new Point(0, 53);
            btnSalaryAssignment.Margin = new Padding(3, 4, 3, 4);
            btnSalaryAssignment.Name = "btnSalaryAssignment";
            btnSalaryAssignment.Size = new Size(183, 53);
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
            btnPersonelAdd.Margin = new Padding(3, 4, 3, 4);
            btnPersonelAdd.Name = "btnPersonelAdd";
            btnPersonelAdd.Size = new Size(183, 53);
            btnPersonelAdd.TabIndex = 0;
            btnPersonelAdd.Text = "Personel Ekleme";
            btnPersonelAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonelAdd.UseVisualStyleBackColor = false;
            btnPersonelAdd.Click += btnPersonelAdd_Click;
            // 
            // NewBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelForms);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
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