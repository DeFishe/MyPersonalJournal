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
    /// Interaction logic for JOURNAL_ENTRY.xaml
    /// </summary>
    public partial class JOURNAL_ENTRY : Window
    {
        ViewJournal viewJournal = new ViewJournal();
        public JOURNAL_ENTRY()
        {
            InitializeComponent();
            JournalEntries.ItemsSource = viewJournal.GetJournal();
        }

        private void JournalEntries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewJournal = (ViewJournal)JournalEntries.SelectedItem;
            JournalTitleText.Text = viewJournal.journalTitle;
            JournalEntryText.Text = viewJournal.entry;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();

        }
    }
}
