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
    public partial class Purchasing : Form
    {
        int unitprice1;
        string name1;
        int quantity1;
        int total;

        // this code is for purchasing
        int pur_id=0;


        public Bidding bid;
        public Purchasing()
        {
            InitializeComponent();
        }

        public Purchasing(Bidding bidding)
        {
            InitializeComponent();
            this.bid = bidding;
            name1 = bidding.ProdName;
            quantity1 = Convert.ToInt32(bidding.Quantity);
            unitprice1 = Convert.ToInt32(bidding.Unitrate);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //this is a code for add or edit purchasing
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("PurchaseAddOrEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_PurchaseID", pur_id);
                //cmd.Parameters.AddWithValue("_Puserid ", u_id);
                cmd.Parameters.AddWithValue("_PPayType", cBPaymentType.Text.Trim());
                cmd.Parameters.AddWithValue("_PDate", dateTimePickerPurchase.Value);
                cmd.Parameters.AddWithValue("_PUnitPrice", tBPUPrice.Text.Trim());
                cmd.Parameters.AddWithValue("_PQuantity", tBQuantity.Text.Trim());
                cmd.Parameters.AddWithValue("_PTotalprice", tBTotalPrice.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Submitted!");
                Clear();
                Gridfill();

            }
        }
        // this code is for data grd view fill in purchasing
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

        // this code is for clear text boxes in purchasing
        void Clear()
        {
            cBPaymentType.Text = dateTimePickerPurchase.Text = tBPUPrice.Text = tBQuantity.Text = tBTotalPrice.Text = "";
            //int purchase_id;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        void Sum()
        {
           total= unitprice1* quantity1;
           tBTotalPrice.Text = Convert.ToString(total);
        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            tBPUPrice.Text = Convert.ToString(unitprice1);
            tBQuantity.Text = Convert.ToString(quantity1);
            tBPName.Text = name1;
            Sum();
            Gridfill();
        }

        // this code is for update in purchasing
        private void dGPurchase_DoubleClick(object sender, EventArgs e)
        {

            if (dGPurchase.CurrentRow.Index != -1)
            {
                cBPaymentType.Text = dGPurchase.CurrentRow.Cells[1].Value.ToString();
                dateTimePickerPurchase.Text = dGPurchase.CurrentRow.Cells[5].Value.ToString();
                tBPUPrice.Text = dGPurchase.CurrentRow.Cells[2].Value.ToString();
                tBQuantity.Text = dGPurchase.CurrentRow.Cells[3].Value.ToString();
                tBTotalPrice.Text = dGPurchase.CurrentRow.Cells[4].Value.ToString();

                pur_id = Convert.ToInt32(dGPurchase.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";

                btnDelete.Enabled = Enabled;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // this code is for search by value in purchasing
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

        // this code is for delete by ID in purchasing
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("PurchaseDeleteByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_PurchaseID", pur_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                Clear();
                Gridfill();
                conn.Close();
            }
        }

        private void tBTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerPurchase_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cBPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPdate_Click(object sender, EventArgs e)
        {

        }

        private void lblPType_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void tBQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void tBPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BidView BV = new BidView();
            BV.Show();
        }
    }
}
