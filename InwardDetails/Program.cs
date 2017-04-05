using InwardDetails.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            if(ConfigurationManager.AppSettings["Evaluation"].ToString() =="1"  && DateTime.Now.Date> new DateTime(2017,04,04))
            {
                MessageBox.Show("Evalution Period Expired..Contact 8600555422");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1() );
        }
    }
}
