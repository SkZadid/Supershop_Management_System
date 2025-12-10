using MetroFramework.Forms;
using SupershopManagement.Manager;
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
    public partial class FormEmployee : MetroForm
    {
        private FormLogin FE { get; set; }
        private UserControl uControl;
        private string userName { set; get; }
        public FormEmployee()
        {
            InitializeComponent();
        }
        public FormEmployee(string text, FormLogin fe) : this()
        {
            this.userName = text;
            this.FE = fe;
        }

       
        private void ViewUserControl(UserControl control)
        {
            if (uControl != null)
            {
                pnlEmployee.Controls.Remove(uControl);
                uControl.Dispose();
            }
            uControl = control;
            control.Dock = DockStyle.Fill;
            pnlEmployee.Controls.Add(control);
            control.Visible = true;
        }

        private void btnBillEmp_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlBill(userName));
        }

        private void btnProfileEmp_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManagerProfile(userName));
        }

        private void FormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProductEmp_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManageProducts());
        }

        private void btnLogoutEmp_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
