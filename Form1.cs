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
    public partial class frmproducts : Form
    {
        int products_id =0;
        public frmproducts()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string GetName(string _PName, string _PType)
        {
            return string.Concat(_PName, " ", _PType);
        }

        //this is a code for add or edit products
        public void btnsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("ProductsAddOrEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_ProdID", products_id);
                cmd.Parameters.AddWithValue("_PName", tBnameProd.Text.Trim());
                cmd.Parameters.AddWithValue("_PQntity", tBquantity1.Text.Trim());
                cmd.Parameters.AddWithValue("_PUnitprice", tBunitprice1.Text.Trim());
                cmd.Parameters.AddWithValue("_PType", cbtypeofProd.Text.Trim());
                cmd.Parameters.AddWithValue("_PCategory", tBcategoryofProd.Text.Trim());
                cmd.Parameters.AddWithValue("_PBidDuration", tBBD.Text.Trim());
                cmd.Parameters.AddWithValue("_PBidDate", dTPBSD.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Submitted!");
                Clear();
                Gridfill();

            }
        }

        public void Gridfill()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("ProductsViewAll", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblproducts = new DataTable();
                sqlda.Fill(dtblproducts);
                dGVProducts.DataSource = dtblproducts;
            }
        }

        private void txttotalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmproducts_Load(object sender, EventArgs e)
        {
                Gridfill();
                Clear();
        }

        void Clear()
        {
            tBnameProd.Text = cbtypeofProd.Text = tBcategoryofProd.Text = tBquantity1.Text = tBunitprice1.Text = tBBD.Text  = "";
                
                products_id = 0;
                btnsave.Text = "Save";
                btndelete.Enabled = false;
        }

        private void dGVProducts_DoubleClick(object sender, EventArgs e)
        {
            if (dGVProducts.CurrentRow.Index != -1)
            {
                tBnameProd.Text = dGVProducts.CurrentRow.Cells[1].Value.ToString();
                tBquantity1.Text = dGVProducts.CurrentRow.Cells[4].Value.ToString();
                tBunitprice1.Text = dGVProducts.CurrentRow.Cells[5].Value.ToString();
                cbtypeofProd.Text = dGVProducts.CurrentRow.Cells[2].Value.ToString();
                tBcategoryofProd.Text = dGVProducts.CurrentRow.Cells[3].Value.ToString();
                tBBD.Text = dGVProducts.CurrentRow.Cells[7].Value.ToString();
                dTPBSD.Text = dGVProducts.CurrentRow.Cells[6].Value.ToString();

                products_id = Convert.ToInt32(dGVProducts.CurrentRow.Cells[0].Value.ToString());
                btnsave.Text = "Update";

                btndelete.Enabled = Enabled;
            }
        }

        private void btdclear_Click(object sender, EventArgs e)
        {
                Clear();
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
                dGVProducts.DataSource = dtblproducts;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("ProductsDeleteByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_ProdID", products_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                Clear();
                Gridfill();
                conn.Close();
            }
        }

        private void dGVProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain FM = new frmMain((false));
            FM.Show();
        }

        

       

      
    }
}
