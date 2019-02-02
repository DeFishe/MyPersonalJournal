using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using JournalClassLibrary.NETFramework;

namespace PersonalJournal
{
    /// <summary>
    /// Interaction logic for NEW_JOURNAL_ENTRY.xaml
    /// </summary>
    public partial class NEW_JOURNAL_ENTRY : Window
    {
        public NEW_JOURNAL_ENTRY()
        {
            InitializeComponent();
        }
        private void Save_Entry(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            //try
            //{
            string journalEntry = BodyBox.Text;
                string journalTitle = TitleBox.Text;
                SaveJournal saveJournal = new SaveJournal(journalTitle, journalEntry);
                saveJournal.UploadJournal();
                mainMenu.Show();
                MessageBox.Show("Journal sucessfully saved.");
                this.Close();
                
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Something went wrong.");
            //    mainMenu.Show();
            //    this.Close();
            //}
        }
    }
}
