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


public class Class1
{
    public void helloBob()
	{
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Hello";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Hello " + BobbyBoy.Form1._Form1.userName + ". How are you";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Hello  " + BobbyBoy.Form1._Form1.userName + " How are you?");
        // Activating Varibles
        BobbyBoy.Form1._Form1.greeted = true;
    }

    public void imGood()
    {
        if(BobbyBoy.Form1._Form1.greeted == true)
        {
            // Console
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "I'm Good";
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: That's good";
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
            // Synthesize
            BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("That's good");
            // Activating Variables
            BobbyBoy.Form1._Form1.greeted1 = true;
            // Deacivating Variables
            BobbyBoy.Form1._Form1.greeted = false;
        }
    }

    public void howAreYou()
    {
        if(BobbyBoy.Form1._Form1.greeted1 == true)
        {
            // Console 
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "How are you";
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: I'm a computer not a human, I don't have emotions";
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
            // Synthesize
            BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("I'm a computer not a human, I don't have emotions");
            // Deactivating Variables
            BobbyBoy.Form1._Form1.greeted1 = false;
        }
    }

    public void okBoB()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "Ok BoB";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Yes";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Yes");
    }

    public void whyIsDadSoAnnoying()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "Why is dad so annoying";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Because he is stupid";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("because he is stupid");
    }

    public void whatIsJak()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What is Jak";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: An idiot";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("An idiot");
    }

    public void whatsMyName()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What's my name";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Jamie";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Jamie");
    }

    public void whatAreYou()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What are you";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: I am a Speech Recognition system programmed in C#";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("I am a Speech Recognition system programmed in C sharp");
    }

    public void whatsTheTime()
    {
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What's the time";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: " + BobbyBoy.Form1._Form1.time;
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync(BobbyBoy.Form1._Form1.time);
    }
}
