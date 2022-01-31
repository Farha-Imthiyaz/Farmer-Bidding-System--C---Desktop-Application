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
    public partial class Formbid : Form
    {
        string name;
        int quantity;
        string type;
        string category;
        string duration;
        int unitprice;
        DateTime biddate;

        // this is a bid form
        private int b_id;
        private int prod_id;

        public Products product;

        public Formbid()
        {
            InitializeComponent();
        }

        public Formbid(Products prod)
        {
            InitializeComponent();
            this.product = prod;
            name = prod.Name;
            quantity = prod.Quantityofprod;
            type = prod.Type;
            category = prod.Category;
            duration = prod.BidDuration;
            unitprice = prod.UnitPriceofprod;
            biddate = prod.BidDate;
           
            Gridfill();
            Clear();
        }

        //this is a code for fill grid view
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

        //this is a code for clear the text boxes
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text =
             textBox6.Text = textBox7.Text = dateTimePicker1.Text = dateTimePickertddate.Text = "";

            b_id = 0;
            btnSave.Text = "Save";
            buttonDelete.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.product = product;
            textBox1.Text = name;
            textBox2.Text = Convert.ToString(quantity);
            textBox4.Text = type;
            textBox5.Text = category;
            textBox6.Text = duration;
            textBox3.Text = Convert.ToString(unitprice);
            dateTimePicker1.Text = Convert.ToString(biddate);

            Gridfill();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
                Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("BidAddOrEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_BID", b_id);
                cmd.Parameters.AddWithValue("_BUnitRate", textBox7.Text.Trim());
                cmd.Parameters.AddWithValue("_BTodayDate", dateTimePickertddate.Value);
                cmd.Parameters.AddWithValue("_BPName", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("_BQuanty", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("_BPPrice", textBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Submitted!");
                Clear();
                Gridfill();
            }
        }

        private void dataGridViewbid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewbid.CurrentRow.Index != -1)
            {
                textBox7.Text = dataGridViewbid.CurrentRow.Cells[1].Value.ToString();
                dateTimePickertddate.Text = Convert.ToString(dataGridViewbid.CurrentRow.Cells[2].Value);
                textBox1.Text = dataGridViewbid.CurrentRow.Cells[3].Value.ToString();
                textBox2.Text = Convert.ToString(dataGridViewbid.CurrentRow.Cells[4].Value);
                textBox3.Text = dataGridViewbid.CurrentRow.Cells[5].Value.ToString();

                b_id = Convert.ToInt32(dataGridViewbid.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";

                buttonDelete.Enabled = Enabled;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("BidDeleteByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_BID", b_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                Clear();
                Gridfill();
                conn.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("BidSearchByValue", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("_SearchValue", textBox8.Text);
                DataTable dtblbid = new DataTable();
                sqlda.Fill(dtblbid);
                dataGridViewbid.DataSource = dtblbid;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Products FM = new View_Products();
            FM.Show();
        }

    }
}
