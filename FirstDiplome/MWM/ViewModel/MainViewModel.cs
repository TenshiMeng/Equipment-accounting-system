﻿using System;
using System.Windows;
using System.Windows.Controls;
using FirstDiplome.Core;

namespace FirstDiplome.MWM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MenuViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public MenuViewModel MenuVM { get; set; }
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
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand((o =>
            {
                CurrentView = HomeVM;
            }));

            MenuViewCommand = new RelayCommand((o =>
            {
                CurrentView = MenuVM;
            }));
        }
    }
}
