using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;

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

        // Conversation Variable
        public bool greeted1 = false;
        public bool greeted2 = false;
        public bool initial = false;
        public bool open = false;
        public bool close = false;
        public bool spotPlaying = false;
        public bool MasterControls = false;

        public Form1()
        {
            InitializeComponent();
            // Create Reference for Form
            _Form1 = this;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
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
                // Greeting
                "Hello Cosmo", "I'm good", "How are you",

                // Application Manipulation
                "Close Application", "Open Application",

                "Google Chrome",

                // Time/Date
                "What's the time", "What's the date",

                // Weather
                "What's the weather like today", "What's the temperature",

                // Spotify
                "Play song", "Pause song",

                // Master Controls
                "Enable master controls", "Disable master controls",
                
                "Spotify is playing", "Spotify is paused"
            });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            
            // Loading  Grammar and defualt settings
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            synthesizer.Volume = 100;
            synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
        }

        public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Confidence >= 0.7)
            {
                #region Greeting
                if (e.Result.Text == "Hello Cosmo")
                {
                    commands.helloCosmo();
                }

                if (e.Result.Text == "I'm good")
                {
                    commands.imGood();
                }

                if (e.Result.Text == "How are you")
                {
                    commands.howAreYou();
                }
                #endregion

                #region Get Information
                if (e.Result.Text == "What's the time")
                {
                    commands.whatsTheTime();
                }

                if (e.Result.Text == "What's the date")
                {
                    commands.whatsTheDate();
                }

                if (e.Result.Text == "What's the weather like today")
                {
                    commands.whatsTheWeatherLikeToday();
                }

                if (e.Result.Text == "What's the temperature")
                {
                    commands.whatsTheTemperature();
                }
                #endregion

                #region Open/Close Application
                if (e.Result.Text == "Open Application")
                {
                    commands.openApplication();
                }

                if (e.Result.Text == "Close Application")
                {
                    commands.closeApplication();
                }

                if (e.Result.Text == "Google Chrome")
                {
                    if (open == true)
                    {
                        commands.openGoogleChrome();
                    }

                    if (close == true)
                    {
                        commands.closeGoogleChrome();
                    }
                }
                #endregion

                #region Spotify Controls
                if (e.Result.Text == "Play song")
                {
                    commands.playSong();
                }

                if (e.Result.Text == "Pause song")
                {
                    commands.pauseSong();
                }
                #endregion

                #region Master Controls
                if (e.Result.Text == "Enable master controls")
                {
                    commands.enableMasterControls();
                }

                if (e.Result.Text == "Disable master controls")
                {
                    commands.disableMasterControls();
                }
                #endregion
            }
        }
    }
}
