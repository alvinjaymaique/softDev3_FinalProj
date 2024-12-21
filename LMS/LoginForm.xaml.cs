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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LMS
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Page
    {
        // Admin account: user=admin; password=admin
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Example login validation (replace with your actual authentication logic)
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (IsValidLogin(username, password))
            {
                // Proceed to next screen or main application page
                MessageBox.Show("Login successful!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Window.GetWindow(this)?.Close();
            }
            else
            {
                // Display error message
                ErrorMessageTextBlock.Text = "Invalid username or password.";
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            var account = AccountManager.Accounts.FirstOrDefault(acc => acc.Username == username && acc.Password == password);
            return account != null;
            //return username == "admin" && password == "password";
        }

        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UsernamePlaceholder.Visibility = Visibility.Collapsed;
        }

        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                UsernamePlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPlaceholder.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        // Handle hyperlink click to navigate to RegisterForm
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // This will navigate to the RegisterForm.xaml page
            NavigationService.Navigate(new Uri("RegisterForm.xaml", UriKind.Relative));
            e.Handled = true;
        }
    }

   
}
