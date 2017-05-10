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


public class Class1
{
    BobbyBoy.Form1 j = new BobbyBoy.Form1();
	public void helloBob()
	{
        // Console
        j.richTextBox1.Text += "\n" + j.userName + ": Hello BoB";
        j.richTextBox1.Text += "\nBoB: Hello " + j.userName + ". How are you";
        j.richTextBox1.Text += "\n";
        // Synthesize
        j.synthesizer.SpeakAsync("Hello  " + j.userName + " How are you?");
        // Varibles
        j.greeted = true;
    }
}
