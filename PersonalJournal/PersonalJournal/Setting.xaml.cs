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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void SubmitClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string newPassword = newPasswordBox.Text;
                EditAccount editAccount = new EditAccount(newPassword);
                var mainMenu = new MainMenu();
                MessageBox.Show("Password updated successfully.");
                mainMenu.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.");
                var mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
        }
    }
}
