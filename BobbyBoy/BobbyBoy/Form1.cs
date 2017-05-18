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

namespace BobbyBoy
{
    public partial class Form1 : Form
    {
        // Engines
        public SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        Class1 responces = new Class1();

        // Personal Variables
        public string userName = "Jamie";

        // Communication Variables
        public bool greeted = false;
        public bool greeted1 = false;
        public bool openApp = false;
        public bool closeApp = false;

        // Important Shit
        public string time = DateTime.Now.ToString("hh:mm tt");

        public Form1()
        {
            InitializeComponent();
            // Creating Reference to Form
            _Form1 = this;
        }

        public static  Form1 _Form1;

        public void CloseProcesses(ref string appClosed)
        {
            Process[] pArry = Process.GetProcesses();

            foreach (Process p in pArry)
            {
                string s = p.ProcessName;
                s = s.ToLower();
                if (s.CompareTo(appClosed) == 0)
                {
                    p.Kill();
                }
            }
        }

        public void textLog_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;
            richTextBox1.Text += "\nBoB: Hey";
            richTextBox1.Text += "\n";
            synthesizer.SpeakAsync("Hey");
        }

        public void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
            richTextBox1.Text += "\nBoB: Bye";
            richTextBox1.Text += "\n";
            synthesizer.SpeakAsync("Bye");
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Setting Choices and Grammar Builder
            Choices commands = new Choices();
            commands.Add(new string[]
            {
                // Initial Conversation
                "Hello Bob", "I'm good", "How are you",

                // Misc
                "Ok Bob", "Why is dad so annoying", "What is Jak",
                "Say hello to Eloise", "Isn't it Bob", 

                // Information
                "What's the time", "Who are you", "What are you",
                "What's my name",

                /// Application Manipulation
                // Open
                "Open Application", "Google",
                
                // Close
                "Close Application", "Close Google",

                // Both
                "Cancel"
            });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            // IDEK
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            synthesizer.Volume = 100;

            // Misc
            richTextBox1.Text += "\n";
            btnDisable.Enabled  = true;


            // Testing
        }

        public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                // Speech Recognition
                case "Hello Bob":
                    responces.helloBob();
                    break;

                case "I'm good":
                    responces.imGood();
                    break;

                case "How are you":
                    responces.howAreYou();
                    break;
                   
                case "Ok Bob":
                    responces.okBoB();
                    break;
                      
                case "Why is dad so annoying":
                    responces.whyIsDadSoAnnoying();
                    break;

                case "What is Jak":
                    responces.whatIsJak();
                    break;

                case "What's my name":
                    responces.whatsMyName();
                    break;

                case "What are you":
                    responces.whatAreYou();
                    break;

                case "What's the time":
                    responces.whatsTheTime();
                    break;

                case "Open Application":
                    responces.open();
                    break;
                    
                case "Google":
                    responces.openGoogle();
                    break;

                case "Close Application":
                    responces.close();
                    break;

                case "Close Google":
                    responces.closeGoogle();
                    break;

                case "Who are you":
                    responces.whoAreYou();
                    break;

                case "Say hello to Eloise":
                    responces.sayHelloToEloise();
                    break;

                case "Isn't it bob":
                    responces.isntItBob();
                    break;

                case "Cancel":
                    responces.cancel();
                    break;
            }
        }
    }
}
