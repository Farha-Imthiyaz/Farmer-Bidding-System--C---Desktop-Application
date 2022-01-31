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
using System.Speech.Synthesis;

namespace AD
{
    public partial class Signup : Form
    {
        int u_id = 0;
        public Signup()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
        }
            

        private void btnclear_Click(object sender, EventArgs e)
        {

        }
         void Clear()
        {
            cbusertype.Text = tBusername.Text = tBpassword.Text = tBaddress.Text = tBfullname.Text =
             dtpickerdob.Text = tBphonnumber.Text = cbgender.Text = textBox2.Text = tBnicno.Text = textBox1.Text = "";

            u_id = 0;
            btnsave.Text = "Save";
            
        }

         private void SignUp_Load(object sender, EventArgs e)
         {

             SpeechSynthesizer synthesizer = new SpeechSynthesizer();
             synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
             synthesizer.Volume = 100;
             synthesizer.Rate = -2;
             synthesizer.SetOutputToDefaultAudioDevice();
             synthesizer.SpeakAsync("Welcome to Registeration Page.");
         }

         private void tBaddress_TextChanged(object sender, EventArgs e)
         {

         }

         private void tBemail_TextChanged(object sender, EventArgs e)
         {

         }

         private void tBGAID_TextChanged(object sender, EventArgs e)
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

         private void lblemail_Click(object sender, EventArgs e)
         {

         }

         private void lblGAID_Click(object sender, EventArgs e)
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

         private void pictureBox1_Click(object sender, EventArgs e)
         {
             this.Hide();
             frmMain FM = new frmMain(false);
             FM.Show();
         }

         private void pictureBox3_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         //this is a code for add user
         private void button1_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("_UEmail", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("_UNIC", tBnicno.Text.Trim());
                cmd.Parameters.AddWithValue("_UGovApprovedNum", textBox1.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Submitted!");
                Clear();
                conn.Close();
            }
        }
         public String Getuser(String _UFullName, String _UGender)
         {
             return String.Concat(_UFullName, " ", _UGender);
         }  

         private void panel2_Paint(object sender, PaintEventArgs e)
         {

         }
         }
   }


  

