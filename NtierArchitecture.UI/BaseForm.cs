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

		private void BaseForm_Load(object sender, EventArgs e)
		{

		}
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
			IzinForm Ifor = new IzinForm();
			FormKontrol(Ifor);
		}
		private void izinFormuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PersonelForm PerForm = new PersonelForm();
			FormKontrol(PerForm);
		}

		private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Departman DForm = new Departman();
			FormKontrol(DForm);
		}

		private void maaþFormuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MaasForm MForm = new MaasForm();
			FormKontrol(MForm);
		}

		private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Raporlar RForm = new Raporlar();
			FormKontrol(RForm);
		}

		private void izinOnayToolStripMenuItem_Click(object sender, EventArgs e)
		{
          IzinOnaylamaForm IoForm=new IzinOnaylamaForm();
			FormKontrol(IoForm);
		}
	}
}
