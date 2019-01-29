using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalClassLibrary.NETFramework
{
    public class Login
    {
        string username = "";
        string password = "";

        public bool Login(string username, string password)
        {
            //TODO
        }
    }
    public class EditAccount
    {
        string password = "";

        public void PasswordUpdate(string password)
        {
            //TODO
        }
    }
    public class ViewJournal
    {
        int userID;
        int entryID;
        string title;
        string body;
        DateTime date;

        public string GetTitlePreview(int userID)
        {
            //TODO
        }
        public string GetBody(int entryID)
        {
            //TODO
        }
        public DateTime GetDate(int entryID)
        {
            //TODO
        }
        public string GetTitle(int entryID)
        {
            //TODO
        }
    }
    public class SaveJournal
    {
        string title;
        string body;
        public void UploadJournal(string title, string body)
        {
            //TODO send jounral to database
        }
    }
}
