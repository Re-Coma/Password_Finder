using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace PasswordFinder
{
    //이름, 아이디, 패스워드가 하나로 묶여있는 클래스
    public class PswdData
    {
        private string Name; //사이트/프로그램 이름
        private string ID;  //아이디
        private string Pswd;    //패스워드

        //세팅
        public PswdData(string Name, string ID, string Pswd)
        {
            this.Name = Name; this.ID = ID;
            this.Pswd = Pswd;
        }
        //정보 수정
        public void SetData(string Name, string ID, string Pswd)
        {
            this.Name = Name; this.ID = ID;
            this.Pswd = Pswd;
        }
        //클래스로 새 정보 수정
        public void SetData(PswdData newData)
        {
            Name = newData.GetName();
            ID = newData.GetID();
            Pswd = newData.GetPswd();
        }
        //정보 추출
        public PswdData GetPswdData() => this;
        public string GetName() => Name;
        public string GetID() => ID;
        public string GetPswd() => Pswd;

        //내용이 같은지 판단 여부
        public bool IsSame(PswdData cmpData)
        {
            return (cmpData.GetName().Equals(Name) && cmpData.GetID().Equals(ID) &&
                cmpData.GetPswd().Equals(Pswd));
        }
    }
    public class DataManager //데이터리스트를 관리하는 클래스
    {
        public List<PswdData> DataList = new List<PswdData>(); //PswdData가 한곳으로 묶여있는 리스트 클래스
        private SQLiteConnection sql = null;

        //초기세팅
        public DataManager(SQLiteConnection conn)
        {
            //DB커넥션 복사 및 열기
            sql = conn;
            sql.Open();

            DataSet InfoSet = new DataSet();

            //커맨드 클래스 생성 및 DB 연결
            SQLiteCommand cmd = new SQLiteCommand("select * from Info", sql);
            SQLiteDataReader Reader = cmd.ExecuteReader();
            while(Reader.Read())
            {
                DataList.Add(new PswdData(Reader["Name"] as string,
                                            Reader["ID"] as string,
                                            Reader["PSWD"] as string));
            }

            Reader.Close(); Reader.Dispose();
            cmd.Dispose(); sql.Close();

        }

        //데이터리스트 추출
        public List<PswdData> GetDataList() => DataList;
        //데이터리스트 동기화
        public void SetDataList(List<PswdData> newDataList) => DataList = newDataList;

        //데이터리스트 추가
        public void AddData(PswdData newData) => DataList.Add(newData);

        //데이터리스트 수정
        public void ModifyData(PswdData LastData, PswdData NewData)
        {
            int index = 0;
            foreach(PswdData SelectedData in DataList)
            {
                if(SelectedData.IsSame(LastData))
                {
                    DataList[index].SetData(NewData);
                    break;
                }
                index++;
            }
        }

        //데이터리스트 제거
        public void DeleteData(PswdData DeleteData)
        {
            int index = 0;
            foreach(PswdData SelectedData in DataList)
            {
                if(SelectedData.IsSame(DeleteData))
                {
                    DataList.RemoveAt(index);
                    break;
                }
                index++;
            }
        }
        
    }
    
}
