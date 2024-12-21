using LMS;
using System.Windows;

namespace LMS
{
    public partial class AddBookWindow : Window
    {
        public Book NewBook { get; private set; }

        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text) ||
                string.IsNullOrWhiteSpace(AuthorTextBox.Text) ||
                string.IsNullOrWhiteSpace(ISBNTextBox.Text) ||
                string.IsNullOrWhiteSpace(GenreTextBox.Text) ||
                string.IsNullOrWhiteSpace(PublisherTextBox.Text) ||
                !int.TryParse(YearPublishedTextBox.Text, out int yearPublished) ||
                !int.TryParse(NumberOfCopiesTextBox.Text, out int numberOfCopies))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Create a new book
            NewBook = new Book
            {
                Title = TitleTextBox.Text,
                Author = AuthorTextBox.Text,
                ISBN = ISBNTextBox.Text,
                Genre = GenreTextBox.Text,
                Publisher = PublisherTextBox.Text,
                YearPublished = yearPublished,
                NumberOfCopies = numberOfCopies
            };

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
