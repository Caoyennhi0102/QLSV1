using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Login : Form
    {
        int Numberoferrors;
        int maximumnumberoferrors = 3;
       
        

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private   void btLogin_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Username1 = "CodeLo",
                Password1 = "123456"
            };
            
            if(string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username và Password không được để trông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (teacher.IsLock1)
            {
                MessageBox.Show("Tài khoản của bạn đã bị khóa. Vui lòng liên hệ quản trị viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(teacher.Username1 == txtUsername.Text && teacher.Password1 == txtPassword.Text)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                SyStem syStem = new SyStem();
                syStem.Show();
                this.Hide();

            }
            else
            {
                Numberoferrors++;

                if(Numberoferrors >= 3)
                {
                    teacher.IsLock1 = true;
                    MessageBox.Show("Tài khoản của bạn đã bị khóa do nhập sai quá 3 lần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btLogin.Enabled = false;

                }
                else
                {
                    MessageBox.Show($"Sai UserName hoặc Password Bạn Còn {maximumnumberoferrors - Numberoferrors} lần thử", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
