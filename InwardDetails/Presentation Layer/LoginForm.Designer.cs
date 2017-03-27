namespace InwardDetails.Presentation_Layer
{
    partial class LoginForm
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
            this.login_group = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new InwardDetails.WaterMarkTextBox();
            this.txt_login = new InwardDetails.WaterMarkTextBox();
            this.login_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_group
            // 
            this.login_group.BackColor = System.Drawing.Color.Transparent;
            this.login_group.Controls.Add(this.label3);
            this.login_group.Controls.Add(this.comboBox1);
            this.login_group.Controls.Add(this.pictureBox1);
            this.login_group.Controls.Add(this.btn_cancel);
            this.login_group.Controls.Add(this.label2);
            this.login_group.Controls.Add(this.txt_password);
            this.login_group.Controls.Add(this.label1);
            this.login_group.Controls.Add(this.btn_login);
            this.login_group.Controls.Add(this.txt_login);
            this.login_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_group.Location = new System.Drawing.Point(0, 0);
            this.login_group.Name = "login_group";
            this.login_group.Size = new System.Drawing.Size(463, 224);
            this.login_group.TabIndex = 15;
            this.login_group.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InwardDetails.Properties.Resources.Locker;
            this.pictureBox1.Location = new System.Drawing.Point(246, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 206);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_cancel.FlatAppearance.BorderSize = 2;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(103, 177);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "User Name";
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(10, 177);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(87, 38);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 22);
            this.comboBox1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Finincial Year";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(10, 86);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(216, 22);
            this.txt_password.TabIndex = 1;
            this.txt_password.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_password.WaterMarkText = "Password";
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(10, 34);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(216, 22);
            this.txt_login.TabIndex = 0;
            this.txt_login.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_login.WaterMarkText = "user..";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 224);
            this.Controls.Add(this.login_group);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.login_group.ResumeLayout(false);
            this.login_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_group;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private WaterMarkTextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private WaterMarkTextBox txt_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}