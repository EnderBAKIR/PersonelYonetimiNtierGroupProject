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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chrtEmpByDepartment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chrtAvarageSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lstEmployees = new ListBox();
            dataGridView1 = new DataGridView();
            lblCompensation = new Label();
            dgwCompensation = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnCompensation = new Button();
            lblSalarySum = new Label();
            dgwEmployeeSalary = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            btnSalarySum = new Button();
            chrtIsActive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblIsactiveEmployeeSalaryAverage = new Label();
            lstLeaveList = new ListBox();
            label1 = new Label();
            btnLeaeList = new Button();
            dgwLeaveDetails = new DataGridView();
            dgwLeaveNowEmp = new DataGridView();
            lblLeaveNow = new Label();
            btnLeaveNow = new Button();
            btnExportEmployeesToExcel = new Button();
            btnExportEmployeesToPdf = new Button();
            btnSendEmail = new Button();
            btnVerifyCode = new Button();
            txtVerificationCode = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chrtEmpByDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtAvarageSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwCompensation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtIsActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveNowEmp).BeginInit();
            SuspendLayout();
            // 
            // chrtEmpByDepartment
            // 
            chartArea4.Name = "ChartArea1";
            chrtEmpByDepartment.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chrtEmpByDepartment.Legends.Add(legend4);
            chrtEmpByDepartment.Location = new Point(12, 12);
            chrtEmpByDepartment.Name = "chrtEmpByDepartment";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chrtEmpByDepartment.Series.Add(series4);
            chrtEmpByDepartment.Size = new Size(297, 214);
            chrtEmpByDepartment.TabIndex = 0;
            chrtEmpByDepartment.Text = "chrtEmpDepartment";
            chrtEmpByDepartment.Click += chrtEmpByDepartment_Click;
            // 
            // chrtAvarageSalary
            // 
            chartArea5.Name = "ChartArea1";
            chrtAvarageSalary.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chrtAvarageSalary.Legends.Add(legend5);
            chrtAvarageSalary.Location = new Point(710, 12);
            chrtAvarageSalary.Name = "chrtAvarageSalary";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 4;
            chrtAvarageSalary.Series.Add(series5);
            chrtAvarageSalary.Size = new Size(317, 214);
            chrtAvarageSalary.TabIndex = 1;
            chrtAvarageSalary.Text = "Departmanlara göre ortlama maaş";
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(315, 12);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(297, 214);
            lstEmployees.TabIndex = 2;
            lstEmployees.SelectedIndexChanged += lstEmployees_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 119);
            dataGridView1.TabIndex = 3;
            // 
            // lblCompensation
            // 
            lblCompensation.AutoSize = true;
            lblCompensation.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCompensation.ForeColor = Color.Red;
            lblCompensation.Location = new Point(12, 386);
            lblCompensation.Name = "lblCompensation";
            lblCompensation.Size = new Size(94, 40);
            lblCompensation.TabIndex = 4;
            lblCompensation.Text = "label1";
            // 
            // dgwCompensation
            // 
            dgwCompensation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCompensation.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgwCompensation.Location = new Point(12, 485);
            dgwCompensation.Name = "dgwCompensation";
            dgwCompensation.Size = new Size(600, 150);
            dgwCompensation.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "TC No";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "İşe Başlama Tarihi";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Maaş";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Tazminat";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnCompensation
            // 
            btnCompensation.Location = new Point(440, 452);
            btnCompensation.Name = "btnCompensation";
            btnCompensation.Size = new Size(172, 27);
            btnCompensation.TabIndex = 6;
            btnCompensation.Text = "Tazminat Listesini Güncelle";
            btnCompensation.UseVisualStyleBackColor = true;
            btnCompensation.Click += btnCompensation_Click;
            // 
            // lblSalarySum
            // 
            lblSalarySum.AutoSize = true;
            lblSalarySum.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSalarySum.ForeColor = Color.Red;
            lblSalarySum.Location = new Point(710, 232);
            lblSalarySum.Name = "lblSalarySum";
            lblSalarySum.Size = new Size(94, 40);
            lblSalarySum.TabIndex = 7;
            lblSalarySum.Text = "label1";
            // 
            // dgwEmployeeSalary
            // 
            dgwEmployeeSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployeeSalary.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dgwEmployeeSalary.Location = new Point(710, 276);
            dgwEmployeeSalary.Name = "dgwEmployeeSalary";
            dgwEmployeeSalary.Size = new Size(786, 150);
            dgwEmployeeSalary.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "TC No";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Doğum Tarihi";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "İşe Başlama Tarihi";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Maaş";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Departman";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // btnSalarySum
            // 
            btnSalarySum.Location = new Point(1316, 232);
            btnSalarySum.Name = "btnSalarySum";
            btnSalarySum.Size = new Size(172, 27);
            btnSalarySum.TabIndex = 9;
            btnSalarySum.Text = "Maaş Listesini Güncelle";
            btnSalarySum.UseVisualStyleBackColor = true;
            btnSalarySum.Click += btnSalarySum_Click;
            // 
            // chrtIsActive
            // 
            chartArea6.Name = "ChartArea1";
            chrtIsActive.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chrtIsActive.Legends.Add(legend6);
            chrtIsActive.Location = new Point(12, 641);
            chrtIsActive.Name = "chrtIsActive";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chrtIsActive.Series.Add(series6);
            chrtIsActive.Size = new Size(300, 300);
            chrtIsActive.TabIndex = 10;
            chrtIsActive.Text = "chart1";
            chrtIsActive.Click += chrtIsActive_Click;
            // 
            // lblIsactiveEmployeeSalaryAverage
            // 
            lblIsactiveEmployeeSalaryAverage.AutoSize = true;
            lblIsactiveEmployeeSalaryAverage.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblIsactiveEmployeeSalaryAverage.ForeColor = Color.Red;
            lblIsactiveEmployeeSalaryAverage.Location = new Point(12, 958);
            lblIsactiveEmployeeSalaryAverage.Name = "lblIsactiveEmployeeSalaryAverage";
            lblIsactiveEmployeeSalaryAverage.Size = new Size(425, 40);
            lblIsactiveEmployeeSalaryAverage.TabIndex = 11;
            lblIsactiveEmployeeSalaryAverage.Text = "Ortalama Maaş Çıkan/Çıkmayan";
            // 
            // lstLeaveList
            // 
            lstLeaveList.FormattingEnabled = true;
            lstLeaveList.ItemHeight = 15;
            lstLeaveList.Location = new Point(710, 485);
            lstLeaveList.Name = "lstLeaveList";
            lstLeaveList.Size = new Size(561, 184);
            lstLeaveList.TabIndex = 12;
            lstLeaveList.SelectedIndexChanged += lstLeaveList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(710, 439);
            label1.Name = "label1";
            label1.Size = new Size(244, 40);
            label1.TabIndex = 13;
            label1.Text = "Yapılan İzin Listesi";
            // 
            // btnLeaeList
            // 
            btnLeaeList.Location = new Point(1107, 455);
            btnLeaeList.Name = "btnLeaeList";
            btnLeaeList.Size = new Size(164, 23);
            btnLeaeList.TabIndex = 14;
            btnLeaeList.Text = "Listeyi Güncelle";
            btnLeaeList.UseVisualStyleBackColor = true;
            btnLeaeList.Click += btnLeaeList_Click;
            // 
            // dgwLeaveDetails
            // 
            dgwLeaveDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwLeaveDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwLeaveDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeaveDetails.Location = new Point(710, 675);
            dgwLeaveDetails.Name = "dgwLeaveDetails";
            dgwLeaveDetails.Size = new Size(642, 150);
            dgwLeaveDetails.TabIndex = 15;
            // 
            // dgwLeaveNowEmp
            // 
            dgwLeaveNowEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwLeaveNowEmp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwLeaveNowEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeaveNowEmp.Location = new Point(710, 886);
            dgwLeaveNowEmp.Name = "dgwLeaveNowEmp";
            dgwLeaveNowEmp.Size = new Size(642, 150);
            dgwLeaveNowEmp.TabIndex = 16;
            // 
            // lblLeaveNow
            // 
            lblLeaveNow.AutoSize = true;
            lblLeaveNow.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblLeaveNow.ForeColor = Color.Red;
            lblLeaveNow.Location = new Point(710, 843);
            lblLeaveNow.Name = "lblLeaveNow";
            lblLeaveNow.Size = new Size(343, 40);
            lblLeaveNow.TabIndex = 17;
            lblLeaveNow.Text = "Şuan İzinli Olan Çalışanlar";
            // 
            // btnLeaveNow
            // 
            btnLeaveNow.Location = new Point(1188, 857);
            btnLeaveNow.Name = "btnLeaveNow";
            btnLeaveNow.Size = new Size(164, 23);
            btnLeaveNow.TabIndex = 18;
            btnLeaveNow.Text = "Listeyi Güncelle";
            btnLeaveNow.UseVisualStyleBackColor = true;
            btnLeaveNow.Click += btnLeaveNow_Click;
            // 
            // btnExportEmployeesToExcel
            // 
            btnExportEmployeesToExcel.Location = new Point(1128, 12);
            btnExportEmployeesToExcel.Name = "btnExportEmployeesToExcel";
            btnExportEmployeesToExcel.Size = new Size(103, 23);
            btnExportEmployeesToExcel.TabIndex = 19;
            btnExportEmployeesToExcel.Text = "Excele Çıktı Al";
            btnExportEmployeesToExcel.UseVisualStyleBackColor = true;
            btnExportEmployeesToExcel.Click += btnExportEmployeesToExcel_Click;
            // 
            // btnExportEmployeesToPdf
            // 
            btnExportEmployeesToPdf.Location = new Point(1263, 12);
            btnExportEmployeesToPdf.Name = "btnExportEmployeesToPdf";
            btnExportEmployeesToPdf.Size = new Size(101, 23);
            btnExportEmployeesToPdf.TabIndex = 20;
            btnExportEmployeesToPdf.Text = "Pdfe Çıktı Al";
            btnExportEmployeesToPdf.UseVisualStyleBackColor = true;
            btnExportEmployeesToPdf.Click += btnExportEmployeesToPdf_Click;
            // 
            // btnSendEmail
            // 
            btnSendEmail.Location = new Point(1316, 165);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(133, 23);
            btnSendEmail.TabIndex = 22;
            btnSendEmail.Text = "Kod Gönder";
            btnSendEmail.UseVisualStyleBackColor = true;
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // btnVerifyCode
            // 
            btnVerifyCode.Location = new Point(1482, 137);
            btnVerifyCode.Name = "btnVerifyCode";
            btnVerifyCode.Size = new Size(190, 23);
            btnVerifyCode.TabIndex = 23;
            btnVerifyCode.Text = "Kodu Doğrula ve dosyaları çıkar";
            btnVerifyCode.UseVisualStyleBackColor = true;
            btnVerifyCode.Click += btnVerifyCode_Click;
            // 
            // txtVerificationCode
            // 
            txtVerificationCode.Location = new Point(1482, 166);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.Size = new Size(190, 23);
            txtVerificationCode.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(1128, 48);
            label2.Name = "label2";
            label2.Size = new Size(551, 80);
            label2.TabIndex = 25;
            label2.Text = "Yetki Kodunu İlgili Alana Girin Ve\r\n Veri Tabanı Dosya Formatlarını Yedekleyin";
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1809, 1061);
            Controls.Add(label2);
            Controls.Add(txtVerificationCode);
            Controls.Add(btnVerifyCode);
            Controls.Add(btnSendEmail);
            Controls.Add(btnExportEmployeesToPdf);
            Controls.Add(btnExportEmployeesToExcel);
            Controls.Add(btnLeaveNow);
            Controls.Add(lblLeaveNow);
            Controls.Add(dgwLeaveNowEmp);
            Controls.Add(dgwLeaveDetails);
            Controls.Add(btnLeaeList);
            Controls.Add(label1);
            Controls.Add(lstLeaveList);
            Controls.Add(lblIsactiveEmployeeSalaryAverage);
            Controls.Add(chrtIsActive);
            Controls.Add(btnSalarySum);
            Controls.Add(dgwEmployeeSalary);
            Controls.Add(lblSalarySum);
            Controls.Add(btnCompensation);
            Controls.Add(dgwCompensation);
            Controls.Add(lblCompensation);
            Controls.Add(dataGridView1);
            Controls.Add(lstEmployees);
            Controls.Add(chrtAvarageSalary);
            Controls.Add(chrtEmpByDepartment);
            Name = "Raporlar";
            Text = "Departman ve Çalışan Raporları";
            Load += Raporlar_Load_1;
            ((System.ComponentModel.ISupportInitialize)chrtEmpByDepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrtAvarageSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwCompensation).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrtIsActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveNowEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtEmpByDepartment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAvarageSalary;
        private ListBox lstEmployees;
        private DataGridView dataGridView1;
        private Label lblCompensation;
        private DataGridView dgwCompensation;
        private Button btnCompensation;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label lblSalarySum;
        private DataGridView dgwEmployeeSalary;
        private Button btnSalarySum;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIsActive;
        private Label lblIsactiveEmployeeSalaryAverage;
        private ListBox lstLeaveList;
        private Label label1;
        private Button btnLeaeList;
        private DataGridView dgwLeaveDetails;
        private DataGridView dgwLeaveNowEmp;
        private Label lblLeaveNow;
        private Button btnLeaveNow;
        private Button btnExportEmployeesToExcel;
        private Button btnExportEmployeesToPdf;
        private Button btnSendEmail;
        private Button btnVerifyCode;
        private TextBox txtVerificationCode;
        private Label label2;
    }
}