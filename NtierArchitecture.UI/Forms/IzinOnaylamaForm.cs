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
using static NtierArchitecture.UI.Formlar.IzinForm;

namespace NtierArchitecture.UI.Forms
{
    public partial class IzinOnaylamaForm : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly EmployeeService _employeeService;
        private readonly LeaveService _leaveService;
        public IzinOnaylamaForm()
        {
            InitializeComponent();

            _dbContext = new ApplicationDbContext();
            EmployeeRepository employeeRepository = new EmployeeRepository(_dbContext);
            LeaveRepository leaveRepository = new LeaveRepository(_dbContext);


            _employeeService = new EmployeeService(employeeRepository);
            _leaveService = new LeaveService(leaveRepository);
        }

        private void IzinOnaylamaForm_Load(object sender, EventArgs e)
        {

            var leaves = _leaveService.GetLeavesWithEmployee();


            var expiredLeaves = leaves.Where(l => l.EndDate < DateTime.Now).ToList();
            foreach (var leave in expiredLeaves)
            {
                leave.Status = LeaveStatus.Expired;
                _leaveService.Delete(leave.Id);
            }


            var activeLeaves = leaves.Where(l => l.Status == LeaveStatus.Pending && l.EndDate >= DateTime.Now).ToList();
            foreach (var leave in activeLeaves)
            {
                lstActiveLeaves.Items.Add(new ListItem
                {
                    Id = leave.Id.ToString(),
                    DisplayText = $"Çalışan Tcsi:: {leave.Employee.TcNo} / Tarih  ({leave.StartDate:dd.MM.yyyy} - {leave.EndDate:dd.MM.yyyy})"
                });
            }


            var finalizedLeaves = leaves.Where(l => l.Status == LeaveStatus.Approved || l.Status == LeaveStatus.Rejected).ToList();
            foreach (var leave in finalizedLeaves)
            {
                lstLeaves.Items.Add(new ListItem
                {
                    Id = leave.Id.ToString(),
                    DisplayText = $"Çalışan Tcsi: {leave.Employee.TcNo} / Tarih({leave.StartDate:dd.MM.yyyy} - {leave.EndDate:dd.MM.yyyy}) /({leave.Status})"
                });
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

        private void SelecItemForDGW()
        {
            if (lstActiveLeaves.SelectedItem is ListItem selectedItem)
            {

                Guid leaveId = Guid.Parse(selectedItem.Id);


                var leave = _leaveService.GetByID(leaveId);

                if (leave != null)
                {
                    string statusText = leave.Status switch
                    {
                        LeaveStatus.Pending => "Bekleniyor",
                        LeaveStatus.Approved => "Onaylandı",
                        LeaveStatus.Rejected => "Reddedildi",
                        LeaveStatus.Expired => "Süresi Geçti",

                    };

                    dgwLeaveDetails.DataSource = new List<object>
            {
                new
                {
                    İzinAçıklaması = leave.Description,
                    BaşlangıçTarihi = leave.StartDate.ToString("dd.MM.yyyy"),
                    BitişTarihi = leave.EndDate.ToString("dd.MM.yyyy"),
                    GünSayısı = leave.Day,
                    Durum = statusText
        }
    };


                    Employee employee = _employeeService.GetByID(leave.EmployeeId);

                    if (employee != null)
                    {

                        dgwEmployeeDetails.DataSource = new List<object>
                {
                    new
                    {
                        Ad = employee.Name,
                        Soyad = employee.Surname,
                        Şifre = employee.Password,
                        TCNo = employee.TcNo,
                        DoğumTarihi = employee.BirthDate.ToString("dd.MM.yyyy"),
                        Adres = employee.Adress,
                        Telefon = employee.Tel
                    }
                };
                    }
                }
            }
        }

        private void lstActiveLeaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecItemForDGW();
        }

        private void lstLeaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLeaves.SelectedItem is ListItem selectedItem)
            {

                Guid leaveId = Guid.Parse(selectedItem.Id);


                var leave = _leaveService.GetByID(leaveId);

                if (leave != null)
                {
                    string statusText = leave.Status switch
                    {
                        LeaveStatus.Pending => "Bekleniyor",
                        LeaveStatus.Approved => "Onaylandı",
                        LeaveStatus.Rejected => "Reddedildi",
                        LeaveStatus.Expired => "Süresi Geçti",

                    };

                    dgwLeaveDetails.DataSource = new List<object>
            {
                new
                {
                    İzinAçıklaması = leave.Description,
                    BaşlangıçTarihi = leave.StartDate.ToString("dd.MM.yyyy"),
                    BitişTarihi = leave.EndDate.ToString("dd.MM.yyyy"),
                    GünSayısı = leave.Day,
                    Durum = statusText
        }
    };


                    Employee employee = _employeeService.GetByID(leave.EmployeeId);

                    if (employee != null)
                    {

                        dgwEmployeeDetails.DataSource = new List<object>
                {
                    new
                    {
                        Ad = employee.Name,
                        Soyad = employee.Surname,
                        Şifre = employee.Password,
                        TCNo = employee.TcNo,
                        DoğumTarihi = employee.BirthDate.ToString("dd.MM.yyyy"),
                        Adres = employee.Adress,
                        Telefon = employee.Tel
                    }
                };
                    }
                }
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            if (lstActiveLeaves.SelectedItem is ListItem selectedItem)
            {
                // Seçili izin talebinin ID'sini al
                Guid leaveId = Guid.Parse(selectedItem.Id);

                // İzin talebini veritabanından al
                var leave = _leaveService.GetByID(leaveId);

                if (leave != null)
                {
                    // İzin talebinin durumunu "Onaylanmış" olarak güncelle
                    leave.Status = LeaveStatus.Approved;

                    // Veritabanını güncelle
                    _leaveService.Update(leave);  // Eğer `Update` metodu yoksa, burada eklemelisin

                    // İzin talebini lstActiveLeaves'den sil
                    lstActiveLeaves.Items.Remove(selectedItem);

                    // Onaylanmış izin talebini lstLeaves'e ekle
                    ListItem newItem = new ListItem
                    {
                        Id = leave.Id.ToString(),
                        DisplayText = $"Çalışan Tcsi: {leave.Employee.TcNo} / Tarih({leave.StartDate:dd.MM.yyyy} - {leave.EndDate:dd.MM.yyyy}) /({leave.Status})"
                    };
                    lstLeaves.Items.Add(newItem);
                }
                else
                {
                    MessageBox.Show("İzin talebi bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen aktif izin taleplerinden bir izin talebi seçin.");
            }
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            if (lstActiveLeaves.SelectedItem is ListItem selectedItem)
            {
                // Seçili izin talebinin ID'sini al
                Guid leaveId = Guid.Parse(selectedItem.Id);

                // İzin talebini veritabanından al
                var leave = _leaveService.GetByID(leaveId);

                if (leave != null)
                {
                    // İzin talebinin durumunu "Onaylanmış" olarak güncelle
                    leave.Status = LeaveStatus.Rejected;

                    // Veritabanını güncelle
                    _leaveService.Update(leave);  // Eğer `Update` metodu yoksa, burada eklemelisin

                    // İzin talebini lstActiveLeaves'den sil
                    lstActiveLeaves.Items.Remove(selectedItem);

                    // Onaylanmış izin talebini lstLeaves'e ekle
                    ListItem newItem = new ListItem
                    {
                        Id = leave.Id.ToString(),
                        DisplayText = $"Çalışan Tcsi: {leave.Employee.TcNo} / Tarih({leave.StartDate:dd.MM.yyyy} - {leave.EndDate:dd.MM.yyyy}) /({leave.Status})"
                    };
                    lstLeaves.Items.Add(newItem);
                }
                else
                {
                    MessageBox.Show("İzin talebi bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen aktif izin taleplerinden bir izin talebi seçin.");
            }
        }
    }
}



