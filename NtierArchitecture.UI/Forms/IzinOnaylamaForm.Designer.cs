namespace NtierArchitecture.UI.Forms
{
    partial class IzinOnaylamaForm
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
            lstActiveLeaves = new ListBox();
            dgwEmployeeDetails = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            dgwLeaveDetails = new DataGridView();
            btnRejected = new Button();
            lstLeaves = new ListBox();
            label4 = new Label();
            btnApproved = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 33);
            label1.TabIndex = 0;
            label1.Text = "Aktif İzin Talepleri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstActiveLeaves
            // 
            lstActiveLeaves.FormattingEnabled = true;
            lstActiveLeaves.ItemHeight = 15;
            lstActiveLeaves.Location = new Point(20, 45);
            lstActiveLeaves.Name = "lstActiveLeaves";
            lstActiveLeaves.Size = new Size(369, 199);
            lstActiveLeaves.TabIndex = 1;
            lstActiveLeaves.SelectedIndexChanged += lstActiveLeaves_SelectedIndexChanged;
            // 
            // dgwEmployeeDetails
            // 
            dgwEmployeeDetails.BackgroundColor = Color.Azure;
            dgwEmployeeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployeeDetails.Location = new Point(30, 432);
            dgwEmployeeDetails.Name = "dgwEmployeeDetails";
            dgwEmployeeDetails.Size = new Size(818, 94);
            dgwEmployeeDetails.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(341, 396);
            label2.Name = "label2";
            label2.Size = new Size(230, 33);
            label2.TabIndex = 3;
            label2.Text = "Personel Detayları";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(357, 256);
            label3.Name = "label3";
            label3.Size = new Size(190, 33);
            label3.TabIndex = 4;
            label3.Text = "Talep Detayları";
            // 
            // dgwLeaveDetails
            // 
            dgwLeaveDetails.BackgroundColor = Color.Azure;
            dgwLeaveDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeaveDetails.Location = new Point(30, 292);
            dgwLeaveDetails.Name = "dgwLeaveDetails";
            dgwLeaveDetails.Size = new Size(818, 88);
            dgwLeaveDetails.TabIndex = 5;
            // 
            // btnRejected
            // 
            btnRejected.BackColor = Color.Firebrick;
            btnRejected.Font = new Font("Microsoft YaHei", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRejected.ForeColor = SystemColors.ButtonHighlight;
            btnRejected.Location = new Point(461, 544);
            btnRejected.Name = "btnRejected";
            btnRejected.Size = new Size(129, 42);
            btnRejected.TabIndex = 7;
            btnRejected.Text = "Reddet";
            btnRejected.UseVisualStyleBackColor = false;
            btnRejected.Click += btnRejected_Click;
            // 
            // lstLeaves
            // 
            lstLeaves.FormattingEnabled = true;
            lstLeaves.ItemHeight = 15;
            lstLeaves.Location = new Point(487, 45);
            lstLeaves.Name = "lstLeaves";
            lstLeaves.Size = new Size(373, 199);
            lstLeaves.TabIndex = 8;
            lstLeaves.SelectedIndexChanged += lstLeaves_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(487, 9);
            label4.Name = "label4";
            label4.Size = new Size(205, 33);
            label4.TabIndex = 9;
            label4.Text = "Sonuçlanmış İzin Talepleri";
            // 
            // btnApproved
            // 
            btnApproved.BackColor = Color.ForestGreen;
            btnApproved.Font = new Font("Microsoft YaHei", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnApproved.ForeColor = SystemColors.ControlLightLight;
            btnApproved.Location = new Point(272, 544);
            btnApproved.Name = "btnApproved";
            btnApproved.Size = new Size(129, 42);
            btnApproved.TabIndex = 10;
            btnApproved.Text = "Onayla";
            btnApproved.UseVisualStyleBackColor = false;
            btnApproved.Click += btnApproved_Click;
            // 
            // IzinOnaylamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 624);
            Controls.Add(btnApproved);
            Controls.Add(label4);
            Controls.Add(lstLeaves);
            Controls.Add(btnRejected);
            Controls.Add(dgwLeaveDetails);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgwEmployeeDetails);
            Controls.Add(lstActiveLeaves);
            Controls.Add(label1);
            Name = "IzinOnaylamaForm";
            Text = "İzinOnaylamaForm";
            Load += IzinOnaylamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox lstActiveLeaves;
        private DataGridView dgwEmployeeDetails;
        private Label label2;
        private Label label3;
        private DataGridView dgwLeaveDetails;
        private Button btnRejected;
        private ListBox lstLeaves;
        private Label label4;
        private Button btnApproved;
    }
}