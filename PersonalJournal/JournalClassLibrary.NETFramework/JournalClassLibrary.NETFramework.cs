using System;
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
        public static string userName = " ";
    }

    public class Login
    {
        public bool LoginProcess(string username, string password)
        {
            string usernameQuery = "select count (*) as cnt from USERS where USERNAME=@user and PASSWORD=@password";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
            SqlCommand sqlCommand = new SqlCommand(usernameQuery, connection);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@user", username);
            sqlCommand.Parameters.AddWithValue("@password", password);
            connection.Open();

            if (sqlCommand.ExecuteScalar().ToString() == "1")
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
    }
    public class EditAccount
    {
        private string newPassword = "";

        public void PasswordUpdate(string newPassword)
        {
            string passwordUpdateQuery = $"UPDATE USERS SET PASSWORD = '{newPassword}' WHERE USERID = {UserInfo.userID}";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
            SqlCommand sqlCommand = new SqlCommand(passwordUpdateQuery, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
    public class JournalList
    {
        public void GetTitlePreview(int userID, IEnumerable listbox)
        {
            string titlePreviewQuery = $"SELECT * FROM JOURNALS WHERE USERID = {UserInfo.userID}";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = (local)\SQLEXPRESS; Initial Catalog =JOURNAL APP; Integrated Security=SSPI";
            SqlCommand sqlCommand = new SqlCommand(titlePreviewQuery, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            connection.Open();
            while (sqlDataReader.Read())
            {
                listbox.Items.Add(sqlDataReader["JOURNALTITLE"]);
            }
        }
    }
    public class ViewJournal
    {
        int entryIDGlobal;
        public ViewJournal(int entryID)
        {
            entryIDGlobal = entryID;
        }

        public string GetJournalBody(int entryID)
        {
            string journalBody = " ";
            string getJournalBodyQuery = $"SELECT JOURNAL JOURNALENTRY FROM JOURNALS WHERE ENTRYID = {entryIDGlobal}";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = (local)\SQLEXPRESS; Initial Catalog =JOURNALAPP; Integrated Security=SSPI";
            SqlCommand command = new SqlCommand(getJournalBodyQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            journalBody = reader.ToString();
            connection.Close();
            return journalBody;
        }
    }
    public class SaveJournal
    {
        string title = " ";
        string body = " ";

        public SaveJournal(string inputTitle, string inputBody)
        {
            title = inputTitle;
            body = inputBody;
        }
        public void UploadJournal(string title, string body)
        {
            string jounrnalEntryQuery = @"INSERT INTO JOURNAL (
        }
    }
}
