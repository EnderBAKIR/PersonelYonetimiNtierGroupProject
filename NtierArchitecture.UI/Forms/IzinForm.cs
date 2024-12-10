using NtierArchitecture.Business.Services;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.Repositories;
using NtierArchitecture.Entities.Models;

namespace NtierArchitecture.UI.Formlar
{
    public partial class IzinForm : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly EmployeeService _employeeService;
        private readonly LeaveService _leaveService;


        public IzinForm()
        {
            InitializeComponent();

            _dbContext = new ApplicationDbContext();
            EmployeeRepository employeeRepository = new EmployeeRepository(_dbContext);
            LeaveRepository leaveRepository = new LeaveRepository(_dbContext);


            _employeeService = new EmployeeService(employeeRepository);
            _leaveService = new LeaveService(leaveRepository);

        }


        private void IzinForm_Load(object sender, EventArgs e)
        {

        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        Employee _employee;


        private void AddListItem(Guid employeeId)
        {
            employeeId = _employee.Id;
            var leaveRequests = _leaveService.GetLeaveRequestsByEmployeeId(employeeId);

            lstLeaveList.Items.Clear();
            foreach (var leaveRequest in leaveRequests)
            {
                if (leaveRequest.EndDate < DateTime.UtcNow)
                {
                    leaveRequest.Status = LeaveStatus.Expired;
                    _leaveService.Update(leaveRequest);
                }
                else
                {
                    var listItem = new ListItem
                    {
                        Id = leaveRequest.Id.ToString(),
                        DisplayText = $"Oluşturulma Tarihi :  {leaveRequest.CreateDate.ToShortDateString()} - Gün Sayısı :  {leaveRequest.Day} "
                    };


                    lstLeaveList.Items.Add(listItem);
                }


            }
        }
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            string tcNo = txtTc.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(tcNo) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen TC Numarası ve Şifreyi giriniz!");
                return;
            }


            _employee = _employeeService.GetEmployeeByTcAndPassword(tcNo, password);

