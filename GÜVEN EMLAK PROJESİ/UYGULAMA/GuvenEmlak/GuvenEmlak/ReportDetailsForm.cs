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

    public partial class ReportDetailsForm : Form
    {
        private int ReportId;
        private MainForm mainForm;

        public ReportDetailsForm(int ReId, MainForm m)
        {
            InitializeComponent();
            ReportId = ReId;
            mainForm = m;
            RaporDetailsLoad();
        }
        public void RaporDetailsLoad()
        {
            GuvenEmlakContext db = new GuvenEmlakContext();
            var report = db.Reports.FirstOrDefault(r => r.Id == ReportId);
            if (report != null)
            {
                txtEmployeeName.Text = report.EmployeeName;
                txtHouseAddress.Text = report.HouseName;
                txtCustomerName.Text = report.CustomerName;
                txtCustomerPhone.Text = report.CustomerPhone;
                txtReportDate.Text = report.DateTime;
                txtCustomerOpinions.Text = report.CustomerOpinions;
            }
            else
            {
                MessageBox.Show("Rapor bulunamadı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuvenEmlakContext db = new GuvenEmlakContext();
            var report = db.Reports.FirstOrDefault(r => r.Id == ReportId);
            if (report != null)
            {
                db.Reports.Remove(report);
                db.SaveChanges();
                mainForm.load();
                this.Close();
            }
            else
            {
                MessageBox.Show("Rapor bulunamadı.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }
    }
}
