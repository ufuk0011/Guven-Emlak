using GuvenEmlak.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuvenEmlak
{
    public partial class HouseDetailsSettings : Form
    {
        private HouseDetails houseDetails;
        private MainForm mainForm;
        private int houseId;
        public HouseDetailsSettings(HouseDetails h, int hid, MainForm m)
        {
            InitializeComponent();
            houseDetails = h;
            mainForm = m;
            houseId = hid;
            Load();
        }
        public void Load()
        {
            MemoryStream ms = new MemoryStream();
            GuvenEmlakContext context = new GuvenEmlakContext();
            var house = context.Houses.FirstOrDefault(x => x.Id == houseId);
            cbType.Items.Add("Kiralık");
            cbType.Items.Add("Satılık");
            cbStatues.Items.Add("Aktif");
            cbStatues.Items.Add("Pasif");
            txtAdress.Text = house.Address;
            txtPrice.Text = house.Price.ToString();
            cbType.Text = house.Type;
            cbStatues.Text = house.Status;
            txtRoomCount.Text = house.CountRoom.ToString();
            txtMetre.Text = house.Size.ToString();
            pbHousePicture.Image = Image.FromStream(new MemoryStream(house.Picture));
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbHousePicture.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GuvenEmlakContext context = new GuvenEmlakContext();
            var house = context.Houses.FirstOrDefault(x => x.Id == houseId);

            if (!string.IsNullOrWhiteSpace(txtAdress.Text) &&
                !string.IsNullOrWhiteSpace(txtPrice.Text) &&
                !string.IsNullOrWhiteSpace(txtMetre.Text) &&
                !string.IsNullOrWhiteSpace(txtRoomCount.Text) &&
                !string.IsNullOrWhiteSpace(cbType.Text) &&
                !string.IsNullOrWhiteSpace(cbStatues.Text))
            {
                MemoryStream ms = new MemoryStream();
                string defaultImage = "C:\\GÜVEN EMLAK PROJESİ\\RESİMLER\\defualt.jpg";
                if (pbHousePicture.Image == null)
                {
                    Image image = Image.FromFile(defaultImage);
                    pbHousePicture.Image = image;
                }
                
                var housee = context.Houses.FirstOrDefault(x => x.Id != houseId  && x.Address == txtAdress.Text );
                pbHousePicture.Image.Save(ms, pbHousePicture.Image.RawFormat);
                if (housee == null)
                {


                    house.Address = txtAdress.Text;
                    house.Price = Convert.ToInt32(txtPrice.Text);
                    house.Type = cbType.Text;
                    house.CountRoom = Convert.ToInt32(txtRoomCount.Text);
                    house.Size = Convert.ToInt32(txtMetre.Text);
                    house.Status = cbStatues.Text;
                    house.Picture = ms.ToArray();


                    context.SaveChanges();
                    MessageBox.Show("Güncelleme Başarılı");
                    mainForm.load();
                    houseDetails.Main_Load();
                    this.Close();
                }
                else if(house.Address != txtAdress.Text && house.Id == houseId)
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
        }

        private void cbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStatues_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMetre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRoomCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
