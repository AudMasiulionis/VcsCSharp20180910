using Business;
using Data;
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

namespace UI
{
    /// <summary>
    /// Interaction logic for ItemList.xaml
    /// </summary>
    public partial class ItemList : UserControl
    {
        private readonly ContactService _service;

        public ItemList()
        {
            _service = new ContactService(new ContactRepository());
            InitializeComponent();
            this.listView.ItemsSource = _service.GetContacts();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.listView.SelectedItem == null)
            {
                MessageBox.Show("Info", "No item selected", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            MessageBoxResult messageBoxResult = MessageBox.Show("Confirm", "Are you sure you want to delete?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                var selectedContact = listView.SelectedItem as Contact;
                _service.DeleteContact(selectedContact.Id);
                listView.Items.Refresh();
                this.listView.Items.Refresh();
            }
        }
    }
}
