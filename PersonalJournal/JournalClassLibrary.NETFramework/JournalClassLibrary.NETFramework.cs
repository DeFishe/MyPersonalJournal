using System;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JournalClassLibrary.NETFramework
{
    public static class UserInfo
    {
        public static int userID = 0;
    }

    public class Login
    {
        public bool LoginProcess(string username, string password)
        {
            string usernameQuery = "SELECT USERID FROM USERS where USERNAME=@user and PASSWORD=@password";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
            SqlCommand sqlCommand = new SqlCommand(usernameQuery, connection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@user", username);
            sqlCommand.Parameters.AddWithValue("@password", password);
            connection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ReadRecord((IDataRecord)reader);
            }
            if (UserInfo.userID > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        private static void ReadRecord(IDataRecord record)
        {
            UserInfo.userID = Convert.ToInt32(record[0]);
        }
    }
    public class EditAccount
    {
        public EditAccount(string newPasswordInput)
        {
            string passwordUpdateQuery = $"UPDATE USERS SET PASSWORD = @password WHERE USERID = @userID";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
            SqlCommand sqlCommand = new SqlCommand(passwordUpdateQuery, connection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@password", newPasswordInput);
            sqlCommand.Parameters.AddWithValue("@userID", UserInfo.userID);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
    //public class JournalList
    //{
    //    public string GetTitlePreview()
    //    {
    //        string titlePreviewQuery = $"SELECT * FROM JOURNALS WHERE USERID = {UserInfo.userID}";
    //        SqlConnection connection = new SqlConnection();
    //        connection.ConnectionString = @"Data Source = (local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
    //        SqlCommand sqlCommand = new SqlCommand(titlePreviewQuery, connection);
    //        sqlCommand.Parameters.Clear();
    //        sqlCommand.Parameters.AddWithValue("@userID", UserInfo.userID);
    //        connection.Open();
    //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    //        while (sqlDataReader.Read())
    //        {
    //            return Convert.ToString(sqlDataReader["JOURNALTITLE"]);
    //        }
    //        connection.Close();
    //        return null;
    //    }
    //}
    public class ViewJournal
    {
        public int entryID { get; set; }
        public string journalTitle { get; set; }
        public string entry { get; set; }
        public List<ViewJournal> GetJournal()
        {

            List<ViewJournal> list = new List<ViewJournal>();

            string viewJournalQuery = $"SELECT ENTRYID, JOURNALTITLE, JOURNALENRTY FROM JOURNALS WHERE USERID = '{UserInfo.userID}';";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
            SqlCommand command = new SqlCommand(viewJournalQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ViewJournal { entryID = reader.GetInt32(0), journalTitle = reader.GetString(1), entry = reader.GetString(2) });
            }
            connection.Close();
            return list;
        }
    }
    public class SaveJournal
    {
        private string title = " ";
        private string body = " ";

        public SaveJournal(string inputTitle, string inputBody)
        {
            title = inputTitle;
            body = inputBody;
        }
        public void UploadJournal()
        {
            string journalEntryQuery = @"INSERT INTO JOURNALS (USERID, JOURNALTITLE, JOURNALENRTY) VALUES (@userID, @title, @body)";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
            SqlCommand command = new SqlCommand(journalEntryQuery, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@body", body);
            command.Parameters.AddWithValue("@userID", UserInfo.userID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
