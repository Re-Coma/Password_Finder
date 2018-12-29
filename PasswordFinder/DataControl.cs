using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PasswordFinder
{
    //DB삽입, 삭제 수정을 하는 메서드 모임
    public class DataControl
    {
        SQLiteConnection sql = null;
        public DataControl(SQLiteConnection conn)
        {
            sql = conn;
        }

        // DB에 정보 입력
        public void InputData(string Site, string ID, string Pswd)
        {
            sql.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.CommandText = string.Format("insert into Info (Name, ID, Pswd) values ('{0}', '{1}', '{2}')",
                Site, ID, Pswd);
            cmd.ExecuteNonQuery();

            cmd.Dispose(); sql.Close();
        }

        //PswdData 로부터 DB에 정보 입력
        public void InputData(PswdData InputData)
        {
            sql.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.CommandText = string.Format("insert into Info (Name, ID, Pswd) values ('{0}', '{1}', '{2}')",
                InputData.GetName(), InputData.GetID(), InputData.GetPswd());
            cmd.ExecuteNonQuery();

            cmd.Dispose(); sql.Close();
        }

        //DB에서 정보 삭제
        public void DeleteData(string Site, string ID, string Pswd)
        {
            sql.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.CommandText = string.Format("delete from Info where Name = '{0}' and ID = '{1}' and Pswd = '{2}'",
                Site, ID, Pswd);
            cmd.ExecuteNonQuery();
            cmd.Dispose(); sql.Close();
        }

        //PswdData 로부터 DB에 정보 삭제
        public void DeleteData(PswdData InputData)
        {
            sql.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.CommandText = string.Format("delete from Info where Name = '{0}' and ID = '{1}' and Pswd = '{2}'",
                InputData.GetName(), InputData.GetID(), InputData.GetPswd());
            cmd.ExecuteNonQuery();

            cmd.Dispose(); sql.Close();
        }

        //DB 정보 수정
        public void ModifyData(string LastSite, string LastID, string LastPswd, 
            string NewSite, string NewID, string NewPswd)
        {
            sql.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.CommandText = string.Format("update Info set Name = '{0}', ID = '{1}', Pswd = '{2}' where Name = '{3}', ID = '{4}', Pswd = '{5}'",
                NewSite, NewID, NewPswd, LastSite, LastID, LastPswd);
            cmd.ExecuteNonQuery();

            cmd.Dispose(); sql.Close();

        }
        //클래스를 이용한 정보수정
        public void ModifyData(PswdData LastData, PswdData newData)
        {
            sql.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.CommandText = string.Format("update Info set Name = '{0}', ID = '{1}', Pswd = '{2}' where Name = '{3}' and ID = '{4}' and Pswd = '{5}'",
                newData.GetName(), newData.GetID(), newData.GetPswd(), LastData.GetName(), LastData.GetID(), LastData.GetPswd());
            cmd.ExecuteNonQuery();
            cmd.Dispose(); sql.Close();
        }
       
    }
}
