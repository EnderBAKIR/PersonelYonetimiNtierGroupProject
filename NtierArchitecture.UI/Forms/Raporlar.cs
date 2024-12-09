using NtierArchitecture.Business.Services;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.IRepositories;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;


namespace NtierArchitecture.UI.Forms
{
    public partial class Raporlar : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService _employeeService;
        private readonly DepartmentRepository _departmentRepository;
        private readonly DepartmentService _departmentService;

        public Raporlar()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _employeeRepository = new EmployeeRepository(_context);
            _employeeService = new EmployeeService(_employeeRepository);
            _departmentRepository = new DepartmentRepository(_context);
            _departmentService = new DepartmentService(_departmentRepository);
        }

        private void Raporlar_Load_1(object sender, EventArgs e)
        {




            // DisplayMember ayarla
            cmbDepartments.DisplayMember = "DisplayText";
            cmbDepartments2.DisplayMember = "DisplayText";

            // Departmanları ComboBox'lara yükle
            var departments = _departmentService.GetAll();
            if (departments == null || !departments.Any())
            {
                MessageBox.Show("Departman listesi boş geldi!");
                return;
            }
            foreach (var department in departments)
            {
                var listItem = new ListItem
                {
                    Id = department.Id.ToString(),
                    DisplayText = $"{department.Name}"  // Departman adı ve kodu ekleyebiliriz
                };

                cmbDepartments.Items.Add(listItem);
                cmbDepartments2.Items.Add(listItem);
            }

            // İstatistikleri güncelle
            UpdateEmployeeStatistics();
            UpdateTotalSalary();
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartments.SelectedItem is ListItem selectedDepartment)
            {
                // Seçilen departman ID'sini al
                Guid departmentId = Guid.Parse(selectedDepartment.Id);

                // Departmana ait çalışanlar
                var employees = _employeeService.GetEmployeesByDepartmentId(departmentId);

                // Toplam çalışan sayısını güncelle
                lblEmployeeCount.Text = $"Çalışan sayısı: {employees.Count}";

                // Ortalama maaşı güncelle
                if (employees.Any())
                {
                    lblDepartmentsSalaryAverage.Text = $"Ortalama maaş: {employees.Average(e => e.Salary ?? 0):F2}";
                }
                else
                {
                    lblDepartmentsSalaryAverage.Text = "Departman için maaş verisi yok.";
                }
            }
        }

        private void cmbDepartments2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartments2.SelectedItem is ListItem selectedDepartment)
            {
                // Seçilen departman ID'sini al
                var departmentId = Guid.Parse(selectedDepartment.Id);

                // Departmana ait çalışanlar
                var employees = _employeeService.GetEmployeesByDepartmentId(departmentId);


                // Listeyi temizle ve yeni çalışanları ekle
                lstEmployeeList.Items.Clear();
                foreach (var employee in employees)
                {
                    lstEmployeeList.Items.Add(new ListItem
                    {
                        Id = employee.Id.ToString(),
                        DisplayText = $"{employee.Name + employee.Surname} - TC: {employee.TcNo}"  // Ad ve TC numarasını daha belirgin hale getirebiliriz
                    });
                }
            }
        }
       
        private void lstEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployeeList.SelectedItem is ListItem selectedEmployee)
            {
                // Seçilen çalışan ID'sini al
                var employeeId = Guid.Parse(selectedEmployee.Id);

                // Çalışan bilgilerini getir
                var employee = _employeeService.GetByID(employeeId);
                if (employee != null)
                {
                    // Detayları DataGridView'e anonim nesneler ile ekle
                    dgwEmployeeDetails.DataSource = new List<object>
                    {
                        new
                        {
                            Ad = employee.Name,
                            Soyad = employee.Surname,
                            Tc = employee.TcNo,
                            Telefon = employee.Tel,
                            DoğumTarihi = employee.BirthDate.ToShortDateString(),
                            Adres = employee.Adress,
                            Maaş = employee.Salary



                        }
                    };
                }

            }
        }

        private void UpdateEmployeeStatistics()
        {
            var employees = _employeeService.GetAll();

            // Aktif çalışan sayısını güncelle
            lblActiveEmp.Text = $"aktif çalışan sayısı: {employees.Count(e => e.IsActive)}";

            // İşten ayrılan çalışan sayısını güncelle
            lblQuittingJob.Text = $"İşten ayrılanlar: {employees.Count(e => !e.IsActive)}";
        }

        private void UpdateTotalSalary()
        {
            var employees = _employeeService.GetAll();

            // Toplam maaşı güncelle
            lblSalaryCount.Text = $"Toplam Maaş Gideri: {employees.Sum(e => e.Salary ?? 0):F2}";
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
    }
}
