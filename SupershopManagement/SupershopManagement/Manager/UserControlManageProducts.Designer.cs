namespace SupershopManagement.Manager
{
    partial class UserControlManageProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnPRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnPUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnPAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cmbPCatagory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtPAutoSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.btnPClear);
            this.panel1.Controls.Add(this.btnPRemove);
            this.panel1.Controls.Add(this.btnPUpdate);
            this.panel1.Controls.Add(this.btnPAdd);
            this.panel1.Controls.Add(this.cmbPCatagory);
            this.panel1.Controls.Add(this.txtPId);
            this.panel1.Controls.Add(this.txtPQuantity);
            this.panel1.Controls.Add(this.txtPPrice);
            this.panel1.Controls.Add(this.txtPName);
            this.panel1.Controls.Add(this.guna2HtmlLabel6);
            this.panel1.Controls.Add(this.guna2HtmlLabel5);
            this.panel1.Controls.Add(this.guna2HtmlLabel4);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 242);
            this.panel1.TabIndex = 0;
            // 
            // btnPClear
            // 
            this.btnPClear.Animated = true;
            this.btnPClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPClear.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPClear.Font = new System.Drawing.Font("Magneto", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPClear.ForeColor = System.Drawing.Color.Black;
            this.btnPClear.Location = new System.Drawing.Point(680, 6);
            this.btnPClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(96, 23);
            this.btnPClear.TabIndex = 7;
            this.btnPClear.Text = "Clear";
            this.btnPClear.Click += new System.EventHandler(this.btnPClear_Click);
            // 
            // btnPRemove
            // 
            this.btnPRemove.Animated = true;
            this.btnPRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnPRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPRemove.FillColor = System.Drawing.Color.White;
            this.btnPRemove.Font = new System.Drawing.Font("Magneto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPRemove.ForeColor = System.Drawing.Color.Black;
            this.btnPRemove.Location = new System.Drawing.Point(625, 193);
            this.btnPRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnPRemove.Name = "btnPRemove";
            this.btnPRemove.Size = new System.Drawing.Size(151, 43);
            this.btnPRemove.TabIndex = 4;
            this.btnPRemove.Text = "Remove";
            this.btnPRemove.Click += new System.EventHandler(this.btnPRemove_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.Animated = true;
            this.btnPUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPUpdate.FillColor = System.Drawing.Color.White;
            this.btnPUpdate.Font = new System.Drawing.Font("Magneto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnPUpdate.Location = new System.Drawing.Point(477, 193);
            this.btnPUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(140, 43);
            this.btnPUpdate.TabIndex = 5;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.Animated = true;
            this.btnPAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPAdd.FillColor = System.Drawing.Color.White;
            this.btnPAdd.Font = new System.Drawing.Font("Magneto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPAdd.ForeColor = System.Drawing.Color.Black;
            this.btnPAdd.Location = new System.Drawing.Point(353, 193);
            this.btnPAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(116, 43);
            this.btnPAdd.TabIndex = 6;
            this.btnPAdd.Text = "ADD";
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // cmbPCatagory
            // 
            this.cmbPCatagory.BackColor = System.Drawing.Color.Transparent;
            this.cmbPCatagory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPCatagory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPCatagory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPCatagory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPCatagory.ItemHeight = 30;
            this.cmbPCatagory.Items.AddRange(new object[] {
            "snacks",
            "soft drinks",
            "grocery",
            "bakery",
            "dairy",
            "fruits",
            "vegetables",
            "meat & fish"});
            this.cmbPCatagory.Location = new System.Drawing.Point(487, 57);
            this.cmbPCatagory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPCatagory.Name = "cmbPCatagory";
            this.cmbPCatagory.Size = new System.Drawing.Size(209, 36);
            this.cmbPCatagory.TabIndex = 2;
            // 
            // txtPId
            // 
            this.txtPId.Animated = true;
            this.txtPId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPId.DefaultText = "";
            this.txtPId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPId.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.ForeColor = System.Drawing.Color.Black;
            this.txtPId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPId.Location = new System.Drawing.Point(109, 98);
            this.txtPId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPId.Name = "txtPId";
            this.txtPId.PasswordChar = '\0';
            this.txtPId.PlaceholderText = "";
            this.txtPId.SelectedText = "";
            this.txtPId.Size = new System.Drawing.Size(177, 28);
            this.txtPId.TabIndex = 1;
            // 
            // txtPQuantity
            // 
            this.txtPQuantity.Animated = true;
            this.txtPQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPQuantity.DefaultText = "";
            this.txtPQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPQuantity.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtPQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPQuantity.Location = new System.Drawing.Point(109, 193);
            this.txtPQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPQuantity.Name = "txtPQuantity";
            this.txtPQuantity.PasswordChar = '\0';
            this.txtPQuantity.PlaceholderText = "";
            this.txtPQuantity.SelectedText = "";
            this.txtPQuantity.Size = new System.Drawing.Size(177, 28);
            this.txtPQuantity.TabIndex = 1;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Animated = true;
            this.txtPPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPPrice.DefaultText = "";
            this.txtPPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPrice.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPrice.Location = new System.Drawing.Point(109, 145);
            this.txtPPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.PasswordChar = '\0';
            this.txtPPrice.PlaceholderText = "";
            this.txtPPrice.SelectedText = "";
            this.txtPPrice.Size = new System.Drawing.Size(177, 28);
            this.txtPPrice.TabIndex = 1;
            // 
            // txtPName
            // 
            this.txtPName.Animated = true;
            this.txtPName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPName.DefaultText = "";
            this.txtPName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.ForeColor = System.Drawing.Color.Black;
            this.txtPName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.Location = new System.Drawing.Point(109, 54);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPName.Name = "txtPName";
            this.txtPName.PasswordChar = '\0';
            this.txtPName.PlaceholderText = "";
            this.txtPName.SelectedText = "";
            this.txtPName.Size = new System.Drawing.Size(177, 28);
            this.txtPName.TabIndex = 1;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(4, 196);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(95, 26);
            this.guna2HtmlLabel6.TabIndex = 0;
            this.guna2HtmlLabel6.Text = "Quantity";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(4, 145);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(55, 26);
            this.guna2HtmlLabel5.TabIndex = 0;
            this.guna2HtmlLabel5.Text = "Price";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(377, 57);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(95, 26);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Category";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(4, 98);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(27, 26);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "ID";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(4, 54);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 26);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(283, 0);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(168, 30);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Manage Products";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(301, 4);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(154, 30);
            this.guna2HtmlLabel7.TabIndex = 0;
            this.guna2HtmlLabel7.Text = "Product Details";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dgvProductDetails);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 332);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(816, 279);
            this.guna2Panel1.TabIndex = 1;
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.AllowUserToResizeRows = false;
            this.dgvProductDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.category,
            this.price,
            this.quantity,
            this.date});
            this.dgvProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.RowHeadersWidth = 51;
            this.dgvProductDetails.RowTemplate.Height = 24;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(816, 279);
            this.dgvProductDetails.TabIndex = 0;
            this.dgvProductDetails.DoubleClick += new System.EventHandler(this.dgvProductDetails_DoubleClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ProductID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 130;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Pricce";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 90;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Adding Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 180;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.guna2Panel2.Controls.Add(this.btnPSearch);
            this.guna2Panel2.Controls.Add(this.txtPAutoSearch);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 248);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(816, 84);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnPSearch
            // 
            this.btnPSearch.Animated = true;
            this.btnPSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnPSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnPSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPSearch.ForeColor = System.Drawing.Color.White;
            this.btnPSearch.Image = global::SupershopManagement.Properties.Resources.search__1_;
            this.btnPSearch.Location = new System.Drawing.Point(188, 29);
            this.btnPSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(65, 47);
            this.btnPSearch.TabIndex = 7;
            this.btnPSearch.UseTransparentBackground = true;
            this.btnPSearch.Click += new System.EventHandler(this.btnPSearch_Click);
            // 
            // txtPAutoSearch
            // 
            this.txtPAutoSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPAutoSearch.DefaultText = "";
            this.txtPAutoSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPAutoSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPAutoSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPAutoSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPAutoSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAutoSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPAutoSearch.ForeColor = System.Drawing.Color.Black;
            this.txtPAutoSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAutoSearch.Location = new System.Drawing.Point(41, 37);
            this.txtPAutoSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPAutoSearch.Name = "txtPAutoSearch";
            this.txtPAutoSearch.PasswordChar = '\0';
            this.txtPAutoSearch.PlaceholderText = "Name/Category";
            this.txtPAutoSearch.SelectedText = "";
            this.txtPAutoSearch.Size = new System.Drawing.Size(199, 27);
            this.txtPAutoSearch.TabIndex = 3;
            this.txtPAutoSearch.TextChanged += new System.EventHandler(this.txtPAutoSearch_TextChanged);
            // 
            // UserControlManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlManageProducts";
            this.Size = new System.Drawing.Size(816, 611);
            this.Load += new System.EventHandler(this.UserControlManageProducts_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPId;
        private Guna.UI2.WinForms.Guna2TextBox txtPQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtPPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPCatagory;
        private Guna.UI2.WinForms.Guna2Button btnPRemove;
        private Guna.UI2.WinForms.Guna2Button btnPUpdate;
        private Guna.UI2.WinForms.Guna2Button btnPAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnPClear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPAutoSearch;
        private Guna.UI2.WinForms.Guna2Button btnPSearch;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
