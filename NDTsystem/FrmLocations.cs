using Dapper;
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

namespace EMSystem
{
    public partial class FrmLocations : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;

        public FrmLocations()
        {
            InitializeComponent();
        }

        void ClearInput()
        {
            TxtLocation.Text = null;
            TxtLocationPerson.Text= null;
            TxtLocationEmail.Text = null;
            TxtLocationPhone.Text = null;
            TxtLocationAddress.Text = null;
        }

        private void FrmLocations_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["connectiondbems"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    LocationBindingSource.DataSource = db.Query<Locations>("SELECT * From dbLocations", commandType: CommandType.Text);
                    pLocation.Enabled = false;
                    Locations obj = LocationBindingSource.Current as Locations;
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
            pLocation.Enabled = true;
            LocationBindingSource.Add(new Locations());
            LocationBindingSource.MoveLast();
            TxtLocation.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            pLocation.Enabled = false;
            LocationBindingSource.ResetBindings(false);
            //ClearInput();
            this.FrmLocations_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pLocation.Enabled = true;
            TxtLocation.Focus();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Locations obj = LocationBindingSource.Current as Locations;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                        Pic.Image = Image.FromFile(obj.ImageUrl);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                LocationBindingSource.EndEdit();
                Locations obj = LocationBindingSource.Current as Locations;
                if (obj != null)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["connectiondbems"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objState == EntityState.Added)
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@LocationID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new { LocationName = obj.LocationName, ContactPerson = obj.ContactPerson, ContactEmail = obj.ContactEmail, ImageUrl = obj.ImageUrl, ContactPhone = obj.ContactPhone, LocationAddress = obj.LocationAddress, });
                            db.Execute("sp_dbLocations_Insert", p, commandType: CommandType.StoredProcedure);
                            obj.LocationID = p.Get<int>("@LocationID");
                        }
                        else if (objState == EntityState.Changed)
                        {
                            db.Execute("sp_dbLocations_Update", new { LocationID = obj.LocationID, LocationName = obj.LocationName, ContactPerson = obj.ContactPerson, ContactEmail = obj.ContactEmail, ImageUrl = obj.ImageUrl, ContactPhone = obj.ContactPhone, LocationAddress = obj.LocationAddress }, commandType: CommandType.StoredProcedure);
                        }
                        metroGrid.Refresh();
                        pLocation.Enabled = false;
                        objState = EntityState.Unchanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Locations obj = LocationBindingSource.Current as Locations;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                        Pic.Image = Image.FromFile(obj.ImageUrl);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Pic.Image = Image.FromFile(ofd.FileName);
                    Locations obj = LocationBindingSource.Current as Locations;
                    if (obj != null)
                        obj.ImageUrl = ofd.FileName;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Locations obj = LocationBindingSource.Current as Locations;
                    if (obj != null)
                    {
                        using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["connectiondbems"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            int result = db.Execute("DELETE FROM dbLocations WHERE LocationID = @LocationID", new { LocationID = obj.LocationID }, commandType: CommandType.Text);
                            if (result != 0)
                            {
                                LocationBindingSource.RemoveCurrent();
                                pLocation.Enabled = false;
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
    }
}
