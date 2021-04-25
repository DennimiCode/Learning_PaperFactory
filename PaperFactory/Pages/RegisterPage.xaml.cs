using System.Windows.Controls;

namespace PaperFactory.Pages
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
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
            
        }
    }
}
