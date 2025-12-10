
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement.Manager
{
    public partial class UserControlManagerProfile : MetroUserControl
    {
        private string userName {  get; set; }
        private DataAccess Da { get; set; }
       
        public UserControlManagerProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
        }
        public UserControlManagerProfile(string userName):this() 
        { 
            this.userName = userName;
            ShowData();

        }

        private void ShowData()
        {
            try
            {
                var data = "select i.Name,i.Email,i.Phone,i.[Date Of Birth],l.Username,l.Password from InfoTable i,LoginTable l where i.id = l.UserId and l.Username = '" + userName + "';";
                var ds = this.Da.ExecuteQuery(data);
                this.txtMName.Text = ds.Tables[0].Rows[0][0].ToString();
               
                this.txtMEAddress.Text = ds.Tables[0].Rows[0][1].ToString();

                this.txtMPhone.Text = ds.Tables[0].Rows[0][2].ToString();

                this.dtpMDOB.Text = ds.Tables[0].Rows[0][3].ToString();

                this.txtMUsername.Text = ds.Tables[0].Rows[0][4].ToString();

                this.txtMPassword.Text = ds.Tables[0].Rows[0][5].ToString();
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error has occured"+ex.Message);
            }
           
        }

        private void txtMUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            epManagerUsername.SetError(txtMUsername, "Username can't be updated");
        


        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                var data = "select i.UserID from InfoTable i,LoginTable l where i.id = l.UserId and l.Username = '" + userName + "'";
                var ds = this.Da.ExecuteQuery(data);
                var userId = ds.Tables[0].Rows[0][0].ToString();

                var updateQuary = "update InfoTable set Name = '" + this.txtMName.Text + "'," +
                                  "Email = '" + this.txtMEAddress.Text + "',Phone = " + this.txtMPhone.Text + ", " +
                                  "[Date Of Birth] = '" + this.dtpMDOB.Text + "' " +
                                  "where UserID = '" + userId + "';";
                var updateQuary2 = "update LoginTable set Password = '" + this.txtMPassword.Text + "' where Username = '" + userName + "'";

                if (this.Da.ExecuteDMLQuery(updateQuary) == 1 && this.Da.ExecuteDMLQuery(updateQuary2) == 1)
                    MessageBox.Show("Data has been update properly");
                else
                {
                    MessageBox.Show("Data update failed");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured" + ex.Message);
            }
        }
    }
}
