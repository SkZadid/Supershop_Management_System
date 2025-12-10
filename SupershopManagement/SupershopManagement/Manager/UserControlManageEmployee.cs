using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace SupershopManagement.Manager
{
    public partial class UserControlManageEmployee : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlManageEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
           
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
 
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }
                if (!this.checkUsername())
                {
                    return;
                }

                var UIdFk = this.Da.ExecuteQueryTable("select max(id) from InfoTable;");
                int num = Convert.ToInt32(UIdFk.Rows[0][0].ToString());
                var quary = "insert into InfoTable values('"+(++num)+"','"+this.txtID.Text+"','"+this.txtName.Text+"','"+this.txtEmail.Text+"',"+this.txtPhone.Text+",'"+this.cmbRole.Text+"','"+this.dtpDateOfBirth.Text+"');";

                var quary2 = "insert into LoginTable values ('"+this.txtUsername.Text+"','"+this.txtPassword.Text +"',"+(num)+");";

                var count = this.Da.ExecuteDMLQuery(quary);
                var count2 = this.Da.ExecuteDMLQuery(quary2);

                if (count == 1 && count2 == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                    MessageBox.Show("Error");
                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }

        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text)
            || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.txtEmail.Text)
            || String.IsNullOrEmpty(this.cmbRole.Text)|| String.IsNullOrEmpty(this.txtPhone.Text)
            || String.IsNullOrEmpty(this.txtUsername.Text))
                return false;
            else
                return true;
        }
       
        public void PopulateGidView(string sql = "select * from InfoTable i, LoginTable l where l.UserId = i.id;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUserDetails.AutoGenerateColumns = false;
            this.dgvUserDetails.DataSource = ds.Tables[0];
        }

        private void UserControlManageEmployee_Load(object sender, EventArgs e)
        {
            this.dgvUserDetails.ClearSelection();
        }
        private bool enableAutoIdGeneration = true;
        private void dgvUserDetails_DoubleClick(object sender, EventArgs e)
        {
            enableAutoIdGeneration = false;
            this.txtPhone.Text = this.dgvUserDetails.CurrentRow.Cells[4].Value.ToString();
            this.txtName.Text = this.dgvUserDetails.CurrentRow.Cells[0].Value.ToString();
            this.txtID.Text = this.dgvUserDetails.CurrentRow.Cells[1].Value.ToString();
            this.txtUsername.Text = this.dgvUserDetails.CurrentRow.Cells[2].Value.ToString();
            this.txtPassword.Text = this.dgvUserDetails.CurrentRow.Cells["Password"].Value.ToString();
            this.txtEmail.Text = this.dgvUserDetails.CurrentRow.Cells[3].Value.ToString();
            this.dtpDateOfBirth.Text = this.dgvUserDetails.CurrentRow.Cells[6].Value.ToString();
            this.cmbRole.Text = this.dgvUserDetails.CurrentRow.Cells["Role"].Value.ToString();
            this.txtUsername.ReadOnly=true;
            this.txtPassword.ReadOnly = true;

            
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*e.Handled = true;
            epEmpUsername.SetError(txtUsername, "Username can't be changed");*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var updateQuary = "update InfoTable set Name = '"+this.txtName.Text+"'," +
                                  "Email = '"+this.txtEmail.Text+"',Phone = "+this.txtPhone.Text    +", " +
                                  "[Date Of Birth] = '"+this.dtpDateOfBirth.Text+"' " +
                                  "where UserID = '"+this.txtID.Text+"';";

                if (this.Da.ExecuteDMLQuery(updateQuary) == 1)
                    MessageBox.Show("Data has been update properly");
                else
                {
                    MessageBox.Show("Data update failed");
                    return;
                }
                    

            }catch (Exception ex)
            {
                MessageBox.Show("Error has occured"+ex.Message);
            }
            this.txtUsername.ReadOnly = false;
            this.txtPassword.ReadOnly = false;
            this.ClearAll();
            
            this.PopulateGidView();
            this.dgvUserDetails.ClearSelection();
        }
        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtName.Text = "";
            this.txtUsername.Clear();
            this.txtEmail.Clear();
            this.dtpDateOfBirth.Text = "";
            this.cmbRole.SelectedIndex = -1;
            this.txtPassword.Text="";
            this.txtPhone.Text="";

            this.txtAutoSearch.Clear();
            this.dgvUserDetails.ClearSelection();
            this.AutoIdGenerate();
        }
        private void AutoIdGenerate()
        {
            if (!enableAutoIdGeneration)
                return;


            string role = this.cmbRole.Text;
            var Sql = this.Da.ExecuteQueryTable($"select max(UserID) from InfoTable where lower(Role) = '{role}';");

            // Check if there are any rows returned by the query
            if (Sql.Rows.Count > 0 && Sql.Rows[0][0] != DBNull.Value)
            {
                var oldId = Sql.Rows[0][0].ToString();
                string[] temp = oldId.Split('-');
                int num = Convert.ToInt32(temp[1]);
                string selectedRole = cmbRole.SelectedItem.ToString();
                string newId = "";

                switch (selectedRole)
                {
                    case "manager":
                        newId = "m-" + (++num).ToString("d3");
                        break;

                    case "employee":
                        newId = "e-" + (++num).ToString("d3");
                        break;
                    default:
                        MessageBox.Show("Invalid role selected.");
                        break;
                }
                this.txtID.Text = newId;
            }
        }


        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
        }

       private bool checkUsername()
        {
            try
            {
                string sql = "select Username from LoginTable where Username ='" + this.txtUsername.Text + "' ";
                var check = Da.ExecuteQuery(sql);

                if (check.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("This username is alrady exist");
                    return false;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error has occured" + ex.Message);
            }
           return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearAll();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error has occured:\n" + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from InfoTable i, LoginTable l where l.UserId = i.id and Name='"+this.txtAutoSearch.Text+"' ;";
            this.PopulateGidView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from InfoTable i, LoginTable l where l.UserId = i.id and Username like'" + this.txtAutoSearch.Text + "%' ;";
            this.PopulateGidView(sql);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUserDetails.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var username = this.dgvUserDetails.CurrentRow.Cells[2].Value.ToString();
                var id = this.dgvUserDetails.CurrentRow.Cells[1].Value.ToString();
                
                var query1 = "delete from LoginTable where Username = '" + username + "';";
                var count1 = this.Da.ExecuteDMLQuery(query1);

                var query2 = "delete from infotable where UserID = '" + id + "';";
                var count2 = this.Da.ExecuteDMLQuery(query2);

                if (count1 == 1 && count2==1)
                    MessageBox.Show(username + "  has been removed from the list.");
                else
                    MessageBox.Show("User data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }

        }
    }
}
