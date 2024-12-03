using NtierArchitecture.Business.Services;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System.Data;

namespace NtierArchitecture.UI.Formlar
{
    public partial class PersonelForm : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeService _employeeService;
        private readonly DepartmentRepository _departmentRepository;
        private readonly DepartmentService _departmentService;

        public PersonelForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _employeeRepository = new EmployeeRepository(_context);
            _employeeService = new EmployeeService(_employeeRepository);
            _departmentRepository = new DepartmentRepository(_context);
            _departmentService = new DepartmentService(_departmentRepository);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string PName = txtName.Text;
                string PSurname = txtSurname.Text;
                string PTC = maskedtxtTC.Text;
                string PAdress = txtAdress.Text;
                string PTel = maskedtxtTC.Text;
                string PPassWord = maskedtxtPswrd.Text;

                if (cmbPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir departman seçiniz.");
                    return;
                }
                // MaskedTextBox'tan tarih verisini al ve kontrol et
                DateTime birthDate;
                if (DateTime.TryParse(maskedtxtBirth.Text, out birthDate))
                {

                    // Employee nesnesini oluştur
                    Employee employee = new Employee()
                    {
                        Name = PName,
                        Surname = PSurname,
                        TcNo = PTC,
                        BirthDate = birthDate,
                        Tel = PTel,
                        Department = selectDepartment,
                        Password = PPassWord,
                        Adress = PAdress

                    };
                    _employeeService.Create(employee);
                    MessageBox.Show("Kayıt Başarılı");
                    FormTemizle();
                }
                else
                {
                    MessageBox.Show("Geçerli bir doğum tarihi giriniz");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void FormTemizle()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            maskedtxtBirth.Text = "";
            maskedtxtTC.Text = "";
            maskedtxtPswrd.Text = "";
            maskedtxtTel.Text = "";
            txtAdress.Text = "";
            cmbPosition.SelectedItem = -1;
            txtName.Focus();
        }

        Department? selectDepartment;
        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex != -1)
            {
                selectDepartment = (Department?)cmbPosition.SelectedItem;

            }
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            GetAllData();

        }

        private void GetAllPersonelBySearchText(string searchText)
        {


            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 2)
            {
                // İsim, soyad veya TcNo'nun ilk iki harfi eşleşenleri filtrele
                var personalList = _employeeService
                    .GetAll()
                    .Where(p =>
                        (!string.IsNullOrEmpty(p.Name) && p.Name.StartsWith(searchText, StringComparison.OrdinalIgnoreCase)) ||
                        (!string.IsNullOrEmpty(p.Surname) && p.Surname.StartsWith(searchText, StringComparison.OrdinalIgnoreCase)) ||
                        (!string.IsNullOrEmpty(p.TcNo) && p.TcNo.StartsWith(searchText, StringComparison.OrdinalIgnoreCase)))
                    .ToList();

                // Listeyi Employee nesneleri ile doldur
                lstPersonelList.ValueMember = "Id";
                lstPersonelList.DisplayMember = "FullNameWithTc";  // FullName ve TcNo'yu birleştir
                lstPersonelList.DataSource = personalList;

                lstPersonelList.ClearSelected();
                lstPersonelList.SelectedIndex = -1;
            }
            else if (string.IsNullOrEmpty(searchText) || searchText.Length == 0)
            {

                // Eğer arama metni kısa veya boşsa, listeyi temizle
                lstPersonelList.DataSource = null;

            }
        }

        private void GetAllData()
        {
            cmbPosition.ValueMember = "Id";
            cmbPosition.DisplayMember = "Name";
            cmbPosition.DataSource = _departmentService.GetAll();
            cmbPosition.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetAllPersonelBySearchText(txtSearch.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Employee? selectedEmployee;
        private void lstPersonelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonelList.SelectedIndex != -1)
            {
                selectedEmployee = (Employee?)lstPersonelList.SelectedItem;

                if (selectedEmployee != null)
                {
                    txtName.Text = selectedEmployee.Name;
                    txtSurname.Text = selectedEmployee.Surname;
                    maskedtxtBirth.Text = selectedEmployee.BirthDate.ToString("dd-MM-yyyy");
                    maskedtxtTC.Text = selectedEmployee.TcNo;
                    maskedtxtPswrd.Text = selectedEmployee.Password;
                    maskedtxtTel.Text = selectedEmployee.Tel;
                    txtAdress.Text = selectedEmployee.Adress;
                    cmbPosition.SelectedItem = selectedEmployee.Department;
                }
                else if (selectedEmployee == null)

                {
                    // Liste öğesi seçilmediğinde textbox'ları temizle
                    txtName.Text = null;
                    txtSurname.Clear();
                    maskedtxtBirth.Clear();
                    maskedtxtTC.Clear();
                    maskedtxtPswrd.Clear();
                    maskedtxtTel.Clear();
                    txtAdress.Clear();
                    cmbPosition.SelectedIndex = -1;  // Departman seçimi kaldır
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedEmployee != null)
                {
                    selectedEmployee.Name = txtName.Text;
                    selectedEmployee.UpdateDate = DateTime.Now;
                    selectedEmployee.Surname = txtSurname.Text;
                    selectedEmployee.TcNo = maskedtxtTC.Text;
                    selectedEmployee.Password = maskedtxtPswrd.Text;
                    selectedEmployee.Tel = maskedtxtTel.Text;
                    selectedEmployee.Adress = txtAdress.Text;
                    selectedEmployee.Department = selectDepartment;
                    DateTime birthDate;
                    if (DateTime.TryParse(maskedtxtBirth.Text, out birthDate))
                    {
                        selectedEmployee.BirthDate = birthDate;
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir doğum tarihi giriniz.");
                        return;
                    }
                    _employeeService.Update(selectedEmployee);
                    MessageBox.Show("Kişi başarıyla güncellendi.");
                    FormTemizle();
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek bir çalışan seçin.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee != null)
                {
                    _employeeService.Delete(selectedEmployee.Id);
                    MessageBox.Show("Silme işlemi Başarılı.");
                    GetAllPersonelBySearchText(txtSearch.Text);
                    selectedEmployee = null;
                    FormTemizle();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

