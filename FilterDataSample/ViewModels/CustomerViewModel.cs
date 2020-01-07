using System;
using System.Collections.ObjectModel;
using System.Linq;
using FilterDataSample.Common;
using FilterDataSample.Entities;
using FilterDataSample.Models;

namespace FilterDataSample.ViewModels
{
    public class CustomerViewModel : CommonBase
    {
        #region Private Fields
        private ObservableCollection<Customer> _Customers = new ObservableCollection<Customer>();
        private ObservableCollection<Customer> _FilteredCustomers = new ObservableCollection<Customer>();
        private ObservableCollection<string> _Titles = new ObservableCollection<string>();
        private ObservableCollection<string> _SalesPeople = new ObservableCollection<string>();
        private string _SelectedTitle = string.Empty;
        private string _SelectedSalesPerson = string.Empty;
        private string _Message = string.Empty;
        #endregion

        #region Public Properties
        public ObservableCollection<string> Titles
        {
            get => _Titles;
            set
            {
                _Titles = value;
                RaisePropertyChanged("Titles");
            }
        }

        public ObservableCollection<string> SalesPeople
        {
            get => _SalesPeople;
            set
            {
                _SalesPeople = value;
                RaisePropertyChanged("SalesPeople");
            }
        }

        public string SelectedTitle
        {
            get => _SelectedTitle;
            set
            {
                if (_SelectedTitle != value)
                {
                    _SelectedTitle = value;
                    RaisePropertyChanged("SelectedTitle");
                    // Filter Customers based on selected title
                    FilterCustomers();
                }
            }
        }


        public string SelectedSalesPerson
        {
            get => _SelectedSalesPerson;
            set
            {
                if (_SelectedSalesPerson != value)
                {
                    _SelectedSalesPerson = value;
                    RaisePropertyChanged("SelectedSalesPerson");
                    // Filter Customers based on selected Sales Person
                    FilterCustomers();
                }
            }
        }

        public ObservableCollection<Customer> Customers
        {
            get => _Customers;
            set
            {
                _Customers = value;
                RaisePropertyChanged("Customers");
            }
        }

        public ObservableCollection<Customer> FilteredCustomers
        {
            get => _FilteredCustomers;
            set
            {
                _FilteredCustomers = value;
                RaisePropertyChanged("FilteredCustomers");
            }
        }

        public string Message
        {
            get => _Message;
            set
            {
                _Message = value;
                RaisePropertyChanged("Message");
            }
        }
        #endregion

        #region Load Method
        public void Load()
        {
            LoadCustomers();
            LoadTitles();
            LoadSalesPeople();
        }
        #endregion

        #region LoadTitles Method
        public void LoadTitles()
        {
            Titles = new ObservableCollection<string>(this.Customers.Select(c => c.Title).Distinct());

            Titles.Insert(0, "All");

            SelectedTitle = "All";
        }
        #endregion

        #region LoadSalesPeople Method
        public void LoadSalesPeople()
        {
            SalesPeople = new ObservableCollection<string>(this.Customers.Select(c => c.SalesPerson).Distinct());

            SalesPeople.Insert(0, "All");

            SelectedSalesPerson = "All";
        }
        #endregion

        #region LoadCustomers Method
        public void LoadCustomers()
        {
            AdventureWorksDbContext db = null;

            Customers = new ObservableCollection<Customer>();
            try
            {
                db = new AdventureWorksDbContext();
                Customers = new ObservableCollection<Customer>(db.Customers);
            }
            catch (Exception ex)
            {
                Message = ex.ToString();
            }

            FilteredCustomers = Customers;
        }
        #endregion

        #region FilterCustomers Method
        private void FilterCustomers()
        {
            FilteredCustomers = new ObservableCollection<Customer>(
              Customers.Where(c =>
                    (SelectedTitle == "All" ? true : c.Title == SelectedTitle)
                  && (SelectedSalesPerson == "All" ? true : c.SalesPerson == SelectedSalesPerson)));
        }
        #endregion
    }
}
