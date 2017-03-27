using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiddleLayer;
using Excel = Microsoft.Office.Interop.Excel;

namespace InwardDetails
{
    public partial class Outward : Form
    {
         CSInward obj;
         CSOutward obj1;
         bool IsNew = true;

        public Outward()
        {
            InitializeComponent();
        }
        
        private void ShowTip(string Message, Control Ctrl)
        {
            Tip_Message.Hide(Ctrl);
            Tip_Message.Show(Message, Ctrl, 0, -(Ctrl.Height * 2), 1500);
        }

        private void Reset()
        {

            cmb_name.Text=String.Empty;
            dgv_outward.Rows.Clear();
            btn_Save.Text = "&Save";
            loadNames();


        }

        private void SetMaterial()
        {
            dgv_outward.EditingControl.TextChanged -= new EventHandler(EditingControl_TextChanged);
            dgv_outward.EditingControl.Text = list_material.Text;
            TextBox tp = (TextBox)dgv_outward.EditingControl;
            tp.Select(tp.TextLength, 0);
            list_material.Visible = false;
            dgv_outward.EditingControl.TextChanged += new EventHandler(EditingControl_TextChanged);

        }
        private void dgv_Ledger_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                //this line lock copy paste option of that cell
                if (dgv_outward.CurrentCell.ColumnIndex == MaterialName.Index)
                    ((TextBox)e.Control).ShortcutsEnabled = false;

                if (dgv_outward.CurrentCell.ColumnIndex == qty.Index)
                    ((TextBox)e.Control).ShortcutsEnabled = false;

                if (dgv_outward.CurrentCell.ColumnIndex == Issue.Index)
                    ((TextBox)e.Control).ShortcutsEnabled = false;

                if (dgv_outward.CurrentCell.ColumnIndex == MaterialName.Index)
                {
                    TextBox tp = (TextBox)e.Control;
                    tp.Text = tp.Text.Trim();
                    tp.ShortcutsEnabled = false;
                    tp.Select(tp.TextLength, 0);
                    tp.MaxLength = 30;
                }

                //this code set the list_material at specific location 
                int po_x = dgv_outward.GetCellDisplayRectangle(dgv_outward.CurrentCell.ColumnIndex, dgv_outward.CurrentCell.RowIndex, false).Left + dgv_outward.Left;
                int po_y = dgv_outward.GetCellDisplayRectangle(dgv_outward.CurrentCell.ColumnIndex, dgv_outward.CurrentCell.RowIndex, false).Bottom + dgv_outward.Top;
                list_material.Top = po_y;
                list_material.Left = po_x;

