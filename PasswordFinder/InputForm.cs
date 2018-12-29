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
    public partial class InputForm : Form
    {
        private SQLiteConnection sql = null;    //DB커넥터
        private ListViewItem newItem = null;    //새 트리 아이템 <- 새로운 정보 입력
        private DataControl dataControl = null;  //DB 입력을 하는 메서드가 있는 클래스


        public InputForm(SQLiteConnection sql)
        {
            this.sql = sql;
            dataControl = new DataControl(this.sql);
            InitializeComponent();
        }
        //새로운 데이터가 추가됬는지 확인
        public bool IsInputNewData() => (newItem != null);

        //리스트뷰 아이템 추출
        public ListViewItem GetNewItem() => newItem;


        //입력버튼
        private void InputBtn_Click(object sender, EventArgs e)
        {
            //비어있는 칸이 없이 정확하게 입력했을 경우
            if((SiteBox.Text != "") && (idBox.Text != "") && (PswdBox.Text != ""))
            {
                //DB 수정
                dataControl.InputData(SiteBox.Text, idBox.Text, PswdBox.Text);

                //리스트 아이템 생성
                newItem = new ListViewItem(SiteBox.Text);
                newItem.SubItems.Add(idBox.Text);
                newItem.SubItems.Add(PswdBox.Text);

                Close();
            }
            else //아닐 경우
            {
                //다시 입력
                MessageBox.Show("데이터 입력이 잘못되었습니다. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        //취소버튼
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
