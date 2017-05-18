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
        // greeted
        if (currentMethod == "helloBob")
        {
            BobbyBoy.Form1._Form1.greeted = true;
        }
        else
        {
            BobbyBoy.Form1._Form1.greeted = false;
        }

        // greeted1
        if (currentMethod == "imGood")
        {
            BobbyBoy.Form1._Form1.greeted1 = true;
        }
        else
        {
            BobbyBoy.Form1._Form1.greeted1 = false;
        }

        // openApp
        if (currentMethod == "open")
        {
            BobbyBoy.Form1._Form1.openApp = true;
        }
        else
        {
            BobbyBoy.Form1._Form1.openApp = false;
        }

        // closeApp
        if (currentMethod == "close")
        {
            BobbyBoy.Form1._Form1.closeApp = true;
        }
        else
        {
            BobbyBoy.Form1._Form1.closeApp = false;
        }
    }
}