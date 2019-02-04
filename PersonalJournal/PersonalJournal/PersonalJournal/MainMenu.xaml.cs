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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Update_Password_Click(object sender, RoutedEventArgs e)
        {
            var settings = new Window1();
            settings.Show();
            this.Close();
        }

        private void New_Journal_Entry_Click(object sender, RoutedEventArgs e)
        {
            var newJournalEntry = new NEW_JOURNAL_ENTRY();
            newJournalEntry.Show();
            this.Close();
        }
        private void View_Journal_Click(object sender, RoutedEventArgs e)
        {
            var viewJournalEntry = new JOURNAL_ENTRY();
            viewJournalEntry.Show();
            this.Close();
        }
    }
}
