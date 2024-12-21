using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;
using System;

namespace LMS
{
    public partial class TransactionManagementPage : Page
    {
        private ObservableCollection<Book> AvailableBooks { get; set; }
        private ObservableCollection<Book> CheckedOutBooks { get; set; }
        private ObservableCollection<OverdueFee> OverdueFees { get; set; }

        public TransactionManagementPage()
        {
            InitializeComponent();
            AvailableBooks = new ObservableCollection<Book>();
            CheckedOutBooks = new ObservableCollection<Book>();
            OverdueFees = new ObservableCollection<OverdueFee>();

            AvailableBooksListBox.ItemsSource = AvailableBooks;
            CheckedOutBooksListBox.ItemsSource = CheckedOutBooks;
            OverdueFeesDataGrid.ItemsSource = OverdueFees;

            LoadAvailableBooks();  // Populate available books (this can be dynamic from your data)
        }

        // Load the available books (you can replace this with actual data from your database)
        private void LoadAvailableBooks()
        {
            AvailableBooks.Add(new Book { Title = "Book 1", Author = "Author 1", ISBN = "12345" });
            AvailableBooks.Add(new Book { Title = "Book 2", Author = "Author 2", ISBN = "67890" });
            // Add more books as needed
        }

        // Checkout Book
        private void CheckoutBook_Click(object sender, RoutedEventArgs e)
        {
            string patronName = PatronNameTextBox.Text;
            if (string.IsNullOrEmpty(patronName))
            {
                MessageBox.Show("Please enter a patron name.");
                return;
            }

            var selectedBook = AvailableBooksListBox.SelectedItem as Book;
            if (selectedBook != null)
            {
                // Mark as checked out and update availability
                CheckedOutBooks.Add(selectedBook);
                AvailableBooks.Remove(selectedBook);

                MessageBox.Show($"Book '{selectedBook.Title}' checked out successfully to {patronName}.");
            }
            else
            {
                MessageBox.Show("Please select a book to checkout.");
            }
        }

        // Return Book
        private void ReturnBook_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = CheckedOutBooksListBox.SelectedItem as Book;
            if (selectedBook != null)
            {
                // Calculate overdue fee (if applicable)
                var overdueFee = CalculateOverdueFee(selectedBook);
                if (overdueFee > 0)
                {
                    MessageBox.Show($"The book is overdue! The fee is ${overdueFee}.");
                }

                // Mark as returned and update availability
                AvailableBooks.Add(selectedBook);
                CheckedOutBooks.Remove(selectedBook);

                MessageBox.Show($"Book '{selectedBook.Title}' returned successfully.");
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }

        // Calculate overdue fee
        private double CalculateOverdueFee(Book book)
        {
            // Example logic for overdue fee calculation (you can customize this)
            DateTime dueDate = DueDatePicker.SelectedDate ?? DateTime.Now;
            if (DateTime.Now > dueDate)
            {
                int overdueDays = (DateTime.Now - dueDate).Days;
                return overdueDays * 0.50;  // Charge 50 cents per overdue day
            }
            return 0;
        }

        // View overdue fees
        private void ViewOverdueFees_Click(object sender, RoutedEventArgs e)
        {
            // Generate overdue fees report (dummy data for demonstration)
            OverdueFees.Add(new OverdueFee { PatronName = "John Doe", BookTitle = "Book 1", OverdueDays = 5, FeeAmount = 2.50 });
            OverdueFees.Add(new OverdueFee { PatronName = "Jane Smith", BookTitle = "Book 2", OverdueDays = 3, FeeAmount = 1.50 });
        }
    }

    public class OverdueFee
    {
        public string PatronName { get; set; }
        public string BookTitle { get; set; }
        public int OverdueDays { get; set; }
        public double FeeAmount { get; set; }
    }
}
