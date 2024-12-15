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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
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
            btnLeaeList = new Button();
            dgwLeaveDetails = new DataGridView();
            dgwLeaveNowEmp = new DataGridView();
            btnLeaveNow = new Button();
            btnExportEmployeesToExcel = new Button();
            btnExportEmployeesToPdf = new Button();
            btnSendEmail = new Button();
            btnVerifyCode = new Button();
            txtVerificationCode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label1 = new Label();
            groupBox6 = new GroupBox();
            lblLeaveNow = new Label();
            ((System.ComponentModel.ISupportInitialize)chrtEmpByDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtAvarageSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwCompensation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtIsActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveNowEmp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // chrtEmpByDepartment
            // 
            chartArea4.Name = "ChartArea1";
            chrtEmpByDepartment.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chrtEmpByDepartment.Legends.Add(legend4);
            chrtEmpByDepartment.Location = new Point(15, 22);
            chrtEmpByDepartment.Name = "chrtEmpByDepartment";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chrtEmpByDepartment.Series.Add(series4);
            chrtEmpByDepartment.Size = new Size(253, 184);
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
            chrtAvarageSalary.Location = new Point(13, 33);
            chrtAvarageSalary.Name = "chrtAvarageSalary";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 4;
            chrtAvarageSalary.Series.Add(series5);
            chrtAvarageSalary.Size = new Size(293, 214);
            chrtAvarageSalary.TabIndex = 1;
            chrtAvarageSalary.Text = "Departmanlara göre ortlama maaş";
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(274, 22);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(284, 184);
            lstEmployees.TabIndex = 2;
            lstEmployees.SelectedIndexChanged += lstEmployees_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 109);
            dataGridView1.TabIndex = 3;
            // 
            // lblCompensation
            // 
            lblCompensation.AutoSize = true;
            lblCompensation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCompensation.ForeColor = Color.FromArgb(64, 64, 64);
            lblCompensation.Location = new Point(6, 34);
            lblCompensation.Name = "lblCompensation";
            lblCompensation.Size = new Size(65, 25);
            lblCompensation.TabIndex = 4;
            lblCompensation.Text = "label1";
            // 
            // dgwCompensation
            // 
            dgwCompensation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCompensation.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgwCompensation.Location = new Point(6, 73);
            dgwCompensation.Name = "dgwCompensation";
            dgwCompensation.Size = new Size(546, 150);
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
            btnCompensation.Location = new Point(377, 40);
            btnCompensation.Name = "btnCompensation";
            btnCompensation.Size = new Size(175, 27);
            btnCompensation.TabIndex = 6;
            btnCompensation.Text = "Tazminat Listesini Güncelle";
            btnCompensation.UseVisualStyleBackColor = true;
            btnCompensation.Click += btnCompensation_Click;
            // 
            // lblSalarySum
            // 
            lblSalarySum.AutoSize = true;
            lblSalarySum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSalarySum.ForeColor = Color.FromArgb(64, 64, 64);
            lblSalarySum.Location = new Point(13, 253);
            lblSalarySum.Name = "lblSalarySum";
            lblSalarySum.Size = new Size(65, 25);
            lblSalarySum.TabIndex = 7;
            lblSalarySum.Text = "label1";
            // 
            // dgwEmployeeSalary
            // 
            dgwEmployeeSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployeeSalary.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dgwEmployeeSalary.Location = new Point(12, 290);
            dgwEmployeeSalary.Name = "dgwEmployeeSalary";
            dgwEmployeeSalary.Size = new Size(672, 137);
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
            btnSalarySum.AutoSize = true;
            btnSalarySum.BackColor = Color.DarkGoldenrod;
            btnSalarySum.FlatAppearance.BorderColor = Color.Goldenrod;
            btnSalarySum.FlatStyle = FlatStyle.Flat;
            btnSalarySum.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSalarySum.ForeColor = Color.Transparent;
            btnSalarySum.Location = new Point(525, 246);
            btnSalarySum.Name = "btnSalarySum";
            btnSalarySum.Size = new Size(159, 38);
            btnSalarySum.TabIndex = 9;
            btnSalarySum.Text = "Maaş Listesini Güncelle";
            btnSalarySum.UseVisualStyleBackColor = false;
            btnSalarySum.Click += btnSalarySum_Click;
            // 
            // chrtIsActive
            // 
            chartArea6.Name = "ChartArea1";
            chrtIsActive.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chrtIsActive.Legends.Add(legend6);
            chrtIsActive.Location = new Point(20, 22);
            chrtIsActive.Name = "chrtIsActive";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chrtIsActive.Series.Add(series6);
            chrtIsActive.Size = new Size(270, 227);
            chrtIsActive.TabIndex = 10;
            chrtIsActive.Text = "chart1";
            chrtIsActive.Click += chrtIsActive_Click;
            // 
            // lblIsactiveEmployeeSalaryAverage
            // 
            lblIsactiveEmployeeSalaryAverage.AutoSize = true;
            lblIsactiveEmployeeSalaryAverage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblIsactiveEmployeeSalaryAverage.ForeColor = Color.FromArgb(64, 64, 64);
            lblIsactiveEmployeeSalaryAverage.Location = new Point(31, 265);
            lblIsactiveEmployeeSalaryAverage.Name = "lblIsactiveEmployeeSalaryAverage";
            lblIsactiveEmployeeSalaryAverage.Size = new Size(27, 25);
            lblIsactiveEmployeeSalaryAverage.TabIndex = 11;
            lblIsactiveEmployeeSalaryAverage.Text = "...";
            // 
            // lstLeaveList
            // 
            lstLeaveList.FormattingEnabled = true;
            lstLeaveList.ItemHeight = 15;
            lstLeaveList.Location = new Point(13, 47);
            lstLeaveList.Name = "lstLeaveList";
            lstLeaveList.Size = new Size(672, 124);
            lstLeaveList.TabIndex = 12;
            lstLeaveList.SelectedIndexChanged += lstLeaveList_SelectedIndexChanged;
            // 
            // btnLeaeList
            // 
            btnLeaeList.AutoSize = true;
            btnLeaeList.BackColor = Color.DarkGoldenrod;
            btnLeaeList.FlatAppearance.BorderColor = Color.Peru;
            btnLeaeList.FlatStyle = FlatStyle.Flat;
            btnLeaeList.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLeaeList.ForeColor = Color.White;
            btnLeaeList.Location = new Point(521, 12);
            btnLeaeList.Name = "btnLeaeList";
            btnLeaeList.Size = new Size(164, 32);
            btnLeaeList.TabIndex = 14;
            btnLeaeList.Text = "Listeyi Güncelle";
            btnLeaeList.UseVisualStyleBackColor = false;
            btnLeaeList.Click += btnLeaeList_Click;
            // 
            // dgwLeaveDetails
            // 
            dgwLeaveDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwLeaveDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwLeaveDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeaveDetails.Location = new Point(13, 184);
            dgwLeaveDetails.Name = "dgwLeaveDetails";
            dgwLeaveDetails.Size = new Size(672, 125);
            dgwLeaveDetails.TabIndex = 15;
            // 
            // dgwLeaveNowEmp
            // 
            dgwLeaveNowEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwLeaveNowEmp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwLeaveNowEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeaveNowEmp.Location = new Point(6, 57);
            dgwLeaveNowEmp.Name = "dgwLeaveNowEmp";
            dgwLeaveNowEmp.Size = new Size(672, 131);
            dgwLeaveNowEmp.TabIndex = 16;
            // 
            // btnLeaveNow
            // 
            btnLeaveNow.BackColor = Color.DarkGoldenrod;
            btnLeaveNow.FlatAppearance.BorderColor = Color.Peru;
            btnLeaveNow.FlatStyle = FlatStyle.Flat;
            btnLeaveNow.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnLeaveNow.ForeColor = Color.Transparent;
            btnLeaveNow.Location = new Point(515, 18);
            btnLeaveNow.Name = "btnLeaveNow";
            btnLeaveNow.Size = new Size(164, 33);
            btnLeaveNow.TabIndex = 18;
            btnLeaveNow.Text = "Listeyi Güncelle";
            btnLeaveNow.UseVisualStyleBackColor = false;
            btnLeaveNow.Click += btnLeaveNow_Click;
            // 
            // btnExportEmployeesToExcel
            // 
            btnExportEmployeesToExcel.AutoSize = true;
            btnExportEmployeesToExcel.BackColor = Color.FromArgb(114, 114, 114);
            btnExportEmployeesToExcel.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnExportEmployeesToExcel.FlatStyle = FlatStyle.Flat;
            btnExportEmployeesToExcel.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExportEmployeesToExcel.ForeColor = Color.White;
            btnExportEmployeesToExcel.Image = (Image)resources.GetObject("btnExportEmployeesToExcel.Image");
            btnExportEmployeesToExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportEmployeesToExcel.Location = new Point(324, 33);
            btnExportEmployeesToExcel.Name = "btnExportEmployeesToExcel";
            btnExportEmployeesToExcel.Size = new Size(100, 42);
            btnExportEmployeesToExcel.TabIndex = 19;
            btnExportEmployeesToExcel.Text = " Çıktı Al";
            btnExportEmployeesToExcel.TextAlign = ContentAlignment.MiddleLeft;
            btnExportEmployeesToExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportEmployeesToExcel.UseVisualStyleBackColor = false;
            btnExportEmployeesToExcel.Click += btnExportEmployeesToExcel_Click;
            // 
            // btnExportEmployeesToPdf
            // 
            btnExportEmployeesToPdf.AutoSize = true;
            btnExportEmployeesToPdf.BackColor = Color.FromArgb(114, 114, 114);
            btnExportEmployeesToPdf.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnExportEmployeesToPdf.FlatStyle = FlatStyle.Flat;
            btnExportEmployeesToPdf.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExportEmployeesToPdf.ForeColor = Color.White;
            btnExportEmployeesToPdf.Image = (Image)resources.GetObject("btnExportEmployeesToPdf.Image");
            btnExportEmployeesToPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportEmployeesToPdf.Location = new Point(447, 33);
            btnExportEmployeesToPdf.Name = "btnExportEmployeesToPdf";
            btnExportEmployeesToPdf.Size = new Size(94, 42);
            btnExportEmployeesToPdf.TabIndex = 20;
            btnExportEmployeesToPdf.Text = "Çıktı Al";
            btnExportEmployeesToPdf.TextAlign = ContentAlignment.MiddleLeft;
            btnExportEmployeesToPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportEmployeesToPdf.UseVisualStyleBackColor = false;
            btnExportEmployeesToPdf.Click += btnExportEmployeesToPdf_Click;
            // 
            // btnSendEmail
            // 
            btnSendEmail.AutoSize = true;
            btnSendEmail.BackColor = Color.FromArgb(124, 124, 124);
            btnSendEmail.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnSendEmail.FlatStyle = FlatStyle.Flat;
            btnSendEmail.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSendEmail.ForeColor = Color.White;
            btnSendEmail.Image = (Image)resources.GetObject("btnSendEmail.Image");
            btnSendEmail.Location = new Point(324, 162);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(121, 32);
            btnSendEmail.TabIndex = 22;
            btnSendEmail.Text = "Kod Gönder";
            btnSendEmail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSendEmail.UseVisualStyleBackColor = false;
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // btnVerifyCode
            // 
            btnVerifyCode.AutoSize = true;
            btnVerifyCode.BackColor = Color.DarkGreen;
            btnVerifyCode.FlatAppearance.BorderColor = Color.Green;
            btnVerifyCode.FlatStyle = FlatStyle.Flat;
            btnVerifyCode.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnVerifyCode.ForeColor = Color.Transparent;
            btnVerifyCode.Location = new Point(324, 200);
            btnVerifyCode.Name = "btnVerifyCode";
            btnVerifyCode.Size = new Size(211, 40);
            btnVerifyCode.TabIndex = 23;
            btnVerifyCode.Text = "Kodu Doğrula ve dosyaları çıkar";
            btnVerifyCode.UseVisualStyleBackColor = false;
            btnVerifyCode.Click += btnVerifyCode_Click;
            // 
            // txtVerificationCode
            // 
            txtVerificationCode.Location = new Point(451, 167);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.Size = new Size(190, 23);
            txtVerificationCode.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(324, 90);
            label2.Name = "label2";
            label2.Size = new Size(285, 23);
            label2.TabIndex = 25;
            label2.Text = "Yetki Kodunu İlgili Alana Girin Ve\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(324, 120);
            label3.Name = "label3";
            label3.Size = new Size(361, 23);
            label3.TabIndex = 26;
            label3.Text = "Veri Tabanı Dosya Formatlarını Yedekleyin";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chrtEmpByDepartment);
            groupBox1.Controls.Add(lstEmployees);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 349);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Departmana Göre Çalışan Listeleme";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwCompensation);
            groupBox2.Controls.Add(lblCompensation);
            groupBox2.Controls.Add(btnCompensation);
            groupBox2.Location = new Point(31, 367);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 233);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tazminat Bilgilendirme";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chrtIsActive);
            groupBox3.Controls.Add(lblIsactiveEmployeeSalaryAverage);
            groupBox3.Location = new Point(30, 618);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(567, 330);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "Çalışan Ve İşten Çıkan Personellerin Ortalama Maaş Bilgilendirmesi";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chrtAvarageSalary);
            groupBox4.Controls.Add(lblSalarySum);
            groupBox4.Controls.Add(dgwEmployeeSalary);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(btnSalarySum);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(btnExportEmployeesToExcel);
            groupBox4.Controls.Add(txtVerificationCode);
            groupBox4.Controls.Add(btnExportEmployeesToPdf);
            groupBox4.Controls.Add(btnVerifyCode);
            groupBox4.Controls.Add(btnSendEmail);
            groupBox4.Location = new Point(621, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(707, 436);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "Departmanlara Göre Maaş Raporu";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(lstLeaveList);
            groupBox5.Controls.Add(btnLeaeList);
            groupBox5.Controls.Add(dgwLeaveDetails);
            groupBox5.Location = new Point(620, 454);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(707, 327);
            groupBox5.TabIndex = 32;
            groupBox5.TabStop = false;
            groupBox5.Text = "İzin Geçmişi Raporu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 16;
            label1.Text = "Yapılan İzin Listesi";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblLeaveNow);
            groupBox6.Controls.Add(dgwLeaveNowEmp);
            groupBox6.Controls.Add(btnLeaveNow);
            groupBox6.Location = new Point(621, 787);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(701, 201);
            groupBox6.TabIndex = 33;
            groupBox6.TabStop = false;
            groupBox6.Text = "Şuan İzinli Olan Çalışanlar";
            // 
            // lblLeaveNow
            // 
            lblLeaveNow.AutoSize = true;
            lblLeaveNow.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblLeaveNow.ForeColor = Color.Teal;
            lblLeaveNow.Location = new Point(8, 26);
            lblLeaveNow.Name = "lblLeaveNow";
            lblLeaveNow.Size = new Size(240, 25);
            lblLeaveNow.TabIndex = 17;
            lblLeaveNow.Text = "Şuan İzinli Olan Çalışanlar";
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1340, 984);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
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
        private Button btnLeaeList;
        private DataGridView dgwLeaveDetails;
        private DataGridView dgwLeaveNowEmp;
        private Button btnLeaveNow;
        private Button btnExportEmployeesToExcel;
        private Button btnExportEmployeesToPdf;
        private Button btnSendEmail;
        private Button btnVerifyCode;
        private TextBox txtVerificationCode;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label lblLeaveNow;
        private Label label1;
    }
}