using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PasswordFinder
{
    //초기 세팅 클래스
    public class Login
    {
        //초기 비밀번호
        public readonly string FirstID = "1234"; //초기 아이디
        public readonly string FirstPswd = "1234"; //초기 패스워드
        private string ID = ""; //현재 아이디
        private string Pswd = ""; //현재 패스워드

        

        //Login 클래스 생성과 동시에 아이디와 패스워드 설정
        public Login()
        {
            SQLiteConnection sql = null; //DB 연결 클래스
            SQLiteCommand cmd = null; //DB 명령문 클래스
            SQLiteDataReader Reader = null; //DB 데이터 추출 클래스

            //파일이 존재하지 않을 경우(초기 또는 데이터베이스 파일 분실)
            if(!File.Exists("List.db"))
            {

                //DB파일 생성
                SQLiteConnection.CreateFile("List.db");
                //DB연결
                sql = new SQLiteConnection("Data Source = List.db; Version=3;");
                sql.Open();

                //명령문을 실행하기 위해서
                //명령문 클래스에 DB 연결 클래스를 연결한다.
                cmd = new SQLiteCommand();
                cmd.Connection = sql;

                /*
                 * sqlList.sql를 이용해서 테이블 생성과 동시에
                 * 초기비밀번호 입력
                */
                cmd.CommandText = ".read sqlList.sql";
                cmd.ExecuteNonQuery();

                //아이디와 패스워드를 초기 아이디/패스워드로 설정
                ID = FirstID; Pswd = FirstPswd;

                //끝
                cmd.Dispose(); sql.Close(); sql.Dispose();
            }
            else //존재하는 경우
            {
                //DB파일 생성
                sql = new SQLiteConnection("Data Source = List.db; Version=3;");
                sql.Open();

                //DB명령문 클래스 연결
                cmd = new SQLiteCommand();
                cmd.Connection = sql;

                //DB로부터 아이디와 패스워드 입력받기
                cmd.CommandText = "select * from member";
                Reader = cmd.ExecuteReader();

                //데이터가 존재하는 경우
                if(Reader.Read())
                {
                    ID = Reader["ID"] as string;
                    Pswd = Reader["PSWD"] as string;
                }
                else //데이터가 존재하지 않는 경우(비상시)
                {
                    //데이터를 삭제할건지 묻는다.
                    DialogResult Delete = MessageBox.Show("데이터베이스가 손상되었습니다 \n 예를 누르면 데이터가 초기화되고 아니오를 누르면 초기아이디와 비밀번호로 복구됩니다.",
                        "DATA ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    
                }
                

            }
        }


        
    }
}