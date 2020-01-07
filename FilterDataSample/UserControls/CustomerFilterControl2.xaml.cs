using System.Windows;
using System.Windows.Controls;
using FilterDataSample.ViewModels;

namespace FilterDataSample.UserControls
{
    public partial class CustomerFilterControl2 : UserControl
    {
        readonly CustomerViewModel _ViewModel;

        public CustomerFilterControl2()
        {
            InitializeComponent();

            _ViewModel = (CustomerViewModel)this.FindResource("viewModel");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _ViewModel.Load();
        }
    }
}
