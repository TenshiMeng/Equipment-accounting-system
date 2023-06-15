using System;
using System.Windows;
using System.Windows.Controls;
using FirstDiplome.Core;

namespace FirstDiplome.MWM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MenuViewCommand { get; set; }
        public RelayCommand TechnicViewCommand { get; set; }
        public RelayCommand SupplierViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public MenuViewModel MenuVM { get; set; }

        public TechnicViewModel TechnicVM { get; set; }

        public SupplierViewModel SupplierVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            MenuVM = new MenuViewModel();
            TechnicVM = new TechnicViewModel();
            SupplierVM = new SupplierViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            MenuViewCommand = new RelayCommand(o =>
            {
                CurrentView = MenuVM;
            });

            TechnicViewCommand = new RelayCommand(o =>
            {
                CurrentView = TechnicVM;
            });
            SupplierViewCommand = new RelayCommand(o =>
            {
                CurrentView = SupplierVM;
            });
            
        }
    }
}
