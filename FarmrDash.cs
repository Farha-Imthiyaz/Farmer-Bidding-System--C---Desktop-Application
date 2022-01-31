using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD
{
    public partial class FarmrDash : Form
    {
        //this is a dashboard for Farmer
        public FarmrDash()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmproducts FD = new frmproducts();
            FD.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            BidView BV = new BidView();
            BV.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain FM = new frmMain(false);
            FM.Show();
        }

        private void FarmrDash_Load(object sender, EventArgs e)
        {

        }
    }
}
