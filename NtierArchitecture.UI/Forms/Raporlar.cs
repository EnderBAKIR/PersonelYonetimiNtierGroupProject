using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
using NtierArchitecture.Business.Services;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.IRepositories;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Document = iTextSharp.text.Document;
using Font = iTextSharp.text.Font;
using Microsoft.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Text;



namespace NtierArchitecture.UI.Forms
{
    public partial class Raporlar : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService _employeeService;
        private readonly DepartmentRepository _departmentRepository;
        private readonly DepartmentService _departmentService;
        private readonly LeaveService _leaveService;
        private readonly LeaveRepository _leaveRepository;
        private string verificationCode;
        public Raporlar()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _employeeRepository = new EmployeeRepository(_context);
            _employeeService = new EmployeeService(_employeeRepository);
            _departmentRepository = new DepartmentRepository(_context);
            _departmentService = new DepartmentService(_departmentRepository);

            _leaveRepository = new LeaveRepository(_context);
            _leaveService = new LeaveService(_leaveRepository);
        }

        private void Raporlar_Load_1(object sender, EventArgs e)
        {
            FillChartWithEmployeeData();
            FillChartWithAverageSalaryData();
            UpdateCompensationLabel();
            LoadCompensationDgw();
            UpdateSalaryCountLabel();
            LoadEmployeeSalaryDgw();
            LoadEmployeeStatusChart();
            LoadApprovedLeaves();
            LoadCurrentlyOnLeaveEmployees();
        }

        private void FillChartWithEmployeeData()
        {
            
            var departmentEmployeeCounts = _departmentService.GetAll()
                .Select(department => new
                {
                    DepartmentName = department.Name, 
                    EmployeeCount = _employeeService.GetEmployeesByDepartmentId(department.Id).Where(x => x.IsActive == true).Count() 
                })
                .ToList();

            
            chrtEmpByDepartment.Series.Clear();
            chrtEmpByDepartment.Titles.Clear();

            
            chrtEmpByDepartment.Titles.Add("Departmanlara Göre Çalışan Dağılımı");

            
            var series = new Series("Çalışanlar");
            series.ChartType = SeriesChartType.Pie; 

            
            foreach (var item in departmentEmployeeCounts)
            {
                series.Points.AddXY(item.DepartmentName, item.EmployeeCount);
            }

            
            chrtEmpByDepartment.Series.Add(series);

            
            series.IsValueShownAsLabel = true;
        }


        private void FillChartWithAverageSalaryData()
        {
            
            var departmentAverageSalaries = _departmentService.GetAll()
                .Select(department => new
                {
                    DepartmentName = department.Name, 
                    AverageSalary = department.Employees != null && department.Employees.Any()
                        ? Math.Round(department.Employees.Average(emp => emp.Salary ?? 0), 2) 
                        : 0
                })
                .Where(data => data.AverageSalary > 0) 
                .ToList();

            
            chrtAvarageSalary.Series.Clear();
            chrtAvarageSalary.Titles.Clear();
            chrtAvarageSalary.ChartAreas.Clear();

            
            chrtAvarageSalary.Titles.Add("Departmanlara Göre Ortalama Maaşlar");

            
            var chartArea = new ChartArea("DoughnutArea");
            chartArea.AxisX.Enabled = AxisEnabled.False; 
            chartArea.AxisY.Enabled = AxisEnabled.False; 
            chrtAvarageSalary.ChartAreas.Add(chartArea);

           
            var series = new Series("Ortalama Maaş");
            series.ChartType = SeriesChartType.Doughnut; 
            series.LabelFormat = "₺#,##0.00"; 
            series.IsValueShownAsLabel = true; 
            series.ToolTip = "#VALX: ₺#VALY"; 

            
            foreach (var item in departmentAverageSalaries)
            {
                
                series.Points.AddXY(item.DepartmentName, item.AverageSalary);
            }

           
            chrtAvarageSalary.Series.Add(series);

            
            series["PieLabelStyle"] = "Outside"; 
            series["DoughnutRadius"] = "60"; 

           
            var legend = new Legend("DepartmentLegend");
            legend.Docking = Docking.Bottom; 
            legend.Alignment = StringAlignment.Center; 
            chrtAvarageSalary.Legends.Add(legend);

           
            series.Legend = "DepartmentLegend"; 
        }

        private void chrtEmpByDepartment_Click(object sender, EventArgs e)
        {

            var chartArea = chrtEmpByDepartment.ChartAreas[0];
            var mousePosition = chrtEmpByDepartment.PointToClient(MousePosition);

           
            var hitTestResult = chrtEmpByDepartment.HitTest(mousePosition.X, mousePosition.Y);

            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                
                var dataPoint = hitTestResult.Series.Points[hitTestResult.PointIndex];

                
                string departmentName = dataPoint.AxisLabel;
                int employeeCount = Convert.ToInt32(dataPoint.YValues[0]);

                lstEmployees.Items.Clear();

                
                var employees = _employeeService.GetEmployeesByDepartmentName(departmentName); 

                
                foreach (var employee in employees)
                {
                    if (employee.IsActive == true)
                    {
                        var listItem = new ListItem
                        {
                            Id = employee.Id.ToString(),
                            DisplayText = employee.FullNameWithTc 
                        };
                        lstEmployees.Items.Add(listItem);
                    }

                }
            }
        }



        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstEmployees.SelectedItem != null)
            {
                var selectedItem = (ListItem)lstEmployees.SelectedItem;

                
                var employeeId = selectedItem.Id;

                
                var employee = _employeeService.GetByID(Guid.Parse(employeeId)); 


                
                dataGridView1.Rows.Clear();

               
                dataGridView1.AutoGenerateColumns = true;

                
                var employeeDetails = new BindingList<object>
        {
            new
            {
                employee.Name,
                employee.Surname,
                employee.TcNo,
                BirthDate = employee.BirthDate.ToString("dd.MM.yyyy"),
                employee.Salary,
                employee.Adress,
                employee.Tel,

                Department = employee.Department?.Name,


            }
        };

                
                dataGridView1.DataSource = employeeDetails;
            }

        }

        private void UpdateCompensationLabel()
        {
          
            var employeesWithCompensation = _employeeService.GetAll() 
                .Where(e => e.IsCompensationPayed) 
                .ToList();

            
            double totalCompensation = employeesWithCompensation.Sum(e => e.CompensationFee);

           
            lblCompensation.Text = $"Toplam Ödenen Tazminat: {totalCompensation:C2}";
        }

        private void btnCompensation_Click(object sender, EventArgs e)
        {
            LoadCompensationDgw();
        }
        private void LoadCompensationDgw()
        {
            
            var employeesWithCompensation = _employeeService.GetAll() 
                .Where(e => e.IsCompensationPayed) 
                .Select(e => new
                {
                    e.Name,
                    e.Surname,
                    e.TcNo,
                    e.BirthDate, 
                    e.Salary,
                    e.CompensationFee
                })
                .ToList();

            
            dgwCompensation.Rows.Clear();

            
            foreach (var employee in employeesWithCompensation)
            {
                dgwCompensation.Rows.Add(
                    employee.Name + " " + employee.Surname, 
                    employee.TcNo, 
                    employee.BirthDate.ToString("dd.MM.yyyy"), 
                    employee.Salary, 
                    employee.CompensationFee 
                );
            }
        }


        private void UpdateSalaryCountLabel()
        {
            var employees = _employeeService.GetAll().Where(x => x.IsActive == true).ToList();
            var employeesSalaryCount = employees.Sum(x => Convert.ToDouble(x.Salary));
            lblSalarySum.Text = $"Çalışanlar Toplam Maaş Gideri: {employeesSalaryCount}₺";
        }


        private void LoadEmployeeSalaryDgw()
        {
            
            var activeEmployees = _employeeService.GetAll() 
                .Where(e => e.IsActive) 
                .Select(e => new
                {
                    e.Name,
                    e.Surname,
                    e.TcNo,
                    e.BirthDate, 
                    e.CreateDate, 
                    e.Salary,
                    DepartmentName = e.Department.Name 
                })
                .ToList();

            
            dgwEmployeeSalary.Rows.Clear();

            
            foreach (var employee in activeEmployees)
            {
                dgwEmployeeSalary.Rows.Add(
                    employee.Name + " " + employee.Surname, 
                    employee.TcNo, 
                    employee.BirthDate.ToString("dd.MM.yyyy"), 
                    employee.CreateDate.ToString("dd.MM.yyyy"), 
                    employee.Salary, 
                    employee.DepartmentName 
                );
            }


        }

        private void btnSalarySum_Click(object sender, EventArgs e)
        {
            LoadEmployeeSalaryDgw();
        }




        private void LoadEmployeeStatusChart()
        {
            
            var activeEmployeesCount = _employeeService.GetAll().Count(e => e.IsActive);  
            var inactiveEmployeesCount = _employeeService.GetAll().Count(e => !e.IsActive); 

            // Chart ayarlarını temizle
            chrtIsActive.Series.Clear();
            chrtIsActive.Titles.Clear();

            // Chart başlığını ekle
            chrtIsActive.Titles.Add("İşten Çıkan ve Çıkmayan Çalışanlar");

            // Yeni bir Series oluştur
            var series = new Series("Çalışan Durumu");
            series.ChartType = SeriesChartType.Doughnut;  

            // Verileri Series'e ekle
            series.Points.AddXY("Çıkmayan Çalışanlar", activeEmployeesCount);  
            series.Points.AddXY("Çıkan Çalışanlar", inactiveEmployeesCount);   

            // Series'i Chart'a ekle
            chrtIsActive.Series.Add(series);

            // Grafiğin etiketlerini göster
            series.IsValueShownAsLabel = true;
        }

        private void chrtIsActive_Click(object sender, EventArgs e)
        {
            
            var chartArea = chrtIsActive.ChartAreas[0];
            var mousePosition = chrtIsActive.PointToClient(MousePosition);

            
            var hitTestResult = chrtIsActive.HitTest(mousePosition.X, mousePosition.Y);

            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                
                var dataPoint = hitTestResult.Series.Points[hitTestResult.PointIndex];

                
                string groupName = dataPoint.AxisLabel;

                
                double averageSalary = 0;

                if (groupName == "Çıkmayan Çalışanlar")
                {
                    
                    averageSalary = _employeeService.GetAll()
                        .Where(e => e.IsActive)
                        .Average(e => e.Salary ?? 0); 
                }
                else if (groupName == "Çıkan Çalışanlar")
                {
                    
                    averageSalary = _employeeService.GetAll()
                        .Where(e => !e.IsActive)
                        .Average(e => e.Salary ?? 0); 
                }

                // Sonucu label'a yazdır
                lblIsactiveEmployeeSalaryAverage.Text = $"{groupName} için Ortalama Maaş: {averageSalary:C}";
            }
        }


        private void LoadApprovedLeaves()
        {
            
            lstLeaveList.Items.Clear();

            
            var approvedLeaves = _leaveService.GetAll()
                .Where(leave => leave.Status == LeaveStatus.Approved)
                .ToList();

            foreach (var leave in approvedLeaves)
            {
                
                var employee = leave.Employee;

                if (employee != null)
                {
                    
                    var listItem = new ListItem
                    {
                        Id = leave.Id.ToString(),
                        DisplayText = $"İsim: {employee.Name} {employee.Surname}, TC: {employee.TcNo}, İzin Günleri: {leave.Day} gün"
                    };

                    
                    lstLeaveList.Items.Add(listItem);
                }
            }
        }


        private void btnLeaeList_Click(object sender, EventArgs e)
        {
            LoadApprovedLeaves();
        }

        private void lstLeaveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var selectedItem = lstLeaveList.SelectedItem as ListItem;
            if (selectedItem == null) return;

            
            var leave = _leaveService.GetAll()
                .FirstOrDefault(l => l.Id.ToString() == selectedItem.Id);

            if (leave != null)
            {
                
                var employee = leave.Employee;

                if (employee != null)
                {
                    
                    dgwLeaveDetails.Rows.Clear();
                    dgwLeaveDetails.Columns.Clear();

                    
                    dgwLeaveDetails.Columns.Add("NameSurname", "Ad Soyad");
                    dgwLeaveDetails.Columns.Add("TcNo", "TC Kimlik No");
                    dgwLeaveDetails.Columns.Add("Department", "Departman");
                    dgwLeaveDetails.Columns.Add("LeaveDays", "İzin Günleri");
                    dgwLeaveDetails.Columns.Add("StartDate", "Başlangıç Tarihi");
                    dgwLeaveDetails.Columns.Add("EndDate", "Bitiş Tarihi");

                    
                    dgwLeaveDetails.Rows.Add(
                        $"{employee.Name} {employee.Surname}", 
                        employee.TcNo,                        
                        employee.Department?.Name ?? "Bilinmiyor", 
                        leave.Day,                            
                        leave.StartDate.ToShortDateString(),  
                        leave.EndDate.ToShortDateString()     
                    );
                }
            }
        }

        private void LoadCurrentlyOnLeaveEmployees()
        {
            
            dgwLeaveNowEmp.Rows.Clear();
            dgwLeaveNowEmp.Columns.Clear();

           
            dgwLeaveNowEmp.Columns.Add("NameSurname", "Ad Soyad");
            dgwLeaveNowEmp.Columns.Add("TcNo", "TC Kimlik No");
            dgwLeaveNowEmp.Columns.Add("Department", "Departman");
            dgwLeaveNowEmp.Columns.Add("LeaveDays", "İzin Günleri");
            dgwLeaveNowEmp.Columns.Add("StartDate", "Başlangıç Tarihi");
            dgwLeaveNowEmp.Columns.Add("EndDate", "Bitiş Tarihi");

           
            var today = DateTime.Today;

            
            var currentlyOnLeave = _leaveService.GetAll()
                .Where(leave =>
                    leave.Status == LeaveStatus.Approved && 
                    leave.StartDate <= today &&            
                    leave.EndDate >= today)                
                .ToList();

            lblLeaveNow.Text = $"Şuan İzinli Olan Çalışan Sayısı: {currentlyOnLeave.Count()}";

           
            foreach (var leave in currentlyOnLeave)
            {
                var employee = leave.Employee;

                if (employee != null)
                {
                    dgwLeaveNowEmp.Rows.Add(
                        $"{employee.Name} {employee.Surname}", 
                        employee.TcNo,                        
                        employee.Department?.Name ?? "Bilinmiyor", 
                        leave.Day,                            
                        leave.StartDate.ToShortDateString(),  
                        leave.EndDate.ToShortDateString()     
                    );
                }
            }
        }
        private void btnLeaveNow_Click(object sender, EventArgs e)
        {
            LoadCurrentlyOnLeaveEmployees();
        }




        public class ListItem
        {
            public string Id { get; set; }
            public string DisplayText { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void btnExportEmployeesToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                
                var employees = _context.Employees
                    .Include(e => e.Department)
                    .Include(e => e.Leaves)
                    .Include(e => e.SalaryTrackings)
                    .ToList();

                
                var activeEmployees = employees.Where(e => e.IsActive).ToList();
                var inactiveEmployees = employees.Where(e => !e.IsActive).ToList();

                
                var totalActiveSalary = activeEmployees.Any() ? activeEmployees.Sum(e => e.Salary ?? 0) : 0;
                var averageActiveSalary = activeEmployees.Any() ? activeEmployees.Average(e => e.Salary ?? 0) : 0;
                var totalInactiveSalary = inactiveEmployees.Any() ? inactiveEmployees.Sum(e => e.Salary ?? 0) : 0;
                var averageInactiveSalary = inactiveEmployees.Any() ? inactiveEmployees.Average(e => e.Salary ?? 0) : 0;

                var totalActiveEmployees = activeEmployees.Count;
                var totalInactiveEmployees = inactiveEmployees.Count;

                var departmentGroups = employees
                    .GroupBy(e => e.Department?.Name ?? "Atanmamış")
                    .Select(g => new
                    {
                        DepartmentName = g.Key,
                        ActiveEmployeeCount = g.Count(e => e.IsActive),
                        InactiveEmployeeCount = g.Count(e => !e.IsActive),
                        AverageActiveDepartmentSalary = g.Any(e => e.IsActive) ? g.Where(e => e.IsActive).Average(e => e.Salary ?? 0) : 0,
                        AverageInactiveDepartmentSalary = g.Any(e => !e.IsActive) ? g.Where(e => !e.IsActive).Average(e => e.Salary ?? 0) : 0
                    })
                    .ToList();

                
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
                    saveFileDialog.Title = "Çalışan Bilgilerini Dışa Aktar";
                    saveFileDialog.FileName = $"Calisanlar_Raporu_{DateTime.Now:yyyyMMdd}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            
                            var employeesWorksheet = workbook.Worksheets.Add("Çalışanlar");

                            
                            employeesWorksheet.Cell(1, 1).Value = "Ad Soyad";
                            employeesWorksheet.Cell(1, 2).Value = "TC No";
                            employeesWorksheet.Cell(1, 3).Value = "Departman";
                            employeesWorksheet.Cell(1, 4).Value = "Maaş";
                            employeesWorksheet.Cell(1, 5).Value = "Doğum Tarihi";
                            employeesWorksheet.Cell(1, 6).Value = "İzin Günleri";
                            employeesWorksheet.Cell(1, 7).Value = "Tazminat Durumu";
                            employeesWorksheet.Cell(1, 8).Value = "Durum"; 

                            
                            employeesWorksheet.Row(1).Style.Font.Bold = true;

                            
                            for (int i = 0; i < employees.Count; i++)
                            {
                                var employee = employees[i];
                                employeesWorksheet.Cell(i + 2, 1).Value = $"{employee.Name} {employee.Surname}";
                                employeesWorksheet.Cell(i + 2, 2).Value = employee.TcNo;
                                employeesWorksheet.Cell(i + 2, 3).Value = employee.Department?.Name ?? "Atanmamış";
                                employeesWorksheet.Cell(i + 2, 4).Value = employee.Salary ?? 0;
                                employeesWorksheet.Cell(i + 2, 5).Value = employee.BirthDate.ToShortDateString();
                                employeesWorksheet.Cell(i + 2, 6).Value = employee.Leaves?.Sum(l => l.Day) ?? 0; 
                                employeesWorksheet.Cell(i + 2, 7).Value = employee.IsCompensationPayed ? "Ödendi" : "Ödenmedi";
                                employeesWorksheet.Cell(i + 2, 8).Value = employee.IsActive ? "Aktif" : "Pasif"; 
                            }

                            
                            employeesWorksheet.Columns().AdjustToContents();

                            
                            var summaryWorksheet = workbook.Worksheets.Add("Özet Bilgiler");

                            
                            summaryWorksheet.Cell(1, 1).Value = "Toplam Aktif Çalışan Sayısı";
                            summaryWorksheet.Cell(1, 2).Value = totalActiveEmployees;

                            summaryWorksheet.Cell(2, 1).Value = "Toplam Pasif Çalışan Sayısı";
                            summaryWorksheet.Cell(2, 2).Value = totalInactiveEmployees;

                            summaryWorksheet.Cell(3, 1).Value = "Toplam Aktif Maaş";
                            summaryWorksheet.Cell(3, 2).Value = totalActiveSalary;

                            summaryWorksheet.Cell(4, 1).Value = "Toplam Pasif Maaş";
                            summaryWorksheet.Cell(4, 2).Value = totalInactiveSalary;

                            summaryWorksheet.Cell(5, 1).Value = "Ortalama Aktif Maaş";
                            summaryWorksheet.Cell(5, 2).Value = averageActiveSalary;

                            summaryWorksheet.Cell(6, 1).Value = "Ortalama Pasif Maaş";
                            summaryWorksheet.Cell(6, 2).Value = averageInactiveSalary;

                            
                            summaryWorksheet.Cell(8, 1).Value = "Departman";
                            summaryWorksheet.Cell(8, 2).Value = "Aktif Çalışan Sayısı";
                            summaryWorksheet.Cell(8, 3).Value = "Pasif Çalışan Sayısı";
                            summaryWorksheet.Cell(8, 4).Value = "Aktif Ort. Maaş";
                            summaryWorksheet.Cell(8, 5).Value = "Pasif Ort. Maaş";
                            summaryWorksheet.Row(8).Style.Font.Bold = true;

                            for (int i = 0; i < departmentGroups.Count; i++)
                            {
                                var dept = departmentGroups[i];
                                summaryWorksheet.Cell(i + 9, 1).Value = dept.DepartmentName;
                                summaryWorksheet.Cell(i + 9, 2).Value = dept.ActiveEmployeeCount;
                                summaryWorksheet.Cell(i + 9, 3).Value = dept.InactiveEmployeeCount;
                                summaryWorksheet.Cell(i + 9, 4).Value = dept.AverageActiveDepartmentSalary;
                                summaryWorksheet.Cell(i + 9, 5).Value = dept.AverageInactiveDepartmentSalary;
                            }

                           
                            var leavesWorksheet = workbook.Worksheets.Add("İzin Bilgileri");

                            leavesWorksheet.Cell(1, 1).Value = "Çalışan Adı";
                            leavesWorksheet.Cell(1, 2).Value = "İzin Başlangıç";
                            leavesWorksheet.Cell(1, 3).Value = "İzin Bitiş";
                            leavesWorksheet.Cell(1, 4).Value = "İzin Günü";
                            leavesWorksheet.Cell(1, 5).Value = "Açıklama";
                            leavesWorksheet.Cell(1, 6).Value = "Durumu";
                            leavesWorksheet.Row(1).Style.Font.Bold = true;

                            int leaveRowIndex = 2;
                            foreach (var employee in employees)
                            {
                                if (employee.Leaves != null && employee.Leaves.Any())
                                {
                                    foreach (var leave in employee.Leaves)
                                    {
                                        leavesWorksheet.Cell(leaveRowIndex, 1).Value = $"{employee.Name} {employee.Surname}";
                                        leavesWorksheet.Cell(leaveRowIndex, 2).Value = leave.StartDate.ToShortDateString();
                                        leavesWorksheet.Cell(leaveRowIndex, 3).Value = leave.EndDate.ToShortDateString();
                                        leavesWorksheet.Cell(leaveRowIndex, 4).Value = leave.Day;
                                        leavesWorksheet.Cell(leaveRowIndex, 5).Value = leave.Description;
                                        leavesWorksheet.Cell(leaveRowIndex, 6).Value = leave.Status.ToString();
                                        leaveRowIndex++;
                                    }
                                }
                            }

                            leavesWorksheet.Columns().AdjustToContents();

                            
                            workbook.SaveAs(saveFileDialog.FileName);
                        }

                        MessageBox.Show("Detaylı Excel raporu başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnExportEmployeesToPdf_Click(object sender, EventArgs e)
        {
            try
            {
                
                var employees = _context.Employees
                    .Include(e => e.Department)
                    .Include(e => e.Leaves)
                    .Include(e => e.SalaryTrackings)
                    .ToList();

                
                var activeEmployees = employees.Where(e => e.IsActive).ToList();
                var inactiveEmployees = employees.Where(e => !e.IsActive).ToList();

                
                var totalActiveSalary = activeEmployees.Any() ? activeEmployees.Sum(e => e.Salary ?? 0) : 0;
                var averageActiveSalary = activeEmployees.Any() ? activeEmployees.Average(e => e.Salary ?? 0) : 0;
                var totalInactiveSalary = inactiveEmployees.Any() ? inactiveEmployees.Sum(e => e.Salary ?? 0) : 0;
                var averageInactiveSalary = inactiveEmployees.Any() ? inactiveEmployees.Average(e => e.Salary ?? 0) : 0;

                var totalActiveEmployees = activeEmployees.Count;
                var totalInactiveEmployees = inactiveEmployees.Count;

                var departmentGroups = employees
                    .GroupBy(e => e.Department?.Name ?? "Atanmamış")
                    .Select(g => new
                    {
                        DepartmentName = g.Key,
                        ActiveEmployeeCount = g.Count(e => e.IsActive),
                        InactiveEmployeeCount = g.Count(e => !e.IsActive),
                        AverageActiveDepartmentSalary = g.Any(e => e.IsActive) ? g.Where(e => e.IsActive).Average(e => e.Salary ?? 0) : 0,
                        AverageInactiveDepartmentSalary = g.Any(e => !e.IsActive) ? g.Where(e => !e.IsActive).Average(e => e.Salary ?? 0) : 0
                    })
                    .ToList();

               
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                    saveFileDialog.Title = "Çalışan Bilgilerini PDF Olarak Dışa Aktar";
                    saveFileDialog.FileName = $"Calisanlar_Raporu_{DateTime.Now:yyyyMMdd}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var pdfDoc = new Document())
                        {
                            PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                            pdfDoc.Open();

                            // Başlık
                            pdfDoc.Add(new Paragraph($"Çalışanlar Raporu - {DateTime.Now:yyyyMMdd}"));
                            pdfDoc.Add(new Paragraph("\n"));

                            // Çalışanlar Tablosu
                            var table = new PdfPTable(8) { WidthPercentage = 100 };
                            table.AddCell("Ad Soyad");
                            table.AddCell("TC No");
                            table.AddCell("Departman");
                            table.AddCell("Maaş");
                            table.AddCell("Doğum Tarihi");
                            table.AddCell("İzin Günleri");
                            table.AddCell("Tazminat Durumu");
                            table.AddCell("Durum");

                            foreach (var employee in employees)
                            {
                                table.AddCell($"{employee.Name} {employee.Surname}");
                                table.AddCell(employee.TcNo);
                                table.AddCell(employee.Department?.Name ?? "Atanmamış");
                                table.AddCell(employee.Salary?.ToString() ?? "0");
                                table.AddCell(employee.BirthDate.ToShortDateString());
                                table.AddCell((employee.Leaves?.Sum(l => l.Day) ?? 0).ToString());
                                table.AddCell(employee.IsCompensationPayed ? "Ödendi" : "Ödenmedi");
                                table.AddCell(employee.IsActive ? "Aktif" : "Pasif");
                            }

                            pdfDoc.Add(table);
                            pdfDoc.Add(new Paragraph("\n"));

                            
                            pdfDoc.Add(new Paragraph("Özet Bilgiler"));
                            pdfDoc.Add(new Paragraph($"Toplam Aktif Çalışan Sayısı: {totalActiveEmployees}"));
                            pdfDoc.Add(new Paragraph($"Toplam Pasif Çalışan Sayısı: {totalInactiveEmployees}"));
                            pdfDoc.Add(new Paragraph($"Toplam Aktif Maaş: {totalActiveSalary}"));
                            pdfDoc.Add(new Paragraph($"Toplam Pasif Maaş: {totalInactiveSalary}"));
                            pdfDoc.Add(new Paragraph($"Ortalama Aktif Maaş: {averageActiveSalary}"));
                            pdfDoc.Add(new Paragraph($"Ortalama Pasif Maaş: {averageInactiveSalary}"));

                            
                            pdfDoc.Add(new Paragraph("\nDepartman Özeti"));
                            var departmentTable = new PdfPTable(5) { WidthPercentage = 100 };
                            departmentTable.AddCell("Departman");
                            departmentTable.AddCell("Aktif Çalışan Sayısı");
                            departmentTable.AddCell("Pasif Çalışan Sayısı");
                            departmentTable.AddCell("Aktif Ort. Maaş");
                            departmentTable.AddCell("Pasif Ort. Maaş");

                            foreach (var dept in departmentGroups)
                            {
                                departmentTable.AddCell(dept.DepartmentName);
                                departmentTable.AddCell(dept.ActiveEmployeeCount.ToString());
                                departmentTable.AddCell(dept.InactiveEmployeeCount.ToString());
                                departmentTable.AddCell(dept.AverageActiveDepartmentSalary.ToString());
                                departmentTable.AddCell(dept.AverageInactiveDepartmentSalary.ToString());
                            }

                            pdfDoc.Add(departmentTable);

                            
                            pdfDoc.Add(new Paragraph("\nİzin Bilgileri"));
                            var leaveTable = new PdfPTable(6) { WidthPercentage = 100 };
                            leaveTable.AddCell("Çalışan Adı");
                            leaveTable.AddCell("İzin Başlangıç");
                            leaveTable.AddCell("İzin Bitiş");
                            leaveTable.AddCell("İzin Günü");
                            leaveTable.AddCell("Açıklama");
                            leaveTable.AddCell("Durumu");

                            foreach (var employee in employees)
                            {
                                if (employee.Leaves != null && employee.Leaves.Any())
                                {
                                    foreach (var leave in employee.Leaves)
                                    {
                                        leaveTable.AddCell($"{employee.Name} {employee.Surname}");
                                        leaveTable.AddCell(leave.StartDate.ToShortDateString());
                                        leaveTable.AddCell(leave.EndDate.ToShortDateString());
                                        leaveTable.AddCell(leave.Day.ToString());
                                        leaveTable.AddCell(leave.Description);
                                        leaveTable.AddCell(leave.Status.ToString());
                                    }
                                }
                            }

                            pdfDoc.Add(leaveTable);
                            pdfDoc.Close();
                        }

                        MessageBox.Show("Detaylı PDF raporu başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void ExportDatabaseToCsv(string connectionString, string query, string csvFilePath)
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    using (StreamWriter writer = new StreamWriter(csvFilePath))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                               
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    writer.Write(reader.GetName(i));
                                    if (i < reader.FieldCount - 1)
                                        writer.Write(",");
                                }
                                writer.WriteLine();

                                
                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        writer.Write(reader[i].ToString());
                                        if (i < reader.FieldCount - 1)
                                            writer.Write(",");
                                    }
                                    writer.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri dışa aktarma işlemi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSqlBackUp_Click(object sender, EventArgs e)
        {

            try
            {
                
                string connectionString = JsonConfigReader.GetConnectionString("EnderSql");

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Bağlantı dizesi alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var models = new Dictionary<string, string>
        {
            { "Department", "SELECT * FROM Departments" },
            { "Employee", "SELECT * FROM Employees" },
            { "Leave", "SELECT * FROM Leaves" },
            { "SalaryTracking", "SELECT * FROM SalaryTrackings" }
        };

               
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string directory = folderDialog.SelectedPath;

                        
                        foreach (var model in models)
                        {
                            string modelName = model.Key;
                            string query = model.Value;

                            
                            string csvFilePath = Path.Combine(directory, $"{modelName}_{DateTime.Now:yyyyMMdd_HHmmss}.csv");

                            
                            ExportDatabaseToCsv(connectionString, query, csvFilePath);
                        }

                       
                        MessageBox.Show("Veriler başarıyla CSV dosyasına aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SendVerificationEmail(string toEmail)
        {
            
            verificationCode = GenerateVerificationCode();

            
            string smtpServer = "smtp.gmail.com";  
            string smtpUser = "personelproje072@gmail.com";  
            string smtpPassword = "obsf usfy vnju ddeq";  
            string fromEmail = "personelproje072@gmail.com"; 

            
            string subject = "Doğrulama Kodu";
            string body = $"Merhaba,\n\nDoğrulama kodunuz: {verificationCode}\n\nKodla işlem yapabilirsiniz.";

            try
            {
                
                using (SmtpClient smtp = new SmtpClient(smtpServer))
                {
                    smtp.Credentials = new NetworkCredential(smtpUser, smtpPassword);
                    smtp.Port = 587; 
                    smtp.EnableSsl = true;

                    // E-posta mesajı
                    MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);

                    // E-posta gönder
                    smtp.Send(mail);
                    MessageBox.Show("Doğrulama kodu e-posta ile gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-posta gönderimi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateVerificationCode()
        {
            Random rand = new Random();
            StringBuilder code = new StringBuilder();
            for (int i = 0; i < 6; i++) 
            {
                code.Append(rand.Next(0, 10).ToString());
            }
            return code.ToString();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            
            string userEmail = "ender.bkrr@gmail.com";

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Lütfen e-posta adresini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            SendVerificationEmail(userEmail);
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            try
            {
                
                string userCode = txtVerificationCode.Text; 

                if (userCode == verificationCode)
                {
                    
                    MessageBox.Show("Doğrulama başarılı. Dosyalar aktarılıyor...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    string connectionString = JsonConfigReader.GetConnectionString("EnderSql");

                    if (string.IsNullOrEmpty(connectionString))
                    {
                        MessageBox.Show("Bağlantı dizesi alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Modeller ve ilgili sorgular
                    var models = new Dictionary<string, string>
            {
                { "Department", "SELECT * FROM Departments" },
                { "Employee", "SELECT * FROM Employees" },
                { "Leave", "SELECT * FROM Leaves" },
                { "SalaryTracking", "SELECT * FROM SalaryTrackings" }
            };

                    
                    using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                    {
                        if (folderDialog.ShowDialog() == DialogResult.OK)
                        {
                            string directory = folderDialog.SelectedPath;

                            
                            foreach (var model in models)
                            {
                                string modelName = model.Key;
                                string query = model.Value;

                               
                                string csvFilePath = Path.Combine(directory, $"{modelName}_{DateTime.Now:yyyyMMdd_HHmmss}.csv");

                                
                                ExportDatabaseToCsv(connectionString, query, csvFilePath);
                            }

                            
                            MessageBox.Show("Veriler başarıyla CSV dosyasına aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    
                    MessageBox.Show("Geçersiz doğrulama kodu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}







