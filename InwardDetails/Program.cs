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
            var year = Convert.ToInt32(ConfigurationManager.AppSettings["Year"]);
            var month = Convert.ToInt32(ConfigurationManager.AppSettings["Month"]);
            var day = Convert.ToInt32(ConfigurationManager.AppSettings["Day"]);

            if (ConfigurationManager.AppSettings["Evaluation"].ToString() == "1" && DateTime.Now.Date > new DateTime(year, month, day))
            {
                MessageBox.Show("Evalution Period Expired..Contact 8600555422", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent1());
        }
    }
}
