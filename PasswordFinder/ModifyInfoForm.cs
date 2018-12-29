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
    public partial class ModifyInfoForm : Form
    {
        private SQLiteConnection sql = null; //커넥션
        private Login newLogin = null; //변경할 계정
        private bool IdentifyPass = false; //신원확인

        public ModifyInfoForm(SQLiteConnection conn, ref Login login)
        {
            //세팅
            sql = conn;
            newLogin = login;

            InitializeComponent();
        }
        //취소 버튼
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //확인 버튼
        private void OKBtn_Click(object sender, EventArgs e)
        {
            switch(IdentifyPass)
            {
                case false: //신원학인
                    if(!AreYouAdmin()) //틀릴 경우
                    {
                        MessageBox.Show("비밀번호와 아이디 입력이 잘못되었습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else //맞을 경우
                    {
                        //재설정 모드로 전환
                        MainText.Text = "아이디, 비밀번호 재설정";
                        CommentText.Text = "신원이 학인되었습니다. 재설정이 가능합니다.";
                        idBox.Text = "";
                        pswdBox.Text = "";

                        //비번 재설정이 필요하므로 visible = true;
                        RePaswdText.Visible = RepswdBox.Visible = true;
                        IdentifyPass = true;
                        return;
                    }
                case true: //아이디 비밀번호 재설정
                    if(idBox.Text == "" || pswdBox.Text == "" || RepswdBox.Text == "") //하나라도 입력이 되지 않은 경우
                    {
                        MessageBox.Show("정보가 정확하게 입력이 되지 않았습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if(!pswdBox.Text.Equals(RepswdBox.Text)) //비밀번호가 일치하지 않을 경우
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return;
                    }
                    else
                    {
                        //DB에서 데이터 수정
                        sql.Open();
                        SQLiteCommand cmd = new SQLiteCommand(sql);
                        cmd.CommandText = string.Format("update member set ID = '{0}', Pswd = '{1}' where ID = '{2}' and Pswd = '{3}'",
                            idBox.Text, pswdBox.Text, newLogin.GetID(), newLogin.GetPswd());
                        cmd.ExecuteNonQuery();
                        cmd.Dispose(); sql.Close();

                        //Login 클래스에서 수정
                        newLogin.SetLogin(idBox.Text, pswdBox.Text);

                        //완료 메세지
                        MessageBox.Show("변경이 완료되었습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();

                        return;
                    }
            }
        }
        //아이디 비밀번호 일치 확인
        public bool AreYouAdmin()
        {
            return (newLogin.GetID().Equals(idBox.Text) && newLogin.GetPswd().Equals(pswdBox.Text));
        }
    }
}
