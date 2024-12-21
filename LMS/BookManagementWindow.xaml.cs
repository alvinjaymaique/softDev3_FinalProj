using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LMS
{
    public partial class BookManagementWindow : Page
    {
        public ObservableCollection<Book> Books { get; set; }

        public BookManagementWindow()
        {
            InitializeComponent();
            Books = new ObservableCollection<Book>();
            BookDataGrid.ItemsSource = Books;
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            var addBookDialog = new AddBookWindow();
            if (addBookDialog.ShowDialog() == true)
            {
                Books.Add(addBookDialog.NewBook);
            }
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            if (BookDataGrid.SelectedItem is Book selectedBook)
            {
                var editBookDialog = new EditBookWindow(selectedBook);
                if (editBookDialog.ShowDialog() == true)
                {
                    BookDataGrid.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit.", "Edit Book", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            if (BookDataGrid.SelectedItem is Book selectedBook)
            {
                if (MessageBox.Show($"Are you sure you want to delete \"{selectedBook.Title}\"?", "Delete Book", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Books.Remove(selectedBook);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Delete Book", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SearchBook_Click(object sender, RoutedEventArgs e)
        {
            string query = SearchTextBox.Text.ToLower();
            var filteredBooks = Books.Where(book =>
                book.Title.ToLower().Contains(query) ||
                book.Author.ToLower().Contains(query) ||
                book.ISBN.ToLower().Contains(query)).ToList();

            BookDataGrid.ItemsSource = filteredBooks;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public int YearPublished { get; set; }
        public int NumberOfCopies { get; set; }
    }
}
