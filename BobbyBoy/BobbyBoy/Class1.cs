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
    // References
    VariableManager varManager = new VariableManager();

    public void helloBob()
	{
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Hello";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Hello " + BobbyBoy.Form1._Form1.userName + ". How are you";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Hello  " + BobbyBoy.Form1._Form1.userName + " How are you?");
        // Varaible Manager
        varManager.Manager("helloBob");
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
            // Varaible Manager
            varManager.Manager("imGood");
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
            // Varaible Manager
            varManager.Manager("howAreYou");
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
        // Variable Manager
        varManager.Manager("okBob");
    }

    public void whyIsDadSoAnnoying()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "Why is dad so annoying";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Because he is stupid";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("because he is stupid");
        // Variable Manager
        varManager.Manager("whyIsDadSoAnnoying");
    }

    public void whatIsJak()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What is Jak";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: An idiot";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("An idiot");
        // Variable Manager
        varManager.Manager("whatIsJak");
    }

    public void whatsMyName()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What's my name";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Jamie";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Jamie");
        // Variable Manager
        varManager.Manager("whatsMyName");
    }

    public void whatAreYou()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What are you";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: I am a Speech Recognition system programmed in C#";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("I am a Speech Recognition system programmed in C sharp");
        // Variable Manager
        varManager.Manager("whatAreYou");
    }

    public void whatsTheTime()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": " + "What's the time";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: " + BobbyBoy.Form1._Form1.time;
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Sythesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync(BobbyBoy.Form1._Form1.time);
        // Variable Manager
        varManager.Manager("whatsTheTime");
    }

    public void open()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Open Application";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: What application do you want to open?";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("What application");
        // Variables
        varManager.Manager("open");
    }

    public void openGoogle()
    {
        if (BobbyBoy.Form1._Form1.openApp == true)
        {
            // Console
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Google";
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Opening Google";
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
            // Synthesize
            BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Opening Google");
            // Execute Code
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            // Variables
            varManager.Manager("openGoogle");
        }
    }

    public void close()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Close application";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: What application do you want to close?";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("What application do you want to close?");
        // Variable Manager
        varManager.Manager("close");
    }

    public void closeGoogle()
    {
        if (BobbyBoy.Form1._Form1.closeApp == true)
        {
            // Variables
            string app = "chrome";
            // Console
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Google";
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Closing Google";;
            BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
            // Synthesize
            BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Closing Google");
            // Activating Methods
            BobbyBoy.Form1._Form1.CloseProcesses(ref app);
            // Variable Manager
            varManager.Manager("closeGoogle");
        }
    }

    public void whoAreYou()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Who are you?";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: I am BoB a speech recognition system programmed in C#";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("I am BoB a speech recognition system programmed in c sharp");
        // Variable Manager
        varManager.Manager("whoAreYou");
    }

    public void sayHelloToEloise()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Say hello to Eloise";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Hi Eloise";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Hi Eloise");
        // Variable Manager
        varManager.Manager("sayHelloToEloise");
    }

    public void isntItBob()
    {
        // Console
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n" + BobbyBoy.Form1._Form1.userName + ": Isn't it BoB";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\nBoB: Shut up";
        BobbyBoy.Form1._Form1.richTextBox1.Text += "\n";
        // Synthesize
        BobbyBoy.Form1._Form1.synthesizer.SpeakAsync("Shut up");
        // Variable Manager
        varManager.Manager("isntItBob");
    }
}
