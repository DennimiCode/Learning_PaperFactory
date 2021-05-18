using System;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using PaperFactory.Data;
using System.Windows.Input;

namespace PaperFactory.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        ApplicationDataContext AppDbContext = new ApplicationDataContext();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.RegisterPage());
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string EnteredLogin = UserLoginTextBox.Text.Trim();
                string EnteredPassword = UserPasswordPasswordBox.Password;

                string DbLogin = AppDbContext.Users.Where(n => n.Login == EnteredLogin && n.Password == EnteredPassword).First().Login;
                string DbPassword = AppDbContext.Users.Where(n => n.Login == EnteredLogin && n.Password == EnteredPassword).First().Password;

                if (EnteredLogin == DbLogin && EnteredPassword == DbPassword)
                {
                    Manager.MainFrame.Navigate(new Pages.MaterialsPage());
                }
            }
            catch
            {
                MessageBox.Show("Не верный логин или пароль!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}