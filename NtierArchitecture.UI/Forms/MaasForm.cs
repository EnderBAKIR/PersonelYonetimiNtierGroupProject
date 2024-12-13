using NtierArchitecture.Business.Services;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NtierArchitecture.UI.Formlar
{
    public partial class MaasForm : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly EmployeeService _employeeService;
        private readonly EmployeeRepository employeeRepository;
        private void MaasForm_Load(object sender, EventArgs e) { }
        public MaasForm()
        {
            _dbContext = new ApplicationDbContext();
            employeeRepository = new EmployeeRepository(_dbContext);
            _employeeService = new EmployeeService(employeeRepository);
            InitializeComponent();
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            comboBox1.Items.Clear();
            var departments = _dbContext.Departments.Select(d => d.Name).ToList();
            comboBox1.Items.AddRange(departments.ToArray());
        }
        private void btnYenile_Click_1(object sender, EventArgs e)
        {
            string selectedDepartment = comboBox1.SelectedItem.ToString();
            string tcNo = tcmaskedbox.Text.Trim();
            string newSalaryText = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(selectedDepartment) || string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(newSalaryText))
            {
                MessageBox.Show("Lütfen departman, T.C. kimlik numarası ve maaş bilgilerini doldurunuz.");
                return;
            }
            if (double.TryParse(newSalaryText, out double newSalary))
            {
                using (var context = new ApplicationDbContext())
                {
                    var employee = context.Employees.FirstOrDefault(e => e.TcNo == tcNo);
                    if (employee != null)// T.C. kimlik numarasına göre çalışanı bul
                    {
                        var department = context.Departments.FirstOrDefault(d => d.Id == employee.DepartmentId);

                        if (department != null && department.Name == selectedDepartment)
                        {
                            employee.Salary = newSalary;
                            context.SaveChanges();
                            MessageBox.Show("Maaş başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Girilen T.C. kimlik numarası ve seçilen departman eşleşmiyor.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("T.C. kimlik numarasına sahip bir personel bulunamadı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir maaş giriniz.");
            }
        }
        private void btnPer_Click_1(object sender, EventArgs e)
        {
            string tcNo = txtmaskedTC.Text.Trim();
            if (string.IsNullOrWhiteSpace(tcNo))
            {
                MessageBox.Show("Lütfen T.C. kimlik numarasını giriniz.");
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var employee = context.Employees.FirstOrDefault(e => e.TcNo == tcNo);
                if (employee != null)
                {
                    var department = context.Departments.FirstOrDefault(d => d.Id == employee.DepartmentId);
                    LstPersonelBilgileri.Items.Clear();
                    LstPersonelBilgileri.Items.Add($"Ad: {employee.Name}");
                    LstPersonelBilgileri.Items.Add($"Soyad: {employee.Surname}");
                    LstPersonelBilgileri.Items.Add($"Departman: {department?.Name ?? "Belirtilmemiş"}");
                    LstPersonelBilgileri.Items.Add($"Maaş: {employee.Salary?.ToString("C")} ₺");
                }
                else
                {
                    MessageBox.Show("Personel bulunamadı.");
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
