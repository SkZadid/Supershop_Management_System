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
    public partial class UserControlManageProducts : UserControl
    {
        private DataAccess Da { get; set; }
        DateTime DateTime = DateTime.Now;
        public UserControlManageProducts()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();

            //this.AutoIdGenerate();
        }
        //private bool enableAutoIdGeneration = true;

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }
                if (!this.checkName())
                {
                    return;
                }

                var quary = "insert into ProductTable values('"+this.txtPId.Text+"','"+this.txtPName.Text+"',"+this.txtPPrice.Text+","+this.txtPQuantity.Text+",'"+DateTime+"','"+this.cmbPCatagory.Text+"')";

                var count = this.Da.ExecuteDMLQuery(quary);

                if (count == 1)
                    MessageBox.Show("1 product has been added properly");
                else
                    MessageBox.Show("Product can't be added"); ;
                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void UserControlManageProducts_Load(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        public void PopulateGidView(string sql = "select * from ProductTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProductDetails.AutoGenerateColumns = false;
            this.dgvProductDetails.DataSource = ds.Tables[0];
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtPName.Text) || String.IsNullOrEmpty(this.txtPId.Text)
            || String.IsNullOrEmpty(this.txtPPrice.Text) || String.IsNullOrEmpty(this.txtPQuantity.Text)
            || String.IsNullOrEmpty(this.cmbPCatagory.Text) )
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.txtPName.Clear();
            this.txtPId.Text = "";
            this.txtPPrice.Clear();
            this.txtPQuantity.Clear();
           // this.dtpProductAddTime.Text = "";
            this.cmbPCatagory.SelectedIndex = -1;
            

            this.txtPAutoSearch.Clear();
            this.dgvProductDetails.ClearSelection();
            this.AutoIdGenerate();
        }

        private void dgvProductDetails_DoubleClick(object sender, EventArgs e)
        {
            //enableAutoIdGeneration = false;
            this.txtPName.Text = this.dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
            this.txtPId.Text = this.dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
            this.txtPPrice.Text = this.dgvProductDetails.CurrentRow.Cells[3].Value.ToString();
            this.txtPQuantity.Text = this.dgvProductDetails.CurrentRow.Cells[4].Value.ToString();
            //this.dtpProductAddTime.Text = this.dgvProductDetails.CurrentRow.Cells[5].Value.ToString();
            this.cmbPCatagory.Text = this.dgvProductDetails.CurrentRow.Cells[2].Value.ToString();

            this.txtPId.ReadOnly = true;
        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void AutoIdGenerate()
        {
            var sql = "select id from ProductTable order by Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "p-" + (++num).ToString("d3");
            //MessageBox.Show(newId);
            this.txtPId.Text = newId;
        }



        private void UserControlManageProducts_Load_1(object sender, EventArgs e)
        {
           this.AutoIdGenerate();
        }

        private void dtpProductAddTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var updateQuary = "update ProductTable set name = '" + this.txtPName.Text + "'," +
                                  "price = " + this.txtPPrice.Text + ", " +
                                  "quantity = '" + this.txtPQuantity.Text + "', " +
                                  "category='"+this.cmbPCatagory.Text+"'"+
                                  "where id = '" + this.txtPId.Text + "';";

                if (this.Da.ExecuteDMLQuery(updateQuary) == 1)
                    MessageBox.Show("Product Data has been update properly");
                else
                {
                    MessageBox.Show("Product Data update failed");
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured" + ex.Message);
            }
            this.txtPId.ReadOnly = false;
            
            this.ClearAll();

            this.PopulateGidView();
            this.dgvProductDetails.ClearSelection();
        }

        private void btnPRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductDetails.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
                var title = this.dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
                //MessageBox.Show(id+title);
                var query = "delete from ProductTable where id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Movie data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void txtPAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from ProductTable" +
               " where name like '%" + this.txtPAutoSearch.Text + "%' " +
               "OR category like '%" + this.txtPAutoSearch.Text + "%' ;";
            this.PopulateGidView(sql);
        }

        private void btnPSearch_Click(object sender, EventArgs e)
        {
            /*var sql = "select * from ProductTable" +
                " where name like '%" + this.txtPAutoSearch.Text + "%' " +
                "OR category like '%" + this.txtPAutoSearch.Text + "%' ;";
            this.PopulateGidView(sql);*/
        }
        private bool checkName()
        {
            try
            {
                string sql = "select name from ProductTable where name ='" + this.txtPName.Text + "' ";
                var check = Da.ExecuteQuery(sql);

                if (check.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("This name is alrady exist");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured" + ex.Message);
            }
            return true;
        }
    }
}
