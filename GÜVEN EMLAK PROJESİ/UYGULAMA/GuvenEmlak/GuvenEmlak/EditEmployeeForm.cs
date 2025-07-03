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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuvenEmlak
{
    public partial class EditEmployeeForm : Form
    {
        private int EmployeeId;
        private MainForm mainForm;
        public EditEmployeeForm(int EmId, MainForm m)
        {
            InitializeComponent();
            EmployeeId = EmId;
            mainForm = m;
            loadEmployeeData();
        }

        public void loadEmployeeData()
        {
            GuvenEmlakContext db = new GuvenEmlakContext();
            var employee = db.Employees.FirstOrDefault(e => e.Id == EmployeeId);
            if (employee != null)
            {
                txtEmployeeName.Text = employee.EmployeeName;
                txtEmployeeLastName.Text = employee.EmployeLastName;
                txtEmployeeEmail.Text = employee.EmployeeEmail;
                mtxtEmployeePhone.Text = employee.EmployeePhone;
            }
            else
            {
                MessageBox.Show("Çalışan bulunamadı.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GuvenEmlakContext db = new GuvenEmlakContext();
            var employee = db.Employees.FirstOrDefault(e => e.Id == EmployeeId);
            if (employee != null)
            {
                if (txtEmployeeName.Text is not null)
                {
                    employee.EmployeeName = txtEmployeeName.Text;
                }
                if (txtEmployeeLastName.Text is not null)
                {
                    employee.EmployeLastName = txtEmployeeLastName.Text;
                }
                if (txtEmployeeEmail.Text is not null)
                {
                    employee.EmployeeEmail = txtEmployeeEmail.Text;
                }
                if (mtxtEmployeePhone.Text is not null)
                {
                    employee.EmployeePhone = mtxtEmployeePhone.Text;
                }
                else
                {
                    MessageBox.Show("Çalışan bulunamadı.");
                    return;
                }
                db.SaveChanges();
                mainForm.load();
                mainForm.EmployyeList();
                this.Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuvenEmlakContext db = new GuvenEmlakContext();
            var employee = db.Employees.FirstOrDefault(e => e.Id == EmployeeId);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                mainForm.load();
                this.Close();
            }
            else
            {
                MessageBox.Show("Çalışan bulunamadı.");
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

        private void txtEmployeeEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!txtEmployeeEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("E-posta adresi '@gmail.com' ile bitmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

