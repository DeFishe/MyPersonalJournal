﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using JournalClassLibrary.NETFramework;

namespace PersonalJournal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PassBox.Text;
            Login login = new Login();
            bool validLogin =login.LoginProcess(username, password);
            if (validLogin == true)
            {
                var mainMenu = new MainMenu();
                mainMenu.Show();
                MessageBox.Show($"Welcome User {UserInfo.userID}");
                this.Close();
            }
            else
            {
                MessageBox.Show("You presented a false password.");
            }
        }
    }
}
