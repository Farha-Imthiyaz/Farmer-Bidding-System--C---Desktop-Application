using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AD
{
    public partial class PurchaseView : Form
    {
        public PurchaseView()
        {
            InitializeComponent();
        }

        void Gridfill()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("PurchaseViewAll", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblpurchase = new DataTable();
                sqlda.Fill(dtblpurchase);
                dGPurchase.DataSource = dtblpurchase;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("PurchaseSearchByValue", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("_SearchValue", tBSearch.Text);
                DataTable dtblproducts = new DataTable();
                sqlda.Fill(dtblproducts);
                dGPurchase.DataSource = dtblproducts;
            }
        }

        private void dGPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
