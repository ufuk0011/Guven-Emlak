namespace GuvenEmlak
{
    partial class ReportDetailsForm
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
            txtHouseAddress = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            txtReportDate = new TextBox();
            txtCustomerOpinions = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Enabled = false;
            txtEmployeeName.Location = new Point(283, 31);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(206, 27);
            txtEmployeeName.TabIndex = 0;
            txtEmployeeName.KeyPress += txtEmployeeName_KeyPress;
            // 
            // txtHouseAddress
            // 
            txtHouseAddress.Enabled = false;
            txtHouseAddress.Location = new Point(283, 92);
            txtHouseAddress.Name = "txtHouseAddress";
            txtHouseAddress.Size = new Size(206, 27);
            txtHouseAddress.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Enabled = false;
            txtCustomerName.Location = new Point(283, 148);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(206, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Enabled = false;
            txtCustomerPhone.Location = new Point(283, 205);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(206, 27);
            txtCustomerPhone.TabIndex = 3;
            // 
            // txtReportDate
            // 
            txtReportDate.Enabled = false;
            txtReportDate.Location = new Point(283, 266);
            txtReportDate.Name = "txtReportDate";
            txtReportDate.Size = new Size(206, 27);
            txtReportDate.TabIndex = 4;
            // 
            // txtCustomerOpinions
            // 
            txtCustomerOpinions.Enabled = false;
            txtCustomerOpinions.Location = new Point(168, 336);
            txtCustomerOpinions.Multiline = true;
            txtCustomerOpinions.Name = "txtCustomerOpinions";
            txtCustomerOpinions.Size = new Size(429, 167);
            txtCustomerOpinions.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(283, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 6;
            label1.Text = "Çalışan Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(283, 61);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 7;
            label2.Text = "Ev Adresi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(283, 122);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 8;
            label3.Text = "MüşteriAdı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(283, 178);
            label4.Name = "label4";
            label4.Size = new Size(173, 28);
            label4.TabIndex = 9;
            label4.Text = "Müşteri Telefonu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(283, 235);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 10;
            label5.Text = "Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(283, 305);
            label6.Name = "label6";
            label6.Size = new Size(203, 28);
            label6.TabIndex = 11;
            label6.Text = "Müşteri Düşünceleri";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(280, 509);
            button1.Name = "button1";
            button1.Size = new Size(206, 46);
            button1.TabIndex = 12;
            button1.Text = "RAPORU SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(283, 561);
            button2.Name = "button2";
            button2.Size = new Size(203, 46);
            button2.TabIndex = 13;
            button2.Text = "GERİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ReportDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomerOpinions);
            Controls.Add(txtReportDate);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerName);
            Controls.Add(txtHouseAddress);
            Controls.Add(txtEmployeeName);
            Name = "ReportDetailsForm";
            Text = "ReportDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeName;
        private TextBox txtHouseAddress;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private TextBox txtReportDate;
        private TextBox txtCustomerOpinions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}