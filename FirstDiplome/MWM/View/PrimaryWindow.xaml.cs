﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

    namespace FirstDiplome.View
    {
    public partial class PrimaryWindow : Window
    {
        private LebedevEnd1Entities _context = new LebedevEnd1Entities();
        private Technic _technic;
        private int _currentPage = 1;
        private int _maxPage = 0;
        
        public PrimaryWindow()
        {
            InitializeComponent();
        }
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
