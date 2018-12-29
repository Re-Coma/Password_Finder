using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PasswordFinder
{
    public partial class LoginForm : Form
    {
        public Login start = null;
        public bool pass = false;

        public LoginForm()
        {
            start = new Login(); //로그인을 위한 세팅 시작
            InitializeComponent();
        }

        //나가기 버튼
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //로그인 성공
            if (idBox.Text.Equals(start.GetID()) && start.GetPswd().Equals(pswdBox.Text)) {
                //매인 폼으로 넘어가기
                pass = true;

                Close();
            }
            else //실패일 경우
            {
                MessageBox.Show("로그인 정보가 정확하지 않습니다.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idBox.Text = ""; pswdBox.Text = "";
                return;
            }
        }
    }
}
