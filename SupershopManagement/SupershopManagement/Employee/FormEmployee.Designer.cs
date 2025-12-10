namespace SupershopManagement.Employee
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnProductEmp = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLogoutEmp = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBillEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfileEmp = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEmployee = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.btnProductEmp);
            this.guna2Panel1.Controls.Add(this.pictureBox4);
            this.guna2Panel1.Controls.Add(this.pictureBox3);
            this.guna2Panel1.Controls.Add(this.btnLogoutEmp);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.btnBillEmp);
            this.guna2Panel1.Controls.Add(this.btnProfileEmp);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(15, 49);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(184, 512);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnProductEmp
            // 
            this.btnProductEmp.Animated = true;
            this.btnProductEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductEmp.FillColor = System.Drawing.Color.MintCream;
            this.btnProductEmp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductEmp.ForeColor = System.Drawing.Color.Black;
            this.btnProductEmp.Location = new System.Drawing.Point(57, 167);
            this.btnProductEmp.Name = "btnProductEmp";
            this.btnProductEmp.Size = new System.Drawing.Size(106, 33);
            this.btnProductEmp.TabIndex = 10;
            this.btnProductEmp.Text = "Product";
            this.btnProductEmp.Click += new System.EventHandler(this.btnProductEmp_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SupershopManagement.Properties.Resources.delivery_box;
            this.pictureBox4.Location = new System.Drawing.Point(16, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SupershopManagement.Properties.Resources.bill;
            this.pictureBox3.Location = new System.Drawing.Point(16, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnLogoutEmp
            // 
            this.btnLogoutEmp.Animated = true;
            this.btnLogoutEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogoutEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogoutEmp.FillColor = System.Drawing.Color.Red;
            this.btnLogoutEmp.Font = new System.Drawing.Font("Lucida Fax", 13.8F);
            this.btnLogoutEmp.ForeColor = System.Drawing.Color.White;
            this.btnLogoutEmp.Location = new System.Drawing.Point(58, 425);
            this.btnLogoutEmp.Name = "btnLogoutEmp";
            this.btnLogoutEmp.Size = new System.Drawing.Size(106, 39);
            this.btnLogoutEmp.TabIndex = 6;
            this.btnLogoutEmp.Text = "Log out";
            this.btnLogoutEmp.Click += new System.EventHandler(this.btnLogoutEmp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SupershopManagement.Properties.Resources.power_off;
            this.pictureBox2.Location = new System.Drawing.Point(16, 425);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnBillEmp
            // 
            this.btnBillEmp.Animated = true;
            this.btnBillEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBillEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBillEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBillEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBillEmp.FillColor = System.Drawing.Color.MintCream;
            this.btnBillEmp.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBillEmp.ForeColor = System.Drawing.Color.Black;
            this.btnBillEmp.Location = new System.Drawing.Point(58, 101);
            this.btnBillEmp.Name = "btnBillEmp";
            this.btnBillEmp.Size = new System.Drawing.Size(106, 30);
            this.btnBillEmp.TabIndex = 4;
            this.btnBillEmp.Text = "Bill";
            this.btnBillEmp.Click += new System.EventHandler(this.btnBillEmp_Click);
            // 
            // btnProfileEmp
            // 
            this.btnProfileEmp.Animated = true;
            this.btnProfileEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfileEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfileEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfileEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfileEmp.FillColor = System.Drawing.Color.MintCream;
            this.btnProfileEmp.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnProfileEmp.ForeColor = System.Drawing.Color.Black;
            this.btnProfileEmp.Location = new System.Drawing.Point(57, 24);
            this.btnProfileEmp.Name = "btnProfileEmp";
            this.btnProfileEmp.Size = new System.Drawing.Size(106, 34);
            this.btnProfileEmp.TabIndex = 3;
            this.btnProfileEmp.Text = "Profile";
            this.btnProfileEmp.Click += new System.EventHandler(this.btnProfileEmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SupershopManagement.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(16, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Location = new System.Drawing.Point(205, 49);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(654, 518);
            this.pnlEmployee.TabIndex = 3;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 577);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "FormEmployee";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "FormEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployee_FormClosed);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnProductEmp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnLogoutEmp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnBillEmp;
        private Guna.UI2.WinForms.Guna2Button btnProfileEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlEmployee;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}