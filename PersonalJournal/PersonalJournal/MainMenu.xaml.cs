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

        private void Update_Password_Button(object sender, RoutedEventArgs e)
        {

        }

        

        private void viewclick(object sender, RoutedEventArgs e)
        {
            var viewclick = new JOURNAL_ENTRY();
            viewclick.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void newclick(object sender, RoutedEventArgs e)
        {
            var newclick = new NEW_JOURNAL_ENTRY ();
            newclick.Show();
            this.Close();
        }

        private void passwordclick(object sender, RoutedEventArgs e)
        {
            var passwordclick = new Window1();
            passwordclick.Show();
            this.Close();
        }
    }
}
