using InwardDetails.Presentation_Layer;
using MiddleLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InwardDetails
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            GlobalData.CurrentUser = string.Empty;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if (Application.OpenForms["PaymentVoucher"] == null)
            {
                PaymentVoucher obj = new PaymentVoucher();
                obj.MdiParent = this;
                obj.Show();
                obj.ShowInTaskbar = false;
            }
            else
                Application.OpenForms["PaymentVoucher"].Activate();

        }

        private void OpenFile(object sender, EventArgs e)
        {

            if (Application.OpenForms["Outward"] == null)
            {
                Outward obj = new Outward();
                obj.MdiParent = this;
                obj.Show();
                obj.ShowInTaskbar = false;
            }
            else
                Application.OpenForms["Outward"].Activate();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to close IOS...... ", "IOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }



        private void stockDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StockReport"] == null)
            {
                StockReport obj = new StockReport();
                obj.MdiParent = this;
                obj.Show();
                obj.ShowInTaskbar = false;
            }
            else
                Application.OpenForms["StockReport"].Activate();
        }

        private void userLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileMenu.Enabled == false)
            {
                if (Application.OpenForms["LoginForm"] == null)
                {
                    LoginForm obj = new LoginForm();
                    obj.ShowDialog();
                }
                else
                    Application.OpenForms["LoginForm"].Activate();


                if (!string.IsNullOrEmpty(GlobalData.CurrentUser))
                {
                    fileMenu.Enabled = true;
                    reporMenu.Enabled = true;
                }

                toolStripStatusLabel_FinYear.Text = GlobalData.CurrentFinicialYear;
                //login_group.Visible = false;
                //txt_login.ResetText();
                //txt_password.ResetText();

                //login_group.Visible = true;
                // txt_login.Focus();
            }
        }

        //private void btn_login_Click(object sender, EventArgs e)
        //{
        //    if (txt_login.Text.Trim() == string.Empty)
        //    {
        //        txt_login.Focus();
        //        MessageBox.Show("Enter Usen Name", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    else if (txt_password.Text.Trim() == string.Empty)
        //    {
        //        txt_login.Focus();
        //        MessageBox.Show("Enter Password Name", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;

        //    }
        //    else
        //    {
        //        if (txt_login.Text.Trim().Equals("admin") && txt_password.Text.Trim().Equals("ark"))
        //        {

        //            fileMenu.Enabled = true;
        //            reporMenu.Enabled = true;
        //            login_group.Visible = false;
        //            txt_login.ResetText();
        //            txt_password.ResetText();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid User Name And password combination", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }
        //    }

        //}

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileMenu.Enabled == true)
            {
                fileMenu.Enabled = false;
                reporMenu.Enabled = false;

            }
        }

        //private void btn_cancel_Click(object sender, EventArgs e)
        //{
        //    login_group.Visible = false;
        //}

        private void txt_login_KeyPress(object sender, KeyPressEventArgs e)
        {

            Control control = (Control)sender;
            try
            {

                if (e.KeyChar == 13)
                    this.SelectNextControl((Control)sender, true, true, true, true);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void rulesToBeFollwsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Help"] == null)
            {
                //Help obj = new Help();

                //obj.MdiParent = this;
                //obj.Show();
                //obj.ShowInTaskbar = false;
            }
            else
                Application.OpenForms["Help"].Activate();
        }

        private void finicialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["FinicialYear"] == null)
            {
                FinicialYear obj = new FinicialYear(this);

                obj.MdiParent = this;
                obj.Show();
                obj.ShowInTaskbar = false;
            }
            else
                Application.OpenForms["Help"].Activate();
         
        }
    }
}
