using Business;
using Data;
using System;
using System.Windows;
using System.Windows.Controls;

namespace UI
{
    /// <summary>
    /// Interaction logic for CreateControl.xaml
    /// </summary>
    public partial class CreateControl : UserControl
    {
        private readonly ContactService _service;
        public event EventHandler ItemAdded;

        public CreateControl()
        {
            _service = new ContactService(new ContactRepository());
            InitializeComponent();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //todo add validation that empty values cannot be added
            //todo handle if adding the same contact
            _service.AddContact(
            new Contact
            {
                Name = nameTextBox.Text,
                Number = numberTextBox.Text
            });

            nameTextBox.Clear();
            numberTextBox.Clear();

            ItemAdded.Invoke(this, EventArgs.Empty);
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            numberTextBox.Clear();
        }
    }
}
