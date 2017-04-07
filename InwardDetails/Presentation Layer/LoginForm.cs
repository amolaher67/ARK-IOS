using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiddleLayer;

namespace InwardDetails.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_login.Text.Trim() == string.Empty)
            {
                txt_login.Focus();
                MessageBox.Show("Enter Usen Name", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txt_password.Text.Trim() == string.Empty)
            {
                txt_login.Focus();
                MessageBox.Show("Enter Password Name", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txt_login.Text.Trim().Equals("admin") && txt_password.Text.Trim().Equals("ark"))
            {

                GlobalData.CurrentUser = "admin";
                GlobalData.CurrentFinicialYear = comboFinicialYear.Text;
                GlobalData.CurrentFinicialYearID = Convert.ToInt32(comboFinicialYear.SelectedValue);
                //fileMenu.Enabled = true;
                //reporMenu.Enabled = true;
                //login_group.Visible = false;
                //txt_login.ResetText();
                //txt_password.ResetText();
                this.Close();
                return;
            }
            else
            {

                MessageBox.Show("Invalid User Name And password combination", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_login.ResetText();
                txt_password.ResetText();

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            GlobalData.CurrentUser = "";
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            GlobalData.CurrentUser = string.Empty;

            //Load Finicial Years
            CSFinicialYear objCsFin = new CSFinicialYear();
            var finYearsData = objCsFin.getAllFinicialYears();

            comboFinicialYear.DisplayMember = "FinicialYear";
            comboFinicialYear.ValueMember = "FinicialYearID";
            comboFinicialYear.DataSource = finYearsData;

            var selectedRow = finYearsData.AsEnumerable().Where(s => s.Field<bool>("isActive") == true);

            if (selectedRow.Any() && selectedRow.Count() > 0)
                comboFinicialYear.SelectedValue = selectedRow.FirstOrDefault().Field<int>("FinicialYearID");

        }
    }
}

