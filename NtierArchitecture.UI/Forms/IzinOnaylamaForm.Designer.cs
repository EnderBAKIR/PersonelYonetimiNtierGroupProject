namespace NtierArchitecture.UI.Forms
{
    partial class IzinOnaylamaForm
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
            dgwEmployeeDetails = new DataGridView();
            dgwLeaveDetails = new DataGridView();
            btnApproved1 = new Krypton.Toolkit.KryptonButton();
            btnRejected1 = new Krypton.Toolkit.KryptonButton();
            lstLeaves1 = new Krypton.Toolkit.KryptonListBox();
            lstActiveLeaves1 = new Krypton.Toolkit.KryptonListBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveDetails).BeginInit();
            SuspendLayout();
            // 
            // dgwEmployeeDetails
            // 
            dgwEmployeeDetails.BackgroundColor = Color.Ivory;
            dgwEmployeeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEmployeeDetails.Location = new Point(34, 576);
            dgwEmployeeDetails.Margin = new Padding(3, 4, 3, 4);
            dgwEmployeeDetails.Name = "dgwEmployeeDetails";
            dgwEmployeeDetails.RowHeadersWidth = 51;
            dgwEmployeeDetails.Size = new Size(935, 125);
            dgwEmployeeDetails.TabIndex = 2;
            // 
            // dgwLeaveDetails
            // 
            dgwLeaveDetails.BackgroundColor = Color.Ivory;
            dgwLeaveDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeaveDetails.Location = new Point(34, 389);
            dgwLeaveDetails.Margin = new Padding(3, 4, 3, 4);
            dgwLeaveDetails.Name = "dgwLeaveDetails";
            dgwLeaveDetails.RowHeadersWidth = 51;
            dgwLeaveDetails.Size = new Size(935, 117);
            dgwLeaveDetails.TabIndex = 5;
            // 
            // btnApproved1
            // 
            btnApproved1.Location = new Point(349, 724);
            btnApproved1.Margin = new Padding(3, 4, 3, 4);
            btnApproved1.Name = "btnApproved1";
            btnApproved1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnApproved1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnApproved1.OverrideDefault.Back.ColorAngle = 45F;
            btnApproved1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnApproved1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnApproved1.OverrideDefault.Border.ColorAngle = 45F;
            btnApproved1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnApproved1.OverrideDefault.Border.Rounding = 17F;
            btnApproved1.OverrideDefault.Border.Width = 2;
            btnApproved1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnApproved1.Size = new Size(142, 57);
            btnApproved1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnApproved1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnApproved1.StateCommon.Back.ColorAngle = 45F;
            btnApproved1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnApproved1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnApproved1.StateCommon.Border.ColorAngle = 45F;
            btnApproved1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnApproved1.StateCommon.Border.Rounding = 17F;
            btnApproved1.StateCommon.Border.Width = 2;
            btnApproved1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnApproved1.StateCommon.Content.ShortText.Color2 = Color.White;
            btnApproved1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApproved1.StateDisabled.Border.Width = 2;
            btnApproved1.StateNormal.Border.Width = 2;
            btnApproved1.StatePressed.Back.Color1 = Color.FromArgb(71, 156, 75);
            btnApproved1.StatePressed.Back.Color2 = Color.FromArgb(64, 142, 66);
            btnApproved1.StatePressed.Border.Color1 = Color.FromArgb(71, 156, 75);
            btnApproved1.StatePressed.Border.Color2 = Color.FromArgb(32, 61, 33);
            btnApproved1.StatePressed.Border.Rounding = 17F;
            btnApproved1.StatePressed.Border.Width = 2;
            btnApproved1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnApproved1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnApproved1.StateTracking.Back.ColorAngle = 45F;
            btnApproved1.StateTracking.Border.ColorAngle = 45F;
            btnApproved1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnApproved1.StateTracking.Border.Rounding = 17F;
            btnApproved1.StateTracking.Border.Width = 2;
            btnApproved1.TabIndex = 15;
            btnApproved1.Values.DropDownArrowColor = Color.Empty;
            btnApproved1.Values.Text = "Onayla";
            btnApproved1.Click += btnApproved1_Click;
            // 
            // btnRejected1
            // 
            btnRejected1.Location = new Point(520, 724);
            btnRejected1.Margin = new Padding(3, 4, 3, 4);
            btnRejected1.Name = "btnRejected1";
            btnRejected1.OverrideDefault.Back.Color1 = Color.FromArgb(59, 61, 59);
            btnRejected1.OverrideDefault.Back.Color2 = Color.FromArgb(22, 22, 22);
            btnRejected1.OverrideDefault.Back.ColorAngle = 45F;
            btnRejected1.OverrideDefault.Border.Color1 = Color.FromArgb(50, 73, 73);
            btnRejected1.OverrideDefault.Border.Color2 = Color.FromArgb(48, 48, 48);
            btnRejected1.OverrideDefault.Border.ColorAngle = 45F;
            btnRejected1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRejected1.OverrideDefault.Border.Rounding = 17F;
            btnRejected1.OverrideDefault.Border.Width = 2;
            btnRejected1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnRejected1.Size = new Size(143, 57);
            btnRejected1.StateCommon.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnRejected1.StateCommon.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnRejected1.StateCommon.Back.ColorAngle = 45F;
            btnRejected1.StateCommon.Border.Color1 = Color.FromArgb(57, 57, 57);
            btnRejected1.StateCommon.Border.Color2 = Color.FromArgb(57, 57, 57);
            btnRejected1.StateCommon.Border.ColorAngle = 45F;
            btnRejected1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRejected1.StateCommon.Border.Rounding = 15F;
            btnRejected1.StateCommon.Border.Width = 2;
            btnRejected1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnRejected1.StateCommon.Content.ShortText.Color2 = Color.White;
            btnRejected1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRejected1.StateDisabled.Border.Width = 2;
            btnRejected1.StateNormal.Border.Width = 2;
            btnRejected1.StatePressed.Back.Color1 = Color.Brown;
            btnRejected1.StatePressed.Back.Color2 = Color.Firebrick;
            btnRejected1.StatePressed.Border.Color1 = Color.FromArgb(181, 132, 68);
            btnRejected1.StatePressed.Border.Color2 = Color.FromArgb(147, 108, 57);
            btnRejected1.StatePressed.Border.Rounding = 15F;
            btnRejected1.StatePressed.Border.Width = 2;
            btnRejected1.StateTracking.Back.Color1 = Color.FromArgb(73, 73, 73);
            btnRejected1.StateTracking.Back.Color2 = Color.FromArgb(48, 48, 48);
            btnRejected1.StateTracking.Back.ColorAngle = 45F;
            btnRejected1.StateTracking.Border.ColorAngle = 45F;
            btnRejected1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRejected1.StateTracking.Border.Rounding = 17F;
            btnRejected1.StateTracking.Border.Width = 2;
            btnRejected1.TabIndex = 16;
            btnRejected1.Values.DropDownArrowColor = Color.Empty;
            btnRejected1.Values.Text = "Reddet";
            btnRejected1.Click += btnRejected1_Click;
            // 
            // lstLeaves1
            // 
            lstLeaves1.Location = new Point(536, 78);
            lstLeaves1.Margin = new Padding(3, 4, 3, 4);
            lstLeaves1.Name = "lstLeaves1";
            lstLeaves1.Size = new Size(442, 219);
            lstLeaves1.StateActive.Back.Color1 = Color.White;
            lstLeaves1.StateActive.Back.Color2 = Color.White;
            lstLeaves1.StateCheckedNormal.Item.Back.Color1 = Color.White;
            lstLeaves1.StateCheckedNormal.Item.Back.Color2 = Color.White;
            lstLeaves1.StateCheckedPressed.Item.Back.Color1 = Color.White;
            lstLeaves1.StateCheckedPressed.Item.Back.Color2 = Color.White;
            lstLeaves1.StateCheckedTracking.Item.Back.Color1 = Color.White;
            lstLeaves1.StateCheckedTracking.Item.Back.Color2 = Color.White;
            lstLeaves1.StateCommon.Back.Color1 = Color.Transparent;
            lstLeaves1.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            lstLeaves1.StateCommon.Border.Rounding = 15F;
            lstLeaves1.StateCommon.Border.Width = 2;
            lstLeaves1.StateDisabled.Border.Rounding = 15F;
            lstLeaves1.StateDisabled.Border.Width = 2;
            lstLeaves1.StatePressed.Item.Border.Rounding = 15F;
            lstLeaves1.StatePressed.Item.Border.Width = 2;
            lstLeaves1.TabIndex = 18;
            lstLeaves1.SelectedIndexChanged += lstLeaves1_SelectedIndexChanged_1;
            // 
            // lstActiveLeaves1
            // 
            lstActiveLeaves1.Location = new Point(34, 78);
            lstActiveLeaves1.Margin = new Padding(3, 4, 3, 4);
            lstActiveLeaves1.Name = "lstActiveLeaves1";
            lstActiveLeaves1.Size = new Size(456, 219);
            lstActiveLeaves1.StateActive.Back.Color1 = Color.White;
            lstActiveLeaves1.StateActive.Back.Color2 = Color.White;
            lstActiveLeaves1.StateCheckedNormal.Item.Back.Color1 = Color.White;
            lstActiveLeaves1.StateCheckedNormal.Item.Back.Color2 = Color.White;
            lstActiveLeaves1.StateCheckedPressed.Item.Back.Color1 = Color.White;
            lstActiveLeaves1.StateCheckedPressed.Item.Back.Color2 = Color.White;
            lstActiveLeaves1.StateCheckedTracking.Item.Back.Color1 = Color.White;
            lstActiveLeaves1.StateCheckedTracking.Item.Back.Color2 = Color.White;
            lstActiveLeaves1.StateCommon.Back.Color1 = Color.Transparent;
            lstActiveLeaves1.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            lstActiveLeaves1.StateCommon.Border.Rounding = 15F;
            lstActiveLeaves1.StateCommon.Border.Width = 2;
            lstActiveLeaves1.StateDisabled.Border.Rounding = 15F;
            lstActiveLeaves1.StateDisabled.Border.Width = 2;
            lstActiveLeaves1.StatePressed.Item.Border.Rounding = 15F;
            lstActiveLeaves1.StatePressed.Item.Border.Width = 2;
            lstActiveLeaves1.TabIndex = 19;
            lstActiveLeaves1.SelectedIndexChanged += lstActiveLeaves1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(47, 45);
            label1.Name = "label1";
            label1.Size = new Size(258, 29);
            label1.TabIndex = 20;
            label1.Text = "Bekleyen İzin Talepleri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(558, 45);
            label4.Name = "label4";
            label4.Size = new Size(284, 29);
            label4.TabIndex = 21;
            label4.Text = "Sonuçlanan İzin Talepleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(405, 346);
            label3.Name = "label3";
            label3.Size = new Size(185, 29);
            label3.TabIndex = 22;
            label3.Text = "Personel Talebi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(405, 528);
            label2.Name = "label2";
            label2.Size = new Size(182, 29);
            label2.TabIndex = 23;
            label2.Text = "Personel Bilgisi";
            // 
            // IzinOnaylamaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 832);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lstActiveLeaves1);
            Controls.Add(lstLeaves1);
            Controls.Add(btnRejected1);
            Controls.Add(btnApproved1);
            Controls.Add(dgwLeaveDetails);
            Controls.Add(dgwEmployeeDetails);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IzinOnaylamaForm";
            Text = "İzinOnaylamaForm";
            Load += IzinOnaylamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwEmployeeDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwLeaveDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgwEmployeeDetails;
        private DataGridView dgwLeaveDetails;
        private Krypton.Toolkit.KryptonButton btnApproved1;
        private Krypton.Toolkit.KryptonButton btnRejected1;
        private Krypton.Toolkit.KryptonListBox lstActiveLeaves1;
        private Krypton.Toolkit.KryptonListBox lstLeaves1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}