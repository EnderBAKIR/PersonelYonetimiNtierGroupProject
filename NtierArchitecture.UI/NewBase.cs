using NtierArchitecture.UI.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtierArchitecture.UI.Forms
{
    public partial class NewBase : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public NewBase()
        {
            InitializeComponent();
            random = new Random();
            CustomizeDesign();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)

            {

                if (previousBtn.GetType() == typeof(Button))

                {

                    previousBtn.BackColor = Color.FromArgb(40, 45, 62);

                    previousBtn.ForeColor = Color.Gainsboro;

                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);

                }

            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Önceki formu kapat
            }
            ActivateButton(btnSender); // Seçilen butonu aktif hale getir
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(childForm);
            this.panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text; // Başlık güncellemesi
                                            // Form açıldığında alt menüyü gizle
            HideAllSubMenus();
        }
        private void btnPersonel_Click(object sender, EventArgs e)
        {

        }
        private void ToggleSubMenu(Panel subMenu)
        {
            // Alt menüyü görünür/kapat
            if (subMenu.Visible == false)
            {
                HideAllSubMenus(); // Tüm açık alt menüleri gizle
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;

                // Eğer bir form açıksa, alt menüyü kapatırken formu da kapatalım
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm = null;
                }
            }
        }

        private void HideAllSubMenus()
        {
            // Diğer alt menüleri gizlemek için
            panelSubMenuPersonel.Visible = false;
        }
        private void CustomizeDesign()
        {
            // Başlangıçta tüm alt menüler gizli
            panelSubMenuPersonel.Visible = false;
        }

        private void panelSubMenuPersonel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPersonelAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PersonelForm(), sender);

        }

        private void panelsubMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalaryAssignment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MaasForm(), sender);
        }

        private void btnSalaryTracking_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CalisanMaasTakibi(), sender);

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Departman(), sender);
        }

        private void btnPremision_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IzinForm(), sender);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.IzinOnaylamaForm(), sender);
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Raporlar(), sender);
        }
    }
}
