using System.Windows;

namespace LMS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Navigate to Book Management page on startup
            BookManagementFrame.Navigate(new BookManagementWindow());
            PatronManagementFrame.Navigate(new PatronManagementWindow());
            TransactionManagementFrame.Navigate(new TransactionManagementPage());
            ReportAndAnalyticsFrame.Navigate(new ReportAndAnalyticsPage());
        }
    }
}
