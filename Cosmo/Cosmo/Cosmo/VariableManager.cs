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

        #region open
        if (MethodAct == "openApplication")
        {
            Cosmo.Form1._Form1.open = true;
        }
        else
        {
            Cosmo.Form1._Form1.open = false;
        }
        #endregion

        #region close
        if (MethodAct == "closeApplication")
        {
            Cosmo.Form1._Form1.close = true;
        }
        else
        {
            Cosmo.Form1._Form1.close = false;
        }
        #endregion

        #region spotPlay
        if (MethodAct == "playSong")
        {
            Cosmo.Form1._Form1.spotPlaying = true;
        }
        else
        {
            Cosmo.Form1._Form1.spotPlaying = false;
        }
        #endregion

        #region MasterControls
        if (MethodAct == "enableMasterControls")
        {
            Cosmo.Form1._Form1.MasterControls = true;
        }

        if (MethodAct == "disableMasterControls")
        {
            Cosmo.Form1._Form1.MasterControls = false;
        }
        #endregion
    }
}