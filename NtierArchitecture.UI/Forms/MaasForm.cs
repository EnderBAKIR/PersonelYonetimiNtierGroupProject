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

		public MaasForm()
		{
			_dbContext = new ApplicationDbContext();
			EmployeeRepository employeeRepository = new EmployeeRepository(_dbContext);
			_employeeService = new EmployeeService(employeeRepository);

			InitializeComponent();
			AddSampleDepartment();
			LoadDepartmentsIntoComboBox();
		}
		private void MaasForm_Load(object sender, EventArgs e) { }
		private void AddSampleDepartment()
		{
			using (var context = new ApplicationDbContext())
			{
				if (!context.Departments.Any(d => d.Name == "Bilgi Teknolojileri"))
				{
					var department = new Department
					{
						Id = Guid.NewGuid(),
						Name = "Bilgi Teknolojileri"
					};
					context.Departments.Add(department);
					context.SaveChanges();
				}
			}
		}
		private void LoadDepartmentsIntoComboBox()
		{
			comboBox1.Items.Clear();
			var departments = _dbContext.Departments.Select(d => d.Name).ToList();
			comboBox1.Items.AddRange(departments.ToArray());
		}
		private void btnYenile_Click_1(object sender, EventArgs e)
		{
			var selectedDepartment = comboBox1.SelectedItem?.ToString();
			if (string.IsNullOrEmpty(selectedDepartment) && string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Lütfen departman ve maaş bilgilerini doldurunuz.");
				return;
			}

			if (double.TryParse(textBox2.Text, out double newSalary))
			{
				using (var context = new ApplicationDbContext())
				{
					// Seçili departmanı ve çalışanları al
					var department = context.Departments.FirstOrDefault(d => d.Name == selectedDepartment);
					if (department != null)
					{
						var employees = context.Employees.Where(e => e.DepartmentId == department.Id).ToList();
						if (employees.Any())
						{
							// Maaşları güncelle
							foreach (var employee in employees)
							{
								employee.Salary = newSalary;
							}
							context.SaveChanges();
							MessageBox.Show("Maaşlar güncellendi.");
						}
						else
						{
							MessageBox.Show("Bu departmanda çalışan bulunamadı.");
						}
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
	}
}
