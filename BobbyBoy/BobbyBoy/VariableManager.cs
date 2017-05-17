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

public class VariableManager
{
    public void Manager(string currentMethod)
    {
        if (currentMethod == "helloBob")
        {
            // Enabling Variables
            BobbyBoy.Form1._Form1.greeted = true;

            // Disabling Variables
            BobbyBoy.Form1._Form1.greeted1 = false;
            BobbyBoy.Form1._Form1.openApp = false;
            BobbyBoy.Form1._Form1.closeApp = false;
        }

        if (currentMethod == "imGood")
        {
            // Enabling Variables
            BobbyBoy.Form1._Form1.greeted1 = true;

            // Disabling Variables

        }
    }
}
