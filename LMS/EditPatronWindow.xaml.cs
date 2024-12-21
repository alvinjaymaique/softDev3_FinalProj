using LMS;
using System.Windows;
using System.Windows.Controls;
using System.Linq;


namespace LMS
{
    public partial class EditPatronWindow : Window
    {
        private Patron _patronToEdit;

        public EditPatronWindow(Patron patron)
        {
            InitializeComponent();
            _patronToEdit = patron;

            // Pre-populate the form with the patron's current details
            FullNameTextBox.Text = _patronToEdit.FullName;
            MembershipIDTextBox.Text = _patronToEdit.MembershipID;
            EmailTextBox.Text = _patronToEdit.Email;
            PhoneNumberTextBox.Text = _patronToEdit.PhoneNumber;
            AddressTextBox.Text = _patronToEdit.Address;
            DateOfBirthTextBox.Text = _patronToEdit.DateOfBirth;

            // Set the selected membership type
            MembershipTypeComboBox.SelectedItem = MembershipTypeComboBox.Items
                .Cast<ComboBoxItem>()
                .FirstOrDefault(item => ((ComboBoxItem)item).Content.ToString() == _patronToEdit.MembershipType);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(FullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MembershipIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(DateOfBirthTextBox.Text) ||
                MembershipTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Update the patron's information
            _patronToEdit.FullName = FullNameTextBox.Text;
            _patronToEdit.MembershipID = MembershipIDTextBox.Text;
            _patronToEdit.Email = EmailTextBox.Text;
            _patronToEdit.PhoneNumber = PhoneNumberTextBox.Text;
            _patronToEdit.Address = AddressTextBox.Text;
            _patronToEdit.DateOfBirth = DateOfBirthTextBox.Text;
            _patronToEdit.MembershipType = ((ComboBoxItem)MembershipTypeComboBox.SelectedItem).Content.ToString();

            DialogResult = true; // Close the dialog and return true to indicate success
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Close the dialog and return false to indicate cancellation
            Close();
        }
    }
}
