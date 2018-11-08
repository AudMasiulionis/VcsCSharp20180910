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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> p = new List<Person>
            {
                new Person{ Name = "1" },
                new Person{ Name = "2" },
                new Person{ Name = "3" },
                new Person{ Name = "4" },
            };

        public MainWindow()
        {
            InitializeComponent();
            listView.ItemsSource = p;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = DateTime.Now.ToString();
            p.Add(new Person { Name = DateTime.Now.ToString() });
            //listView.Items.Refresh();
        }
    }

    internal class Person
    {
        public string Name { get; set; }
    }
}
