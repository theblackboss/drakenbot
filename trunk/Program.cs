using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using USkin;

namespace Drakenbot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            USkinClass.USkinInit("", "", "" + "//" + "Skins/default.msstyles");
            USkinClass.USkinLoadSkin("Skins/default.msstyles");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
