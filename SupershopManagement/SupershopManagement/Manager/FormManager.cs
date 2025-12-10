using MetroFramework.Forms;
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
    public partial class FormManager : MetroForm
    {
        private UserControl uControl;
        private FormLogin FM { set; get; }
        private string userName {  set; get; } 
        public FormManager()
        {
            InitializeComponent();
        }

        private void ViewUserControl(UserControl control)
        {
            if(uControl != null)
            {
                pnlProfile.Controls.Remove(uControl);
                uControl.Dispose();
            }
            uControl = control;
            control.Dock = DockStyle.Fill;
            pnlProfile.Controls.Add(control);
            control.Visible = true;
        }
        public FormManager(string text, FormLogin fm) : this()
        {
            this.userName = text;
            this.FM = fm;
        }

        private void FormManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManagerProfile(userName));
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManageEmployee());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnMProducts_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManageProducts());
        }

        private void btnSellsRecord_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlSellsRecord());
        }
    }
}
