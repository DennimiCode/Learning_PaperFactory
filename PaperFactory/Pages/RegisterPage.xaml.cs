using System.Windows.Controls;
using System.Windows;
using PaperFactory.Data;

namespace PaperFactory.Pages
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        ApplicationDataContext AppDbContext = new ApplicationDataContext();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void RegisterButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (UserPasswordPasswordBox.Password != RepeatUserPasswordPasswordBox.Password || 
                (UserPasswordPasswordBox.Password == string.Empty && RepeatUserPasswordPasswordBox.Password == string.Empty))
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                
            }

            if (LastnameTextBox.Text == string.Empty || FirstnameTextBox.Text == string.Empty 
                || MiddlenameTextBox.Text == string.Empty || LoginTextBox.Text == string.Empty 
                || UserPasswordPasswordBox.Password == string.Empty || RepeatUserPasswordPasswordBox.Password == string.Empty)
            {
                MessageBox.Show("Все поля обязательны для заполнения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
