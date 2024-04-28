using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.Show();

        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
