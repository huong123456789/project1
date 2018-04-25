namespace project1
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.fpassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.fusername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.btlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 178);
            this.panel1.TabIndex = 0;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(302, 116);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(101, 34);
            this.btexit.TabIndex = 3;
            this.btexit.Text = "Thoát";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(177, 117);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(103, 34);
            this.btlogin.TabIndex = 2;
            this.btlogin.Text = "Đăng nhập";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.fpassword);
            this.panel3.Location = new System.Drawing.Point(7, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 42);
            this.panel3.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(170, 12);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(249, 22);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fpassword
            // 
            this.fpassword.AutoSize = true;
            this.fpassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpassword.Location = new System.Drawing.Point(7, 11);
            this.fpassword.Name = "fpassword";
            this.fpassword.Size = new System.Drawing.Size(102, 22);
            this.fpassword.TabIndex = 0;
            this.fpassword.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.fusername);
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 42);
            this.panel2.TabIndex = 0;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(177, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(249, 22);
            this.username.TabIndex = 1;
            // 
            // fusername
            // 
            this.fusername.AutoSize = true;
            this.fusername.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fusername.Location = new System.Drawing.Point(14, 12);
            this.fusername.Name = "fusername";
            this.fusername.Size = new System.Drawing.Size(157, 22);
            this.fusername.TabIndex = 0;
            this.fusername.Text = "Tên đăng nhập:";
            // 
            // login
            // 
            this.AcceptButton = this.btlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 202);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label fpassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label fusername;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btlogin;
    }
}

