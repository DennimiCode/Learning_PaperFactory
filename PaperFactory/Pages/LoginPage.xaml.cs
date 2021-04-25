using System.Windows;
using System.Windows.Controls;

namespace PaperFactory.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
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

        }
    }
}
