using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InwardDetails
{
    static class Program
    {
        public static bool IsEnter = false;
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1() );
        }
    }
}
