using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Cosmo
{
    public partial class Form1 : Form
    {
        // Creating References
        public SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        Commands commands = new Commands();
        public static Form1 _Form1;

        // User Variables
        public string username = "Jamie";

        public Form1()
        {
            InitializeComponent();
            // Create Reference for Form
            _Form1 = this;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[]
            {
                // Hello
                "Hello Cosmo"
            });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            // Update
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            synthesizer.Volume = 100;
        }

        public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Hello Cosmo")
            {
                commands.helloCosmo();
            }
        }
    }
}
