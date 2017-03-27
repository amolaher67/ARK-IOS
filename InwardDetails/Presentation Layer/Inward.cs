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
    public partial class PaymentVoucher : Form
    {
        bool IsNew;
        CSInward obj;
       
        private void ShowTip(string Message, Control Ctrl)
        {
            Tip_Message.Hide(Ctrl);
            Tip_Message.Show(Message, Ctrl, 0, -(Ctrl.Height * 2), 1500);
        }

        private void Reset()
        {
                       
            cmb_sup.SelectedItem = null;
            cmb_sup.Text = string.Empty;

            dgv_Inward.Rows.Clear();
            txt_billNo.ResetText();
            txt_PONO.ResetText();
            cmb_bill_type.SelectedItem = null;
            
            cmb_material_type.SelectedItem = null;
            cmb_material_type.Text = string.Empty;
            lbl_CreditAmt.Text = "0.00";
            btn_Delete.Enabled = false;
            btn_Save.Text = "&Save";
            txt_GrnNo.Focus();
            
            newUpdate();
            IsNew = true;
        }
       

        //Set list box value on cell when
        private void SetMaterial()
        {
            dgv_Inward.EditingControl.TextChanged -= new EventHandler(EditingControl_TextChanged);
            dgv_Inward.EditingControl.Text = list_material.Text;
            TextBox tp = (TextBox)dgv_Inward.EditingControl;
            tp.Select(tp.TextLength, 0);
            list_material.Visible = false;
            dgv_Inward.EditingControl.TextChanged += new EventHandler(EditingControl_TextChanged);

        }
       
        //This function Added the Total amount at every item 
         private void AmountSum()
         {
             double Total = 0;
               for (int i = 0; i < dgv_Inward.Rows.Count - 1; i++)
                 if (Convert.ToString(dgv_Inward[Amount.Index, i].EditedFormattedValue)!= string.Empty)
                     Total += Convert.ToDouble(dgv_Inward[Amount.Index, i].EditedFormattedValue);
               lbl_CreditAmt.Text = Total.ToString("F2");
        }

        private void Save()
        {
            try
            {
                  
                //this line checks wheather grno no is empty or not
                if (txt_GrnNo.Enabled == true && txt_GrnNo.Text == string.Empty)
                {
                    txt_GrnNo.Focus();
                    ShowTip("Number required", txt_GrnNo);
                    return;
                }

                //this line checks wheather grno no is should not be less tham zero
                if (txt_GrnNo.Enabled == true && Convert.ToInt64(txt_GrnNo.Text) <= 0)
                {
                    txt_GrnNo.Focus();
                    ShowTip("Invalid number", txt_GrnNo);
                    return;
                }

                //this line checks wheather Supplier name is not selected
                if (cmb_sup.Text.Trim()==String.Empty)
                {
                    cmb_sup.Focus();
                    ShowTip("Supplier name required", cmb_sup);
                    return;
                }
              
                //this line checks wheather bill no is entered or not
                if (txt_billNo.Text.Trim()== String.Empty)
                {
                    txt_billNo.Focus();
                    ShowTip("Bill Number is required", txt_billNo);
                    return;
                }

                if (cmb_bill_type.SelectedItem==null)
                {
                    cmb_bill_type.Focus();
                    ShowTip("Bill Type is required", cmb_bill_type);
                    return;
                }

                if (cmb_material_type.Text== null)
                {
                    cmb_material_type.Focus();
                    ShowTip("Bill Type is required", cmb_material_type);
                    return;
                }

                //if data grid voew rows are empty means only one row present
                if (dgv_Inward.Rows.Count <= 1)
                {
                    dgv_Inward.CurrentCell = dgv_Inward[MaterialName.Index, 0];
                    dgv_Inward.BeginEdit(false);
                    error_Show.SetError(dgv_Inward.EditingPanel, "Materials are Required");
                    ShowTip("Material Description is Required", dgv_Inward.EditingPanel);
                    return;
                }
                
                //test gridview empty cell if it is filled
                for (int row = 0; row < dgv_Inward.Rows.Count - 1; row++)
                {
                    if (Convert.ToString(dgv_Inward[MaterialName.Index, row].EditedFormattedValue) == string.Empty)
                    {
                        dgv_Inward.CurrentCell = dgv_Inward[MaterialName.Index,row];
                        dgv_Inward.BeginEdit(false);
                        error_Show.SetError(dgv_Inward.EditingPanel, "Materials are Required");
                        ShowTip("Material Description is Required", dgv_Inward.EditingPanel);
                        return;
                    }
                    if (Convert.ToString(dgv_Inward[Unit.Index, row].EditedFormattedValue) == string.Empty)
                    {
                        dgv_Inward.CurrentCell = dgv_Inward[Unit.Index, row];
                        dgv_Inward.BeginEdit(false);
                        error_Show.SetError(dgv_Inward.EditingPanel, "Unit Required");
                        ShowTip("Unit is Required", dgv_Inward.EditingPanel);
                        return;
                    }
                    if (Convert.ToString(dgv_Inward[rate.Index, row].EditedFormattedValue) == string.Empty)
                    {
                        dgv_Inward.CurrentCell = dgv_Inward[rate.Index, row];
                        dgv_Inward.BeginEdit(false);
                        error_Show.SetError(dgv_Inward.EditingPanel, "rate Required");
                        ShowTip("rate is Required", dgv_Inward.EditingPanel);
                        return;
                    }
                    if (Convert.ToString(dgv_Inward[qty.Index, row].EditedFormattedValue) == string.Empty)
                    {
                        dgv_Inward.CurrentCell = dgv_Inward[qty.Index, row];
                        dgv_Inward.BeginEdit(false);
                        error_Show.SetError(dgv_Inward.EditingPanel, "Quantity Required");
                        ShowTip("Quantity is Required", dgv_Inward.EditingPanel);
                        return;
                    }
                    if (Convert.ToString(dgv_Inward[MachineName.Index, row].EditedFormattedValue) == string.Empty)
                    {
                        dgv_Inward.CurrentCell = dgv_Inward[MachineName.Index, row];
                        dgv_Inward.BeginEdit(false);
                        error_Show.SetError(dgv_Inward.EditingPanel, "Machine Required");
                        ShowTip("Machine is Required", dgv_Inward.EditingPanel);
                        return;
                    }
               }
               if (MessageBox.Show("Do you want to save Inward ?", "IOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {

                   //create midle layer class object 
                   obj = new CSInward();
                   obj.GrnNo =Convert.ToInt64(txt_GrnNo.Text.Trim());
                   obj.InwardDate = dtp_inward.Value.Date;
                   obj.SupName = cmb_sup.Text.Trim().ToUpperInvariant();
                   obj.BillNo =txt_billNo.Text.Trim();
                   obj.BillDate = dtp_bill.Value.Date;
                   obj.BillType = cmb_bill_type.Text.Trim();
                   obj.MaterialType = cmb_material_type.Text.Trim().ToUpperInvariant();
                   obj.PONO =txt_PONO.Text.Trim();
                   obj.Total = Convert.ToDouble(lbl_CreditAmt.Text);
                   if (txt_PONO.Text.Trim() != String.Empty)
                       obj.PODate =Convert.ToString(dtp_PO.Value.Date);
                   else
                       obj.PODate = null;


                   if (IsNew == true)
                   {
                       //Chk Bill No is Allready Not Present For same Party
                       DataTable dt = obj.ChkBillPresent();
                       if (dt.Rows.Count > 0)
                       {
                           MessageBox.Show("Bill No is Allready Present For same Supplier");
                           txt_billNo.Focus();
                           return;
                       }
                       else
                       {
                           obj.saveInward();
                       }
                   }
                   else
                       obj.UpdateInward();

                   //Delete First All Inward Item And Insert Again
                   if (IsNew == false)
                       obj.DeleteInwardItem();

                 //This code calls save inward item of middle layer       
                   for (int row = 0; row < dgv_Inward.Rows.Count - 1; row++)
                   {
                       obj.MaterialName =Convert.ToString(dgv_Inward[MaterialName.Index, row].EditedFormattedValue);
                       obj.MaterialUnit = Convert.ToString(dgv_Inward[Unit.Index, row].EditedFormattedValue);
                       obj.Material_qty = Convert.ToDouble(dgv_Inward[qty.Index, row].EditedFormattedValue);
                       obj.Material_rate = Convert.ToDouble(dgv_Inward[rate.Index, row].EditedFormattedValue);
                       obj.Material_Amount=Convert.ToDouble(dgv_Inward[Amount.Index, row].EditedFormattedValue);
                       obj.Material_machine = Convert.ToString(dgv_Inward[MachineName.Index, row].EditedFormattedValue);
                       obj.save_Inward_Item();
                   }
                   Reset();
                   btn_Save.CausesValidation = false;
                   MessageBox.Show("√ Inward Bill saved Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   btn_Save.DialogResult = DialogResult.OK;
                   this.DialogResult = DialogResult.OK;
                   //Reset All Data Of dgv_Inward_item
                   dgv_inward_Item.DataSource = null;
               }
                else
                 txt_GrnNo.Focus();
          }
          catch (Exception ee)
          {
                if (ee.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show("This GRNO is allready used Select different Grn no","Inward",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_GrnNo.Focus();

                }
                else
                {
                    MessageBox.Show(ee.Message);//"Sorry! Unable to proceed please contact our software support for this exception [error code -1001].","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
        }

      

       //constructor
        public PaymentVoucher()
        {
            InitializeComponent();
        }

        //loads customer and material type
        public void newUpdate()
        {
             obj = new CSInward();
             cmb_sup.DataSource = obj.getSupplier();
             cmb_sup.DisplayMember = "sup_name";

             cmb_material_type.DataSource = obj.getMaterialType();
             cmb_material_type.DisplayMember = "material_type";
             txt_GrnNo.Text = Convert.ToString(obj.getMaxNumber());
        }
        
        //load event of frame
        private void PaymentVoucher_Load(object sender, EventArgs e)
        {
            Reset();
        }

        //------------------Validation----------------------
        private void timer_ErrorShow_Tick(object sender, EventArgs e)
        {

            if (txt_GrnNo.Enabled == true && txt_GrnNo.Text == string.Empty)
                error_Show.SetError(txt_GrnNo, "Number required");
            else
                if (txt_GrnNo.Enabled == true && Convert.ToInt64(txt_GrnNo.Text) <= 0)
                    error_Show.SetError(txt_GrnNo, "Invalid number");
                else
                    error_Show.SetError(txt_GrnNo, string.Empty);
            if (cmb_sup.Text== String.Empty)
                error_Show.SetError(cmb_sup, "Supplier Required");
            else
                error_Show.SetError(cmb_sup, string.Empty);

            if (txt_billNo.Text.Trim() ==string.Empty)
                error_Show.SetError(txt_billNo, "Bill No Required");
            else
                error_Show.SetError(txt_billNo, string.Empty);
            
            if (cmb_bill_type.SelectedItem == null)
                error_Show.SetError(cmb_bill_type, "Bill type is required");
            else
                error_Show.SetError(cmb_bill_type, string.Empty);

            if ( cmb_material_type.Text.Trim() ==string .Empty)
                error_Show.SetError(cmb_material_type, "Material type is required");
            else
                error_Show.SetError(cmb_material_type, string.Empty);
         
     }
       
        //Take Acton on Key Press Event of Control
        private void Expression_Validating(object sender, KeyPressEventArgs e)
        {
            Control control = (Control)sender;
            try
            {
                if (txt_GrnNo == control)
                    ASSValidater.IsValid(e.KeyChar, AssValidation.Number);

                if (cmb_sup == control )
                    ASSValidater.IsValid(e.KeyChar, AssValidation.ProductName);

                if (e.KeyChar == 13)
                    this.SelectNextControl((Control)sender, true, true, true, true);
            }
            catch (Exception ee)
            {
                e.Handled = true;
                ShowTip("Invalid character '" + e.KeyChar + "'", control);
            }
        }
             
        private void btn_Save_Click(object sender, EventArgs e)    {  Save();        }
        private void btn_Reset_Click(object sender, EventArgs e)   {  Reset();       }
        private void btn_Close_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Do you want to Delete Inward ?", "IOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                obj.DeleteInwardItem();
                obj.DeleteInward();
                MessageBox.Show("√ Inward Bill Delete Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Delete.DialogResult = DialogResult.OK;
                this.DialogResult = DialogResult.OK;
                //Reset All Data Of dgv_Inward_item
                dgv_inward_Item.DataSource = null;
                Reset();
            }

        }

        private void dgv_Ledger_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            
            //this line lock copy paste option of that cell
            //if (dgv_Inward.CurrentCell.ColumnIndex ==MaterialName.Index)
            //    ((TextBox)e.Control).ShortcutsEnabled = false;
           
            if (dgv_Inward.CurrentCell.ColumnIndex ==qty.Index )
                ((TextBox)e.Control).ShortcutsEnabled = false;

            if (dgv_Inward.CurrentCell.ColumnIndex == Unit.Index)
            {
                ((TextBox)e.Control).ShortcutsEnabled = false;
            }

            if (dgv_Inward.CurrentCell.ColumnIndex == rate.Index)
                ((TextBox)e.Control).ShortcutsEnabled = false;

            if (dgv_Inward.CurrentCell.ColumnIndex == Amount.Index)
                ((TextBox)e.Control).ShortcutsEnabled = false;

            if (dgv_Inward.CurrentCell.ColumnIndex ==MaterialName.Index)
            {
                TextBox tp = (TextBox)e.Control;
                tp.Text = tp.Text.Trim();
               // tp.ShortcutsEnabled = false;
                tp.Select(tp.TextLength, 0);
                tp.MaxLength = 30;
            }

            //this code set the list_material at specific location 
            int po_x = dgv_Inward.GetCellDisplayRectangle(dgv_Inward.CurrentCell.ColumnIndex, dgv_Inward.CurrentCell.RowIndex, false).Left + dgv_Inward.Left;
            int po_y = dgv_Inward.GetCellDisplayRectangle(dgv_Inward.CurrentCell.ColumnIndex, dgv_Inward.CurrentCell.RowIndex, false).Bottom + dgv_Inward.Top;
            list_material.Top = po_y;
            list_material.Left = po_x;
            
            //this are the even we are handling in gridview
            dgv_Inward.EditingControl.KeyDown += new KeyEventHandler(EditingControl_KeyDown);
            dgv_Inward.EditingControl.KeyPress += new KeyPressEventHandler(EditingControl_KeyPress);
            dgv_Inward.EditingControl.TextChanged += new EventHandler(EditingControl_TextChanged);
            dgv_Inward.CellValidating += new DataGridViewCellValidatingEventHandler(dgv_Ledger_CellValidating);

        }
        private void EditingControl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgv_Inward.CurrentCell.ColumnIndex == MaterialName.Index || dgv_Inward.CurrentCell.ColumnIndex == MachineName.Index || dgv_Inward.CurrentCell.ColumnIndex ==Unit.Index)
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
                             obj = new CSInward();
                             if (dgv_Inward.CurrentCell.ColumnIndex == MaterialName.Index)
                                 obj.FillList(list_material, txt, "%", "material_name", 1);
                             else if (dgv_Inward.CurrentCell.ColumnIndex == MachineName.Index)
                                 obj.FillList(list_material, txt, "%", "machine_name", 2);
                             else
                                 obj.FillList(list_material, txt, "%", "unit_id", 4);

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
            if (dgv_Inward.CurrentCell.ColumnIndex == qty.Index)
            {
                try
                {
                    ASSValidater.IsValid(Convert.ToString(dgv_Inward.CurrentCell.EditedFormattedValue), e.KeyChar, AssValidation.Amount);   
                }
                catch (Exception ee)
                {
                    e.Handled = true;
                    ShowTip(ee.Message, dgv_Inward.EditingControl);
                }
            }

              if(dgv_Inward.CurrentCell.ColumnIndex == rate.Index)
              {
                try
                {
                    ASSValidater.IsValid(Convert.ToString(dgv_Inward.CurrentCell.EditedFormattedValue), e.KeyChar, AssValidation.Amount);   
                }
                catch (Exception ee)
                {
                    e.Handled = true;
                    ShowTip(ee.Message, dgv_Inward.EditingControl);
                }
                }
        }

        private void EditingControl_TextChanged(object sender, EventArgs e)
        {
            if (dgv_Inward.CurrentCell.ColumnIndex == MaterialName.Index || dgv_Inward.CurrentCell.ColumnIndex ==MachineName.Index)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Trim() != string.Empty)
                {
                    obj = new CSInward();
                   if (dgv_Inward.CurrentCell.ColumnIndex == MaterialName.Index)
                       obj.FillList(list_material, txt, "%"+txt.Text.Trim()+"%", "material_name",1);
                   else
                       obj.FillList(list_material, txt, "%"+txt.Text.Trim()+"%", "machine_name", 2);
                  list_material.SelectedIndex = list_material.FindString(txt.Text.Trim(), 0);
                }
                else
                {
                    list_material.Visible = false;
                    list_material.DataSource = null;
                }
            }
        }

        private void dgv_Ledger_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            error_Show.SetError(dgv_Inward.EditingPanel, string.Empty);
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

            if (e.ColumnIndex == dgv_Inward.Columns["rate"].Index && (dgv_Inward["rate", e.RowIndex].EditedFormattedValue.ToString() == string.Empty || dgv_Inward["rate", e.RowIndex].EditedFormattedValue.ToString() == "." || dgv_Inward["rate", e.RowIndex].EditedFormattedValue.ToString() == "0." || dgv_Inward["rate", e.RowIndex].EditedFormattedValue.ToString() == ".0"))
                dgv_Inward.EditingControl.Text = "0.00";

            //if (e.ColumnIndex == qty.Index && Convert.ToString(dgv_Ledger.EditingControl.Text) == String.Empty)
            //{
            //    dgv_Ledger.EditingControl.Text = Convert.ToDouble(dgv_Ledger.EditingControl.Text).ToString("F2");
            //}
            if ((e.ColumnIndex == qty.Index||e.ColumnIndex == rate.Index) && Convert.ToString(dgv_Inward.EditingControl.Text) != String.Empty)
            {
                dgv_Inward.EditingControl.Text = Convert.ToDouble(dgv_Inward.EditingControl.Text).ToString("F2");
            }
            if ((e.ColumnIndex == qty.Index && Convert.ToString(dgv_Inward.EditingControl.Text) != String.Empty))
            {
                double ans = Convert.ToDouble(dgv_Inward.EditingControl.Text) * Convert.ToDouble(dgv_Inward[rate.Index, e.RowIndex].Value);
                dgv_Inward[Amount.Index, dgv_Inward.CurrentCell.RowIndex].Value = ans;
            }
            if ((e.ColumnIndex == rate.Index && Convert.ToString(dgv_Inward.EditingControl.Text) != String.Empty))
            {
                double ans = Convert.ToDouble(dgv_Inward.EditingControl.Text) * Convert.ToDouble(dgv_Inward[qty.Index, e.RowIndex].Value);
                dgv_Inward[Amount.Index, dgv_Inward.CurrentCell.RowIndex].Value = ans;
            }
 
            AmountSum();
            Tip_Message.Hide((Control)sender);

        }
        private void RemoveDgvEvents()
        {
            if (dgv_Inward.EditingControl != null)
            {
                dgv_Inward.EditingControl.KeyDown -= new KeyEventHandler(EditingControl_KeyDown);
                dgv_Inward.EditingControl.KeyPress -= new KeyPressEventHandler(EditingControl_KeyPress);
                dgv_Inward.EditingControl.TextChanged -= new EventHandler(EditingControl_TextChanged);
                dgv_Inward.CellValidating -= new DataGridViewCellValidatingEventHandler(dgv_Ledger_CellValidating);
            }
        }
        private void list_Ledger_MouseClick(object sender, MouseEventArgs e)
        {
            dgv_Inward.Focus();
        }

        private void dgv_Ledger_Leave_1(object sender, EventArgs e)
        {
            for (int row = 0; row < dgv_Inward.Rows.Count - 1; )
            {
                if (Convert.ToString(dgv_Inward[MaterialName.Index, row].Value) == string.Empty && Convert.ToString(dgv_Inward[MachineName.Index, row].Value) == string.Empty)
                {
                    RemoveDgvEvents();
                    dgv_Inward.Rows.RemoveAt(row);
                    row = 0;
                }
                else
                    row++;
            }
            AmountSum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_Ledger_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dgv_Inward.Focus();
            SetMaterial();
        }

        private void PaymentVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgv_Inward.RowCount > 1)
            {
                DialogResult = MessageBox.Show("Do you want to save the changes before closing?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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

        private void btn_PayShow_Click(object sender, EventArgs e)
        {
            obj = new CSInward();
            dgv_inward_Item.DataSource = null;
            dgv_inward_Item.Rows.Clear();

            dgv_inward_Item.AutoGenerateColumns = false;

            //check all possibilities of searching
            if (rb_machine.Checked == false && chk_bill_type.Checked == false)
            {
                dgv_inward_Item.DataSource = (obj.search(date_From.Value.Date, date_To.Value.Date, 0));
                if (dgv_inward_Item.RowCount < 1)
                    MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //search by machine name only in beetwwen selected dates
            else if (rb_machine.Checked == true && chk_bill_type.Checked == false)
            {
                dgv_inward_Item.DataSource = (obj.search(cmb_machine.Text, date_From.Value.Date, date_To.Value.Date, 5));
                if (dgv_inward_Item.RowCount < 1)
                    MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //search by bill type in perticular dates     
            else if (rb_machine.Checked == false && chk_bill_type.Checked == true)
            {
                if (cmb_bill.SelectedIndex == -1)
                {
                    ShowTip("Select Type", cmb_bill);
                    cmb_bill.Focus();
                    return;
                }
                dgv_inward_Item.DataSource = (obj.search(cmb_bill.Text.Trim(), date_From.Value.Date, date_To.Value.Date, 3));
                if (dgv_inward_Item.RowCount < 1)
                    MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //search by machine name and Bill type in beetwwen selected dates 
        }

        private void date_PayFrom_ValueChanged(object sender, EventArgs e)
        {
            date_To.MinDate = date_From.Value.Date;

        }
        private void PaymentVoucher_Activated(object sender, EventArgs e)
        {
            txt_GrnNo.Focus();
        }
        public void fillMachines()
        {
            obj = new CSInward();
            cmb_machine.DisplayMember = "machine_name";
            cmb_machine.ResetText();
            cmb_machine.DataSource = obj.FillMachine(); 
        }



        private void tab_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            rb_date.Checked = true;
            if (tab_Payment.SelectedIndex == 1)
            {
                fillMachines();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            

                obj = new CSInward();
                dgv_inward_Item.DataSource = null;

                 //Date wise search only
                if (rb_machine.Checked == false && chk_bill_type.Checked == false)
                {
                    dt=obj.search(date_From.Value.Date, date_To.Value.Date, 1);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExportDataToExcel(dt, saveFileDialog1.FileName);
                        }
                    }
                }
               //Machine Wise Search in beetween dates also
                else if (rb_machine.Checked == true)
                {

                    dt = obj.search(cmb_machine.Text, date_From.Value.Date, date_To.Value.Date, 2);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExportDataToExcel(dt, saveFileDialog1.FileName);
                        }
                    }
           
                }
                else if(chk_bill_type.Checked==true)
                {
                     if (cmb_bill.SelectedIndex == -1)
                     {
                        ShowTip("Select Type", cmb_bill);
                        cmb_bill.Focus();
                        return;
                     }
                     dt = obj.search(cmb_bill.Text.Trim(), date_From.Value.Date, date_To.Value.Date, 4);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Result Not Found........", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            ExportDataToExcel(dt, saveFileDialog1.FileName);
                        }
                    }
           
                }
            
                     


        
        }

        public static bool ExportDataToExcel(DataTable dt, string filepath)
        {
          
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRange;

            try
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
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message,"IOS",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

            return true;

          
        }

        private void date_To_ValueChanged(object sender, EventArgs e)
        {
            date_From.MaxDate = date_To.Value.Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (dgv_inward_Item.RowCount > 0)
                {
                   //reset all field first
                    Reset();
                    IsNew = false;
                    tab_Payment.SelectedIndex = 0;
                    btn_Save.Text = "&Update";
                    btn_Delete.Enabled = true;
                    obj = new CSInward();
                    obj.GrnNo = Convert.ToInt64(dgv_inward_Item[InwardNo.Index, dgv_inward_Item.CurrentCell.RowIndex].Value);

                    //Get All Inward Item here   
                    DataTable dt;
                    dt = new DataTable();
                    dt = obj.GetInward();
                    txt_GrnNo.Text = Convert.ToString(dt.Rows[0][0]);
                    dtp_inward.Value = Convert.ToDateTime(dt.Rows[0][1].ToString());
                    txt_billNo.Text = dt.Rows[0][2].ToString();
                    cmb_bill_type.Text = dt.Rows[0][3].ToString();
                    dtp_bill.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                    txt_PONO.Text = Convert.ToString(dt.Rows[0][5]);
                    if (txt_PONO.Text != String.Empty)
                        dtp_PO.Value = Convert.ToDateTime(dt.Rows[0][6].ToString());
                    cmb_sup.Text = Convert.ToString(dt.Rows[0][7]);
                    cmb_material_type.Text = Convert.ToString(dt.Rows[0][8]);
                    lbl_CreditAmt.Text=Convert.ToDouble(dt.Rows[0][9]).ToString("F2");

                    //Get All Inward Item here
                    dt = new DataTable();
                    dt = obj.GetInwardItem();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv_Inward.Rows.Add();
                        dgv_Inward[MaterialName.Index, i].Value = dt.Rows[i][1].ToString();
                        dgv_Inward[qty.Index, i].Value = dt.Rows[i][2].ToString();
                        dgv_Inward[Unit.Index, i].Value =dt.Rows[i][3].ToString();
                        dgv_Inward[rate.Index, i].Value =Convert.ToDouble(dt.Rows[i][4]).ToString("F2");
                        dgv_Inward[Amount.Index, i].Value =Convert.ToDouble(dt.Rows[i][5]).ToString("F2");
                        dgv_Inward[MachineName.Index, i].Value = dt.Rows[i][6];

                    }


               }

            }
            catch (Exception ee)
            {

                MessageBox.Show("Error At Upadte Event" + ee.Message);
            }





           


        }

        private void chk_bill_type_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_bill_type.Checked==true)
              rb_machine.Checked = false;
        }

        private void rb_machine_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_machine.Checked == true)
                chk_bill_type.Checked = false;

        }

        private void txt_mname_TextChanged(object sender, EventArgs e)
        {
            obj.FillList(list_partmaster, txt_mname,"%"+txt_mname.Text.Trim()+"%", "material_name", 1);
            if (txt_mname.Text.Trim() == string.Empty)
                list_partmaster.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_mname.Text.Trim() == string.Empty)
            {
                ShowTip("Enter Material Description", txt_mname);
                txt_mname.Focus();
                return;
            }
            else
            {
                CSInward obj = new CSInward();
                if (MessageBox.Show("Do you want to save New Material Name ?", "IOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj.AddNewMaterial(txt_mname.Text.Trim().ToUpperInvariant());
                    MessageBox.Show("√ New material Name Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                }
            }
        }

        private void tabPage_Entry_Click(object sender, EventArgs e)
        {

        }

        private void cmb_sup_KeyDown(object sender, KeyEventArgs e)
        {
            Control control = (Control)sender;
            try
            {
             
                if (e.KeyCode  ==Keys.Enter)
                    this.SelectNextControl((Control)sender, true, true, true, true);

                //if (control == dtp_PO)
                //{
                //    dgv_Inward.Focus();
                //    dgv_Inward.CurrentCell = dgv_Inward[0,0];
                //    dgv_Inward.BeginEdit(true);

                //}
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

      
    }
}
