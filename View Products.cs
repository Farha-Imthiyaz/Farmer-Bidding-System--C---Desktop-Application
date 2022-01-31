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
    public partial class View_Products : Form
    {
        public string bidding;
        public View_Products()
        {
            InitializeComponent();
        }



        private void View_Products_Load(object sender, EventArgs e)
        {
            Gridfill();
        }

        void Gridfill()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("ProductsViewAll", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblproducts = new DataTable();
                sqlda.Fill(dtblproducts);
                dGVProducts2.DataSource = dtblproducts;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("ProductsSearchByValue", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtsearch.Text);
                DataTable dtblproducts = new DataTable();
                sqlda.Fill(dtblproducts);
                dGVProducts2.DataSource = dtblproducts;
            }
        }

        private void dGVProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Products prod = new Products();
            //prod.ProdID = Convert.ToInt32(this.dGVProducts2.CurrentRow.Cells[0].Value);
            prod.Name = this.dGVProducts2.CurrentRow.Cells[1].Value.ToString();
            prod.Type = this.dGVProducts2.CurrentRow.Cells[2].Value.ToString();
            prod.Category = this.dGVProducts2.CurrentRow.Cells[3].Value.ToString();
            prod.Quantityofprod = Convert.ToInt32(this.dGVProducts2.CurrentRow.Cells[4].Value);
            prod.UnitPriceofprod = Convert.ToInt32(this.dGVProducts2.CurrentRow.Cells[5].Value);
            prod.BidDate = Convert.ToDateTime(this.dGVProducts2.CurrentRow.Cells[6].Value);
            prod.BidDuration = this.dGVProducts2.CurrentRow.Cells[7].Value.ToString();

            Formbid frmbid = new Formbid(prod);
            frmbid.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void View_Products_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
