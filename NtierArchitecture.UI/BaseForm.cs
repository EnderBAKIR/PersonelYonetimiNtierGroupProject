using NtierArchitecture.UI.Formlar;
using NtierArchitecture.UI.Forms;

namespace NtierArchitecture.UI
{
	public partial class BaseForm : Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

		private void BaseForm_Load(object sender, EventArgs e) {		}
		private void FormKontrol(Form frm)
		{
			bool acikMi = false;
			foreach (var item in Application.OpenForms)
			{
				if (item.GetType() == frm.GetType())
				{
					acikMi = true;
				}
			}

			if (acikMi)
			{
				MessageBox.Show("Form zaten açýk durumda.");
			}
			else
			{
				frm.Show();
			}

		}
		private void izinFormuToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MaasForm maasForm = new MaasForm();
			FormKontrol(maasForm);
		}
		private void izinFormuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PersonelForm PerForm = new PersonelForm();
			FormKontrol(PerForm);
		}
		private void çalýþanMaaþTakibiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CalisanMaasTakibi cmform = new CalisanMaasTakibi();
			FormKontrol(cmform);
		}
		private void departmanFormuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Departman DForm = new Departman();
			FormKontrol(DForm);
		}

		private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Raporlar RForm = new Raporlar();
			FormKontrol(RForm);
		}

		private void izinTalepToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IzinForm Iform = new IzinForm();
			FormKontrol(Iform);
		}

		private void izinOnaylamaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IzinOnaylamaForm IoForm = new IzinOnaylamaForm();
			FormKontrol(IoForm);
		}
	}
}
