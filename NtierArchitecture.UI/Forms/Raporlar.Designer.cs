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
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Location = new Point(20, 20);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(180, 35);
            cmbDepartments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartments.TabIndex = 0;
            cmbDepartments.Text = "Departmanlar";
            cmbDepartments.BackColor = Color.WhiteSmoke;
            cmbDepartments.ForeColor = Color.DarkSlateGray;
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            cmbDepartments.FlatStyle = FlatStyle.Flat;

            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeCount.ForeColor = Color.DarkSlateGray;
            lblEmployeeCount.Location = new Point(210, 20);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(170, 28);
            lblEmployeeCount.TabIndex = 1;
            lblEmployeeCount.Text = "Çalışan Sayısı: 0";
            lblEmployeeCount.BackColor = Color.Transparent;

            // 
            // lblDepartmentsSalaryAverage
            // 
            lblDepartmentsSalaryAverage.AutoSize = true;
            lblDepartmentsSalaryAverage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartmentsSalaryAverage.ForeColor = Color.DarkSlateGray;
            lblDepartmentsSalaryAverage.Location = new Point(380, 20);
            lblDepartmentsSalaryAverage.Name = "lblDepartmentsSalaryAverage";
            lblDepartmentsSalaryAverage.Size = new Size(230, 28);
            lblDepartmentsSalaryAverage.TabIndex = 2;
            lblDepartmentsSalaryAverage.Text = "Ortalama Maaş: 0,00";
            lblDepartmentsSalaryAverage.BackColor = Color.Transparent;

            // 
            // cmbDepartments2
            // 
            cmbDepartments2.FormattingEnabled = true;
            cmbDepartments2.Location = new Point(20, 90);
            cmbDepartments2.Name = "cmbDepartments2";
            cmbDepartments2.Size = new Size(180, 35);
            cmbDepartments2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartments2.TabIndex = 3;
            cmbDepartments2.Text = "Departmanlar";
            cmbDepartments2.BackColor = Color.WhiteSmoke;
            cmbDepartments2.ForeColor = Color.DarkSlateGray;
            cmbDepartments2.FlatStyle = FlatStyle.Flat;
            cmbDepartments2.SelectedIndexChanged += cmbDepartments2_SelectedIndexChanged;

            // 
            // lstEmployeeList
            // 
            lstEmployeeList.FormattingEnabled = true;
            lstEmployeeList.ItemHeight = 15;
            lstEmployeeList.Location = new Point(210, 90);
            lstEmployeeList.Name = "lstEmployeeList";
            lstEmployeeList.Size = new Size(350, 150);
            lstEmployeeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstEmployeeList.TabIndex = 4;
            lstEmployeeList.BackColor = Color.WhiteSmoke;
            lstEmployeeList.ForeColor = Color.DarkSlateGray;
            lstEmployeeList.BorderStyle = BorderStyle.None;
            lstEmployeeList.SelectedIndexChanged += lstEmployeeList_SelectedIndexChanged;

            // 
            // dgwEmployeeDetails
            // 
            dgwEmployeeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployeeDetails.Location = new Point(210, 250);
            dgwEmployeeDetails.Name = "dgwEmployeeDetails";
            dgwEmployeeDetails.Size = new Size(450, 150);
            dgwEmployeeDetails.TabIndex = 5;
            dgwEmployeeDetails.BackgroundColor = Color.White;
            dgwEmployeeDetails.BorderStyle = BorderStyle.None;
            dgwEmployeeDetails.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgwEmployeeDetails.GridColor = Color.LightGray;
            dgwEmployeeDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgwEmployeeDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgwEmployeeDetails.DefaultCellStyle.ForeColor = Color.DarkSlateGray;

            // 
            // lblActiveEmp
            // 
            lblActiveEmp.AutoSize = true;
            lblActiveEmp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActiveEmp.ForeColor = Color.SeaGreen;
            lblActiveEmp.Location = new Point(12, 420);
            lblActiveEmp.Name = "lblActiveEmp";
            lblActiveEmp.Size = new Size(180, 28);
            lblActiveEmp.TabIndex = 6;
            lblActiveEmp.Text = "Aktif Çalışanlar: 0";

            // 
            // lblQuittingJob
            // 
            lblQuittingJob.AutoSize = true;
            lblQuittingJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuittingJob.ForeColor = Color.OrangeRed;
            lblQuittingJob.Location = new Point(200, 420);
            lblQuittingJob.Name = "lblQuittingJob";
            lblQuittingJob.Size = new Size(180, 28);
            lblQuittingJob.TabIndex = 7;
            lblQuittingJob.Text = "İşten Ayrılanlar: 0";

            // 
            // lblSalaryCount
            // 
            lblSalaryCount.AutoSize = true;
            lblSalaryCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryCount.ForeColor = Color.DeepSkyBlue;
            lblSalaryCount.Location = new Point(380, 420);
            lblSalaryCount.Name = "lblSalaryCount";
            lblSalaryCount.Size = new Size(235, 28);
            lblSalaryCount.TabIndex = 8;
            lblSalaryCount.Text = "Toplam Maaş Gideri: 0,00";

            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 480); // Boyutu arttırdık
            Controls.Add(lblSalaryCount);
            Controls.Add(lblQuittingJob);
            Controls.Add(lblActiveEmp);
            Controls.Add(dgwEmployeeDetails);
            Controls.Add(lstEmployeeList);
            Controls.Add(cmbDepartments2);
            Controls.Add(lblDepartmentsSalaryAverage);
            Controls.Add(lblEmployeeCount);
            Controls.Add(cmbDepartments);
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