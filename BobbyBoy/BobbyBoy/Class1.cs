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

    public void okBoB()
    {
        // Console
        j.richTextBox1.Text += "\n" + j.userName + ": " + "Ok BoB";
        j.richTextBox1.Text += "\nBoB: Yes";
        j.richTextBox1.Text += "\n";
        // Synthesize
        j.synthesizer.SpeakAsync("Yes");
    }

    public void whyIsDadSoAnnoying()
    {
        // Console
        j.richTextBox1.Text += "\n" + j.userName + ": " + "Why is dad so annoying";
        j.richTextBox1.Text += "\nBoB: Because he is stupid";
        j.richTextBox1.Text += "\n";
        // Synthesize
        j.synthesizer.SpeakAsync("because he is stupid");
    }

    public void whatIsJak()
    {
        // Console
        j.richTextBox1.Text += "\n" + j.userName + ": " + "What is Jak";
        j.richTextBox1.Text += "\nBoB: An idiot";
        j.richTextBox1.Text += "\n";
        // Synthesize
        j.synthesizer.SpeakAsync("An idiot");
    }

    public void whatsMyName()
    {
        // Console
        j.richTextBox1.Text += "\n" + j.userName + ": " + "What's my name";
        j.richTextBox1.Text += "\nBoB: Jamie";
        j.richTextBox1.Text += "\n";
        // Synthesize
        j.synthesizer.SpeakAsync("Jamie");
    }
}
