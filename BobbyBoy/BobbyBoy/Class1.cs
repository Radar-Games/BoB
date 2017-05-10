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
        j.richTextBox1.Text += "\n" + j.userName + ": Hello";
        j.richTextBox1.Text += "\nBoB: Hello " + j.userName + ". How are you";
        j.richTextBox1.Text += "\n";
        // Synthesize
        j.synthesizer.SpeakAsync("Hello  " + j.userName + " How are you?");
        // Activating Varibles
        j.greeted = true;
    }

    public void imGood()
    {
        if(j.greeted == true)
        {
            // Console
            j.richTextBox1.Text += "\n" + j.userName + ": " + "I'm Good";
            j.richTextBox1.Text += "\nBoB: That's good";
            j.richTextBox1.Text += "\n";
            // Synthesize
            j.synthesizer.SpeakAsync("That's good");
            // Activating Variables
            j.greeted1 = true;
            // Deacivating Variables
            j.greeted = false;
        }
    }

    public void howAreYou()
    {
        if(j.greeted1 == true)
        {
            // Console 
            j.richTextBox1.Text += "\n" + j.userName + ": " + "How are you";
            j.richTextBox1.Text += "\nBoB: I'm a computer not a human, I don't have emotions";
            j.richTextBox1.Text += "\n";
            // Synthesize
            j.synthesizer.SpeakAsync("I'm a computer not a human, I don't have emotions");
            // Deactivating Variables
            j.greeted1 = false;
        }
    }
}
