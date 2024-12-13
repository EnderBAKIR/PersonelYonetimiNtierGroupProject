namespace NtierArchitecture.UI.Forms
{
    partial class Raporlar
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cmbDepartments = new ComboBox();
            lblEmployeeCount = new Label();
            lblDepartmentsSalaryAverage = new Label();
            cmbDepartments2 = new ComboBox();
            lstEmployeeList = new ListBox();
            dgwEmployeeDetails = new DataGridView();
            lblActiveEmp = new Label();
            lblQuittingJob = new Label();
            lblSalaryCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeDetails).BeginInit();
            SuspendLayout();
            // 
            // cmbDepartments
            // 
            cmbDepartments.BackColor = Color.WhiteSmoke;
            cmbDepartments.FlatStyle = FlatStyle.Flat;
            cmbDepartments.Font = new Font("Segoe UI", 12F);
            cmbDepartments.ForeColor = Color.DarkSlateGray;
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Location = new Point(20, 27);
            cmbDepartments.Margin = new Padding(3, 4, 3, 4);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(180, 36);
            cmbDepartments.TabIndex = 0;
            cmbDepartments.Text = "Departmanlar";
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.BackColor = Color.Transparent;
            lblEmployeeCount.Font = new Font("Segoe UI", 12F);
            lblEmployeeCount.ForeColor = Color.DarkSlateGray;
            lblEmployeeCount.Location = new Point(210, 27);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(147, 28);
            lblEmployeeCount.TabIndex = 1;
            lblEmployeeCount.Text = "Çalışan Sayısı: 0";
            // 
            // lblDepartmentsSalaryAverage
            // 
            lblDepartmentsSalaryAverage.AutoSize = true;
            lblDepartmentsSalaryAverage.BackColor = Color.Transparent;
            lblDepartmentsSalaryAverage.Font = new Font("Segoe UI", 12F);
            lblDepartmentsSalaryAverage.ForeColor = Color.DarkSlateGray;
            lblDepartmentsSalaryAverage.Location = new Point(380, 27);
            lblDepartmentsSalaryAverage.Name = "lblDepartmentsSalaryAverage";
            lblDepartmentsSalaryAverage.Size = new Size(190, 28);
            lblDepartmentsSalaryAverage.TabIndex = 2;
            lblDepartmentsSalaryAverage.Text = "Ortalama Maaş: 0,00";
            // 
            // cmbDepartments2
            // 
            cmbDepartments2.BackColor = Color.WhiteSmoke;
            cmbDepartments2.FlatStyle = FlatStyle.Flat;
            cmbDepartments2.Font = new Font("Segoe UI", 12F);
            cmbDepartments2.ForeColor = Color.DarkSlateGray;
            cmbDepartments2.FormattingEnabled = true;
            cmbDepartments2.Location = new Point(20, 120);
            cmbDepartments2.Margin = new Padding(3, 4, 3, 4);
            cmbDepartments2.Name = "cmbDepartments2";
            cmbDepartments2.Size = new Size(180, 36);
            cmbDepartments2.TabIndex = 3;
            cmbDepartments2.Text = "Departmanlar";
            cmbDepartments2.SelectedIndexChanged += cmbDepartments2_SelectedIndexChanged;
            // 
            // lstEmployeeList
            // 
            lstEmployeeList.BackColor = Color.White;
            lstEmployeeList.BorderStyle = BorderStyle.None;
            lstEmployeeList.Font = new Font("Segoe UI", 12F);
            lstEmployeeList.ForeColor = Color.Black;
            lstEmployeeList.FormattingEnabled = true;
            lstEmployeeList.ItemHeight = 28;
            lstEmployeeList.Location = new Point(210, 120);
            lstEmployeeList.Margin = new Padding(3, 4, 3, 4);
            lstEmployeeList.Name = "lstEmployeeList";
            lstEmployeeList.Size = new Size(450, 196);
            lstEmployeeList.TabIndex = 4;
            lstEmployeeList.SelectedIndexChanged += lstEmployeeList_SelectedIndexChanged;
            // 
            // dgwEmployeeDetails
            // 
            dgwEmployeeDetails.BackgroundColor = Color.White;
            dgwEmployeeDetails.BorderStyle = BorderStyle.None;
            dgwEmployeeDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgwEmployeeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle2;
            dgwEmployeeDetails.Font = new Font("Segoe UI", 10F);
            dgwEmployeeDetails.GridColor = Color.LightGray;
            dgwEmployeeDetails.Location = new Point(210, 333);
            dgwEmployeeDetails.Margin = new Padding(3, 4, 3, 4);
            dgwEmployeeDetails.Name = "dgwEmployeeDetails";
            dgwEmployeeDetails.RowHeadersWidth = 51;
            dgwEmployeeDetails.Size = new Size(450, 200);
            dgwEmployeeDetails.TabIndex = 5;
            // 
            // lblActiveEmp
            // 
            lblActiveEmp.AutoSize = true;
            lblActiveEmp.Font = new Font("Segoe UI", 12F);
            lblActiveEmp.ForeColor = Color.SeaGreen;
            lblActiveEmp.Location = new Point(12, 560);
            lblActiveEmp.Name = "lblActiveEmp";
            lblActiveEmp.Size = new Size(161, 28);
            lblActiveEmp.TabIndex = 6;
            lblActiveEmp.Text = "Aktif Çalışanlar: 0";
            // 
            // lblQuittingJob
            // 
            lblQuittingJob.AutoSize = true;
            lblQuittingJob.Font = new Font("Segoe UI", 12F);
            lblQuittingJob.ForeColor = Color.OrangeRed;
            lblQuittingJob.Location = new Point(200, 560);
            lblQuittingJob.Name = "lblQuittingJob";
            lblQuittingJob.Size = new Size(161, 28);
            lblQuittingJob.TabIndex = 7;
            lblQuittingJob.Text = "İşten Ayrılanlar: 0";
            // 
            // lblSalaryCount
            // 
            lblSalaryCount.AutoSize = true;
            lblSalaryCount.Font = new Font("Segoe UI", 12F);
            lblSalaryCount.ForeColor = Color.DeepSkyBlue;
            lblSalaryCount.Location = new Point(380, 560);
            lblSalaryCount.Name = "lblSalaryCount";
            lblSalaryCount.Size = new Size(231, 28);
            lblSalaryCount.TabIndex = 8;
            lblSalaryCount.Text = "Toplam Maaş Gideri: 0,00";
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 640);
            Controls.Add(lblSalaryCount);
            Controls.Add(lblQuittingJob);
            Controls.Add(lblActiveEmp);
            Controls.Add(dgwEmployeeDetails);
            Controls.Add(lstEmployeeList);
            Controls.Add(cmbDepartments2);
            Controls.Add(lblDepartmentsSalaryAverage);
            Controls.Add(lblEmployeeCount);
            Controls.Add(cmbDepartments);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Raporlar";
            Text = "Departman ve Çalışan Raporları";
            Load += Raporlar_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private ComboBox cmbDepartments;
        private Label lblEmployeeCount;
        private Label lblDepartmentsSalaryAverage;
        private ComboBox cmbDepartments2;
        private ListBox lstEmployeeList;
        private DataGridView dgwEmployeeDetails;
        private Label lblActiveEmp;
        private Label lblQuittingJob;
        private Label lblSalaryCount;
    }
}