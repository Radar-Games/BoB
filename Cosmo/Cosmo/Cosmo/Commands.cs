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
using System.Xml;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Cosmo
{
    class Executables
    {
        string temp;
        string condition;
        string high;
        string low;

        public void textAdd(ref string text)
        {
            Cosmo.Form1._Form1.richTextBox1.Text += text;
        }
        public void synth(ref string text)
        {
            Cosmo.Form1._Form1.synthesizer.SpeakAsync(text);
        }

        public String GetWeather(String input)
        {
            String query = String.Format("https://query.yahooapis.com/v1/public/yql?q=select * from weather.forecast where woeid in (select woeid from geo.places(1) where text='Perth, WA')&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
            XmlDocument wData = new XmlDocument();
            wData.Load(query);
 
            XmlNamespaceManager manager = new XmlNamespaceManager(wData.NameTable);
            manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");
 
            XmlNode channel = wData.SelectSingleNode("query").SelectSingleNode("results").SelectSingleNode("channel");
            XmlNodeList nodes = wData.SelectNodes("query/results/channel");
            try
            {
                temp = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value;
                condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;
                high = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;
                low = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;
                if (input == "temp")
                {
                    return temp;
                }
                if (input == "high")
                {
                    return high;
                }
                if (input == "low")
                {
                    return low;
                }
                if (input == "cond")
                {
                    return condition;
                }
            }
            catch
            {
                return "Error Reciving data";
            }
            return "error";
        }
    }

    class Commands
    {
        public string time = DateTime.Now.ToString("hh:mm");
        public string date = DateTime.Now.ToString("dd/MM/yyyy");

        Executables exe = new Executables();
        VariableController var = new VariableController();

        // Methods
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

        public void imGood()
        {
            if (Cosmo.Form1._Form1.greeted1 == true)
            {
                // Variables
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
        }

        public void howAreYou()
        {
            if (Cosmo.Form1._Form1.greeted2 == true)
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
        }

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

        public void openApplication()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": Open Application";
            string response = "\nBoB: Which Application?";
            string addLine = "\n";
            string synthesize = "Which Application?";
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager
            var.VarManager("openApplication");
        }

        public void openGoogleChrome()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": Open Google Chrome";
            string response = "\nBoB: Opening Google Chrome";
            string addLine = "\n";
            string synthesize = "Opening Google Chrome";
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Executing Methods
            Process.Start(@"C:\Program Files(x86)\Google\Chrome\Application\chrome");
            // Variable Manager
            var.VarManager("openGoogleChrome");
        }

        public void closeApplication()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": Close Application";
            string response = "\nBoB: Which Application?";
            string addLine = "\n";
            string synthesize = "Which Application?";
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager
            var.VarManager("closeApplication");
        }

        public void closeGoogleChrome()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": Google Chrome";
            string response = "\nBoB: Closing Google Chrome";
            string addLine = "\n";
            string synthesize = "Closing Google Chrome";
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Executing Methods
            Cosmo.Form1._Form1.CloseProcesses("chrome");
            // Variable Manager
            var.VarManager("closeGoogleChrome");
        }

        public void whatsTheWeatherLikeToday()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": What's the weather like today?";
            string response = "\nBoB: The weather is " + exe.GetWeather("cond") + ", with a high of " + exe.GetWeather("high") + "and a low of " + exe.GetWeather("low");
            string addLine = "\n";
            string synthesize = "The weather is " + exe.GetWeather("cond") + ", with a high of " + exe.GetWeather("high") + "and a low of " + exe.GetWeather("low");
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager
            var.VarManager("whatsTheWeatherLikeToday");
        }

        public void whatsTheTempurature()
        {
            // Variables
            string recognized = "\n" + Cosmo.Form1._Form1.username + ": What's the tempurature?";
            string response = "\nBoB: The temperature is " + exe.GetWeather("temp");
            string addLine = "\n";
            string synthesize = "The tempurature is " + exe.GetWeather("temp");
            // Adding to Console
            exe.textAdd(ref recognized);
            exe.textAdd(ref response);
            exe.textAdd(ref addLine);
            // Synthesize
            exe.synth(ref synthesize);
            // Variable Manager 
            var.VarManager("whatsTheTempurature");
        }
    }
}
