using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace InwardDetails
{
   public class CustomDataGridView :DataGridView
   {
   
        [System.Security.Permissions.UIPermission(
    System.Security.Permissions.SecurityAction.LinkDemand,
    Window = System.Security.Permissions.UIPermissionWindow.AllWindows)]
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // Extract the key code from the key value. 
            Keys key = (keyData & Keys.KeyCode);

            // Handle the ENTER key as if it were a RIGHT ARROW key. 
            if (key == Keys.Enter)
            {
                Program.IsEnter = true;
                return this.ProcessTabKey(keyData);//.ProcessRightKey(keyData);
               
            }
            if (Convert.ToInt32(keyData) == 192)
            {
                return this.ProcessLeftKey(keyData);
            }
            //--------------------
            if (key == Keys.Subtract)
            {
                //return this.ProcessLeftKey(keyData);
                return this.ProcessUpKey(keyData);
            }
            if (key == Keys.Add)
            {
                return this.ProcessDownKey(keyData);
            }
            if (key == Keys.Multiply)
            {
                return this.ProcessRightKey(keyData);
            }
            if (key == Keys.Divide)
            {
                return this.ProcessLeftKey(keyData);
            }
            if (key == Keys.Escape)
            {
                return this.ProcessInsertKey(keyData);
            }
            

            return base.ProcessDialogKey(keyData);
        }

        [System.Security.Permissions.SecurityPermission(
         System.Security.Permissions.SecurityAction.LinkDemand, Flags =
         System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            // Handle the ENTER key as if it were a RIGHT ARROW key. 
            if (e.KeyCode == Keys.Enter)
            {
                     Program.IsEnter=true;
                return this.ProcessTabKey(e.KeyData);//.ProcessRightKey(e.KeyData);

            }
            if (e.KeyValue == 192)
            {
                return this.ProcessLeftKey(e.KeyData);
            }
            //----------------
            if (e.KeyCode == Keys.Subtract)
            {
                return this.ProcessUpKey(e.KeyData);
            }
            if (e.KeyCode == Keys.Add)
            {
                return this.ProcessDownKey(e.KeyData);
            }
            if (e.KeyCode == Keys.Multiply)
            {
                return this.ProcessRightKey(e.KeyData);
            }
            if (e.KeyCode == Keys.Divide)
            {
                return this.ProcessLeftKey(e.KeyData);
            }
            if (e.KeyCode == Keys.Escape)
            {
                return this.ProcessInsertKey(e.KeyData);
            }
            if (e.KeyCode == Keys.Down)
            {
                return this.ProcessInsertKey(e.KeyData);
            }
            if (e.KeyCode == Keys.Up)
            {
                return this.ProcessInsertKey(e.KeyData);
            }
            return base.ProcessDataGridViewKey(e);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomDataGridView
            // 
            this.Enter += new System.EventHandler(this.CustomDataGridView_Enter);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void CustomDataGridView_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
