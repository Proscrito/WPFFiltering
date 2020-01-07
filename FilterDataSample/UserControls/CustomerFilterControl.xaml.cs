using System.Windows;
using System.Windows.Controls;
using FilterDataSample.ViewModels;

namespace FilterDataSample.UserControls
{
  public partial class CustomerFilterControl : UserControl
  {
      readonly CustomerViewModel _ViewModel;

    public CustomerFilterControl() {
      InitializeComponent();

      _ViewModel = (CustomerViewModel)this.FindResource("viewModel");
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e) {
      _ViewModel.Load();
    }
  }
}
