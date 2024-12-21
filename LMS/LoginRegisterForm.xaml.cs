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

namespace LMS
{
    /// <summary>
    /// Interaction logic for LoginRegisterForm.xaml
    /// </summary>
    public partial class LoginRegisterForm : Window
    {
        // Admin account: user=admin; password=admin
        public LoginRegisterForm()
        {
            InitializeComponent();
            LoginFrame.Navigate(new LoginForm());
        }

    }
    
}