                //this are the even we are handling in gridview
                dgv_outward.EditingControl.KeyDown += new KeyEventHandler(EditingControl_KeyDown);
                dgv_outward.EditingControl.KeyPress += new KeyPressEventHandler(EditingControl_KeyPress);
                dgv_outward.EditingControl.TextChanged += new EventHandler(EditingControl_TextChanged);
                dgv_outward.CellValidating += new DataGridViewCellValidatingEventHandler(dgv_Ledger_CellValidating);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void EditingControl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgv_outward.CurrentCell.ColumnIndex == MaterialName.Index || dgv_outward.CurrentCell.ColumnIndex == MachineName.Index)
                {
                    TextBox txt = (TextBox)sender;
                    if (e.KeyValue == (int)Keys.Escape)
                    {
                        list_material.Visible = false;
                        list_material.DataSource = null;
                    }
                    if (e.KeyValue == 13 && list_material.Visible == true && list_material.SelectedItem != null)
                    {
                        SetMaterial();
                        return;
                    }
                    if (e.KeyValue == (int)Keys.Up)
                    {
                        if (list_material.Visible == true && list_material.Items.Count != 0)
                        {
                            if (list_material.SelectedIndex == 0)
                                list_material.SelectedIndex = list_material.Items.Count - 1;
                            else
                                list_material.SelectedIndex = list_material.SelectedIndex - 1;
                            e.SuppressKeyPress = true;
                            return;
                        }
                        else
                            e.SuppressKeyPress = true;
                    }
                    if (e.KeyValue == (int)Keys.Down)
                    {
                        if (list_material.Visible == true && list_material.Items.Count != 0)
                        {
                            if (list_material.SelectedIndex == list_material.Items.Count - 1)
                                list_material.SelectedIndex = 0;
                            else
                                list_material.SelectedIndex = list_material.SelectedIndex + 1;

                            e.SuppressKeyPress = true;
                            return;
                        }
                        else
                        {
                            CSOutward ob = new CSOutward();
                            if (dgv_outward.CurrentCell.ColumnIndex == MaterialName.Index)
                            {
                                ob.FillList(list_material, txt, "%", "material_name", 6);
                            }
                            else
                            {
                                obj = new CSInward();
                                obj.FillList(list_material, txt, "%", "machine_name", 2);
                            }
                            list_material.SelectedIndex = list_material.FindString(txt.Text.Trim(), 0);
                            if (list_material.Items.Count == 0)
                                ShowTip("List is empty", (Control)sender);
                        }
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Sorry! Unable to proceed please contact our software support for this exception [error code -1001].", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (dgv_outward.CurrentCell.ColumnIndex == Issue.Index || dgv_outward.CurrentCell.ColumnIndex == qty.Index)
            {
                try
                {
                    ASSValidater.IsValid(Convert.ToString(dgv_outward.CurrentCell.EditedFormattedValue), e.KeyChar, AssValidation.Amount);
                }
                catch (Exception)
                {
                    e.Handled = true;
                    // ShowTip(ee.Message, dgv_outward.EditingControl);
                }
            }
        }

        private void EditingControl_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgv_outward.CurrentCell.ColumnIndex == MaterialName.Index || dgv_outward.CurrentCell.ColumnIndex == MachineName.Index)
                {
                    TextBox txt = (TextBox)sender;
                    if (txt.Text.Trim() != string.Empty)
                    {

                        if (dgv_outward.CurrentCell.ColumnIndex == MaterialName.Index)
                        {
                              CSOutward ob = new CSOutward();
                              ob.FillList(list_material, txt, txt.Text.Trim() + "%", "material_name", 6);
                        }
                        else
                        {
                            obj = new CSInward();
                            obj.FillList(list_material, txt, txt.Text.Trim() + "%", "machine_name", 2);
                        }
                            list_material.SelectedIndex = list_material.FindString(txt.Text.Trim(), 0);
                    }
                    else
                    {
                        list_material.Visible = false;
                        list_material.DataSource = null;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dgv_Ledger_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                error_Show.SetError(dgv_outward.EditingPanel, string.Empty);
                if (Program.IsEnter == true && list_material.Visible == true)
                {
                    SetMaterial();
                    e.Cancel = true;
                    Program.IsEnter = false;
                }
                else
                    RemoveDgvEvents();

                if (list_material.Focused == false)
                    list_material.Visible = false;

                if (e.ColumnIndex == qty.Index && Convert.ToString(dgv_outward.EditingControl.Text) == String.Empty)
                {
                    dgv_outward.EditingControl.Text = "0";
                }
                else if (e.ColumnIndex == qty.Index)
                {
                    //FIND Stock Of that selected Item
                    String Material_name = Convert.ToString(dgv_outward[MaterialName.Index, dgv_outward.CurrentCell.RowIndex].EditedFormattedValue);
                    StockChk(Material_name,dgv_outward.CurrentCell.RowIndex);
                }


                if (e.ColumnIndex == Issue.Index && Convert.ToString(dgv_outward.EditingControl.Text) == String.Empty)
                {
                    dgv_outward.EditingControl.Text = "0";
                }
                //else if(e.ColumnIndex==Issue.Index)
                //{
                //    Double Issueqty = Convert.ToDouble(dgv_outward[Issue.Index, dgv_outward.CurrentCell.RowIndex].EditedFormattedValue);
                //    Double qtty=Convert.ToDouble(dgv_outward[Issue.Index, dgv_outward.CurrentCell.RowIndex].EditedFormattedValue);
                //    if(Issueqty >qtty) 
                //    {
                //        MessageBox.Show("Issue Quantity must be less than Required Quantity!!!!", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    }

                //}
                Tip_Message.Hide((Control)sender);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        } 

        //This function is used to chk available staock is sufficient or not
        public bool StockChk(String Material_Name,int row)
        {
          
                CSOutward obj = new CSOutward();
                obj.Material_Name = Material_Name;
                DataTable dt = new DataTable();
                dt = obj.DislayStock(1);
                if (dt.Rows.Count > 0 && (Convert.ToInt64(dt.Rows[0][3]) < Convert.ToInt64(dgv_outward[qty.Index, row].EditedFormattedValue)))
                {
                    MessageBox.Show("You are Entered More Value . available stock=" + Convert.ToInt64(dt.Rows[0][3]) + "","IOS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dgv_outward[qty.Index, row].Value = "0";
                    dgv_outward[Issue.Index, row].Value = "0";
                    error_Show.SetError(dgv_outward.EditingPanel, "Issue Quantity is Required");
                    dgv_outward.RefreshEdit();
                    
                        return true;
                }
                if (Convert.ToInt64(dgv_outward[qty.Index, row].EditedFormattedValue) < Convert.ToInt64(dgv_outward[Issue.Index, row].EditedFormattedValue))
                {
                    dgv_outward.CurrentCell = dgv_outward[Issue.Index, row];
                    dgv_outward.BeginEdit(true);
                    dgv_outward[Issue.Index, row].Value = "0";
                    MessageBox.Show("Issue Quantity must be less than or equals to required Quantity", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_outward.RefreshEdit();
                    return true;
                }




                return false;
           


            
        }

        private void RemoveDgvEvents()
        {
            if (dgv_outward.EditingControl != null)
            {
                dgv_outward.EditingControl.KeyDown -= new KeyEventHandler(EditingControl_KeyDown);
                dgv_outward.EditingControl.KeyPress -= new KeyPressEventHandler(EditingControl_KeyPress);
                dgv_outward.EditingControl.TextChanged -= new EventHandler(EditingControl_TextChanged);
                dgv_outward.CellValidating -= new DataGridViewCellValidatingEventHandler(dgv_Ledger_CellValidating);
            }
        }
        private void list_Ledger_MouseClick(object sender, MouseEventArgs e)
        {
            dgv_outward.Focus();
        }

        private void dgv_Ledger_Leave_1(object sender, EventArgs e)
        {
            for (int row = 0; row < dgv_outward.Rows.Count - 1; )
            {
                if (Convert.ToString(dgv_outward[MaterialName.Index, row].Value) == string.Empty && Convert.ToString(dgv_outward[MachineName.Index, row].Value) == string.Empty)
                {
                    RemoveDgvEvents();
                    dgv_outward.Rows.RemoveAt(row);
                    row = 0;
                }
                else
                    row++;
            }
          
        }

        private void list_Ledger_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dgv_outward.Focus();
            SetMaterial();
        }
        private void PaymentVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgv_outward.RowCount > 1)
            {
                DialogResult = MessageBox.Show("Do you want to save the changes before closing?", "IOS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    btn_Save.PerformClick();
                    e.Cancel = btn_Save.CausesValidation;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    Focus();
                }
            }
        }
   


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmb_name.Text==String.Empty)
                {
                    ShowTip("Name Required", cmb_name);
                    cmb_name.Focus();
                    return;
                }

                if (dgv_outward.Rows.Count <= 1)
                {
                    dgv_outward.CurrentCell = dgv_outward[MaterialName.Index, 0];
                    dgv_outward.BeginEdit(false);
                    error_Show.SetError(dgv_outward.EditingPanel, "Materials are Required");
                    ShowTip("Required", dgv_outward.EditingPanel);
                    return;
                }


                //Check all cells of DataGridView
                for (int row = 0; row < dgv_outward.Rows.Count - 1; row++)
                {
                    if (Convert.ToString(dgv_outward[MaterialName.Index, row].EditedFormattedValue) == string.Empty)
                    {
                        dgv_outward.CurrentCell = dgv_outward[MaterialName.Index, row];
                        dgv_outward.BeginEdit(false);
                        error_Show.SetError(dgv_outward.EditingPanel, "Materials is Required");
                        ShowTip(" Required", dgv_outward.EditingPanel);
                        return;
                    }
                    if (Convert.ToString(dgv_outward[MachineName.Index, row].EditedFormattedValue) == string.Empty)
                    {
                        dgv_outward.CurrentCell = dgv_outward[MachineName.Index, row];
                        dgv_outward.BeginEdit(false);
                        error_Show.SetError(dgv_outward.EditingPanel, "Machine name is Required");
                        ShowTip(" Required", dgv_outward.EditingPanel);
                        return;
                    }
                    if (Convert.ToString(dgv_outward[qty.Index, row].EditedFormattedValue) =="0")
                    {
                        dgv_outward.CurrentCell = dgv_outward[qty.Index, row];
                        dgv_outward.BeginEdit(false);
                        error_Show.SetError(dgv_outward.EditingPanel, "Quantity is Required");
                        ShowTip(" Required", dgv_outward.EditingPanel);
                        return;
                    }
                    if (Convert.ToString(dgv_outward[Issue.Index, row].EditedFormattedValue) =="0" )
                    {
                        dgv_outward.CurrentCell = dgv_outward[Issue.Index, row];
                        dgv_outward.BeginEdit(false);
                        error_Show.SetError(dgv_outward.EditingPanel, "Issue Quantity is Required");
                        ShowTip("Required", dgv_outward.EditingPanel);
                        return;
                    }

                    if (StockChk(dgv_outward[MaterialName.Index, row].EditedFormattedValue.ToString(), row) == true)
                        return;
                }

                if (MessageBox.Show("Do you want to save Outward ?", "IOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Insert outward here
                    CSOutward obbj = new CSOutward();
                    obbj.IssueNo =Convert.ToInt32(txt_IssueNo.Text) ;
                    obbj.IssueTo = cmb_name.Text.Trim().ToLowerInvariant();
                    obbj.IssueDate = dtp_outward.Value.Date;
                    if (IsNew == true)
                    {
                        obbj.SaveOutward();
                    }
                    else
                    {
                        //delete that outward Before Updation
                          obbj.DeleteOutwardItem();
                          obbj.DeleteOutward();

                          obbj.SaveOutward();
                      
                    }
                    //Save Outward Item list
                    if (IsNew == false)
                        obbj.DeleteOutwardItem();

                    for (int row = 0; row < dgv_outward.Rows.Count - 1; row++)
                    {
                        obbj.Material_Name = Convert.ToString(dgv_outward[MaterialName.Index, row].EditedFormattedValue);
                        obbj.Qty = Convert.ToDouble(dgv_outward[qty.Index, row].EditedFormattedValue);
                        obbj.Issue = Convert.ToDouble(dgv_outward[Issue.Index, row].EditedFormattedValue);
                        obbj.MachineName = Convert.ToString(dgv_outward[MachineName.Index, row].EditedFormattedValue);
                        obbj.SaveOutwardItem();

                    }
                    Reset();
                    btn_Save.CausesValidation = false;

                    MessageBox.Show("√ Outward saved Successfully.", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Save.DialogResult = DialogResult.OK;
                    this.DialogResult = DialogResult.OK;
                }
                else
                    cmb_name.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        public void loadNames()
        {
            CSOutward obj=new CSOutward();
            cmb_name.DataSource = obj.LoadNames();
            cmb_name.DisplayMember = "IssueTo";
            txt_IssueNo.Text = Convert.ToString(obj.getMax());

        }

        private void Outward_Load(object sender, EventArgs e)
        {
            loadNames();
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            rb_date.Checked = true;
            if (tab_out.SelectedIndex == 1)
            {
                obj1 = new CSOutward();
                cmb_machine.DisplayMember = "MachineName";
                cmb_machine.DataSource = obj1.FillMachine();

            }
        }

        private void btn_PayShow_Click(object sender, EventArgs e)
        {
            CSOutward obj = new CSOutward();
            dgv_outward_Item.DataSource = null;
            dgv_outward_Item.AutoGenerateColumns = false;

            //check all possibilities of searching
            if (rb_machine.Checked == false)
            {
                dgv_outward_Item.DataSource = (obj.search(date_From.Value.Date, date_To.Value.Date));
                if (dgv_outward_Item.RowCount < 1)
                    MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           //search by machine name only in beetwwen selected dates
           else if (rb_machine.Checked == true)
           {
               dgv_outward_Item.DataSource = (obj.search(cmb_machine.Text, date_From.Value.Date, date_To.Value.Date,1));
               if (dgv_outward_Item.RowCount < 1)
                    MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
                     
        }

        private void date_From_ValueChanged(object sender, EventArgs e)
        {
            date_To.MinDate = date_From.Value.Date;
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                CSOutward obj = new CSOutward();
                if (rb_date.Checked == true)
                {
                    dt = obj.search(date_From.Value.Date, date_To.Value.Date);
                    if (dt.Rows.Count > 0)
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExportDataToExcel(dt, saveFileDialog1.FileName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Result Not Found....... ", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rb_machine.Checked == true)
                {
                    dt = obj.search(cmb_machine.Text, date_From.Value.Date, date_To.Value.Date, 1);
                    if (dt.Rows.Count > 0)
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExportDataToExcel(dt, saveFileDialog1.FileName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Result Not Found....... ", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void date_To_ValueChanged(object sender, EventArgs e)
        {
            date_From.MaxDate = date_To.Value.Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_outward_Item.RowCount > 0)
                {
                    if (MessageBox.Show("Do you want to Delete Outward ?", "IOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CSOutward obj = new CSOutward();
                        obj.IssueNo = Convert.ToInt32(dgv_outward_Item[IssueNo.Index, dgv_outward_Item.CurrentCell.RowIndex].EditedFormattedValue);
                        obj.DeleteOutwardItem();
                        obj.DeleteOutward();
                        dgv_outward_Item.DataSource = null;
                    //    MessageBox.Show("√ Outward  Delete Successfully.", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        btn_PayShow.PerformClick();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"IOS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_outward_Item. RowCount > 0)
                {
                    //reset all field first
                    Reset();
                    IsNew = false;
                    tab_out. SelectedIndex = 0;
                    btn_Save.Text = "&Update";
                    CSOutward obj = new CSOutward();
                    obj.IssueNo = Convert.ToInt32(dgv_outward_Item[IssueNo.Index, dgv_outward_Item.CurrentCell.RowIndex].EditedFormattedValue);
                   
                     //Get  outward  here   
                    DataTable dt;
                    dt = new DataTable();
                    dt = obj.getOutWard();
                    txt_IssueNo.Text = Convert.ToString(dt.Rows[0][0]);
                    cmb_name.Text=dt.Rows[0][1].ToString();
                    dtp_outward.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                   

                    //Get All outward Item here
                    dt = new DataTable();
                    dt = obj.getOutWardItem();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv_outward.Rows.Add();
                        dgv_outward[MaterialName.Index, i].Value = dt.Rows[i][1].ToString();
                        dgv_outward[MachineName.Index, i].Value = dt.Rows[i][2].ToString();
                        dgv_outward[qty.Index, i].Value = dt.Rows[i][3].ToString();
                        dgv_outward[Issue.Index, i].Value = dt.Rows[i][4].ToString();
                    }
               }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Error At Upadte Event" + ee.Message,"IOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

       }

        private void dgv_outward_Leave(object sender, EventArgs e)
        {

            for (int row = 0; row < dgv_outward.Rows.Count - 1; )
            {
                if (Convert.ToString(dgv_outward[MaterialName.Index, row].Value) == string.Empty && Convert.ToString(dgv_outward[MachineName.Index, row].Value) == string.Empty)
                {
                    RemoveDgvEvents();
                    dgv_outward.Rows.RemoveAt(row);
                    row = 0;
                }
                else
                    row++;
            }
            
        }

        private void tp_outward_Click(object sender, EventArgs e)
        {

        }

        private void cmb_name_KeyDown(object sender, KeyEventArgs e)
        {
             
            Control control = (Control)sender;
            try
            {
             
                if (e.KeyCode  ==Keys.Enter)
                    this.SelectNextControl((Control)sender, true, true, true, true);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        
        }

       

    }
}
