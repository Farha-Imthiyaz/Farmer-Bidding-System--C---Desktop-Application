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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
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

        private void Contact_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Volume = 100;
            synthesizer.Rate = -1;
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.SpeakAsync("you can contact us from these details.");
        }
    }
}
