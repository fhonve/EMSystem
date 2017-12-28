namespace EMSystem
{
    partial class FrmContacts
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
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pContacts = new MetroFramework.Controls.MetroPanel();
            this.ChkType = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.TxtPosition = new MetroFramework.Controls.MetroTextBox();
            this.TxtPhone = new MetroFramework.Controls.MetroTextBox();
            this.TxtBirthday = new MetroFramework.Controls.MetroTextBox();
            this.TxtCompany = new MetroFramework.Controls.MetroTextBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtFullName = new MetroFramework.Controls.MetroTextBox();
            this.TxtContactID = new MetroFramework.Controls.MetroTextBox();
            this.BtnBrowse = new MetroFramework.Controls.MetroButton();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.pContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.contactIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.Company,
            this.Position,
            this.typeDataGridViewCheckBoxColumn,
            this.Phone,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.metroGrid.DataSource = this.contactsBindingSource;
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
            this.metroGrid.Location = new System.Drawing.Point(23, 130);
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
            this.metroGrid.Size = new System.Drawing.Size(629, 483);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellClick);
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "Type";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.Width = 50;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 250;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataSource = typeof(EMSystem.Contacts);
            // 
            // pContacts
            // 
            this.pContacts.Controls.Add(this.ChkType);
            this.pContacts.Controls.Add(this.metroLabel4);
            this.pContacts.Controls.Add(this.metroLabel5);
            this.pContacts.Controls.Add(this.metroLabel7);
            this.pContacts.Controls.Add(this.metroLabel8);
            this.pContacts.Controls.Add(this.metroLabel6);
            this.pContacts.Controls.Add(this.metroLabel10);
            this.pContacts.Controls.Add(this.metroLabel3);
            this.pContacts.Controls.Add(this.metroLabel2);
            this.pContacts.Controls.Add(this.metroLabel1);
            this.pContacts.Controls.Add(this.TxtAddress);
            this.pContacts.Controls.Add(this.TxtPosition);
            this.pContacts.Controls.Add(this.TxtPhone);
            this.pContacts.Controls.Add(this.TxtBirthday);
            this.pContacts.Controls.Add(this.TxtCompany);
            this.pContacts.Controls.Add(this.TxtEmail);
            this.pContacts.Controls.Add(this.TxtFullName);
            this.pContacts.Controls.Add(this.TxtContactID);
            this.pContacts.Controls.Add(this.BtnBrowse);
            this.pContacts.Controls.Add(this.Pic);
            this.pContacts.HorizontalScrollbarBarColor = true;
            this.pContacts.HorizontalScrollbarHighlightOnWheel = false;
            this.pContacts.HorizontalScrollbarSize = 10;
            this.pContacts.Location = new System.Drawing.Point(690, 130);
            this.pContacts.Name = "pContacts";
            this.pContacts.Size = new System.Drawing.Size(531, 483);
            this.pContacts.TabIndex = 0;
            this.pContacts.VerticalScrollbarBarColor = true;
            this.pContacts.VerticalScrollbarHighlightOnWheel = false;
            this.pContacts.VerticalScrollbarSize = 10;
            // 
            // ChkType
            // 
            this.ChkType.AutoSize = true;
            this.ChkType.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contactsBindingSource, "Type", true));
            this.ChkType.Location = new System.Drawing.Point(291, 98);
            this.ChkType.Name = "ChkType";
            this.ChkType.Size = new System.Drawing.Size(38, 15);
            this.ChkType.TabIndex = 2;
            this.ChkType.Text = "???";
            this.ChkType.UseSelectable = true;
            this.ChkType.CheckStateChanged += new System.EventHandler(this.ChkType_CheckStateChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(194, 94);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Type";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(194, 235);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Address:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(194, 177);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Phone/Mobile:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(194, 148);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(57, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Position:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(194, 457);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Birthday:";
            this.metroLabel6.Visible = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(194, 119);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(69, 19);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "Company:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(194, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Email:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(194, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Full Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(194, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Contact ID:";
            // 
            // TxtAddress
            // 
            // 
            // 
            // 
            this.TxtAddress.CustomButton.Image = null;
            this.TxtAddress.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.TxtAddress.CustomButton.Name = "";
            this.TxtAddress.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.TxtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddress.CustomButton.TabIndex = 1;
            this.TxtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddress.CustomButton.UseSelectable = true;
            this.TxtAddress.CustomButton.Visible = false;
            this.TxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Address", true));
            this.TxtAddress.Lines = new string[0];
            this.TxtAddress.Location = new System.Drawing.Point(291, 235);
            this.TxtAddress.MaxLength = 32767;
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.SelectionLength = 0;
            this.TxtAddress.SelectionStart = 0;
            this.TxtAddress.ShortcutsEnabled = true;
            this.TxtAddress.Size = new System.Drawing.Size(236, 112);
            this.TxtAddress.TabIndex = 5;
            this.TxtAddress.UseSelectable = true;
            this.TxtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPosition
            // 
            // 
            // 
            // 
            this.TxtPosition.CustomButton.Image = null;
            this.TxtPosition.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtPosition.CustomButton.Name = "";
            this.TxtPosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPosition.CustomButton.TabIndex = 1;
            this.TxtPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPosition.CustomButton.UseSelectable = true;
            this.TxtPosition.CustomButton.Visible = false;
            this.TxtPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Position", true));
            this.TxtPosition.Lines = new string[0];
            this.TxtPosition.Location = new System.Drawing.Point(291, 148);
            this.TxtPosition.MaxLength = 32767;
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.PasswordChar = '\0';
            this.TxtPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPosition.SelectedText = "";
            this.TxtPosition.SelectionLength = 0;
            this.TxtPosition.SelectionStart = 0;
            this.TxtPosition.ShortcutsEnabled = true;
            this.TxtPosition.Size = new System.Drawing.Size(236, 23);
            this.TxtPosition.TabIndex = 3;
            this.TxtPosition.UseSelectable = true;
            this.TxtPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPhone
            // 
            // 
            // 
            // 
            this.TxtPhone.CustomButton.Image = null;
            this.TxtPhone.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtPhone.CustomButton.Name = "";
            this.TxtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPhone.CustomButton.TabIndex = 1;
            this.TxtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPhone.CustomButton.UseSelectable = true;
            this.TxtPhone.CustomButton.Visible = false;
            this.TxtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Phone", true));
            this.TxtPhone.Lines = new string[0];
            this.TxtPhone.Location = new System.Drawing.Point(291, 177);
            this.TxtPhone.MaxLength = 32767;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.PasswordChar = '\0';
            this.TxtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPhone.SelectedText = "";
            this.TxtPhone.SelectionLength = 0;
            this.TxtPhone.SelectionStart = 0;
            this.TxtPhone.ShortcutsEnabled = true;
            this.TxtPhone.Size = new System.Drawing.Size(236, 23);
            this.TxtPhone.TabIndex = 3;
            this.TxtPhone.UseSelectable = true;
            this.TxtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtBirthday
            // 
            // 
            // 
            // 
            this.TxtBirthday.CustomButton.Image = null;
            this.TxtBirthday.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtBirthday.CustomButton.Name = "";
            this.TxtBirthday.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBirthday.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBirthday.CustomButton.TabIndex = 1;
            this.TxtBirthday.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBirthday.CustomButton.UseSelectable = true;
            this.TxtBirthday.CustomButton.Visible = false;
            this.TxtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Birthday", true));
            this.TxtBirthday.Lines = new string[0];
            this.TxtBirthday.Location = new System.Drawing.Point(291, 457);
            this.TxtBirthday.MaxLength = 32767;
            this.TxtBirthday.Name = "TxtBirthday";
            this.TxtBirthday.PasswordChar = '\0';
            this.TxtBirthday.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBirthday.SelectedText = "";
            this.TxtBirthday.SelectionLength = 0;
            this.TxtBirthday.SelectionStart = 0;
            this.TxtBirthday.ShortcutsEnabled = true;
            this.TxtBirthday.Size = new System.Drawing.Size(236, 23);
            this.TxtBirthday.TabIndex = 3;
            this.TxtBirthday.UseSelectable = true;
            this.TxtBirthday.Visible = false;
            this.TxtBirthday.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBirthday.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtCompany
            // 
            // 
            // 
            // 
            this.TxtCompany.CustomButton.Image = null;
            this.TxtCompany.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtCompany.CustomButton.Name = "";
            this.TxtCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCompany.CustomButton.TabIndex = 1;
            this.TxtCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCompany.CustomButton.UseSelectable = true;
            this.TxtCompany.CustomButton.Visible = false;
            this.TxtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Company", true));
            this.TxtCompany.Lines = new string[0];
            this.TxtCompany.Location = new System.Drawing.Point(291, 119);
            this.TxtCompany.MaxLength = 32767;
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.PasswordChar = '\0';
            this.TxtCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCompany.SelectedText = "";
            this.TxtCompany.SelectionLength = 0;
            this.TxtCompany.SelectionStart = 0;
            this.TxtCompany.ShortcutsEnabled = true;
            this.TxtCompany.Size = new System.Drawing.Size(236, 23);
            this.TxtCompany.TabIndex = 4;
            this.TxtCompany.UseSelectable = true;
            this.TxtCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Email", true));
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(291, 206);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(236, 23);
            this.TxtEmail.TabIndex = 4;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtFullName
            // 
            // 
            // 
            // 
            this.TxtFullName.CustomButton.Image = null;
            this.TxtFullName.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtFullName.CustomButton.Name = "";
            this.TxtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtFullName.CustomButton.TabIndex = 1;
            this.TxtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtFullName.CustomButton.UseSelectable = true;
            this.TxtFullName.CustomButton.Visible = false;
            this.TxtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "FullName", true));
            this.TxtFullName.Lines = new string[0];
            this.TxtFullName.Location = new System.Drawing.Point(291, 65);
            this.TxtFullName.MaxLength = 32767;
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.PasswordChar = '\0';
            this.TxtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtFullName.SelectedText = "";
            this.TxtFullName.SelectionLength = 0;
            this.TxtFullName.SelectionStart = 0;
            this.TxtFullName.ShortcutsEnabled = true;
            this.TxtFullName.Size = new System.Drawing.Size(236, 23);
            this.TxtFullName.TabIndex = 1;
            this.TxtFullName.UseSelectable = true;
            this.TxtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtContactID
            // 
            // 
            // 
            // 
            this.TxtContactID.CustomButton.Image = null;
            this.TxtContactID.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtContactID.CustomButton.Name = "";
            this.TxtContactID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContactID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContactID.CustomButton.TabIndex = 1;
            this.TxtContactID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContactID.CustomButton.UseSelectable = true;
            this.TxtContactID.CustomButton.Visible = false;
            this.TxtContactID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "ContactID", true));
            this.TxtContactID.Lines = new string[0];
            this.TxtContactID.Location = new System.Drawing.Point(291, 36);
            this.TxtContactID.MaxLength = 32767;
            this.TxtContactID.Name = "TxtContactID";
            this.TxtContactID.PasswordChar = '\0';
            this.TxtContactID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContactID.SelectedText = "";
            this.TxtContactID.SelectionLength = 0;
            this.TxtContactID.SelectionStart = 0;
            this.TxtContactID.ShortcutsEnabled = true;
            this.TxtContactID.Size = new System.Drawing.Size(236, 23);
            this.TxtContactID.TabIndex = 0;
            this.TxtContactID.UseSelectable = true;
            this.TxtContactID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContactID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(70, 202);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 6;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseSelectable = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // Pic
            // 
            this.Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic.Location = new System.Drawing.Point(27, 36);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(160, 160);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 2;
            this.Pic.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(1065, 619);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(984, 619);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(903, 619);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(822, 619);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(741, 619);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 676);
            this.Controls.Add(this.pContacts);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Name = "FrmContacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.FrmContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.pContacts.ResumeLayout(false);
            this.pContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroPanel pContacts;
        private MetroFramework.Controls.MetroTextBox TxtContactID;
        private MetroFramework.Controls.MetroButton BtnBrowse;
        private System.Windows.Forms.PictureBox Pic;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox ChkType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtAddress;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtFullName;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroButton BtnAdd;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox TxtPosition;
        private MetroFramework.Controls.MetroTextBox TxtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox TxtBirthday;
        private MetroFramework.Controls.MetroTextBox TxtCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}