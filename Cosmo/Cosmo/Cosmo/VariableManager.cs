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

public class VariableController
{   
    public void VarManager(string MethodAct)
    {
        if (MethodAct == "helloCosmo")
        {
            Cosmo.Form1._Form1.greeted1 = true;
        }
        else
        {
            Cosmo.Form1._Form1.greeted1 = false;
        }

        if(MethodAct == "imGood")
        {
            Cosmo.Form1._Form1.greeted2 = true;
        }
        else
        {
            Cosmo.Form1._Form1.greeted2 = false;
        }

        if (MethodAct == "okCosmo")
        {
            Cosmo.Form1._Form1.initial = true;
        }
        else
        {
            Cosmo.Form1._Form1.initial = false;
        }

        if (MethodAct == "openApplication")
        {
            Cosmo.Form1._Form1.open = true;
        }
        else
        {
            Cosmo.Form1._Form1.open = false;
        }

        if (MethodAct == "closeApplication")
        {
            Cosmo.Form1._Form1.close = true;
        }
        else
        {
            Cosmo.Form1._Form1.close = false;
        }
    }

    public bool VarChecker(string MethodCheck)
    {
        // Variable
        bool possible;

        // Checking
        if (MethodCheck == "imGood")
        {
            if(Cosmo.Form1._Form1.greeted1 == true)
            {
                possible = true;
            }
            else
            {
                possible = false;
            }
        }
        else
        {
            possible = true;
        }

        if (MethodCheck == "howAreyou")
        {
            if (Cosmo.Form1._Form1.greeted2 == true)
            {
                possible = true;
            }
            else
            {
                possible = false;
            }
        }
        else
        {
            possible = true;
        }

        // Returning Value
        if (possible == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
