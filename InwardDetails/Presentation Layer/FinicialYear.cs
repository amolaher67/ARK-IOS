using MiddleLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InwardDetails.Presentation_Layer
{
    public partial class FinicialYear : Form
    {

        CSFinicialYear obj;
        MDIParent1 MdiObject = null;

        public FinicialYear(MDIParent1 obj)
        {
            MdiObject = obj;
            InitializeComponent();
        }

        private void FinicialYear_Load(object sender, EventArgs e)
        {
            LoadAndBindFinicialYear();
        }

        public void LoadAndBindFinicialYear()
        {
            obj = new CSFinicialYear();
            dgvFinicialYear.AutoGenerateColumns = false;
            var finYearData = obj.getAllFinicialYears();
            dgvFinicialYear.DataSource = finYearData;

            DataRow row = finYearData.AsEnumerable().Where(S => S.Field<bool>("isActive") == true).FirstOrDefault();
            if (row != null)
            {
                GlobalData.CurrentFinicialYearID = Convert.ToInt32(row["FinicialYearID"]);
                GlobalData.CurrentFinicialYear = Convert.ToString(row["FinicialYear"]);
                MdiObject.toolStripStatusLabel_FinYear.Text = GlobalData.CurrentFinicialYear;
            }
        }

        private void btnAddNewYear_Click(object sender, EventArgs e)
        {
            obj = new CSFinicialYear();

            var startMonth = Convert.ToString(ConfigurationManager.AppSettings["FinicialYearMonth1"]);
            var endMonth = Convert.ToString(ConfigurationManager.AppSettings["FinicialYearMonth2"]);

            if (String.IsNullOrEmpty(startMonth) || String.IsNullOrEmpty(endMonth))
            {
                MessageBox.Show("Please set Appsetting values for Moths first.", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want to create new finicial year ?", "IOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                obj.SaveFinicialYear(startMonth, endMonth);
                MessageBox.Show("√ Finicial year created Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadAndBindFinicialYear();
        }

        private void SetAsCurrentYear_Click(object sender, EventArgs e)
        {
            if (dgvFinicialYear.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select finicial year", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            obj = new CSFinicialYear();
            var currentFinicialYearID = dgvFinicialYear.Rows[dgvFinicialYear.CurrentRow.Index].Cells["clm_FinicialYearID"].Value;
            if (currentFinicialYearID != null)
            {
                obj.SetCurrentFinicialYear(Convert.ToInt32(currentFinicialYearID));
                MessageBox.Show("√ Finicial year set Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAndBindFinicialYear();
                GlobalData.CurrentFinicialYearID = Convert.ToInt32(currentFinicialYearID);
            }
            else
                MessageBox.Show("Selected finicial year has some problem.", "IOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
