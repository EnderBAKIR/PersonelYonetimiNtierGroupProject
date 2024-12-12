using Krypton.Toolkit;
using NtierArchitecture.Business.Services;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;


namespace NtierArchitecture.UI.Formlar
{
    public partial class Departman : KryptonForm
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

            try
            {



                var departmentName = txtDepartmentName1.Text.Trim();
                if (string.IsNullOrWhiteSpace(departmentName))
                {
                    MessageBox.Show("Departman ismi boş olamaz.");
                    return;
                }
                var newDepartment = new Department { Name = departmentName };
                _departmentService.Create(newDepartment);

                MessageBox.Show($"Departman '{departmentName}' başarıyla eklendi.");
                LoadDepartments();
                txtDepartmentName1.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}");
            }
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
            try
            {



                if (lstDepartmants.SelectedItem is ListItem selectedItem)
                {
                    Guid departmentId = Guid.Parse(selectedItem.Id);
                    var newName = txtDepartmentName1.Text.Trim();

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
                        txtDepartmentName1.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Güncellemek için bir departman seçmelisiniz.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}");
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
                    txtDepartmentName1.Text = department.Name;
                }
            }
        }

        private void txtDepartmentName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


