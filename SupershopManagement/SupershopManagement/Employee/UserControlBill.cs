using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement.Employee
{
    public partial class UserControlBill : UserControl
    {
        double GrandPrice = 0;
        double priceTotal = 0;
        double Price = 0;
        double Quantity = 0;
        int q = 0;
        private string userName { get; set; }
        DateTime DateTime = DateTime.Now;
        private DataAccess Da { get; set; }
        public UserControlBill()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
        }
        public UserControlBill(string userName) : this()
        {
            this.userName = userName;
          

        }
        public void PopulateGidView(string sql = "select * from ProductTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProductData.AutoGenerateColumns = false;
            this.dgvProductData.DataSource = ds.Tables[0];
        }
        private void dgvProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlBill_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvProductData_DoubleClick(object sender, EventArgs e)
        {
            this.txtPName.Text = this.dgvProductData.CurrentRow.Cells[0].Value.ToString();
            this.txtID.Text = this.dgvProductData.CurrentRow.Cells[1].Value.ToString();
            this.txtCategory.Text = this.dgvProductData.CurrentRow.Cells[4].Value.ToString();
            this.txtPrice.Text = this.dgvProductData.CurrentRow.Cells[2].Value.ToString();   

        }

        private void CalculatePrice(double Quantity, double Price)
        {
            priceTotal = Quantity * Price;
        }
        private bool IsValidTOAdd()
        {
            if (String.IsNullOrEmpty(this.txtPName.Text) || String.IsNullOrEmpty(this.txtPrice.Text)
            || String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtCategory.Text)|| string.IsNullOrEmpty(this.cmbQuantity.Text))
                return false;
            else
                return true;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

           
           

            try
            {
                if (!this.IsValidTOAdd())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                int tableQuantity = Convert.ToInt32(this.dgvProductData.CurrentRow.Cells[3].Value.ToString());
                if (tableQuantity == 0)
                {
                    MessageBox.Show("Product Not available");
                    return;
                }
                var qt = this.cmbQuantity.Text;
                Quantity = Convert.ToDouble(qt);
                var pp = this.txtPrice.Text;
                Price = Convert.ToDouble(pp);

                this.CalculatePrice(Quantity, Price);

                dgvCart.Rows.Add(this.txtPName.Text, this.cmbQuantity.Text, priceTotal);
                GrandPrice += priceTotal;
                lblTotalBill.Text = GrandPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured : " + ex.Message);
            }

            this.ClearAll();


            // this.QuantityControl();
        }
        private void ClearAll()
        {
            this.txtPName.Clear();
            this.txtID.Text = "";
            this.txtPrice.Clear();
            this.txtCategory.Clear();
           
            this.cmbQuantity.SelectedIndex = -1;
            

            
        }
        private bool IsValid()
        {
            if (String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrEmpty(this.txtCustomerPhone.Text))
                return false;
            else
                return true;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

               

                if (!this.IsValid())
                {
                    MessageBox.Show("Please Fill Customer Information");
                    return;
                }
                var query = "insert into RecordTable values('" + this.txtCustomerName.Text + "','"+this.txtCustomerPhone.Text+ "', '" + userName + "','"+DateTime+"',"+this.lblTotalBill.Text+");";

                var count = this.Da.ExecuteDMLQuery(query);


                if (count == 1)
                {
                    MessageBox.Show("Order Completed\nTotal Amount :" + this.lblTotalBill.Text + "\n Customer Name: " + this.txtCustomerName.Text + " \nCustomer Phone Number: "+ this.txtCustomerPhone.Text+" ");
                    GrandPrice = 0;
                    this.lblTotalBill.Text = " ";
                    this.dgvCart.Rows.Clear();
                    this.txtCustomerPhone.Clear();
                    this.txtCustomerName.Clear();
                    
                }
                int tableQuantity = Convert.ToInt32(this.dgvProductData.CurrentRow.Cells[3].Value.ToString());
                string id = this.dgvProductData.CurrentRow.Cells[1].Value.ToString();

                if (tableQuantity == 0)
                {
                    MessageBox.Show("Product Not available");
                    return;
                }
                double finalQuantity = tableQuantity - Quantity;
                var updateQuary = "update ProductTable set quantity = " + finalQuantity + " where id = '" + id + "';";
                this.Da.ExecuteDMLQuery(updateQuary);
                this.PopulateGidView();

                


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error has occured:\n" + ex.Message);
            }

        }
        private void QuantityControl()
        {
           
           
        }

        private void dgvCart_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            this.dgvCart.Rows.Clear();
        }
    }
    
}
