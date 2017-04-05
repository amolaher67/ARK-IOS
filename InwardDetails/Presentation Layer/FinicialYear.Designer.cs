namespace InwardDetails.Presentation_Layer
{
    partial class FinicialYear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SetAsCurrentYear = new System.Windows.Forms.Button();
            this.btnAddNewYear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFinicialYear = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_FinicialYearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_FinYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinicialYear)).BeginInit();
            this.SuspendLayout();
            // 
            // SetAsCurrentYear
            // 
            this.SetAsCurrentYear.Location = new System.Drawing.Point(455, 293);
            this.SetAsCurrentYear.Name = "SetAsCurrentYear";
            this.SetAsCurrentYear.Size = new System.Drawing.Size(95, 37);
            this.SetAsCurrentYear.TabIndex = 1;
            this.SetAsCurrentYear.Text = "Set Finicial Year";
            this.SetAsCurrentYear.UseVisualStyleBackColor = true;
            this.SetAsCurrentYear.Click += new System.EventHandler(this.SetAsCurrentYear_Click);
            // 
            // btnAddNewYear
            // 
            this.btnAddNewYear.Location = new System.Drawing.Point(349, 293);
            this.btnAddNewYear.Name = "btnAddNewYear";
            this.btnAddNewYear.Size = new System.Drawing.Size(100, 37);
            this.btnAddNewYear.TabIndex = 2;
            this.btnAddNewYear.Text = "Add New";
            this.btnAddNewYear.UseVisualStyleBackColor = true;
            this.btnAddNewYear.Click += new System.EventHandler(this.btnAddNewYear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note : Indian Finicial Year Start 1 April to 31st March";
            // 
            // dgvFinicialYear
            // 
            this.dgvFinicialYear.AllowUserToDeleteRows = false;
            this.dgvFinicialYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinicialYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_FinicialYearID,
            this.MaterialName,
            this.clm_FinYear,
            this.RRate});
            this.dgvFinicialYear.Location = new System.Drawing.Point(2, 3);
            this.dgvFinicialYear.MultiSelect = false;
            this.dgvFinicialYear.Name = "dgvFinicialYear";
            this.dgvFinicialYear.ReadOnly = true;
            this.dgvFinicialYear.RowHeadersWidth = 45;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFinicialYear.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinicialYear.Size = new System.Drawing.Size(548, 284);
            this.dgvFinicialYear.TabIndex = 93;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FinicialYear";
            this.dataGridViewTextBoxColumn1.HeaderText = "Finicial Year";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 350;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "isActive";
            dataGridViewCellStyle3.Format = "F2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Current Finicial Yeatr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // clm_FinicialYearID
            // 
            this.clm_FinicialYearID.DataPropertyName = "FinicialYearID";
            this.clm_FinicialYearID.HeaderText = "finicial year ID";
            this.clm_FinicialYearID.Name = "clm_FinicialYearID";
            this.clm_FinicialYearID.ReadOnly = true;
            this.clm_FinicialYearID.Visible = false;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "FinicialYear";
            this.MaterialName.HeaderText = "Finicial Year";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 200;
            // 
            // clm_FinYear
            // 
            this.clm_FinYear.DataPropertyName = "FinYear";
            this.clm_FinYear.HeaderText = "Year";
            this.clm_FinYear.Name = "clm_FinYear";
            this.clm_FinYear.ReadOnly = true;
            // 
            // RRate
            // 
            this.RRate.DataPropertyName = "isActive";
            dataGridViewCellStyle1.Format = "F2";
            this.RRate.DefaultCellStyle = dataGridViewCellStyle1;
            this.RRate.HeaderText = "IsActive";
            this.RRate.Name = "RRate";
            this.RRate.ReadOnly = true;
            this.RRate.Width = 200;
            // 
            // FinicialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 336);
            this.Controls.Add(this.dgvFinicialYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewYear);
            this.Controls.Add(this.SetAsCurrentYear);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinicialYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinicialYear";
            this.Load += new System.EventHandler(this.FinicialYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinicialYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SetAsCurrentYear;
        private System.Windows.Forms.Button btnAddNewYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvFinicialYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_FinicialYearID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_FinYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn RRate;
    }
}