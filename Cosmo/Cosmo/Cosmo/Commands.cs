using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmo
{
    class Commands
    {
        public void helloCosmo()
        {
            // Console
            Cosmo.Form1._Form1.richTextBox1.Text += "\n" + Cosmo.Form1._Form1.username + ": Hello Cosmo";
            Cosmo.Form1._Form1.richTextBox1.Text += "\nBoB: Hello " + Cosmo.Form1._Form1.username + ". How are you";
            Cosmo.Form1._Form1.richTextBox1.Text += "\n";
            // Synthesize
            Cosmo.Form1._Form1.synthesizer.SpeakAsync("Hello  " + Cosmo.Form1._Form1.username + " How are you?");
        }
    }
}
