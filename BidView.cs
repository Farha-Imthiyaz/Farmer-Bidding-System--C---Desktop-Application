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
    public partial class BidView : Form
    {
        public BidView()
        {
            InitializeComponent();
        }

        private void dGVBid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BidView_Load(object sender, EventArgs e)
        {
            Gridfill();
            dataGridViewbid.AllowUserToAddRows = false;
        }

        void Gridfill()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("BidViewAll", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblproducts = new DataTable();
                sqlda.Fill(dtblproducts);
                dataGridViewbid.DataSource = dtblproducts;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("BidSearchByValue", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtsearch.Text);
                DataTable dtblproducts = new DataTable();
                sqlda.Fill(dtblproducts);
                dataGridViewbid.DataSource = dtblproducts;
            }
        }

        private void dGVBid_DoubleClick(object sender, EventArgs e)
        {
            
        }

            private void dGVBid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmaxBUP_Click(object sender, EventArgs e)
        { 
               
         }

        private void txtsearch_TextChanged(object sender, EventArgs e)
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


        private void dataGridViewbid_DoubleClick(object sender, EventArgs e)
        {
            Bidding bidclass = new Bidding();
            bidclass.Unitrate = this.dataGridViewbid.CurrentRow.Cells[1].Value.ToString();
            bidclass.ProdName = this.dataGridViewbid.CurrentRow.Cells[3].Value.ToString();
            bidclass.Quantity = this.dataGridViewbid.CurrentRow.Cells[4].Value.ToString();

            Purchasing frmpur = new Purchasing(bidclass);
            frmpur.ShowDialog();
        }
        }
    }

