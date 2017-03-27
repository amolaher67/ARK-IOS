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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReport));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PayShow = new System.Windows.Forms.Button();
            this.cmb_machine = new System.Windows.Forms.ComboBox();
            this.rb_machine = new System.Windows.Forms.RadioButton();
            this.dgv_outward_Item = new System.Windows.Forms.DataGridView();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outward_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_PayShow);
            this.groupBox2.Controls.Add(this.cmb_machine);
            this.groupBox2.Controls.Add(this.rb_machine);
            this.groupBox2.Location = new System.Drawing.Point(8, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 75);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Searching";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(26, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 18);
            this.radioButton1.TabIndex = 92;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 91;
            this.button1.Text = " &Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_PayShow
            // 
            this.btn_PayShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PayShow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayShow.Location = new System.Drawing.Point(475, 23);
            this.btn_PayShow.Name = "btn_PayShow";
            this.btn_PayShow.Size = new System.Drawing.Size(83, 32);
            this.btn_PayShow.TabIndex = 86;
            this.btn_PayShow.Text = " &Show";
            this.btn_PayShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PayShow.UseVisualStyleBackColor = true;
            this.btn_PayShow.Click += new System.EventHandler(this.btn_PayShow_Click);
            // 
            // cmb_machine
            // 
            this.cmb_machine.FormattingEnabled = true;
            this.cmb_machine.Location = new System.Drawing.Point(103, 30);
            this.cmb_machine.Name = "cmb_machine";
            this.cmb_machine.Size = new System.Drawing.Size(346, 21);
            this.cmb_machine.TabIndex = 88;
            // 
            // rb_machine
            // 
            this.rb_machine.AutoSize = true;
            this.rb_machine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rb_machine.Location = new System.Drawing.Point(26, 31);
            this.rb_machine.Name = "rb_machine";
            this.rb_machine.Size = new System.Drawing.Size(77, 18);
            this.rb_machine.TabIndex = 90;
            this.rb_machine.TabStop = true;
            this.rb_machine.Text = "Machine";
            this.rb_machine.UseVisualStyleBackColor = true;
            // 
            // dgv_outward_Item
            // 
            this.dgv_outward_Item.AllowUserToDeleteRows = false;
            this.dgv_outward_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outward_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialName,
            this.Available_Stock});
            this.dgv_outward_Item.Location = new System.Drawing.Point(8, 103);
            this.dgv_outward_Item.Name = "dgv_outward_Item";
            this.dgv_outward_Item.ReadOnly = true;
            this.dgv_outward_Item.Size = new System.Drawing.Size(657, 372);
            this.dgv_outward_Item.TabIndex = 92;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "material_name";
            this.MaterialName.HeaderText = "Material Name";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 350;
            // 
            // Available_Stock
            // 
            this.Available_Stock.DataPropertyName = "AvailableStock";
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
            this.ClientSize = new System.Drawing.Size(672, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_outward_Item);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rb_machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Stock;
    }
}