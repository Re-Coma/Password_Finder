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
    public partial class MainForm : Form
    {
        //해당 유저의 아이디와 패스워드
        Login userInfo = null;
        //DB커넥션
        SQLiteConnection conn = new SQLiteConnection("Data Source = List.db; Version=3;");
        DataManager dataManager = null; //데이터 관리를 위한 자작 클래스 DataManager 선언

        public MainForm(Login userInfo)
        {
            this.userInfo = userInfo;
            dataManager = new DataManager(conn);
            //DB에서 데이터 가져오기

            InitializeComponent();

            //트리뷰에 나열
            foreach (PswdData pwd in dataManager.GetDataList())
            {

                ListViewItem newItem = new ListViewItem(pwd.GetName());
                newItem.SubItems.Add(pwd.GetID());
                newItem.SubItems.Add(pwd.GetPswd());

                DataView.Items.Add(newItem);
            }
            //끝
        }

        //데이터 추가
        private void InputDataStrip_Click(object sender, EventArgs e)
        {
            InputForm iForm = new InputForm(conn);
            iForm.ShowDialog();

            /*
             * 리스트 아이템이 null이 아닌 경우에(새로 정보를 입력한 경우에)
             * 데이터리스트에 추가를 하고
             * 리스트 뷰에 새로 갱신한 정보를 추가한다.
             */
            if (iForm.IsInputNewData())
            {
                //새로운 리스트 뷰 생성
                ListViewItem newItem = iForm.GetNewItem();
                //새로운 데이터 생성
                PswdData newData = new PswdData(newItem.Name, newItem.SubItems[0].Name, newItem.SubItems[1].Name);
                //데이터리스트에 추가
                dataManager.AddData(newData);
                //리스트 뷰 추가
                DataView.Items.Add(newItem);
            }

            iForm.Dispose();
            return;
        }
        //데이터 수정
        private void ModifyDataStrip_Click(object sender, EventArgs e)
        {

            PswdData LastData = null;
            //선택된 데이터 설정
            try
            {
                LastData = new PswdData(DataView.SelectedItems[0].SubItems[0].Text,
                    DataView.SelectedItems[0].SubItems[1].Text,
                    DataView.SelectedItems[0].SubItems[2].Text);
            }
            catch(ArgumentOutOfRangeException) //선택하지 않았을 경우
            {
                MessageBox.Show("해당 데이터가 선택되지 않았습니다.", "ERROr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //수정 폼 접근
            ModifyForm mForm = new ModifyForm(conn, LastData);
            mForm.ShowDialog();

            PswdData newData = mForm.GetNewData();
            ListViewItem newItem = mForm.GetNewItem();

            //취소가 아닌 변경을 눌렀을 경우
            if(mForm.isModified())
            {
                //데이터 변경
                dataManager.ModifyData(LastData, newData);
                //리스트 수정
                int index = DataView.SelectedItems[0].Index;

                //1.해당 리스트 삭제
                DataView.Items.RemoveAt(index);
                //2.갱신
                DataView.Items.Add(newItem);
            }
            mForm.Dispose();

            return;
        }

        //제거
        private void DeleteDataStrip_Click(object sender, EventArgs e)
        {
            PswdData DeleteData = null;
            //선택된 데이터 설정
            try
            {
                DeleteData = new PswdData(DataView.SelectedItems[0].SubItems[0].Text,
                    DataView.SelectedItems[0].SubItems[1].Text,
                    DataView.SelectedItems[0].SubItems[2].Text);
            }
            catch (ArgumentOutOfRangeException) //선택되지 않은 경우
            {
                MessageBox.Show("해당 데이터가 선택되지 않았습니다.", "ERROr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //정말로 삭제하시겠습니까?
            DialogResult AreYouDelete = MessageBox.Show("정말로 삭제하시겠습니까?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(AreYouDelete.Equals(DialogResult.No)) //아니오
            {
                return; //취소
            }
            else
            {
                //DB에서 삭제
                new DataControl(conn).DeleteData(DeleteData);
                //데이터리스트에서 삭제
                dataManager.DeleteData(DeleteData);
                //뷰에서도 삭제
                DataView.SelectedItems[0].Remove();
                
            }
        }

        //아이디 비밀번호 수정
        private void ModifyInfo_Click(object sender, EventArgs e)
        {
            //창 열기
            ModifyInfoForm mIForm = new ModifyInfoForm(conn, ref userInfo);
            mIForm.ShowDialog();

            //끝
            mIForm.Dispose();
            return;
        }

        //About
        private void AboutStrip_Click(object sender, EventArgs e)
        {
            AboutForm aForm = new AboutForm();
            aForm.ShowDialog();
        }
    }
}
