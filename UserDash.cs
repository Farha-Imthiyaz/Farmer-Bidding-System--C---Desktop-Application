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
    public partial class UserDash : Form
    {
        //this is a dashboard for Mileer and SFCA
        public UserDash()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmproducts FP = new frmproducts();
            FP.Show();
        }

        private void btnAuction_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Products VP = new View_Products();
            VP.Show();
        }

        private void btnPurchaseView_Click(object sender, EventArgs e)
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
    }
}
