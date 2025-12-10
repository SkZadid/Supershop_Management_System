using MetroFramework.Forms;
using SupershopManagement.Employee;
using SupershopManagement.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement
{
    public partial class FormLogin : MetroForm
    {
        private DataAccess Da { get; set; }
        public FormLogin()
        {

            InitializeComponent();
            this.Da = new DataAccess();
        }



        private void btnShow_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnHide.BringToFront();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnShow.BringToFront();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                //string query = null;
                string sql = "select i.Name,i.Role from LoginTable l, InfoTable i where l.UserId = i.id and l.Username='" + this.txtUsername.Text+"' and l.Password = '"+txtPassword.Text+"';";
                var ds = this.Da.ExecuteQuery(sql);
       
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var name = ds.Tables[0].Rows[0][0].ToString();
                    var role = ds.Tables[0].Rows[0][1].ToString();
                    MessageBox.Show("Valid User: " + name.ToUpper());
                    if (role == "manager")
                    {
                        this.Hide();
                        string uName = this.txtUsername.Text;
                        new FormManager(uName, this).Show();
                        
                    }
                    else if (role == "employee")
                    {
                        this.Hide();
                        string uName = this.txtUsername.Text;
                        new FormEmployee(uName, this).Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid User" , "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUsername.Text) || String.IsNullOrEmpty(this.txtPassword.Text))

                return false;
            else
                return true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLower(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                epUsername.SetError(txtUsername, "Username can contain only lowercase letters and numbers");
            }
            else
            {
                epUsername.SetError(txtUsername, "");

            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Aqua;
        }
    }
}
