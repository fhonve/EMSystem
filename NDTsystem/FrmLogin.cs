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
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

            if (Properties.Settings.Default.RememberMe)
            {
                TxtBoxUserName.Text = Properties.Settings.Default.UserName;
                TxtBoxPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBoxUserName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this,"Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBoxUserName.Focus();
            }
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["connectiondbems"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    db.Open();

                    User obj = db.Query<User>($"SELECT * FROM Users WHERE UserName = '{TxtBoxUserName.Text}'", commandType: CommandType.Text).SingleOrDefault();
                    if (obj!=null)
                    {
                        if (obj.Password==TxtBoxPassword.Text)
                        {
                            using (FrmMain frm = new FrmMain())
                            {
                                this.Hide();
                                frm.ShowDialog();
                            }
                        }
                        else
                        {

                            MetroFramework.MetroMessageBox.Show(this, "Username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ChkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = TxtBoxUserName.Text;
                Properties.Settings.Default.Password = TxtBoxPassword.Text;
            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
            }

            Properties.Settings.Default.RememberMe = ChkRememberMe.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
