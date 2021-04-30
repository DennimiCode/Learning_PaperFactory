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
            bool ErrorFlag = false;
            if (UserPasswordPasswordBox.Password != RepeatUserPasswordPasswordBox.Password || 
                (UserPasswordPasswordBox.Password == string.Empty && RepeatUserPasswordPasswordBox.Password == string.Empty))
            {
                ErrorFlag = true;
                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (LastnameTextBox.Text == string.Empty || FirstnameTextBox.Text == string.Empty 
                || MiddlenameTextBox.Text == string.Empty || LoginTextBox.Text == string.Empty 
                || UserPasswordPasswordBox.Password == string.Empty || RepeatUserPasswordPasswordBox.Password == string.Empty)
            {
                ErrorFlag = true;
                MessageBox.Show("Все поля обязательны для заполнения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!ErrorFlag)
            {
                bool SuccessFlag = false;
                try
                {
                    UsersInfo UserInfo = new UsersInfo()
                    {
                        Lastname = LastnameTextBox.Text.Trim(),
                        Firstname = FirstnameTextBox.Text.Trim(),
                        Middlename = MiddlenameTextBox.Text.Trim()
                    };

                    AppDbContext.Add(UserInfo);
                    AppDbContext.SaveChanges();

                    Users User = new Users()
                    {
                        InfoId = UserInfo.Id,
                        Login = LoginTextBox.Text.Trim(),
                        Password = UserPasswordPasswordBox.Password
                    };

                    AppDbContext.Add(User);
                    AppDbContext.SaveChanges();
                    SuccessFlag = true;
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Регистрация не удалась!\nПовторите попытку регистрации.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (SuccessFlag)
                {
                    MessageBox.Show("Вы успешно зарегистрированы!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
