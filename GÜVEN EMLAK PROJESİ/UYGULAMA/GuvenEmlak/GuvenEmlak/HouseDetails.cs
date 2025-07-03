using GuvenEmlak.Models;
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
    public partial class HouseDetails : Form
    {
        private int userId;
        private int housesId;
        private MainForm Mainform;
        public HouseDetails(int houseId, int usersId, MainForm mainForm)
        {
            InitializeComponent();
            userId = usersId;
            housesId = houseId;
            Mainform = mainForm;
            Main_Load();
        }

        public void Main_Load()
        {
            load();
            
        }
        public void load()
        {
            GuvenEmlakContext g = new GuvenEmlakContext();
            var user = g.Users.FirstOrDefault(x => x.Id == userId);
            var house = g.Houses.FirstOrDefault(x => x.Id == housesId);
            if (house.Type == "Kiralık")
            {
                btnSell.Text = "Kirala";
            }
            else if (house.Type == "Satılık")
            {
                btnSell.Text = "Sat";
            }

            if (house.Status == "Aktif")
            {
                btnSellCancel.Enabled = false;
                btnSellCancel.Text = "İPTAL";
            }
            else
            {
                btnSellCancel.Enabled = true;
                btnSellCancel.Text = "İPTAL";
            }
            if (house.Status == "Pasif" && house.Type == "Kiralık")
            {
                btnSell.Enabled = false;
                btnSell.Text = "Kiralandı";
            }
            else
            {
                btnSell.Enabled = true;
            }
            if (house.Status == "Pasif" && house.Type == "Satılık")
            {
                btnSell.Enabled = false;
                btnSell.Text = "Satıldı";
            }

            MemoryStream ms = new MemoryStream(house.Picture);
            format f = new format();


            pbHousePicture.Image = Image.FromStream(ms);
            lblAddress.Text = house.Address;
            lblCountRoom.Text = Convert.ToString(house.CountRoom);
            lblPrice.Text = $"{house.Price:C} TL";
            lblSize.Text = Convert.ToString(house.Size);
            lblStatus.Text = house.Status;
            lblType.Text = house.Type;
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            GuvenEmlakContext g = new GuvenEmlakContext();
            var house = g.Houses.FirstOrDefault(x => x.Id == housesId);
            house.Status = "Pasif";
            g.SaveChanges();
            load();
            Mainform.load();

        }

        private void btnSellCancel_Click(object sender, EventArgs e)
        {
            GuvenEmlakContext g = new GuvenEmlakContext();
            var house = g.Houses.FirstOrDefault(x => x.Id == housesId);
            house.Status = "Aktif";
            g.SaveChanges();
            load();
            Mainform.load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuvenEmlakContext a = new GuvenEmlakContext();
            var house = a.Houses.FirstOrDefault(x => x.Id == housesId);
            a.Houses.Remove(house);
            a.SaveChanges();
            Mainform.load();
            this.Close();
        }

        private void btnHouseSettings_Click(object sender, EventArgs e)
        {
            HouseDetailsSettings house=new HouseDetailsSettings(this ,housesId,Mainform);
            house.ShowDialog();
        }
    }
}
