using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSystem
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        
        private void metroTile5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            FrmEquipment frm = new FrmEquipment();
            frm.Show();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            FrmContacts frm = new FrmContacts();
            frm.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            FrmLocations frm = new FrmLocations();
            frm.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            FrmRent frm = new FrmRent();
            frm.Show();
        }
    }
}
