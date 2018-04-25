namespace project1
{
    partial class account
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.fusername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.fpassword = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.returnnewpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.fusername);
            this.panel2.Location = new System.Drawing.Point(46, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 42);
            this.panel2.TabIndex = 1;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(177, 12);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(392, 22);
            this.username.TabIndex = 1;
            this.username.Text = "nguyenhuongathoa@gmail.com";
            // 
            // fusername
            // 
            this.fusername.AutoSize = true;
            this.fusername.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fusername.Location = new System.Drawing.Point(14, 11);
            this.fusername.Name = "fusername";
            this.fusername.Size = new System.Drawing.Size(157, 22);
            this.fusername.TabIndex = 0;
            this.fusername.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 42);
            this.panel1.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(177, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(392, 22);
            this.name.TabIndex = 1;
            this.name.Text = "Nguyễn Thị Hường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.fpassword);
            this.panel3.Location = new System.Drawing.Point(46, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 42);
            this.panel3.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(177, 12);
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(392, 22);
            this.password.TabIndex = 1;
            this.password.Text = "********";
            this.password.UseSystemPasswordChar = true;
            // 
            // fpassword
            // 
            this.fpassword.AutoSize = true;
            this.fpassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpassword.Location = new System.Drawing.Point(14, 11);
            this.fpassword.Name = "fpassword";
            this.fpassword.Size = new System.Drawing.Size(102, 22);
            this.fpassword.TabIndex = 0;
            this.fpassword.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.newpassword);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(46, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(593, 42);
            this.panel4.TabIndex = 4;
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(177, 12);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(392, 22);
            this.newpassword.TabIndex = 1;
            this.newpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.returnnewpassword);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(46, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(593, 42);
            this.panel5.TabIndex = 5;
            // 
            // returnnewpassword
            // 
            this.returnnewpassword.Location = new System.Drawing.Point(177, 12);
            this.returnnewpassword.Name = "returnnewpassword";
            this.returnnewpassword.Size = new System.Drawing.Size(392, 22);
            this.returnnewpassword.TabIndex = 1;
            this.returnnewpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại:";
            // 
            // update
            // 
            this.update.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(237, 433);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 24);
            this.update.TabIndex = 6;
            this.update.Text = "Cập nhật";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(473, 433);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(94, 24);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(46, 316);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(593, 42);
            this.panel6.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Việt Nam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "quốc tịch";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(46, 375);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(593, 42);
            this.panel7.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(392, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "28/03/1998";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ngày sinh";
            // 
            // account
            // 
            this.AcceptButton = this.update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.update;
            this.ClientSize = new System.Drawing.Size(678, 469);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.update);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập_thông_tin_cá_nhân";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label fusername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label fpassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox returnnewpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}