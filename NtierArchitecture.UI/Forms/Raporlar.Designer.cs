namespace NtierArchitecture.UI.Forms
{
    partial class Raporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbDepartman = new ComboBox();
            lblCalisanSayisi = new Label();
            lblOrtalamaMaas = new Label();
            cmbDepartman2 = new ComboBox();
            lstDepartman = new ListBox();
            dgwDepartman = new DataGridView();
            lblAktifCalisan = new Label();
            lblIstenAyrilan = new Label();
            lblToplamFirmaMaasGideri = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwDepartman).BeginInit();
            SuspendLayout();
            // 
            // cmbDepartman
            // 
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(23, 12);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(137, 23);
            cmbDepartman.TabIndex = 0;
            cmbDepartman.Text = "Departmanlar";
            // 
            // lblCalisanSayisi
            // 
            lblCalisanSayisi.AutoSize = true;
            lblCalisanSayisi.Location = new Point(177, 15);
            lblCalisanSayisi.Name = "lblCalisanSayisi";
            lblCalisanSayisi.Size = new Size(77, 15);
            lblCalisanSayisi.TabIndex = 1;
            lblCalisanSayisi.Text = "Çalışan Sayısı";
            // 
            // lblOrtalamaMaas
            // 
            lblOrtalamaMaas.AutoSize = true;
            lblOrtalamaMaas.Location = new Point(260, 15);
            lblOrtalamaMaas.Name = "lblOrtalamaMaas";
            lblOrtalamaMaas.Size = new Size(87, 15);
            lblOrtalamaMaas.TabIndex = 2;
            lblOrtalamaMaas.Text = "Ortalama Maaş";
            // 
            // cmbDepartman2
            // 
            cmbDepartman2.FormattingEnabled = true;
            cmbDepartman2.Location = new Point(23, 84);
            cmbDepartman2.Name = "cmbDepartman2";
            cmbDepartman2.Size = new Size(121, 23);
            cmbDepartman2.TabIndex = 3;
            cmbDepartman2.Text = "Departmanlar";
            // 
            // lstDepartman
            // 
            lstDepartman.FormattingEnabled = true;
            lstDepartman.ItemHeight = 15;
            lstDepartman.Location = new Point(177, 84);
            lstDepartman.Name = "lstDepartman";
            lstDepartman.Size = new Size(277, 124);
            lstDepartman.TabIndex = 4;
            // 
            // dgwDepartman
            // 
            dgwDepartman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDepartman.Location = new Point(177, 214);
            dgwDepartman.Name = "dgwDepartman";
            dgwDepartman.Size = new Size(383, 124);
            dgwDepartman.TabIndex = 5;
            // 
            // lblAktifCalisan
            // 
            lblAktifCalisan.AutoSize = true;
            lblAktifCalisan.Location = new Point(12, 389);
            lblAktifCalisan.Name = "lblAktifCalisan";
            lblAktifCalisan.Size = new Size(73, 15);
            lblAktifCalisan.TabIndex = 6;
            lblAktifCalisan.Text = "Aktif Çalışan";
            // 
            // lblIstenAyrilan
            // 
            lblIstenAyrilan.AutoSize = true;
            lblIstenAyrilan.Location = new Point(113, 389);
            lblIstenAyrilan.Name = "lblIstenAyrilan";
            lblIstenAyrilan.Size = new Size(72, 15);
            lblIstenAyrilan.TabIndex = 7;
            lblIstenAyrilan.Text = "İşten Ayrılan";
            // 
            // lblToplamFirmaMaasGideri
            // 
            lblToplamFirmaMaasGideri.AutoSize = true;
            lblToplamFirmaMaasGideri.Location = new Point(225, 389);
            lblToplamFirmaMaasGideri.Name = "lblToplamFirmaMaasGideri";
            lblToplamFirmaMaasGideri.Size = new Size(144, 15);
            lblToplamFirmaMaasGideri.TabIndex = 8;
            lblToplamFirmaMaasGideri.Text = "Toplam Firma Maaş Gideri";
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 441);
            Controls.Add(lblToplamFirmaMaasGideri);
            Controls.Add(lblIstenAyrilan);
            Controls.Add(lblAktifCalisan);
            Controls.Add(dgwDepartman);
            Controls.Add(lstDepartman);
            Controls.Add(cmbDepartman2);
            Controls.Add(lblOrtalamaMaas);
            Controls.Add(lblCalisanSayisi);
            Controls.Add(cmbDepartman);
            Name = "Raporlar";
            Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)dgwDepartman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepartman;
        private Label lblCalisanSayisi;
        private Label lblOrtalamaMaas;
        private ComboBox cmbDepartman2;
        private ListBox lstDepartman;
        private DataGridView dgwDepartman;
        private Label lblAktifCalisan;
        private Label lblIstenAyrilan;
        private Label lblToplamFirmaMaasGideri;
    }
}