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
    public partial class ModifyForm : Form
    {
        private SQLiteConnection sql = null; //DB 커넥션
        private PswdData LastData = null; //이전 데이터
        private PswdData newData = null; //새로 갱신될 데이터
        private ListViewItem newItem = null; //새로 갱신될 뷰아이템

        public bool isModified() => (newData != null); //새로 갱신에 성공했는지 판별
        public PswdData GetNewData() => newData; //갱신된 데이터 추출
        public ListViewItem GetNewItem() => newItem; //갱신된 아이템 추출
        

        public ModifyForm(SQLiteConnection conn, PswdData LastData)
        {
            //sql, 이전데이터 세팅
            sql = conn;
            this.LastData = LastData;

            InitializeComponent();

            //사이트 아이디 비밀번호 텍스트 박스에 이전 데이터 삽입
            SiteBox.Text = this.LastData.GetName();
            idBox.Text = this.LastData.GetID();
            PswdBox.Text = this.LastData.GetPswd();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            
            if (SiteBox.Text == "" || idBox.Text == "" || PswdBox.Text == "")
            {
                MessageBox.Show("해당 칸에 입력을 하지 않으셨습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //똑같을 경우(차이가 없는 경우)
            
            else if (LastData.IsSame(new PswdData(SiteBox.Text, idBox.Text, PswdBox.Text)))
            {
                Close(); //그냥 나가기
            }
            else //전부다 입력이 되어있고 한 글자라도 변경이 된 경우
            {
                //PswdData 생성
                newData = new PswdData(SiteBox.Text, idBox.Text, PswdBox.Text);

                //DB에 업데이트
                new DataControl(sql).ModifyData(LastData, newData);

                //리스트뷰 아이템 생성
                newItem = new ListViewItem(newData.GetName());
                newItem.SubItems.Add(newData.GetID());
                newItem.SubItems.Add(newData.GetPswd());

                //끝
                Close();
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
