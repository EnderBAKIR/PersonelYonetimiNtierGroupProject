using NtierArchitecture.Business.Services;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NtierArchitecture.UI.Formlar
{
    public partial class Departman : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly DepartmentRepository _departmentRepository;
        private readonly DepartmentService _departmentService;
        public Departman()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _departmentRepository = new DepartmentRepository(_context);
            _departmentService = new DepartmentService(_departmentRepository);
        }
        private void AddDepart_Click(object sender, EventArgs e)
        {
            var departmentName = txtDepartmanName.Text.Trim();
            if (string.IsNullOrWhiteSpace(departmentName))
            {
                MessageBox.Show("Departman ismi boş olamaz.");
                return;
            }
            var newDepartment = new Department { Name = departmentName };
            _departmentService.Create(newDepartment);

            MessageBox.Show($"Departman '{departmentName}' başarıyla eklendi.");
            LoadDepartments();
            txtDepartmanName.Clear();
        }
        private void LoadDepartments()
        {
            lstDepartmants.Items.Clear();
            var departments = _departmentService.GetAll();
            foreach (var department in departments)
            {
                var item = new ListItem
                {
                    Id = department.Id.ToString(),
                    DisplayText = department.Name
                };
                lstDepartmants.Items.Add(item);
            }

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

        private void Departman_Load(object sender, EventArgs e)
        {

        }

        private void DepartmantsShow_Click(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDepartmants.SelectedItem is ListItem selectedItem)
            {
                Guid departmentId = Guid.Parse(selectedItem.Id);
                _departmentService.Delete(departmentId);

                MessageBox.Show($"Departman '{selectedItem.DisplayText}' başarıyla silindi.");

                LoadDepartments();
            }
            else
            {
                MessageBox.Show("Silmek için bir departman seçmelisiniz.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstDepartmants.SelectedItem is ListItem selectedItem)
            {
                Guid departmentId = Guid.Parse(selectedItem.Id);
                var newName = txtDepartmanName.Text.Trim();

                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Departman ismi boş olamaz.");
                    return;
                }

                var department = _departmentService.GetByID(departmentId);
                if (department != null)
                {
                    var oldName = department.Name;
                    department.Name = newName;
                    _departmentService.Update(department);

                    MessageBox.Show($"Departman   güncellendi");

                    LoadDepartments();
                    txtDepartmanName.Clear();
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir departman seçmelisiniz.");
            }
        }

        private void lstDepartmants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDepartmants.SelectedItem is ListItem selectedItem)
            {
                Guid departmentId = Guid.Parse(selectedItem.Id);
                var department = _departmentService.GetByID(departmentId);

                if (department != null)
                {
                    txtDepartmanName.Text = department.Name;
                }
            }
        }
    }
}
   

