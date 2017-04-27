using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Bob
{
    public partial class Form1 : Form
    {
        // Engines
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        // Personal Variables
        string userName = "Jamie";

        // Important Shit
        string time = DateTime.Now.ToString("hh:mm tt");

        // Form 1
        public Form1()
        {
            InitializeComponent();
        }

        // Enable Button Clicked
        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
        }

        //Disable Button Clicked
        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting Choices and Grammar Builder
            Choices commands = new Choices();
            commands.Add(new string[] { "Say hello", "Whats my name", "What are you", "Who is the worst", "Who are you", "What's the time", "Open google", "Will Hellewell", "Why are u so dumb"});
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            // IDEK
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

            // Misc
            richTextBox1.Text += "\n";
        }

        // Functions
        

        // Speech Recognition
        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                // Speech Recognition
                case "Say hello":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Hello " + userName + ". How are you";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Hello  " + userName + " How are you?");
                    break;

                case "Whats my name":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text; 
                    richTextBox1.Text += "\nBoB: Jamie";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Jamie");
                    break;

                case "What are you":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: I am a Speech Recognition system programmed in C#";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("I am a Speech Recognition system programmed in C sharp");
                    break;

                case "Who is the worst":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Scotty Dunc dad";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Scotty Dunk Dad");
                    break;

                case "What's the time":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: " + time;
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync(time);
                    break;

                case "Open google":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Opening Google";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Opening Google");
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                    break;

                case "Who are you":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: I am BoB a speech recognition system programmed in C#";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("I am BoB a speech recognition system programmed in c sharp");
                    break;

                case "Will Hellewell":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Sick Radical dabs";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Sick radical dabs");
                    break;

                case "Why are you so dumb":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Im only as smart as the person that made me";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Im only as smart as the person that made me");
                    break;
            }
        }
    }
}