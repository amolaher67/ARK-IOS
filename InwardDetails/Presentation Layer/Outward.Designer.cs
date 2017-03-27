namespace InwardDetails
{
    partial class Outward
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Outward));
            this.tab_out = new System.Windows.Forms.TabControl();
            this.tp_outward = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IssueNo = new System.Windows.Forms.TextBox();
            this.list_material = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.dtp_outward = new System.Windows.Forms.DateTimePicker();
            this.dgv_outward = new InwardDetails.CustomDataGridView();
            this.MaterialName = new InwardDetails.TextboxColumn();
            this.MachineName = new InwardDetails.TextboxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_date = new System.Windows.Forms.CheckBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PayShow = new System.Windows.Forms.Button();
            this.cmb_machine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_To = new System.Windows.Forms.DateTimePicker();
            this.date_From = new System.Windows.Forms.DateTimePicker();
            this.rb_machine = new System.Windows.Forms.CheckBox();
            this.dgv_outward_Item = new System.Windows.Forms.DataGridView();
            this.IssueNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issuedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip_Message = new System.Windows.Forms.ToolTip(this.components);
            this.error_Show = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_out.SuspendLayout();
            this.tp_outward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outward)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outward_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_out
            // 
            this.tab_out.Controls.Add(this.tp_outward);
            this.tab_out.Controls.Add(this.tabPage2);
            this.tab_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_out.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_out.Location = new System.Drawing.Point(0, 0);
            this.tab_out.Name = "tab_out";
            this.tab_out.SelectedIndex = 0;
            this.tab_out.Size = new System.Drawing.Size(946, 531);
            this.tab_out.TabIndex = 0;
            this.tab_out.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tp_outward
            // 
            this.tp_outward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tp_outward.Controls.Add(this.label4);
            this.tp_outward.Controls.Add(this.label6);
            this.tp_outward.Controls.Add(this.label5);
            this.tp_outward.Controls.Add(this.txt_IssueNo);
            this.tp_outward.Controls.Add(this.list_material);
            this.tp_outward.Controls.Add(this.label8);
            this.tp_outward.Controls.Add(this.cmb_name);
            this.tp_outward.Controls.Add(this.btn_Save);
            this.tp_outward.Controls.Add(this.btn_Reset);
            this.tp_outward.Controls.Add(this.dtp_outward);
            this.tp_outward.Controls.Add(this.dgv_outward);
            this.tp_outward.Controls.Add(this.label3);
            this.tp_outward.Controls.Add(this.label2);
            this.tp_outward.Controls.Add(this.label1);
            this.tp_outward.Location = new System.Drawing.Point(4, 22);
            this.tp_outward.Name = "tp_outward";
            this.tp_outward.Padding = new System.Windows.Forms.Padding(3);
            this.tp_outward.Size = new System.Drawing.Size(938, 505);
            this.tp_outward.TabIndex = 0;
            this.tp_outward.Text = "Entry";
            this.tp_outward.Click += new System.EventHandler(this.tp_outward_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(805, 1);
            this.label4.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(805, 3);
            this.label6.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "No";
            // 
            // txt_IssueNo
            // 
            this.txt_IssueNo.Enabled = false;
            this.txt_IssueNo.Location = new System.Drawing.Point(69, 101);
            this.txt_IssueNo.Name = "txt_IssueNo";
            this.txt_IssueNo.Size = new System.Drawing.Size(145, 21);
            this.txt_IssueNo.TabIndex = 23;
            // 
            // list_material
            // 
            this.list_material.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_material.FormattingEnabled = true;
            this.list_material.Location = new System.Drawing.Point(69, 255);
            this.list_material.Name = "list_material";
            this.list_material.Size = new System.Drawing.Size(312, 95);
            this.list_material.TabIndex = 22;
            this.list_material.TabStop = false;
            this.list_material.Visible = false;
            this.list_material.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_Ledger_MouseClick);
            this.list_material.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_Ledger_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Name";
            // 
            // cmb_name
            // 
            this.cmb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_name.BackColor = System.Drawing.Color.White;
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(69, 127);
            this.cmb_name.MaxLength = 30;
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(348, 21);
            this.cmb_name.TabIndex = 0;
            this.cmb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_name_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.FlatAppearance.BorderSize = 2;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(379, 426);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 36);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = " &Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reset.FlatAppearance.BorderSize = 2;
            this.btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(471, 426);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(89, 36);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = " &Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // dtp_outward
            // 
            this.dtp_outward.CustomFormat = "dd/MM/yyyy";
            this.dtp_outward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_outward.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_outward.Location = new System.Drawing.Point(683, 10);
            this.dtp_outward.Name = "dtp_outward";
            this.dtp_outward.Size = new System.Drawing.Size(109, 22);
            this.dtp_outward.TabIndex = 16;
            // 
            // dgv_outward
            // 
            this.dgv_outward.AllowUserToDeleteRows = false;
            this.dgv_outward.AllowUserToOrderColumns = true;
            this.dgv_outward.AllowUserToResizeColumns = false;
            this.dgv_outward.AllowUserToResizeRows = false;
            this.dgv_outward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_outward.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_outward.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_outward.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_outward.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_outward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialName,
            this.MachineName,
            this.qty,
            this.Issue});
            this.dgv_outward.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_outward.EnableHeadersVisualStyles = false;
            this.dgv_outward.Location = new System.Drawing.Point(6, 167);
            this.dgv_outward.MultiSelect = false;
            this.dgv_outward.Name = "dgv_outward";
            this.dgv_outward.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_outward.RowHeadersVisible = false;
            this.dgv_outward.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_outward.Size = new System.Drawing.Size(924, 253);
            this.dgv_outward.TabIndex = 1;
            this.dgv_outward.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_Ledger_EditingControlShowing);
            this.dgv_outward.Leave += new System.EventHandler(this.dgv_outward_Leave);
            // 
            // MaterialName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.MaterialName.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaterialName.HeaderText = "Material Description";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialName.Width = 320;
            // 
            // MachineName
            // 
            this.MachineName.HeaderText = "Machine Name";
            this.MachineName.Name = "MachineName";
            this.MachineName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MachineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MachineName.Width = 300;
            // 
            // qty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.qty.HeaderText = "Quantity";
            this.qty.MaxInputLength = 4;
            this.qty.Name = "qty";
            this.qty.Width = 70;
            // 
            // Issue
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "0";
            this.Issue.DefaultCellStyle = dataGridViewCellStyle3;
            this.Issue.HeaderText = "Issue qty";
            this.Issue.Name = "Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tal-Khed,Dist- Pune-401501,Email-arkengg@vsnl.net";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(636, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gat No.245,246,247,249,Chakan-Talegaon Road,Kharabwadi,Near Kharabwadi Toll Naka," +
                "Chakan, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "ARK MachTek Private Limited";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dgv_outward_Item);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(938, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_date);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_PayShow);
            this.groupBox2.Controls.Add(this.cmb_machine);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.date_To);
            this.groupBox2.Controls.Add(this.date_From);
            this.groupBox2.Controls.Add(this.rb_machine);
            this.groupBox2.Location = new System.Drawing.Point(11, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 98);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Searching";
            // 
            // rb_date
            // 
            this.rb_date.AutoSize = true;
            this.rb_date.Checked = true;
            this.rb_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rb_date.Enabled = false;
            this.rb_date.Location = new System.Drawing.Point(18, 22);
            this.rb_date.Name = "rb_date";
            this.rb_date.Size = new System.Drawing.Size(58, 17);
            this.rb_date.TabIndex = 94;
            this.rb_date.Text = "Date:";
            this.rb_date.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.FlatAppearance.BorderSize = 2;
            this.btn_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(713, 25);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 38);
            this.btn_update.TabIndex = 93;
            this.btn_update.Text = " &Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.FlatAppearance.BorderSize = 2;
            this.btn_Delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(795, 25);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(73, 38);
            this.btn_Delete.TabIndex = 92;
            this.btn_Delete.Text = " &Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(631, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 39);
            this.button1.TabIndex = 91;
            this.button1.Text = " &Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_PayShow
            // 
            this.btn_PayShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PayShow.FlatAppearance.BorderSize = 2;
            this.btn_PayShow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn_PayShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_PayShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_PayShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PayShow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayShow.Location = new System.Drawing.Point(551, 25);
            this.btn_PayShow.Name = "btn_PayShow";
            this.btn_PayShow.Size = new System.Drawing.Size(74, 38);
            this.btn_PayShow.TabIndex = 86;
            this.btn_PayShow.Text = " &Show";
            this.btn_PayShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PayShow.UseVisualStyleBackColor = true;
            this.btn_PayShow.Click += new System.EventHandler(this.btn_PayShow_Click);
            // 
            // cmb_machine
            // 
            this.cmb_machine.FormattingEnabled = true;
            this.cmb_machine.Location = new System.Drawing.Point(91, 58);
            this.cmb_machine.Name = "cmb_machine";
            this.cmb_machine.Size = new System.Drawing.Size(290, 21);
            this.cmb_machine.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "To";
            // 
            // date_To
            // 
            this.date_To.CustomFormat = "dd/MM/yyyy";
            this.date_To.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_To.Location = new System.Drawing.Point(258, 20);
            this.date_To.Name = "date_To";
            this.date_To.Size = new System.Drawing.Size(123, 21);
            this.date_To.TabIndex = 85;
            this.date_To.ValueChanged += new System.EventHandler(this.date_To_ValueChanged);
            // 
            // date_From
            // 
            this.date_From.CustomFormat = "dd/MM/yyyy";
            this.date_From.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_From.Location = new System.Drawing.Point(90, 20);
            this.date_From.Name = "date_From";
            this.date_From.Size = new System.Drawing.Size(121, 21);
            this.date_From.TabIndex = 84;
            this.date_From.ValueChanged += new System.EventHandler(this.date_From_ValueChanged);
            // 
            // rb_machine
            // 
            this.rb_machine.AutoSize = true;
            this.rb_machine.Location = new System.Drawing.Point(18, 60);
            this.rb_machine.Name = "rb_machine";
            this.rb_machine.Size = new System.Drawing.Size(77, 17);
            this.rb_machine.TabIndex = 95;
            this.rb_machine.Text = "Machine:";
            this.rb_machine.UseVisualStyleBackColor = true;
            // 
            // dgv_outward_Item
            // 
            this.dgv_outward_Item.AllowUserToAddRows = false;
            this.dgv_outward_Item.AllowUserToDeleteRows = false;
            this.dgv_outward_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outward_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueNo,
            this.IssueTo,
            this.Issuedate,
            this.Material_name,
            this.Machine,
            this.Quantity,
            this.IssueQty,
            this.Rate});
            this.dgv_outward_Item.Location = new System.Drawing.Point(8, 120);
            this.dgv_outward_Item.MultiSelect = false;
            this.dgv_outward_Item.Name = "dgv_outward_Item";
            this.dgv_outward_Item.ReadOnly = true;
            this.dgv_outward_Item.Size = new System.Drawing.Size(922, 351);
            this.dgv_outward_Item.TabIndex = 90;
            // 
            // IssueNo
            // 
            this.IssueNo.DataPropertyName = "IssueNo";
            this.IssueNo.HeaderText = "Issue No";
            this.IssueNo.Name = "IssueNo";
            this.IssueNo.ReadOnly = true;
            // 
            // IssueTo
            // 
            this.IssueTo.DataPropertyName = "IssueTo";
            this.IssueTo.HeaderText = "Issue To";
            this.IssueTo.Name = "IssueTo";
            this.IssueTo.ReadOnly = true;
            // 
            // Issuedate
            // 
            this.Issuedate.DataPropertyName = "Issuedate";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.Issuedate.DefaultCellStyle = dataGridViewCellStyle4;
            this.Issuedate.HeaderText = "Issue Date";
            this.Issuedate.Name = "Issuedate";
            this.Issuedate.ReadOnly = true;
            // 
            // Material_name
            // 
            this.Material_name.DataPropertyName = "Material_name";
            this.Material_name.HeaderText = "Material Name";
            this.Material_name.Name = "Material_name";
            this.Material_name.ReadOnly = true;
            this.Material_name.Width = 150;
            // 
            // Machine
            // 
            this.Machine.DataPropertyName = "MachineName";
            this.Machine.HeaderText = "Machine Name";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "qty";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // IssueQty
            // 
            this.IssueQty.DataPropertyName = "IssueQty";
            this.IssueQty.HeaderText = "Issue Qty";
            this.IssueQty.Name = "IssueQty";
            this.IssueQty.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "rate";
            dataGridViewCellStyle5.Format = "F2";
            this.Rate.DefaultCellStyle = dataGridViewCellStyle5;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Tip_Message
            // 
            this.Tip_Message.IsBalloon = true;
            // 
            // error_Show
            // 
            this.error_Show.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_Show.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IssueNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Issue No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IssueTo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Issue To";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Issuedate";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Issue Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Material_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Material Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Machine Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IssueQty";
            this.dataGridViewTextBoxColumn7.HeaderText = "Issue Qty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "rate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Outward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(946, 531);
            this.Controls.Add(this.tab_out);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Outward";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outward";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentVoucher_FormClosing);
            this.Load += new System.EventHandler(this.Outward_Load);
            this.tab_out.ResumeLayout(false);
            this.tp_outward.ResumeLayout(false);
            this.tp_outward.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outward)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outward_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_out;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip Tip_Message;
        private System.Windows.Forms.ErrorProvider error_Show;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_PayShow;
        private System.Windows.Forms.ComboBox cmb_machine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_To;
        private System.Windows.Forms.DateTimePicker date_From;
        private System.Windows.Forms.DataGridView dgv_outward_Item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TabPage tp_outward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IssueNo;
        private System.Windows.Forms.ListBox list_material;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DateTimePicker dtp_outward;
        private CustomDataGridView dgv_outward;
        private TextboxColumn MaterialName;
        private TextboxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rb_date;
        private System.Windows.Forms.CheckBox rb_machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issuedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;

    }
}