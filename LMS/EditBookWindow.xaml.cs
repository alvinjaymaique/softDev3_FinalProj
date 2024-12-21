using LMS;
using System.Windows;

namespace LMS
{
    public partial class EditBookWindow : Window
    {
        private Book _bookToEdit;

        public EditBookWindow(Book bookToEdit)
        {
            InitializeComponent();

            _bookToEdit = bookToEdit;

            // Populate fields with existing book details
            TitleTextBox.Text = _bookToEdit.Title;
            AuthorTextBox.Text = _bookToEdit.Author;
            ISBNTextBox.Text = _bookToEdit.ISBN;
            GenreTextBox.Text = _bookToEdit.Genre;
            PublisherTextBox.Text = _bookToEdit.Publisher;
            YearPublishedTextBox.Text = _bookToEdit.YearPublished.ToString();
            NumberOfCopiesTextBox.Text = _bookToEdit.NumberOfCopies.ToString();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
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

            // Update book details
            _bookToEdit.Title = TitleTextBox.Text;
            _bookToEdit.Author = AuthorTextBox.Text;
            _bookToEdit.ISBN = ISBNTextBox.Text;
            _bookToEdit.Genre = GenreTextBox.Text;
            _bookToEdit.Publisher = PublisherTextBox.Text;
            _bookToEdit.YearPublished = yearPublished;
            _bookToEdit.NumberOfCopies = numberOfCopies;

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
