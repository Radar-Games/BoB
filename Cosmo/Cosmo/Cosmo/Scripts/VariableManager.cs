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
        #region greeted1
        if (MethodAct == "helloCosmo")
        {
            Cosmo.Form1._Form1.greeted1 = true;
        }
        else
        {
            Cosmo.Form1._Form1.greeted1 = false;
        }
        #endregion

        #region greeted2
        if(MethodAct == "imGood")
        {
            Cosmo.Form1._Form1.greeted2 = true;
        }
        else
        {
            Cosmo.Form1._Form1.greeted2 = false;
        }
        #endregion
    }

    public bool VarChecker(string MethodCheck)
    {
        bool possible = false;
        #region greeted1
        if ()
    }
}
