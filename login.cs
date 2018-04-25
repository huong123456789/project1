using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btlogin_Click(object sender, EventArgs e)
        {
            bool boqua = true;
            if (username.Text.Length == 0 || password.Text.Length == 0)
                MessageBox.Show("bạn chưa nhập mật khẩu hoặc tên đăng nhập xin kiểm tra lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((this.username.Text == ("nguyenhuongathoa@gmail.com")) && (this.password.Text == ("20101975")) || boqua)
            {
                    TableMain f = new TableMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
               }
    
            else MessageBox.Show("Tài khoản của bạn chưa đúng");
            
            
        }
       
    }
}
