using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement
{
    public partial class UserControlSellsRecord : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlSellsRecord()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
        }

        private void dgvSellsRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void PopulateGidView(string sql = "select * from RecordTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSellsRecord.AutoGenerateColumns = false;
            this.dgvSellsRecord.DataSource = ds.Tables[0];
            
        }

        private void UserControlSellsRecord_Load(object sender, EventArgs e)
        {
            this.dgvSellsRecord.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from RecordTable" +
               " where SellerName like '%" + this.txtSearch.Text + "%' " +
               "OR Time like '%" + this.txtSearch.Text + "%' ;";
            this.PopulateGidView(sql);
        }
    }
}
