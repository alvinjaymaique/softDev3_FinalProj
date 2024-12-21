using LMS;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LMS
{
    public partial class PatronManagementWindow : Page
    {
        public ObservableCollection<Patron> Patrons { get; set; }

        public PatronManagementWindow()
        {
            InitializeComponent();
            Patrons = new ObservableCollection<Patron>();
            PatronDataGrid.ItemsSource = Patrons;
        }

        private void AddPatron_Click(object sender, RoutedEventArgs e)
        {
            var addPatronDialog = new AddPatronWindow();
            if (addPatronDialog.ShowDialog() == true)
            {
                Patrons.Add(addPatronDialog.NewPatron);
            }
        }

        private void EditPatron_Click(object sender, RoutedEventArgs e)
        {
            if (PatronDataGrid.SelectedItem is Patron selectedPatron)
            {
                var editPatronDialog = new EditPatronWindow(selectedPatron);
                if (editPatronDialog.ShowDialog() == true)
                {
                    PatronDataGrid.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a patron to edit.", "Edit Patron", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeletePatron_Click(object sender, RoutedEventArgs e)
        {
            if (PatronDataGrid.SelectedItem is Patron selectedPatron)
            {
                if (MessageBox.Show($"Are you sure you want to delete \"{selectedPatron.FullName}\"?", "Delete Patron", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Patrons.Remove(selectedPatron);
                }
            }
            else
            {
                MessageBox.Show("Please select a patron to delete.", "Delete Patron", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SearchPatron_Click(object sender, RoutedEventArgs e)
        {
            string query = SearchTextBox.Text.ToLower();
            var filteredPatrons = Patrons.Where(patron =>
                patron.FullName.ToLower().Contains(query) ||
                patron.MembershipID.ToLower().Contains(query)).ToList();

            PatronDataGrid.ItemsSource = filteredPatrons;
        }
    }
}
