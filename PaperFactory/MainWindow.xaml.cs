using System.Windows;

namespace PaperFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new Pages.LoginPage());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Manager.AddMaterialWindow != null)
            {
                Manager.AddMaterialWindow.Close();
            }
        }
    }
}
