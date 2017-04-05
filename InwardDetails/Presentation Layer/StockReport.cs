using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiddleLayer;
using Excel = Microsoft.Office.Interop.Excel;

namespace InwardDetails
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }
        private void ShowTip(string Message, Control Ctrl)
        {
            Tip_Message.Hide(Ctrl);
            Tip_Message.Show(Message, Ctrl, 0, -(Ctrl.Height * 2), 1500);
        }

        private void btn_PayShow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            CSOutward obj = new CSOutward();
            //search as per machine name
            if (rb_material.Checked == true)
            {
                if(cmb_machine.Text.Trim()==String.Empty)
                {
                    ShowTip("required", cmb_machine);
                    cmb_machine.Focus();
                    return;
                }
               
                obj.Material_Name = cmb_machine.Text.Trim();
                dgv_outward_Item.DataSource = null;
                dgv_outward_Item.AutoGenerateColumns = false;
                
                dt=obj.DislayStock(1);
                if (dt.Rows.Count > 0)
                    dgv_outward_Item.DataSource = dt;
                else
                    MessageBox.Show("Result Not Found.......", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(Rb_All.Checked==true) 
            {
              
                dgv_outward_Item.DataSource = null;
                dgv_outward_Item.AutoGenerateColumns = false;

                dt = obj.DislayStock(0);
                if (dt.Rows.Count > 0)
                    dgv_outward_Item.DataSource = dt;
                else
                    MessageBox.Show("Result Not Found.......", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            else if (rb_mat.Checked == true)
            {

                dgv_outward_Item.DataSource = null;
                dgv_outward_Item.AutoGenerateColumns = false;
                dt = obj.DislayStock(2);
                if (dt!=null && dt.Rows.Count > 0)
                    dgv_outward_Item.DataSource = dt;
                else
                    MessageBox.Show("Result Not Found.......", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
         
        }
        private void StockReport_Load(object sender, EventArgs e)
        {
          //Call Fill combo method of CSnward
            CSOutward obj = new CSOutward();
            cmb_machine.DisplayMember = "material_name";
            cmb_machine.DataSource = obj.FillMaterial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            DataTable dt = new DataTable();
            CSOutward obj = new CSOutward();

            if (rb_material.Checked == true)
            {
                if (cmb_machine.Text.Trim() == string.Empty)
                {
                    ShowTip("Required", cmb_machine);
                    cmb_machine.Focus();
                    return;
                }
               
                obj.Material_Name = cmb_machine.Text.Trim();
                dt = obj.DislayStock(1);
                if (dt.Rows.Count > 0)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        dgv_outward_Item.DataSource = null;
                        dgv_outward_Item.AutoGenerateColumns = false;
                        ExportDataToExcel(dt, saveFileDialog1.FileName);
                    }

                }
                else
                    MessageBox.Show("Result Not Found...........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(Rb_All.Checked==true) 
            {
                 
                    
                    dt=obj.DislayStock(0);
                    if (dt.Rows.Count > 0)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            dgv_outward_Item.DataSource = null;
                            dgv_outward_Item.AutoGenerateColumns = false;
                            ExportDataToExcel(dt, saveFileDialog1.FileName);
                        }
                     }
                    else
                        MessageBox.Show("Result Not Found...........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else 
            {
                 
                    
                    dt=obj.DislayStock(2);
                    if (dt.Rows.Count > 0)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            dgv_outward_Item.DataSource = null;
                            dgv_outward_Item.AutoGenerateColumns = false;
                            ExportDataToExcel(dt, saveFileDialog1.FileName);
                        }
                     }
                    else
                        MessageBox.Show("Result Not Found...........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }


        }

        public static void ExportDataToExcel(DataTable dt, string filepath)
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRange;

            try
            {
                if (dt.Rows.Count >= 1)
                {

                    //Start Excel and get Application Oject
                    oXL = new Excel.Application();

                    //set some properties

                    oXL.Visible = true;
                    oXL.DisplayAlerts = false;

                    //get a new WorkBook;
                    oWB = oXL.Workbooks.Add();

                    //get The Active Sheet
                    oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                    oSheet.Name = "Data";

                    int rowcount = 1;

                    foreach (DataRow dr in dt.Rows)
                    {
                        rowcount += 1;

                        for (int i = 1; i < dt.Columns.Count + 1; i++)
                        {

                            //add Header First time through
                            if (rowcount == 2)
                            {
                                oSheet.Cells[1, i] = dt.Columns[i - 1].ColumnName;
                            }

                            oSheet.Cells[rowcount, i] = dr[i - 1].ToString();
                        }

                    }

                    //Resize the Colom
                    //  oRange = oSheet.get_Range(oSheet.Cells[1, 1], oSheet.Cells[rowcount, dt.Columns.Count]);
                    //  oRange.EntireColumn.AutoFit();

                    //Save The Sheet And Close

                    oSheet = null;
                    oRange = null;
                    oWB.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal);

                    oWB.Close();
                    oWB = null;
                    oXL.Quit();

                }
                else
                    MessageBox.Show("Data Not Found ", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //clean up
                //Note When in  release mode ,this does not trick

                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

    }
}
