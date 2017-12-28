using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace EMSystem
{
    public partial class FrmContacts : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;

        public FrmContacts()
        {
            InitializeComponent();
        }
        

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    Pic.Image = Image.FromFile(ofd.FileName);
                    Contacts obj = contactsBindingSource.Current as Contacts;
                    if (obj != null)
                        obj.ImageUrl = ofd.FileName;
                }
            }
        }
        
        void ClearInput()
        {
            TxtFullName.Text = null;
            TxtEmail.Text = null;
            TxtAddress.Text = null;
            ChkType.Checked = false;
            TxtBirthday.Text = null;
            Pic.Image = null;
            TxtPhone = null;
            TxtPosition = null;
            TxtCompany = null;
        }

        private void FrmContacts_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["connectiondbems"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    contactsBindingSource.DataSource = db.Query<Contacts>("SELECT * From dbContacts", commandType: CommandType.Text);
                    pContacts.Enabled = false;
                    Contacts obj = contactsBindingSource.Current as Contacts;
                    if (obj != null)
                    {
                        if (!string.IsNullOrEmpty(obj.ImageUrl))
                            Pic.Image = Image.FromFile(obj.ImageUrl);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            Pic.Image = null;
            pContacts.Enabled = true;
            contactsBindingSource.Add(new Contacts());
            contactsBindingSource.MoveLast();
            TxtFullName.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            pContacts.Enabled = false;
            contactsBindingSource.ResetBindings(false);
            //ClearInput();
            this.FrmContacts_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pContacts.Enabled = true;
            TxtFullName.Focus();
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Contacts obj = contactsBindingSource.Current as Contacts;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                        Pic.Image = Image.FromFile(obj.ImageUrl);
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if(MetroFramework.MetroMessageBox.Show(this,"Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Contacts obj = contactsBindingSource.Current as Contacts;
                    if (obj != null)
                    { 
                        using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["connectiondbems"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            int result = db.Execute("DELETE FROM dbContacts WHERE ContactID = @ContactID", new { ContactID = obj.ContactID }, commandType: CommandType.Text);
                            if (result != 0)
                            {
                                contactsBindingSource.RemoveCurrent();
                                pContacts.Enabled = false;
                                Pic.Image = null;
                                objState = EntityState.Unchanged;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                contactsBindingSource.EndEdit();
                Contacts obj = contactsBindingSource.Current as Contacts;
                if (obj != null)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["connectiondbems"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objState == EntityState.Added)
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@ContactID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new { FullName = obj.FullName, Email = obj.Email, Address = obj.Address, Type = obj.Type, Birthday = obj.Birthday, ImageUrl = obj.ImageUrl, Phone = obj.Phone, Position = obj.Position, Company = obj.Company });
                            db.Execute("sp_dbContacts_Insert", p, commandType: CommandType.StoredProcedure);
                            obj.ContactID = p.Get<int>("@ContactID");
                        }
                        else if (objState == EntityState.Changed)
                        {
                            db.Execute("sp_dbContacts_Update", new { ContactID = obj.ContactID, FullName = obj.FullName, Email = obj.Email, Address = obj.Address, Type = obj.Type, Birthday = obj.Birthday, ImageUrl = obj.ImageUrl, Phone = obj.Phone, Position = obj.Position, Company = obj.Company }, commandType: CommandType.StoredProcedure);
                        }
                        metroGrid.Refresh();
                        pContacts.Enabled = false;
                        objState = EntityState.Unchanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkType_CheckStateChanged(object sender, EventArgs e)
        {
            if (ChkType.CheckState == CheckState.Checked)
                ChkType.Text = "Customer/Supplier";
            else if (ChkType.CheckState == CheckState.Unchecked)
                ChkType.Text = "Employee";
            else
                ChkType.Text = "???";
        }
    }
}
