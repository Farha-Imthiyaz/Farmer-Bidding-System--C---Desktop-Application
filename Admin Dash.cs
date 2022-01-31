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
    public partial class Admin_Dash : Form
    {
        //this is a dashboard for Admin
        public Admin_Dash()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BidView BV = new BidView();
            BV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration regist = new Registration();
            regist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Products VP = new View_Products();
            VP.Show();
        }

        private void btnPDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseView PV = new PurchaseView();
            PV.Show();
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

        private void Admin_Dash_Load(object sender, EventArgs e)
        {

        }
    }
}
