namespace GuvenEmlak
{
    partial class HouseDetailsSettings
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
            pbHousePicture = new PictureBox();
            button1 = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            txtAdress = new TextBox();
            txtPrice = new TextBox();
            txtRoomCount = new TextBox();
            txtMetre = new TextBox();
            cbType = new ComboBox();
            cbStatues = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHousePicture).BeginInit();
            SuspendLayout();
            // 
            // pbHousePicture
            // 
            pbHousePicture.Location = new Point(459, 17);
            pbHousePicture.Margin = new Padding(4);
            pbHousePicture.Name = "pbHousePicture";
            pbHousePicture.Size = new Size(123, 123);
            pbHousePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHousePicture.TabIndex = 0;
            pbHousePicture.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(590, 99);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 1;
            button1.Text = "Resim Yükle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Location = new Point(459, 572);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(227, 64);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 0);
            btnBack.Location = new Point(459, 644);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(227, 64);
            btnBack.TabIndex = 3;
            btnBack.Text = "GERİ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(459, 176);
            txtAdress.Margin = new Padding(4);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(227, 34);
            txtAdress.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(459, 246);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(227, 34);
            txtPrice.TabIndex = 5;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtRoomCount
            // 
            txtRoomCount.Location = new Point(459, 316);
            txtRoomCount.Margin = new Padding(4);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(227, 34);
            txtRoomCount.TabIndex = 6;
            txtRoomCount.KeyPress += txtRoomCount_KeyPress;
            // 
            // txtMetre
            // 
            txtMetre.Location = new Point(459, 386);
            txtMetre.Margin = new Padding(4);
            txtMetre.Name = "txtMetre";
            txtMetre.Size = new Size(227, 34);
            txtMetre.TabIndex = 7;
            txtMetre.TextChanged += textBox4_TextChanged;
            txtMetre.KeyPress += txtMetre_KeyPress;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(459, 456);
            cbType.Margin = new Padding(4);
            cbType.Name = "cbType";
            cbType.Size = new Size(224, 36);
            cbType.TabIndex = 8;
            cbType.KeyPress += cbType_KeyPress;
            // 
            // cbStatues
            // 
            cbStatues.FormattingEnabled = true;
            cbStatues.Location = new Point(459, 528);
            cbStatues.Margin = new Padding(4);
            cbStatues.Name = "cbStatues";
            cbStatues.Size = new Size(224, 36);
            cbStatues.TabIndex = 9;
            cbStatues.KeyPress += cbStatues_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(459, 144);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 10;
            label1.Text = "Adres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(459, 214);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 11;
            label2.Text = "Değer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(459, 284);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 12;
            label3.Text = "Oda Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(459, 354);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 28);
            label4.TabIndex = 13;
            label4.Text = "M²";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(459, 424);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 14;
            label5.Text = "Tipi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(459, 496);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 15;
            label6.Text = "Durumu";
            // 
            // HouseDetailsSettings
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 808);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbStatues);
            Controls.Add(cbType);
            Controls.Add(txtMetre);
            Controls.Add(txtRoomCount);
            Controls.Add(txtPrice);
            Controls.Add(txtAdress);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Controls.Add(pbHousePicture);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "HouseDetailsSettings";
            Text = "HouseDetailsSettings";
            ((System.ComponentModel.ISupportInitialize)pbHousePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbHousePicture;
        private Button button1;
        private Button btnUpdate;
        private Button btnBack;
        private TextBox txtAdress;
        private TextBox txtPrice;
        private TextBox txtRoomCount;
        private TextBox txtMetre;
        private ComboBox cbType;
        private ComboBox cbStatues;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}