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

namespace Lesson25_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Hello wolrd";


            Window1 window1 = new Window1();
            window1.Show();

            //MessageBoxResult result = MessageBox.Show("Do you want to close this window?",
            //                              "Confirmation",
            //                              MessageBoxButton.YesNo,
            //                              MessageBoxImage.Question);
        }
    }
}
