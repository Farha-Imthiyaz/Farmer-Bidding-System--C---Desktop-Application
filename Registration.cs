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
using System.Globalization;

namespace AD
{
    public partial class Registration : Form
    {
        // these codes are for user form
        int u_id = 0;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Gridfill();
            Clear();
        }

        //this is a code for add or edit user
        private void btnsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UserAddOrEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_UID", u_id);
                cmd.Parameters.AddWithValue("_UType", cbusertype.Text.Trim());
                cmd.Parameters.AddWithValue("_UName", tBusername.Text.Trim());
                cmd.Parameters.AddWithValue("_UPassword", tBpassword.Text.Trim());
                cmd.Parameters.AddWithValue("_UAddress", tBaddress.Text.Trim());
                cmd.Parameters.AddWithValue("_UFullName", tBfullname.Text.Trim());
                cmd.Parameters.AddWithValue("_UDOB", dtpickerdob.Value);
                cmd.Parameters.AddWithValue("_UPhoneNumber", tBphonnumber.Text.Trim());
                cmd.Parameters.AddWithValue("_UGender", cbgender.Text.Trim());
                cmd.Parameters.AddWithValue("_UEmail", tBemail.Text.Trim());
                cmd.Parameters.AddWithValue("_UNIC", tBnicno.Text.Trim());
                cmd.Parameters.AddWithValue("_UGovApprovedNum", tBGAID.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Submitted!");
                Clear();
                Gridfill();
                conn.Close();
            }
        }

        // this is a code for update user
        private void dGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dGVuser.CurrentRow.Index != -1)
            {
                cbusertype.Text = dGVuser.CurrentRow.Cells[1].Value.ToString();
                tBusername.Text = dGVuser.CurrentRow.Cells[2].Value.ToString();
                tBpassword.Text = dGVuser.CurrentRow.Cells[3].Value.ToString();
                tBaddress.Text = dGVuser.CurrentRow.Cells[4].Value.ToString();
                tBfullname.Text = dGVuser.CurrentRow.Cells[5].Value.ToString();
                dtpickerdob.Text = (dGVuser.CurrentRow.Cells[6].Value.ToString());
                //dtpickerdob.Text= DateTime.ParseExact(dGVuser.CurrentRow.Cells[8].Value.ToString(),
                //"dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                tBphonnumber.Text = dGVuser.CurrentRow.Cells[7].Value.ToString();
                cbgender.Text = dGVuser.CurrentRow.Cells[8].Value.ToString();
                tBemail.Text = dGVuser.CurrentRow.Cells[9].Value.ToString();
                tBnicno.Text = dGVuser.CurrentRow.Cells[10].Value.ToString();
                tBGAID.Text = dGVuser.CurrentRow.Cells[11].Value.ToString();

                u_id = Convert.ToInt32(dGVuser.CurrentRow.Cells[0].Value.ToString());
                btnsave.Text = "Update";

                btndelete.Enabled = Enabled;
            }
        }

        //this is a code for fill the datagrid view in user
        void Gridfill()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("userViewAll",conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblproducts = new DataTable();
                sqlda.Fill(dtblproducts);
                dGVuser.DataSource = dtblproducts;
            }
        }

        //this is a code for clear the text boxes in user
        void Clear()
        {
            cbusertype.Text = tBusername.Text = tBpassword.Text = tBaddress.Text = tBfullname.Text =
             dtpickerdob.Text = tBphonnumber.Text = cbgender.Text = tBemail.Text = tBnicno.Text = tBGAID.Text = "";       
                
                u_id = 0;
                btnsave.Text = "Save";
                btndelete.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //this is a code for search by value in user
        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("UserSearchByValue", conn);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("_SearchValue", tBsearch.Text);
                DataTable dtbluser = new DataTable();
                sqlda.Fill(dtbluser);
                dGVuser.DataSource = dtbluser;
            }
        }

        //this is a code for delete by ID in user
        private void btndelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UserDeleteByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_UID", u_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                Clear();
                Gridfill();
                conn.Close();
            }
        }

        private void tBGAID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGAID_Click(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void dtpickerdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbusertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblregistration_Click(object sender, EventArgs e)
        {

        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void lblage_Click(object sender, EventArgs e)
        {

        }

        private void lbldob_Click(object sender, EventArgs e)
        {

        }

        private void lblusertype_Click(object sender, EventArgs e)
        {

        }

        private void lblnicno_Click(object sender, EventArgs e)
        {

        }

        private void tBnicno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void tBusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void tBage_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblphonenumber_Click(object sender, EventArgs e)
        {

        }

        private void tBaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        private void tBphonnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfullname_Click(object sender, EventArgs e)
        {

        }

        private void tBfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelleftside_Paint(object sender, PaintEventArgs e)
        {

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
            Admin_Dash BV = new Admin_Dash();
            BV.Show();
        }
    }
}
