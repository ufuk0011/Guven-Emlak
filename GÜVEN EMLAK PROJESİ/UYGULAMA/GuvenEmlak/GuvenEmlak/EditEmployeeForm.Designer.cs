namespace GuvenEmlak
{
    partial class EditEmployeeForm
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
            txtEmployeeName = new TextBox();
            txtEmployeeLastName = new TextBox();
            mtxtEmployeePhone = new MaskedTextBox();
            txtEmployeeEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(43, 58);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(226, 27);
            txtEmployeeName.TabIndex = 0;
            txtEmployeeName.KeyPress += txtEmployeeName_KeyPress;
            // 
            // txtEmployeeLastName
            // 
            txtEmployeeLastName.Location = new Point(43, 125);
            txtEmployeeLastName.Name = "txtEmployeeLastName";
            txtEmployeeLastName.Size = new Size(226, 27);
            txtEmployeeLastName.TabIndex = 1;
            txtEmployeeLastName.KeyPress += txtEmployeeLastName_KeyPress;
            // 
            // mtxtEmployeePhone
            // 
            mtxtEmployeePhone.Location = new Point(43, 263);
            mtxtEmployeePhone.Mask = "(999) 000-0000";
            mtxtEmployeePhone.Name = "mtxtEmployeePhone";
            mtxtEmployeePhone.Size = new Size(226, 27);
            mtxtEmployeePhone.TabIndex = 2;
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.Location = new Point(43, 194);
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(226, 27);
            txtEmployeeEmail.TabIndex = 3;
            txtEmployeeEmail.Validating += txtEmployeeEmail_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 4;
            label1.Text = "Çalışan Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(43, 94);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 5;
            label2.Text = "Çalışan Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(43, 163);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 6;
            label3.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(43, 232);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 7;
            label4.Text = "Telefon";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(43, 305);
            button1.Name = "button1";
            button1.Size = new Size(226, 44);
            button1.TabIndex = 8;
            button1.Text = "GÜNCELLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(43, 355);
            button2.Name = "button2";
            button2.Size = new Size(226, 44);
            button2.TabIndex = 9;
            button2.Text = "ÇALIŞANI SİL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2025_04_03_110759;
            pictureBox1.Location = new Point(275, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 477);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(43, 403);
            button3.Name = "button3";
            button3.Size = new Size(226, 44);
            button3.TabIndex = 11;
            button3.Text = "GERİ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmployeeEmail);
            Controls.Add(mtxtEmployeePhone);
            Controls.Add(txtEmployeeLastName);
            Controls.Add(txtEmployeeName);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeName;
        private TextBox txtEmployeeLastName;
        private MaskedTextBox mtxtEmployeePhone;
        private TextBox txtEmployeeEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}