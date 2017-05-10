﻿using System;
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

        // Important Shit
        string time = DateTime.Now.ToString("hh:mm tt");

        public Form1()
        {
            InitializeComponent();
        }

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

        private void textLog_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;
            richTextBox1.Text += "\nBoB: Hey";
            richTextBox1.Text += "\n";
            synthesizer.SpeakAsync("Hey");
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
            richTextBox1.Text += "\nBoB: Bye";
            richTextBox1.Text += "\n";
            synthesizer.SpeakAsync("Bye");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting Choices and Grammar Builder
            Choices commands = new Choices();
            commands.Add(new string[] { "Hello", "I'm good", "How are you", "Ok Bob", "Why is dad so annoying", "Whats my name", "What is Jak", "What are you", "Who is the worst", "Who are you", "What's the time", "Open Google", "Will Hellewell", "Why are you so dumb", "Say hello to Eloise", "Isn't it bob", "What songs playing", "Close Google", "Open Steam", "Close Steam" });
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
            btnDisable.Enabled = true;


            // Testing
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                // Speech Recognition
                case "Hello":
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

                case "Whats my name":
                    responces.whatsMyName();
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

                case "Open Google":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Opening Google";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Opening Google");
                    Process.Start("chrome");
                    break;

                case "Close Google":
                    string app = "chrome";
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Closing Google";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Closing Google");
                    CloseProcesses(ref app);
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

                case "Say hello to Eloise":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Hi Eloise";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Hi Eloise");
                    break;

                case "Isn't it bob":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Shut up";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Shut up");
                    break;

                case "Open Steam":
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Opening Steam";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Opening Steam");
                    Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe");
                    break;

                case "Close Steam":
                    string app1 = "Steam Client Bootstrapper";
                    richTextBox1.Text += "\n" + userName + ": " + e.Result.Text;
                    richTextBox1.Text += "\nBoB: Closing Steam";
                    richTextBox1.Text += "\n";
                    synthesizer.SpeakAsync("Closing Steam");
                    CloseProcesses(ref app1);
                    break;
            }
        }
    }
}
