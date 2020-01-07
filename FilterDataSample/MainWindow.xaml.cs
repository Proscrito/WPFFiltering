using System.Windows;
using FilterDataSample.UserControls;

namespace FilterDataSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CustomerSearchMenuItem_Click(object sender, RoutedEventArgs e)
        {
            contentArea.Children.Clear();
            contentArea.Children.Add(new CustomerSearchControl());
        }

        private void CustomerFilterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            contentArea.Children.Clear();
            contentArea.Children.Add(new CustomerFilterControl());
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CustomerFilter2MenuItem_Click(object sender, RoutedEventArgs e)
        {
            contentArea.Children.Clear();
            contentArea.Children.Add(new CustomerFilterControl2());
        }
    }
}
