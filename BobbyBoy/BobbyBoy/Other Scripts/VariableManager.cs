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
    public void VariableManager(string currentMethod)
    {
        if (currentMethod == "helloBob")
        {
            // Enabling Varaibles
            BobbyBoy.Form1._Form1.greeted = true;
        }
    }
}
