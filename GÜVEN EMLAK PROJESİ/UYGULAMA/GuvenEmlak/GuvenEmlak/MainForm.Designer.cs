namespace GuvenEmlak
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            flowHouses = new FlowLayoutPanel();
            EmployyePage = new TabPage();
            dgvEmployeeList = new DataGridView();
            pictureBox6 = new PictureBox();
            ReportsPage = new TabPage();
            dgvReportsList = new DataGridView();
            pictureBox4 = new PictureBox();
            reportAddPage = new TabPage();
            btnReportDelete = new Button();
            cbox = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            mtxtCustomerPhone = new MaskedTextBox();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            btnReportSave = new Button();
            txtCustomerOpinions = new TextBox();
            cbHouseName = new ComboBox();
            txtCustomerName = new TextBox();
            cbEmployeeName = new ComboBox();
            pictureBox3 = new PictureBox();
            AddHouse = new TabPage();
            btnHouseDelete = new Button();
            txtPrice = new TextBox();
            pbHousePicture = new PictureBox();
            btnPictureSelect = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            cbSituation = new ComboBox();
            txtSize = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtRoomCount = new TextBox();
            label4 = new Label();
            cbType = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btnHouseSave = new Button();
            txtAdres = new TextBox();
            EmployeeAddPage = new TabPage();
            btnDeleteEmployee = new Button();
            mtxtEmployeePhone = new MaskedTextBox();
            pictureBox5 = new PictureBox();
            btnSaveEmployee = new Button();
            label15 = new Label();
            txtEmployeeEmail = new TextBox();
            label14 = new Label();
            txtEmployeeLastName = new TextBox();
            label13 = new Label();
            txtEmployeeName = new TextBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            EmployyePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ReportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            reportAddPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            AddHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHousePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            EmployeeAddPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(EmployyePage);
            tabControl1.Controls.Add(ReportsPage);
            tabControl1.Controls.Add(reportAddPage);
            tabControl1.Controls.Add(AddHouse);
            tabControl1.Controls.Add(EmployeeAddPage);
            tabControl1.Location = new Point(1, 101);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1266, 603);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowHouses);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1258, 570);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Evler";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowHouses
            // 
            flowHouses.Location = new Point(3, 3);
            flowHouses.Name = "flowHouses";
            flowHouses.Size = new Size(1249, 529);
            flowHouses.TabIndex = 0;
            // 
            // EmployyePage
            // 
            EmployyePage.Controls.Add(dgvEmployeeList);
            EmployyePage.Controls.Add(pictureBox6);
            EmployyePage.Location = new Point(4, 29);
            EmployyePage.Name = "EmployyePage";
            EmployyePage.Padding = new Padding(3);
            EmployyePage.Size = new Size(1258, 570);
            EmployyePage.TabIndex = 7;
            EmployyePage.Text = "Çalışanlar";
            EmployyePage.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Location = new Point(7, 6);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.RowHeadersWidth = 51;
            dgvEmployeeList.Size = new Size(782, 523);
            dgvEmployeeList.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Ekran_görüntüsü_2025_04_03_110759;
            pictureBox6.Location = new Point(771, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(516, 523);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // ReportsPage
            // 
            ReportsPage.Controls.Add(dgvReportsList);
            ReportsPage.Controls.Add(pictureBox4);
            ReportsPage.Location = new Point(4, 29);
            ReportsPage.Name = "ReportsPage";
            ReportsPage.Padding = new Padding(3);
            ReportsPage.Size = new Size(1258, 570);
            ReportsPage.TabIndex = 5;
            ReportsPage.Text = "Raporlar";
            ReportsPage.UseVisualStyleBackColor = true;
            // 
            // dgvReportsList
            // 
            dgvReportsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportsList.Location = new Point(7, 6);
            dgvReportsList.Name = "dgvReportsList";
            dgvReportsList.RowHeadersWidth = 51;
            dgvReportsList.Size = new Size(930, 519);
            dgvReportsList.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Ekran_görüntüsü_2025_04_03_110759;
            pictureBox4.Location = new Point(862, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(498, 430);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // reportAddPage
            // 
            reportAddPage.Controls.Add(btnReportDelete);
            reportAddPage.Controls.Add(cbox);
            reportAddPage.Controls.Add(label11);
            reportAddPage.Controls.Add(label10);
            reportAddPage.Controls.Add(mtxtCustomerPhone);
            reportAddPage.Controls.Add(label9);
            reportAddPage.Controls.Add(label8);
            reportAddPage.Controls.Add(label1);
            reportAddPage.Controls.Add(btnReportSave);
            reportAddPage.Controls.Add(txtCustomerOpinions);
            reportAddPage.Controls.Add(cbHouseName);
            reportAddPage.Controls.Add(txtCustomerName);
            reportAddPage.Controls.Add(cbEmployeeName);
            reportAddPage.Controls.Add(pictureBox3);
            reportAddPage.Location = new Point(4, 29);
            reportAddPage.Name = "reportAddPage";
            reportAddPage.Padding = new Padding(3);
            reportAddPage.Size = new Size(1258, 570);
            reportAddPage.TabIndex = 4;
            reportAddPage.Text = "RaporEkle";
            reportAddPage.UseVisualStyleBackColor = true;
            // 
            // btnReportDelete
            // 
            btnReportDelete.BackColor = Color.Red;
            btnReportDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportDelete.Location = new Point(219, 475);
            btnReportDelete.Name = "btnReportDelete";
            btnReportDelete.Size = new Size(335, 50);
            btnReportDelete.TabIndex = 16;
            btnReportDelete.Text = "Temizle";
            btnReportDelete.UseVisualStyleBackColor = false;
            btnReportDelete.Click += btnReportDelete_Click;
            // 
            // cbox
            // 
            cbox.AutoSize = true;
            cbox.Location = new Point(560, 120);
            cbox.Name = "cbox";
            cbox.Size = new Size(146, 24);
            cbox.TabIndex = 15;
            cbox.Text = "Satıldı / Kiralandı";
            cbox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(219, 267);
            label11.Name = "label11";
            label11.Size = new Size(203, 28);
            label11.TabIndex = 10;
            label11.Text = "Müşteri Düşünceleri";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(219, 206);
            label10.Name = "label10";
            label10.Size = new Size(173, 28);
            label10.TabIndex = 9;
            label10.Text = "Müşteri Telefonu";
            // 
            // mtxtCustomerPhone
            // 
            mtxtCustomerPhone.Location = new Point(219, 237);
            mtxtCustomerPhone.Mask = "(999) 000-0000";
            mtxtCustomerPhone.Name = "mtxtCustomerPhone";
            mtxtCustomerPhone.Size = new Size(335, 27);
            mtxtCustomerPhone.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(219, 149);
            label9.Name = "label9";
            label9.Size = new Size(123, 28);
            label9.TabIndex = 7;
            label9.Text = "Müşteri Adı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(219, 87);
            label8.Name = "label8";
            label8.Size = new Size(34, 28);
            label8.TabIndex = 6;
            label8.Text = "Ev";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(219, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 5;
            label1.Text = "Çalışan";
            // 
            // btnReportSave
            // 
            btnReportSave.BackColor = Color.Lime;
            btnReportSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportSave.Location = new Point(219, 419);
            btnReportSave.Name = "btnReportSave";
            btnReportSave.Size = new Size(335, 50);
            btnReportSave.TabIndex = 4;
            btnReportSave.Text = "Kaydet";
            btnReportSave.UseVisualStyleBackColor = false;
            btnReportSave.Click += btnReportSave_Click;
            // 
            // txtCustomerOpinions
            // 
            txtCustomerOpinions.Location = new Point(219, 298);
            txtCustomerOpinions.Multiline = true;
            txtCustomerOpinions.Name = "txtCustomerOpinions";
            txtCustomerOpinions.Size = new Size(335, 115);
            txtCustomerOpinions.TabIndex = 3;
            // 
            // cbHouseName
            // 
            cbHouseName.FormattingEnabled = true;
            cbHouseName.Location = new Point(219, 118);
            cbHouseName.Name = "cbHouseName";
            cbHouseName.Size = new Size(335, 28);
            cbHouseName.TabIndex = 2;
            cbHouseName.KeyPress += cbHouseName_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(219, 176);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(335, 27);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.KeyPress += txtCustomerName_KeyPress;
            // 
            // cbEmployeeName
            // 
            cbEmployeeName.FormattingEnabled = true;
            cbEmployeeName.Location = new Point(219, 56);
            cbEmployeeName.Name = "cbEmployeeName";
            cbEmployeeName.Size = new Size(335, 28);
            cbEmployeeName.TabIndex = 0;
            cbEmployeeName.SelectedIndexChanged += cbEmployeeName_SelectedIndexChanged;
            cbEmployeeName.KeyPress += cbEmployeeName_KeyPress;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Ekran_görüntüsü_2025_04_03_110759;
            pictureBox3.Location = new Point(530, -61);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(706, 622);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // AddHouse
            // 
            AddHouse.Controls.Add(btnHouseDelete);
            AddHouse.Controls.Add(txtPrice);
            AddHouse.Controls.Add(pbHousePicture);
            AddHouse.Controls.Add(btnPictureSelect);
            AddHouse.Controls.Add(pictureBox1);
            AddHouse.Controls.Add(label7);
            AddHouse.Controls.Add(cbSituation);
            AddHouse.Controls.Add(txtSize);
            AddHouse.Controls.Add(label6);
            AddHouse.Controls.Add(label5);
            AddHouse.Controls.Add(txtRoomCount);
            AddHouse.Controls.Add(label4);
            AddHouse.Controls.Add(cbType);
            AddHouse.Controls.Add(label3);
            AddHouse.Controls.Add(label2);
            AddHouse.Controls.Add(btnHouseSave);
            AddHouse.Controls.Add(txtAdres);
            AddHouse.Location = new Point(4, 29);
            AddHouse.Name = "AddHouse";
            AddHouse.Padding = new Padding(3);
            AddHouse.Size = new Size(1258, 570);
            AddHouse.TabIndex = 3;
            AddHouse.Text = "Ev Ekle";
            AddHouse.UseVisualStyleBackColor = true;
            // 
            // btnHouseDelete
            // 
            btnHouseDelete.BackColor = Color.Red;
            btnHouseDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHouseDelete.Location = new Point(407, 480);
            btnHouseDelete.Name = "btnHouseDelete";
            btnHouseDelete.Size = new Size(263, 45);
            btnHouseDelete.TabIndex = 17;
            btnHouseDelete.Text = "Temizle";
            btnHouseDelete.UseVisualStyleBackColor = false;
            btnHouseDelete.Click += btnHouseDelete_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(261, 202);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(263, 27);
            txtPrice.TabIndex = 16;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // pbHousePicture
            // 
            pbHousePicture.Location = new Point(261, 0);
            pbHousePicture.Name = "pbHousePicture";
            pbHousePicture.Size = new Size(110, 110);
            pbHousePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHousePicture.TabIndex = 15;
            pbHousePicture.TabStop = false;
            // 
            // btnPictureSelect
            // 
            btnPictureSelect.BackColor = Color.Cyan;
            btnPictureSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPictureSelect.Location = new Point(377, 72);
            btnPictureSelect.Name = "btnPictureSelect";
            btnPictureSelect.Size = new Size(147, 38);
            btnPictureSelect.TabIndex = 14;
            btnPictureSelect.Text = "Resim Yükle";
            btnPictureSelect.UseVisualStyleBackColor = false;
            btnPictureSelect.Click += btnPictureSelect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2025_04_03_110759;
            pictureBox1.Location = new Point(530, -61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(706, 622);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(261, 416);
            label7.Name = "label7";
            label7.Size = new Size(89, 28);
            label7.TabIndex = 12;
            label7.Text = "Durumu";
            // 
            // cbSituation
            // 
            cbSituation.FormattingEnabled = true;
            cbSituation.Location = new Point(261, 446);
            cbSituation.Name = "cbSituation";
            cbSituation.Size = new Size(263, 28);
            cbSituation.TabIndex = 11;
            cbSituation.KeyPress += cbSituation_KeyPress;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(261, 386);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(263, 27);
            txtSize.TabIndex = 10;
            txtSize.KeyPress += txtSize_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(261, 355);
            label6.Name = "label6";
            label6.Size = new Size(38, 28);
            label6.TabIndex = 9;
            label6.Text = "m²";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(261, 294);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 8;
            label5.Text = "Oda Sayısı";
            // 
            // txtRoomCount
            // 
            txtRoomCount.Location = new Point(261, 325);
            txtRoomCount.Name = "txtRoomCount";
            txtRoomCount.Size = new Size(263, 27);
            txtRoomCount.TabIndex = 7;
            txtRoomCount.KeyPress += txtRoomCount_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(261, 232);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 6;
            label4.Text = "Tipi";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(261, 263);
            cbType.Name = "cbType";
            cbType.Size = new Size(263, 28);
            cbType.TabIndex = 5;
            cbType.KeyPress += cbType_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(261, 171);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 4;
            label3.Text = "Değer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(261, 110);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 2;
            label2.Text = "Adres";
            // 
            // btnHouseSave
            // 
            btnHouseSave.BackColor = Color.Lime;
            btnHouseSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHouseSave.Location = new Point(127, 480);
            btnHouseSave.Name = "btnHouseSave";
            btnHouseSave.Size = new Size(263, 45);
            btnHouseSave.TabIndex = 1;
            btnHouseSave.Text = "Kaydet";
            btnHouseSave.UseVisualStyleBackColor = false;
            btnHouseSave.Click += btnHouseSave_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(261, 141);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(263, 27);
            txtAdres.TabIndex = 0;
            // 
            // EmployeeAddPage
            // 
            EmployeeAddPage.Controls.Add(btnDeleteEmployee);
            EmployeeAddPage.Controls.Add(mtxtEmployeePhone);
            EmployeeAddPage.Controls.Add(pictureBox5);
            EmployeeAddPage.Controls.Add(btnSaveEmployee);
            EmployeeAddPage.Controls.Add(label15);
            EmployeeAddPage.Controls.Add(txtEmployeeEmail);
            EmployeeAddPage.Controls.Add(label14);
            EmployeeAddPage.Controls.Add(txtEmployeeLastName);
            EmployeeAddPage.Controls.Add(label13);
            EmployeeAddPage.Controls.Add(txtEmployeeName);
            EmployeeAddPage.Controls.Add(label12);
            EmployeeAddPage.Location = new Point(4, 29);
            EmployeeAddPage.Name = "EmployeeAddPage";
            EmployeeAddPage.Size = new Size(1258, 570);
            EmployeeAddPage.TabIndex = 6;
            EmployeeAddPage.Text = "Çalışan Ekle";
            EmployeeAddPage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.Red;
            btnDeleteEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteEmployee.Location = new Point(244, 408);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(236, 56);
            btnDeleteEmployee.TabIndex = 16;
            btnDeleteEmployee.Text = "Temizle";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // mtxtEmployeePhone
            // 
            mtxtEmployeePhone.Location = new Point(244, 302);
            mtxtEmployeePhone.Mask = "(999) 000-0000";
            mtxtEmployeePhone.Name = "mtxtEmployeePhone";
            mtxtEmployeePhone.Size = new Size(236, 27);
            mtxtEmployeePhone.TabIndex = 15;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Ekran_görüntüsü_2025_04_03_110759;
            pictureBox5.Location = new Point(530, -61);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(706, 622);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.BackColor = Color.Lime;
            btnSaveEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveEmployee.Location = new Point(244, 346);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(236, 56);
            btnSaveEmployee.TabIndex = 8;
            btnSaveEmployee.Text = "Kaydet";
            btnSaveEmployee.UseVisualStyleBackColor = false;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.Location = new Point(244, 271);
            label15.Name = "label15";
            label15.Size = new Size(82, 28);
            label15.TabIndex = 6;
            label15.Text = "Telefon";
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.Location = new Point(244, 241);
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(236, 27);
            txtEmployeeEmail.TabIndex = 5;
            txtEmployeeEmail.KeyPress += txtEmployeeEmail_KeyPress;
            txtEmployeeEmail.Validating += txtEmployeeEmail_Validating;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(244, 210);
            label14.Name = "label14";
            label14.Size = new Size(73, 28);
            label14.TabIndex = 4;
            label14.Text = "E-Mail";
            // 
            // txtEmployeeLastName
            // 
            txtEmployeeLastName.Location = new Point(244, 180);
            txtEmployeeLastName.Name = "txtEmployeeLastName";
            txtEmployeeLastName.Size = new Size(236, 27);
            txtEmployeeLastName.TabIndex = 3;
            txtEmployeeLastName.KeyPress += txtEmployeeLastName_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(244, 149);
            label13.Name = "label13";
            label13.Size = new Size(75, 28);
            label13.TabIndex = 2;
            label13.Text = "Soyadı";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(244, 119);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(236, 27);
            txtEmployeeName.TabIndex = 1;
            txtEmployeeName.KeyPress += txtEmployeeName_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(244, 88);
            label12.Name = "label12";
            label12.Size = new Size(44, 28);
            label12.TabIndex = 0;
            label12.Text = "Adı";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ekran_görüntüsü_2025_04_03_110759;
            pictureBox2.Location = new Point(-71, -72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 661);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox2);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            EmployyePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ReportsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            reportAddPage.ResumeLayout(false);
            reportAddPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            AddHouse.ResumeLayout(false);
            AddHouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHousePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            EmployeeAddPage.ResumeLayout(false);
            EmployeeAddPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowHouses;
        private TabPage AddHouse;
        private Button btnHouseSave;
        private TextBox txtAdres;
        private Label label5;
        private TextBox txtRoomCount;
        private Label label4;
        private ComboBox cbType;
        private Label label3;
        private Label label2;
        private TextBox txtSize;
        private Label label6;
        private Button btnPictureSelect;
        private PictureBox pictureBox1;
        private Label label7;
        private ComboBox cbSituation;
        private PictureBox pbHousePicture;
        private PictureBox pictureBox2;
        private TextBox txtPrice;
        private TabPage reportAddPage;
        private Button btnReportSave;
        private TextBox txtCustomerOpinions;
        private ComboBox cbHouseName;
        private TextBox txtCustomerName;
        private ComboBox cbEmployeeName;
        private Label label9;
        private Label label8;
        private Label label1;
        private Label label11;
        private Label label10;
        private MaskedTextBox mtxtCustomerPhone;
        private TabPage ReportsPage;
        private DataGridView dgvReportsList;
        private PictureBox pictureBox4;
        private TabPage EmployeeAddPage;
        private TextBox txtEmployeeLastName;
        private Label label13;
        private TextBox txtEmployeeName;
        private Label label12;
        private Button btnSaveEmployee;
        private Label label15;
        private TextBox txtEmployeeEmail;
        private Label label14;
        private TabPage EmployyePage;
        private PictureBox pictureBox6;
        private DataGridView dgvEmployeeList;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private CheckBox cbox;
        private MaskedTextBox mtxtEmployeePhone;
        private Button btnReportDelete;
        private Button btnDeleteEmployee;
        private Button btnHouseDelete;
    }
}