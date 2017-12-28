namespace EMSystem
{
    partial class FrmLocations
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtLocationID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtLocationPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtLocationEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtLocationPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtLocationAddress = new MetroFramework.Controls.MetroTextBox();
            this.pLocation = new MetroFramework.Controls.MetroPanel();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.BtnBrowse = new MetroFramework.Controls.MetroButton();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtLocation = new MetroFramework.Controls.MetroTextBox();
            this.pLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Location ID:";
            // 
            // TxtLocationID
            // 
            // 
            // 
            // 
            this.TxtLocationID.CustomButton.Image = null;
            this.TxtLocationID.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.TxtLocationID.CustomButton.Name = "";
            this.TxtLocationID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLocationID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLocationID.CustomButton.TabIndex = 1;
            this.TxtLocationID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLocationID.CustomButton.UseSelectable = true;
            this.TxtLocationID.CustomButton.Visible = false;
            this.TxtLocationID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LocationBindingSource, "LocationID", true));
            this.TxtLocationID.Lines = new string[0];
            this.TxtLocationID.Location = new System.Drawing.Point(138, 20);
            this.TxtLocationID.MaxLength = 32767;
            this.TxtLocationID.Name = "TxtLocationID";
            this.TxtLocationID.PasswordChar = '\0';
            this.TxtLocationID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLocationID.SelectedText = "";
            this.TxtLocationID.SelectionLength = 0;
            this.TxtLocationID.SelectionStart = 0;
            this.TxtLocationID.ShortcutsEnabled = true;
            this.TxtLocationID.Size = new System.Drawing.Size(318, 23);
            this.TxtLocationID.TabIndex = 1;
            this.TxtLocationID.UseSelectable = true;
            this.TxtLocationID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLocationID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Location:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Contact Person:";
            // 
            // TxtLocationPerson
            // 
            // 
            // 
            // 
            this.TxtLocationPerson.CustomButton.Image = null;
            this.TxtLocationPerson.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.TxtLocationPerson.CustomButton.Name = "";
            this.TxtLocationPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLocationPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLocationPerson.CustomButton.TabIndex = 1;
            this.TxtLocationPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLocationPerson.CustomButton.UseSelectable = true;
            this.TxtLocationPerson.CustomButton.Visible = false;
            this.TxtLocationPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LocationBindingSource, "ContactPerson", true));
            this.TxtLocationPerson.Lines = new string[0];
            this.TxtLocationPerson.Location = new System.Drawing.Point(138, 78);
            this.TxtLocationPerson.MaxLength = 32767;
            this.TxtLocationPerson.Name = "TxtLocationPerson";
            this.TxtLocationPerson.PasswordChar = '\0';
            this.TxtLocationPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLocationPerson.SelectedText = "";
            this.TxtLocationPerson.SelectionLength = 0;
            this.TxtLocationPerson.SelectionStart = 0;
            this.TxtLocationPerson.ShortcutsEnabled = true;
            this.TxtLocationPerson.Size = new System.Drawing.Size(318, 23);
            this.TxtLocationPerson.TabIndex = 1;
            this.TxtLocationPerson.UseSelectable = true;
            this.TxtLocationPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLocationPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Contact E-Mail:";
            // 
            // TxtLocationEmail
            // 
            // 
            // 
            // 
            this.TxtLocationEmail.CustomButton.Image = null;
            this.TxtLocationEmail.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.TxtLocationEmail.CustomButton.Name = "";
            this.TxtLocationEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLocationEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLocationEmail.CustomButton.TabIndex = 1;
            this.TxtLocationEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLocationEmail.CustomButton.UseSelectable = true;
            this.TxtLocationEmail.CustomButton.Visible = false;
            this.TxtLocationEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LocationBindingSource, "ContactEmail", true));
            this.TxtLocationEmail.Lines = new string[0];
            this.TxtLocationEmail.Location = new System.Drawing.Point(138, 107);
            this.TxtLocationEmail.MaxLength = 32767;
            this.TxtLocationEmail.Name = "TxtLocationEmail";
            this.TxtLocationEmail.PasswordChar = '\0';
            this.TxtLocationEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLocationEmail.SelectedText = "";
            this.TxtLocationEmail.SelectionLength = 0;
            this.TxtLocationEmail.SelectionStart = 0;
            this.TxtLocationEmail.ShortcutsEnabled = true;
            this.TxtLocationEmail.Size = new System.Drawing.Size(318, 23);
            this.TxtLocationEmail.TabIndex = 1;
            this.TxtLocationEmail.UseSelectable = true;
            this.TxtLocationEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLocationEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 136);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Contact Phone:";
            // 
            // TxtLocationPhone
            // 
            // 
            // 
            // 
            this.TxtLocationPhone.CustomButton.Image = null;
            this.TxtLocationPhone.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.TxtLocationPhone.CustomButton.Name = "";
            this.TxtLocationPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLocationPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLocationPhone.CustomButton.TabIndex = 1;
            this.TxtLocationPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLocationPhone.CustomButton.UseSelectable = true;
            this.TxtLocationPhone.CustomButton.Visible = false;
            this.TxtLocationPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LocationBindingSource, "ContactPhone", true));
            this.TxtLocationPhone.Lines = new string[0];
            this.TxtLocationPhone.Location = new System.Drawing.Point(138, 136);
            this.TxtLocationPhone.MaxLength = 32767;
            this.TxtLocationPhone.Name = "TxtLocationPhone";
            this.TxtLocationPhone.PasswordChar = '\0';
            this.TxtLocationPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLocationPhone.SelectedText = "";
            this.TxtLocationPhone.SelectionLength = 0;
            this.TxtLocationPhone.SelectionStart = 0;
            this.TxtLocationPhone.ShortcutsEnabled = true;
            this.TxtLocationPhone.Size = new System.Drawing.Size(318, 23);
            this.TxtLocationPhone.TabIndex = 1;
            this.TxtLocationPhone.UseSelectable = true;
            this.TxtLocationPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLocationPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(26, 165);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Address:";
            // 
            // TxtLocationAddress
            // 
            // 
            // 
            // 
            this.TxtLocationAddress.CustomButton.Image = null;
            this.TxtLocationAddress.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.TxtLocationAddress.CustomButton.Name = "";
            this.TxtLocationAddress.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.TxtLocationAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLocationAddress.CustomButton.TabIndex = 1;
            this.TxtLocationAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLocationAddress.CustomButton.UseSelectable = true;
            this.TxtLocationAddress.CustomButton.Visible = false;
            this.TxtLocationAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LocationBindingSource, "LocationAddress", true));
            this.TxtLocationAddress.Lines = new string[0];
            this.TxtLocationAddress.Location = new System.Drawing.Point(138, 165);
            this.TxtLocationAddress.MaxLength = 32767;
            this.TxtLocationAddress.Multiline = true;
            this.TxtLocationAddress.Name = "TxtLocationAddress";
            this.TxtLocationAddress.PasswordChar = '\0';
            this.TxtLocationAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLocationAddress.SelectedText = "";
            this.TxtLocationAddress.SelectionLength = 0;
            this.TxtLocationAddress.SelectionStart = 0;
            this.TxtLocationAddress.ShortcutsEnabled = true;
            this.TxtLocationAddress.Size = new System.Drawing.Size(318, 125);
            this.TxtLocationAddress.TabIndex = 1;
            this.TxtLocationAddress.UseSelectable = true;
            this.TxtLocationAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLocationAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pLocation
            // 
            this.pLocation.Controls.Add(this.Pic);
            this.pLocation.Controls.Add(this.BtnBrowse);
            this.pLocation.Controls.Add(this.TxtLocationPhone);
            this.pLocation.Controls.Add(this.TxtLocationAddress);
            this.pLocation.Controls.Add(this.metroLabel1);
            this.pLocation.Controls.Add(this.TxtLocationEmail);
            this.pLocation.Controls.Add(this.TxtLocationID);
            this.pLocation.Controls.Add(this.TxtLocationPerson);
            this.pLocation.Controls.Add(this.metroLabel2);
            this.pLocation.Controls.Add(this.metroLabel6);
            this.pLocation.Controls.Add(this.metroLabel3);
            this.pLocation.Controls.Add(this.TxtLocation);
            this.pLocation.Controls.Add(this.metroLabel4);
            this.pLocation.Controls.Add(this.metroLabel5);
            this.pLocation.HorizontalScrollbarBarColor = true;
            this.pLocation.HorizontalScrollbarHighlightOnWheel = false;
            this.pLocation.HorizontalScrollbarSize = 10;
            this.pLocation.Location = new System.Drawing.Point(23, 63);
            this.pLocation.Name = "pLocation";
            this.pLocation.Size = new System.Drawing.Size(521, 293);
            this.pLocation.TabIndex = 2;
            this.pLocation.VerticalScrollbarBarColor = true;
            this.pLocation.VerticalScrollbarHighlightOnWheel = false;
            this.pLocation.VerticalScrollbarSize = 10;
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationIDDataGridViewTextBoxColumn,
            this.locationNameDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.contactEmailDataGridViewTextBoxColumn,
            this.contactPhoneDataGridViewTextBoxColumn,
            this.locationAddressDataGridViewTextBoxColumn});
            this.metroGrid.DataSource = this.LocationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(550, 63);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersVisible = false;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(700, 388);
            this.metroGrid.TabIndex = 3;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(192, 362);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(273, 362);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(354, 362);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(435, 362);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(111, 362);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(3, 267);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "metroButton1";
            this.BtnBrowse.UseSelectable = true;
            this.BtnBrowse.Visible = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // Pic
            // 
            this.Pic.Location = new System.Drawing.Point(3, 251);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(76, 10);
            this.Pic.TabIndex = 3;
            this.Pic.TabStop = false;
            this.Pic.Visible = false;
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "LocationID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            this.locationIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            this.locationNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "Contact Person";
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            this.contactEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "Phone/Mobile";
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            // 
            // locationAddressDataGridViewTextBoxColumn
            // 
            this.locationAddressDataGridViewTextBoxColumn.DataPropertyName = "LocationAddress";
            this.locationAddressDataGridViewTextBoxColumn.HeaderText = "Address:";
            this.locationAddressDataGridViewTextBoxColumn.Name = "locationAddressDataGridViewTextBoxColumn";
            this.locationAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // LocationBindingSource
            // 
            this.LocationBindingSource.DataSource = typeof(EMSystem.Locations);
            // 
            // TxtLocation
            // 
            // 
            // 
            // 
            this.TxtLocation.CustomButton.Image = null;
            this.TxtLocation.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.TxtLocation.CustomButton.Name = "";
            this.TxtLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLocation.CustomButton.TabIndex = 1;
            this.TxtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLocation.CustomButton.UseSelectable = true;
            this.TxtLocation.CustomButton.Visible = false;
            this.TxtLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LocationBindingSource, "LocationName", true));
            this.TxtLocation.Lines = new string[0];
            this.TxtLocation.Location = new System.Drawing.Point(138, 49);
            this.TxtLocation.MaxLength = 32767;
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.PasswordChar = '\0';
            this.TxtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLocation.SelectedText = "";
            this.TxtLocation.SelectionLength = 0;
            this.TxtLocation.SelectionStart = 0;
            this.TxtLocation.ShortcutsEnabled = true;
            this.TxtLocation.Size = new System.Drawing.Size(318, 23);
            this.TxtLocation.TabIndex = 1;
            this.TxtLocation.UseSelectable = true;
            this.TxtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 495);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.pLocation);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Name = "FrmLocations";
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.FrmLocations_Load);
            this.pLocation.ResumeLayout(false);
            this.pLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtLocationID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtLocationPerson;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtLocationEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtLocationPhone;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TxtLocationAddress;
        private MetroFramework.Controls.MetroPanel pLocation;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroButton BtnAdd;
        private System.Windows.Forms.BindingSource LocationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationAddressDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton BtnBrowse;
        private System.Windows.Forms.PictureBox Pic;
        private MetroFramework.Controls.MetroTextBox TxtLocation;
    }
}