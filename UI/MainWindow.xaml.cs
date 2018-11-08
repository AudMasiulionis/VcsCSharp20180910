using Data;
using Lesson21_DesignPatterns.Repositories;
using System.Windows;

namespace UI
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

        private void CreateControl_ItemAdded(object sender, System.EventArgs e)
        {
            this.listControl.listView.Items.Refresh();
        }
    }
}
