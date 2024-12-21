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
    /// Interaction logic for RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Page
    {
        public RegisterForm()
        {
            InitializeComponent();
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

        private void RetypePasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RetypePasswordBox.Password.Length == 0) // Only hide placeholder if the text box is empty
            {
                RetypePasswordPlaceholder.Visibility = Visibility.Collapsed;
            }
        }

        // Handle LostFocus for Retype Password
        private void RetypePasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (RetypePasswordBox.Password.Length == 0)
            {
                RetypePasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        // Handle GotFocus for Email TextBox
        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextBox.Text)) // Only hide placeholder if the text box is empty
            {
                EmailPlaceholder.Visibility = Visibility.Collapsed;
            }
        }

        // Handle LostFocus for Email TextBox
        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                EmailPlaceholder.Visibility = Visibility.Visible;
            }
        }

        // Handle Register Button Click
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string retypePassword = RetypePasswordBox.Password;
            string email = EmailTextBox.Text;
            string role = (RoleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Validate the inputs (basic validation example)
            if (password != retypePassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Proceed with registration logic (saving user info, etc.)
            MessageBox.Show("Registration Successful!");
            AccountManager.AddAccount(username, password, email, role);
            NavigationService.Navigate(new Uri("LoginForm.xaml", UriKind.Relative));
        }

        // Simple email validation (basic example)
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Handle navigation to Login Form
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            NavigationService.Navigate(new Uri("LoginForm.xaml", UriKind.Relative));
            e.Handled = true;
        }
    }
}
