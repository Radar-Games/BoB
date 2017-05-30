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

namespace Cosmo
{
    #region Methods used to access form
    class Executables
    {
        
        public void textAdd(ref string text)
        {
            Cosmo.Form1._Form1.richTextBox1.Text += text;
        }
        public void synth(ref string text)
        {
            Cosmo.Form1._Form1.synthesizer.SpeakAsync(text);
        }
    }
    #endregion

    class Commands
    {
        #region Variables
        public string time = DateTime.Now.ToString("hh:mm");
        public string date = DateTime.Now.ToString("dd:mm:yyyy");
        #endregion

        #region Creating Classes
        Executables exe = new Executables();
        VariableController var = new VariableController();
        #endregion

        // Methods

        #region helloCosmo
        public void helloCosmo()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": Hello Cosmo";
            string response = "\nBoB: Hello " + Cosmo.Form1._Form1.username + ". How are you";
            string addLine = "\n";
            string synthesize = "Hello  " + Cosmo.Form1._Form1.username + " How are you?";
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Varaible Manager
            var.VarManager("helloCosmo");
        }
        #endregion

        #region imGood
        public void imGood()
        {
            // Varibles
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": I'm good";
            string response = "\nBoB: That's good";
            string addLine = "\n";
            string synthesize = "That's good";
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager
            var.VarManager("imGood");
        }
        #endregion

        #region howAreYou
        public void howAreYou()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": How are you?";
            string response = "\nBoB: I don't have emotions";
            string addLine = "\n";
            string synthesize = "I don't have emotions";
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager
            var.VarManager("howAreYou");
        }
        #endregion

        #region whatsTheTime
        public void whatsTheTime()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": What's the time?";
            string response = "\nBoB: The time is " + time;
            string addLine = "\n";
            string synthesize = "The time is " + time;
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager
            var.VarManager("whatsTheTime");
        }
        #endregion

        #region whatsTheDate
        public void whatsTheDate()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": What's the date?";
            string response = "\nBoB: The date is " + date;
            string addLine = "\n";
            string synthesize = "The date is " + date;
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager
            var.VarManager("whatsTheDate");
        }
        #endregion
    }
}
