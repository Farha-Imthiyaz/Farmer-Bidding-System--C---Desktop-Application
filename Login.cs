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
using System.Text.RegularExpressions;
using System.Speech.Synthesis;

namespace AD
{
    public partial class Login : Form
    {
        
        //this code is for login form
        public Login()
        {
            InitializeComponent();
        }

         
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this code is for validating the email
            string pattern = @"^[a-zA-Z0-9]{1,25}\@[a-zA-Z0-9]{1,15}\.[a-zA-Z]{1,5}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(tBemail.Text))
            {
                MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.ConnectionString);
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT u_type FROM tbl_user WHERE u_email='" + tBemail.Text + "' AND u_password='" +tBpassword.Text + "'",conn);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        switch (dt.Rows[0]["u_type"] as string)
                        {
                        case "Admin":
                                this.Hide();
                                Admin_Dash AD = new Admin_Dash();
                                AD.Show();
                                break;

                        case "Farmer":
                                this.Hide();
                                FarmrDash FD = new FarmrDash();
                                FD.Show();
                                break;

                        default:
                                this.Hide();
                                UserDash UD = new UserDash();
                                UD.Show();
                                 break;   
                        }
                    }
                else
                {
                    MessageBox.Show("check login details");
                }
            }
            else
            {
                MessageBox.Show("Invalid email");
            }
        }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                this.Hide();
                Signup reg = new Signup();
                reg.Show();
                
                }          

            private void pictureBox4_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                this.Hide();
                frmMain FM = new frmMain(false);
                FM.Show();
            }

            private void Login_Load(object sender, EventArgs e)
            {
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                synthesizer.Volume = 100;
                synthesizer.Rate = -2;
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.SpeakAsync("Remember your email and Password to access this system");
            }

               
                }
            }
       


        
    
