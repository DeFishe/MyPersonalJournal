using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalClassLibrary.NETFramework
{
    public class Login
    {
        //private string username = "";
        //private string password = "";

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

            if(sqlCommand.ExecuteScalar().ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    //public class EditAccount
    //{
    //    string password = "";

    //    public void PasswordUpdate(string password)
    //    {
    //        //TODO
    //    }
    //}
    //public class ViewJournal
    //{
    //    int userID;
    //    int entryID;
    //    string title;
    //    string body;
    //    DateTime date;

    //    public string GetTitlePreview(int userID)
    //    {
    //        //TODO
    //    }
    //    public string GetBody(int entryID)
    //    {
    //        //TODO
    //    }
    //    public DateTime GetDate(int entryID)
    //    {
    //        //TODO
    //    }
    //    public string GetTitle(int entryID)
    //    {
    //        //TODO
    //    }
    //}
    //public class SaveJournal
    //{
    //    string title;
    //    string body;
    //    public void UploadJournal(string title, string body)
    //    {
    //        //TODO send jounral to database
    //    }
    //}
}
