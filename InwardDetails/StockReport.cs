using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MiddleLayer;

namespace InwardDetails
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void btn_PayShow_Click(object sender, EventArgs e)
        {
        
            CSOutward obj=new CSOutward();
            dgv_outward_Item.DataSource = null;
            dgv_outward_Item.AutoGenerateColumns = false;
            dgv_outward_Item.DataSource = obj.DislayStock();
              
        }
        private void StockReport_Load(object sender, EventArgs e)
        {
          //Call Fill combo method of CSnward
            CSInward obj = new CSInward();
            cmb_machine.DisplayMember = "machine_name";
            cmb_machine.DataSource = obj.FillMachine(); 
        }
    }
}
