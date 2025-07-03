using GuvenEmlak.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace GuvenEmlak
{
    public partial class MainForm : Form
    {
        GuvenEmlakContext context;
        private int userId;
        private int houseId;
        public MainForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.houseId = houseId;
            context = new GuvenEmlakContext();
            load();
            EmplooyeeButtonLoad();
            RaporListButtonLoad();
            cbox.Checked = false;


        }

        public void load()
        {
            LoadReportsList();
            LoadReports();
            LoadHouse();
            admin();
            LoadComboBox();
            EmployyeList();

        }
        public void EmployyeList()
        {

            GuvenEmlakContext a = new GuvenEmlakContext();
            dgvEmployeeList.DataSource = a.Employees.ToList();
            dgvEmployeeList.Columns["Id"].Visible = false;
            dgvEmployeeList.Columns["EmployeeName"].HeaderText = "Çalışan Adı";
            dgvEmployeeList.Columns["EmployeLastName"].HeaderText = "Çalışan Soyadı";
            dgvEmployeeList.Columns["EmployeePhone"].HeaderText = "Çalışan Telefonu";
            dgvEmployeeList.Columns["EmployeeEmail"].HeaderText = "Çalışan E-Posta";
            dgvEmployeeList.Columns["EmployeeName"].Width = 150;
            dgvEmployeeList.Columns["EmployeLastName"].Width = 150;
            dgvEmployeeList.Columns["EmployeePhone"].Width = 150;
            dgvEmployeeList.Columns["EmployeeEmail"].Width = 150;



        }
        public void EmplooyeeButtonLoad()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Düzenle";
            button.Name = "btnEdit";
            button.Text = "Düzenle";
            button.UseColumnTextForButtonValue = true;

            dgvEmployeeList.Columns.Insert(5, button);
            dgvEmployeeList.CellContentClick += (sender, e) =>
            {
                if (dgvEmployeeList.Columns[e.ColumnIndex].Name == "btnEdit" && e.RowIndex >= 0)
                {
                    var selectedEmployee = (dynamic)dgvEmployeeList.Rows[e.RowIndex].DataBoundItem;
                    int employeeId = selectedEmployee.Id;
                    EditEmployee(employeeId);
                }
            };
        }
        public void EditEmployee(int employeeId)
        {
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employeeId, this);
            editEmployeeForm.ShowDialog();
        }
        public void LoadReportsList()
        {
            GuvenEmlakContext a = new GuvenEmlakContext();
            dgvReportsList.DataSource = a.Reports.ToList();
            dgvReportsList.Columns["Id"].Visible = false;
            dgvReportsList.Columns["EmployeeId"].Visible = false;
            dgvReportsList.Columns["Employee"].Visible = false;
            dgvReportsList.Columns["HouseId"].Visible = false;
            dgvReportsList.Columns["House"].Visible = false;
            dgvReportsList.Columns["EmployeeName"].HeaderText = "Çalışan Adı";
            dgvReportsList.Columns["HouseName"].HeaderText = "Ev Adı";
            dgvReportsList.Columns["CustomerName"].HeaderText = "Müşteri Adı";
            dgvReportsList.Columns["CustomerPhone"].HeaderText = "Müşteri Telefonu";
            dgvReportsList.Columns["CustomerOpinions"].HeaderText = "Müşteri Görüşleri";
            dgvReportsList.Columns["DateTime"].HeaderText = "Tarih";
            dgvReportsList.Columns["CustomerPhone"].Width = 150;
            dgvReportsList.Columns["CustomerOpinions"].Width = 150;
            dgvReportsList.Columns["DateTime"].Width = 150;
            dgvReportsList.Columns["EmployeeName"].Width = 75;
            dgvReportsList.Columns["HouseName"].Width = 150;
            dgvReportsList.Columns["CustomerName"].Width = 75;

        }
        public void RaporListButtonLoad()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Rapor Detay";
            button.Name = "btnReportDetails";
            button.Text = "Detay";
            button.UseColumnTextForButtonValue = true;
            dgvReportsList.Columns.Insert(7, button);
            dgvReportsList.CellContentClick += (sender, e) =>
            {
                if (dgvReportsList.Columns[e.ColumnIndex].Name == "btnReportDetails" && e.RowIndex >= 0)
                {
                    var selectedReport = (dynamic)dgvReportsList.Rows[e.RowIndex].DataBoundItem;
                    int reportId = selectedReport.Id;
                    ReportDetails(reportId);
                }
            };
        }
        public void ReportDetails(int reportId)
        {
            ReportDetailsForm reportDetailsForm = new ReportDetailsForm(reportId, this);
            reportDetailsForm.ShowDialog();
        }
        public void LoadReports()
        {
            cbEmployeeName.Items.Clear();
            cbHouseName.Items.Clear();
            GuvenEmlakContext a = new GuvenEmlakContext();
            foreach (var item in a.Employees.ToList())
            {
                cbEmployeeName.Items.Add(item.EmployeeName);
            }
            foreach (var item in a.Houses.ToList())
            {
                if (item.Status == "Aktif")
                {
                    cbHouseName.Items.Add(item.Address);
                }

            }
        }
        public void LoadComboBox()
        {
            cbType.Items.Clear();
            cbType.Items.Add("Satılık");
            cbType.Items.Add("Kiralık");
            cbSituation.Items.Add("Aktif");
            cbSituation.Items.Add("Pasif");
        }
        public void admin()
        {
            if (userId != 1)
            {
                tabControl1.TabPages.Remove(AddHouse);

            }

        }


        private void BtnBuy_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int houseId = (int)btn.Tag;
            HouseDetails(houseId, userId);
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int HouseId = (int)button.Tag;
            OffersDetails(userId, HouseId);
        }

        private void AddHouseCard(int houseId, int housePrice, string houseAddress, int userId, byte[] Picture)
        {
            GuvenEmlakContext g = new GuvenEmlakContext();
            var house = g.Houses.FirstOrDefault(x => x.Id == houseId);

            Panel card = new Panel
            {

                Size = new Size(150, 200),
                BorderStyle = BorderStyle.Fixed3D,

            };
            if (house.Status == "Aktif")
            {
                card.BackColor = Color.LightGreen;
            }
            else
            {
                card.BackColor = Color.Red;
            }

            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Top,
                Height = 120
            };

            using (MemoryStream ms = new MemoryStream(Picture))
            {
                pictureBox.Image = Image.FromStream(ms);

            }
            card.Controls.Add(pictureBox);

            Label lblhouseAddress = new Label
            {
                Text = houseAddress,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.TopLeft,
            };
            card.Controls.Add(lblhouseAddress);

            Button btnBuy = new Button
            {
                Text = "Satın Al",
                Dock = DockStyle.Bottom,
                Tag = houseId,
                Height = 30,
                BackColor = Color.GhostWhite,

            };
            switch (house.Status)
            {
                case "Aktif":
                    btnBuy.Text = house.Type == "Satılık" ? "Sat" : "Kirala";
                    break;
                case "Pasif":
                    btnBuy.Text = house.Type == "Satılık" ? "Satıldı" : "Kiralandı";
                    break;
            }

            btnBuy.Click += BtnBuy_Click;
            card.Controls.Add(btnBuy);

            flowHouses.Controls.Add(card);
        }
        
        public void LoadHouse()
        {
            flowHouses.Controls.Clear();
            var houses = context.Houses;
            var users = context.Users.FirstOrDefault(x => x.Id == userId);

            foreach (var house in houses)
            {
                AddHouseCard(house.Id, house.Price, house.Address, users.Id, house.Picture);
                //AddOfferHouseCard(house.Id, house.Price, house.Address, users.Id, house.Picture);
            }
        }

        private void HouseDetails(int houseId, int userId)
        {

            HouseDetails HouseDetails = new HouseDetails(houseId, userId, this);
            HouseDetails.ShowDialog();
        }

        private void OffersDetails(int userId, int HouseId)
        {
            
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPictureSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbHousePicture.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnHouseSave_Click(object sender, EventArgs e)
        {

            var housename = context.Houses.FirstOrDefault(x => x.Address == txtAdres.Text);
            if (!string.IsNullOrWhiteSpace(txtAdres.Text) &&
                !string.IsNullOrWhiteSpace(txtPrice.Text) &&
                !string.IsNullOrWhiteSpace(txtSize.Text) &&
                !string.IsNullOrWhiteSpace(txtRoomCount.Text) &&
                !string.IsNullOrWhiteSpace(cbType.Text) &&
                !string.IsNullOrWhiteSpace(cbSituation.Text))
            {
                var phone = mtxtEmployeePhone.Text;

                MemoryStream ms = new MemoryStream();
                string defaultImage = "C:\\GÜVEN EMLAK PROJESİ\\RESİMLER\\defualt.jpg";
                if (pbHousePicture.Image == null)
                {
                    Image image = Image.FromFile(defaultImage);
                    pbHousePicture.Image = image;
                }


                pbHousePicture.Image.Save(ms, pbHousePicture.Image.RawFormat);
                if (housename == null)
                {
                    var houses = new House
                    {
                        Address = txtAdres.Text,
                        Price = Convert.ToInt32(txtPrice.Text),
                        Type = cbType.Text,
                        CountRoom = Convert.ToInt32(txtRoomCount.Text),
                        Size = Convert.ToInt32(txtSize.Text),
                        Status = cbSituation.Text,
                        Picture = ms.ToArray()
                    };
                    context.Houses.Add(houses);
                    context.SaveChanges();
                    AddHouseCard(houses.Id, houses.Price, houses.Address, userId, houses.Picture);
                    MessageBox.Show("Kayıt Başarılı");
                }
                else
                {
                    MessageBox.Show("Bu Adreste Zaten Bir Ev Var");
                    return;
                }


            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun");
                return;
            }


            txtAdres.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtRoomCount.Text = string.Empty;
            cbEmployeeName.Text = string.Empty;
            cbHouseName.Text = string.Empty;
            cbType.Text = string.Empty;
            txtSize.Text = string.Empty;
            cbSituation.Text = string.Empty;
            pbHousePicture.Image = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void numPrice_Leave(object sender, EventArgs e)
        {


        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReportSave_Click(object sender, EventArgs e)
        {

            GuvenEmlakContext a = new GuvenEmlakContext();

            string cleanedPhone = new string(mtxtCustomerPhone.Text.Where(char.IsDigit).ToArray());

            var employee = a.Employees.FirstOrDefault(x => x.EmployeeName == cbEmployeeName.Text);
            

            if (!string.IsNullOrWhiteSpace(cbEmployeeName.Text) &&
                !string.IsNullOrWhiteSpace(cbHouseName.Text) &&
                cleanedPhone.Length >= 10 &&
                !string.IsNullOrWhiteSpace(txtCustomerName.Text) &&
                !string.IsNullOrWhiteSpace(txtCustomerOpinions.Text))
            {
                
                var house = a.Houses.FirstOrDefault(x => x.Address == cbHouseName.Text);
                if (cbox.Checked == true)
                {
                    house.Status = "Pasif";
                }

                var report = new Report
                {
                    EmployeeName = cbEmployeeName.Text,
                    EmployeeId = employee.Id,
                    HouseId = house.Id,
                    HouseName = cbHouseName.Text,
                    CustomerName = txtCustomerName.Text,
                    CustomerPhone = cleanedPhone,
                    CustomerOpinions = txtCustomerOpinions.Text,
                    DateTime = DateTime.Now.ToString("HH/mm / dd/MM/yyyy")
                };
                a.Reports.Add(report);
                a.SaveChanges();
                MessageBox.Show("Rapor Başarıyla Kaydedildi");

                // Temizleme
                cbEmployeeName.Text = "";
                cbHouseName.Text = "";
                txtCustomerName.Text = "";
                mtxtCustomerPhone.Text = "";
                txtCustomerOpinions.Text = "";
                cbox.Checked = false;
                load();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun");
                return;
            }




        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {








            string phone = new string(mtxtEmployeePhone.Text.Where(char.IsDigit).ToArray());
            string email = txtEmployeeEmail.Text.Trim();
            string name = txtEmployeeName.Text;
            string lastName = txtEmployeeLastName.Text;

            bool isValidEmail = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool isValidPhone = !string.IsNullOrEmpty(phone) && phone.All(char.IsDigit) && phone.Length >= 10;
            bool isValidName = !string.IsNullOrWhiteSpace(name);
            bool isValidLastName = !string.IsNullOrWhiteSpace(lastName);

            if (isValidName && isValidLastName && !string.IsNullOrEmpty(email) && isValidEmail && isValidPhone)
            {
                GuvenEmlakContext g = new GuvenEmlakContext();
                var employee = new Employee
                {
                    EmployeeName = name,
                    EmployeLastName = lastName,
                    EmployeePhone = phone,
                    EmployeeEmail = email
                };
                g.Employees.Add(employee);
                g.SaveChanges();

                txtEmployeeName.Text = "";
                txtEmployeeLastName.Text = "";
                mtxtEmployeePhone.Text = "";
                txtEmployeeEmail.Text = "";
                MessageBox.Show("Çalışan Başarıyla Kaydedildi");
                load();
            }
            else
            {
                MessageBox.Show("- Lütfen tüm alanları doğru şekilde doldurun.\n" +
                    "- Telefon: en az 10 haneli ve sadece rakam olmalı\n" +
                    "- Email: geçerli formatta olmalı");
            }

        }



        private void txtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSituation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRoomCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbHouseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeEmail_Validating(object sender, CancelEventArgs e)
        {
            //if (!txtEmployeeEmail.Text.EndsWith("@gmail.com"))
            //{
            //    MessageBox.Show("E-posta adresi '@gmail.com' ile bitmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void txtEmployeeEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void mtxtEmployeePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnReportDelete_Click(object sender, EventArgs e)
        {
            cbEmployeeName.Text = string.Empty;
            cbHouseName.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            mtxtCustomerPhone.Text = string.Empty;
            txtCustomerOpinions.Text = string.Empty;
            cbox.Checked = false;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Text = string.Empty;
            txtEmployeeLastName.Text = string.Empty;
            mtxtEmployeePhone.Text = string.Empty;
            txtEmployeeEmail.Text = string.Empty;

        }

        private void btnHouseDelete_Click(object sender, EventArgs e)
        {
            pbHousePicture.Image = null;
            txtAdres.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtRoomCount.Text = string.Empty;
            cbType.Text = string.Empty;
            cbSituation.Text = string.Empty;
            txtSize.Text = string.Empty;
            cbSituation.Text = string.Empty;
        }
    }
}
