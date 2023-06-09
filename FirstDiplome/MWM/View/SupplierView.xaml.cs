﻿using FirstDiplome.Properties;
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

namespace FirstDiplome.MWM.View
{
    /// <summary>
    /// Логика взаимодействия для SupplierView.xaml
    /// </summary>
    public partial class SupplierView : UserControl
    {
        private LebedevEnd1Entities2 _context = new LebedevEnd1Entities2();
        public SupplierView()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SupplierGrid.ItemsSource = AppData.lebedevEnd1Entities2.Employee.ToList();
        }
    }
}