            if (_employee != null)
            {
                LstBilgi.Items.Clear();
                LstBilgi.Items.Add($"Ad: {_employee.Name}");
                LstBilgi.Items.Add($"Soyad: {_employee.Surname}");
                LstBilgi.Items.Add($"Doğum Tarihi: {_employee.BirthDate.ToShortDateString()}");
                LstBilgi.Items.Add($"Telefon: {_employee.Tel}");

                //
                AddListItem(_employee.Id);
            }
            else
            {

                MessageBox.Show("Çalışan bulunamadı! Lütfen bilgilerinizi kontrol edin.");
                LstBilgi.Items.Clear();
            }
        }



        private void btnCreateLeave_Click(object sender, EventArgs e)
        {
            try
            {



                string leaveDescription = txtLeaveDescription.Text;
                int leaveDays = (int)nmrLeaveDay.Value;


                if (string.IsNullOrWhiteSpace(leaveDescription) || leaveDays <= 0)
                {
                    MessageBox.Show("Lütfen izin açıklamasını ve gün sayısını giriniz!");
                    return;
                }



                if (_employee != null)
                {
                    var anyLeave = _leaveService.GetLeaveRequestsByEmployeeId(_employee.Id)
                        .Where(leave => leave.EndDate >= DateTime.Today);

                    if (anyLeave.Any())
                    {
                        MessageBox.Show("Süresi geçmemiş bir izin talebiniz bulunuyor. Yeni bir izin talebi oluşturamazsınız.");
                    }
                    else
                    {
                        // Yeni izin talebi oluştur
                        var leaveRequest = new Leave
                        {
                            EmployeeId = _employee.Id,
                            Day = leaveDays,
                            Description = leaveDescription,
                            StartDate = dtStartDate.Value,
                            EndDate = dtEndDate.Value,
                            Status = LeaveStatus.Pending
                        };

                        _leaveService.Create(leaveRequest);

                        MessageBox.Show("İzin talebiniz başarıyla oluşturuldu.");

                        AddListItem(_employee.Id);
                    }
                }
                else
                {
                    MessageBox.Show("Çalışan bulunamadı! Lütfen bilgilerinizi kontrol edin.");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnLeaveCancel_Click(object sender, EventArgs e)
        {
            if (lstLeaveList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek istediğiniz izin talebini seçin.");
                return;
            }


            ListItem selectedItem = (ListItem)lstLeaveList.SelectedItem;

            if (selectedItem != null)
            {

                var leaveRequest = _leaveService.GetByID(Guid.Parse(selectedItem.Id));

                if (leaveRequest != null)
                {
                    if (leaveRequest.Status != LeaveStatus.Approved && leaveRequest.Status != LeaveStatus.Rejected)
                    {
                        _leaveService.Delete(leaveRequest.Id);


                        lstLeaveList.Items.Remove(selectedItem);

                        MessageBox.Show("İzin talebi başarıyla silindi.");
                    }
                    else
                    {
                        if (leaveRequest.Status == LeaveStatus.Approved)
                        {
                            MessageBox.Show("Onaylanmış izin talebi süresi geçene kadar silinemez");
                        }
                        if (leaveRequest.Status == LeaveStatus.Rejected)
                        {
                            MessageBox.Show("Reddedilmiş izin talebi süresi geçene kadar silinemez");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("İzin talebi bulunamadı.");
                }
            }
        }

        private void btnLeaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {



                if (lstLeaveList.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz izin talebini seçin.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLeaveDescription.Text))
                {
                    MessageBox.Show("Lütfen izin açıklamasını girin.");
                    return;
                }

                if (nmrLeaveDay.Value <= 0)
                {
                    MessageBox.Show("Lütfen izin gün sayısını girin.");
                    return;
                }

                
                ListItem selectedItem = (ListItem)lstLeaveList.SelectedItem;

                if (selectedItem != null)
                {
                    
                    var leaveRequest = _leaveService.GetByID(Guid.Parse(selectedItem.Id));

                    if (leaveRequest != null)
                    {
                        if (leaveRequest.Status != LeaveStatus.Approved && leaveRequest.Status != LeaveStatus.Rejected)
                        {
                            leaveRequest.Description = txtLeaveDescription.Text;
                            leaveRequest.Day = (int)nmrLeaveDay.Value;
                            leaveRequest.UpdateDate = DateTime.Now;
                            leaveRequest.StartDate = dtStartDate.Value;
                            leaveRequest.EndDate = dtEndDate.Value;

                            
                            _leaveService.Update(leaveRequest);

                            

                            selectedItem.DisplayText = $"Oluşturulma Tarihi :  {leaveRequest.CreateDate.ToShortDateString()} - Gün Sayısı :  {leaveRequest.Day} ";
                            lstLeaveList.Items[lstLeaveList.SelectedIndex] = selectedItem;

                            MessageBox.Show("İzin talebi başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Yanıtlanmış izin talepleri güncellenemez");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("İzin talebi bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}");
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

        private void lstLeaveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLeaveList.SelectedIndex != -1)
            {

                ListItem selectedItem = (ListItem)lstLeaveList.SelectedItem;

                if (selectedItem != null)
                {

                    var leaveRequest = _leaveService.GetByID(Guid.Parse(selectedItem.Id));

                    if (leaveRequest.Status == LeaveStatus.Pending)
                    {
                        lblDurum.Text = "Beklemede";
                    }
                    if (leaveRequest.Status == LeaveStatus.Approved)
                    {
                        lblDurum.Text = "Onaylandı";
                    }
                    if (leaveRequest.Status == LeaveStatus.Rejected)
                    {
                        lblDurum.Text = "Onaylanmadı";
                    }


                    txtLeaveDescription.Text = leaveRequest.Description;
                    nmrLeaveDay.Value = leaveRequest.Day;
                    dtStartDate.Value = leaveRequest.StartDate;
                    dtEndDate.Value = leaveRequest.EndDate;
                }
            }
        }


    }
}
