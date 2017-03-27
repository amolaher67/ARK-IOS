namespace InwardDetails
{
    partial class StockReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReport));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_mat = new System.Windows.Forms.RadioButton();
            this.Rb_All = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PayShow = new System.Windows.Forms.Button();
            this.cmb_machine = new System.Windows.Forms.ComboBox();
            this.rb_material = new System.Windows.Forms.RadioButton();
            this.dgv_outward_Item = new System.Windows.Forms.DataGridView();
            this.Tip_Message = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outward_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_mat);
            this.groupBox2.Controls.Add(this.Rb_All);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_PayShow);
            this.groupBox2.Controls.Add(this.cmb_machine);
            this.groupBox2.Controls.Add(this.rb_material);
            this.groupBox2.Location = new System.Drawing.Point(8, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 75);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Searching";
            // 
            // rb_mat
            // 
            this.rb_mat.AutoSize = true;
            this.rb_mat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rb_mat.Location = new System.Drawing.Point(103, 54);
            this.rb_mat.Name = "rb_mat";
            this.rb_mat.Size = new System.Drawing.Size(95, 18);
            this.rb_mat.TabIndex = 93;
            this.rb_mat.Text = "Material Type";
            this.rb_mat.UseVisualStyleBackColor = true;
            // 
            // Rb_All
            // 
            this.Rb_All.AutoSize = true;
            this.Rb_All.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Rb_All.Location = new System.Drawing.Point(26, 53);
            this.Rb_All.Name = "Rb_All";
            this.Rb_All.Size = new System.Drawing.Size(42, 18);
            this.Rb_All.TabIndex = 92;
            this.Rb_All.Text = "All";
            this.Rb_All.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(665, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 91;
            this.button1.Text = " &Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_PayShow
            // 
            this.btn_PayShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PayShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_PayShow.FlatAppearance.BorderSize = 2;
            this.btn_PayShow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn_PayShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_PayShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_PayShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PayShow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayShow.Location = new System.Drawing.Point(585, 23);
            this.btn_PayShow.Name = "btn_PayShow";
            this.btn_PayShow.Size = new System.Drawing.Size(74, 32);
            this.btn_PayShow.TabIndex = 86;
            this.btn_PayShow.Text = " &Show";
            this.btn_PayShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PayShow.UseVisualStyleBackColor = true;
            this.btn_PayShow.Click += new System.EventHandler(this.btn_PayShow_Click);
            // 
            // cmb_machine
            // 
            this.cmb_machine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_machine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_machine.FormattingEnabled = true;
            this.cmb_machine.Location = new System.Drawing.Point(103, 27);
            this.cmb_machine.Name = "cmb_machine";
            this.cmb_machine.Size = new System.Drawing.Size(376, 21);
            this.cmb_machine.TabIndex = 88;
            // 
            // rb_material
            // 
            this.rb_material.AutoSize = true;
            this.rb_material.Checked = true;
            this.rb_material.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rb_material.Location = new System.Drawing.Point(26, 29);
            this.rb_material.Name = "rb_material";
            this.rb_material.Size = new System.Drawing.Size(68, 18);
            this.rb_material.TabIndex = 90;
            this.rb_material.TabStop = true;
            this.rb_material.Text = "Material";
            this.rb_material.UseVisualStyleBackColor = true;
            // 
            // dgv_outward_Item
            // 
            this.dgv_outward_Item.AllowUserToDeleteRows = false;
            this.dgv_outward_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outward_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialName,
            this.RRate,
            this.Amount,
            this.Available_Stock});
            this.dgv_outward_Item.Location = new System.Drawing.Point(8, 103);
            this.dgv_outward_Item.MultiSelect = false;
            this.dgv_outward_Item.Name = "dgv_outward_Item";
            this.dgv_outward_Item.ReadOnly = true;
            this.dgv_outward_Item.RowHeadersWidth = 45;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_outward_Item.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_outward_Item.Size = new System.Drawing.Size(787, 372);
            this.dgv_outward_Item.TabIndex = 92;
            // 
            // Tip_Message
            // 
            this.Tip_Message.IsBalloon = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "material_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Material Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 350;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "rate";
            dataGridViewCellStyle5.Format = "F2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "total";
            dataGridViewCellStyle6.Format = "F2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AvailableStock";
            dataGridViewCellStyle7.Format = "F2";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Available Stock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "material_name";
            this.MaterialName.HeaderText = "Material Name/Material_Type";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 350;
            // 
            // RRate
            // 
            this.RRate.DataPropertyName = "rate";
            dataGridViewCellStyle1.Format = "F2";
            this.RRate.DefaultCellStyle = dataGridViewCellStyle1;
            this.RRate.HeaderText = "Rate";
            this.RRate.Name = "RRate";
            this.RRate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "total";
            dataGridViewCellStyle2.Format = "F2";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Available_Stock
            // 
            this.Available_Stock.DataPropertyName = "AvailableStock";
            dataGridViewCellStyle3.Format = "F2";
            this.Available_Stock.DefaultCellStyle = dataGridViewCellStyle3;
            this.Available_Stock.HeaderText = "Available Stock";
            this.Available_Stock.Name = "Available_Stock";
            this.Available_Stock.ReadOnly = true;
            this.Available_Stock.Width = 150;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(807, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_outward_Item);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StockReport";
            this.ShowInTaskbar = false;
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.StockReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outward_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_machine;
        private System.Windows.Forms.DataGridView dgv_outward_Item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_PayShow;
        private System.Windows.Forms.RadioButton Rb_All;
        private System.Windows.Forms.RadioButton rb_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolTip Tip_Message;
        private System.Windows.Forms.RadioButton rb_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Stock;
    }
}