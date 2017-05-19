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

public class SpeechRecognition
{
    public void Speech(ref string[] choices)
    {
        // Create a new speech recognition engine
        SpeechRecognizer recognizer = new SpeechRecognizer();

        // Creating simple grammar
        Choices choice = new Choices();
        choice.Add(choices);
    }
}