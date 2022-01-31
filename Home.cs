using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace AD
{
    public partial class frmMain : Form
    {
        private bool voice = true; 
        
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(bool voice)
        {
            InitializeComponent();
            this.voice = voice;
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void paneltop_Move(object sender, EventArgs e)
        {
            
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup reg = new Signup();
            reg.Show();
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact con = new Contact();
            con.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (voice)
            {
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                synthesizer.Volume = 100;
                synthesizer.Rate = -1;
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.SpeakAsync("Hi, We Warmly Welcome to our Agri Department in Kaluthara. Our Aim is We Provide Healthy Foods For Our Nation.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
