using NtierArchitecture.Business.Services;
using NtierArchitecture.Business.Validators;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string PPassWord=maskedtxtPswrd.Text;


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
                         Adress= PAdress

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
            maskedtxtTel.Text ="";
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

        private void GetAllData()
        {
            cmbPosition.ValueMember = "Id";
            cmbPosition.DisplayMember = "Name";
            cmbPosition.DataSource = _departmentService.GetAll();
            cmbPosition.SelectedIndex = -1;
        }
    }
}
