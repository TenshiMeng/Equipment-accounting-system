﻿using System;
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
using System.Windows.Shapes;
using FirstDiplome.Properties;
using MaterialDesignThemes.Wpf;

namespace FirstDiplome
{
    /// <summary>
    /// Логика взаимодействия для WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        LebedevEnd1Entities1 lebedevEnd1Entities1 = new LebedevEnd1Entities1();
        public WindowLogin()
        {
            InitializeComponent();
        }

        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();
                if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark) 
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
                else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);

        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }       

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.lebedevEnd1Entities1.Users.FirstOrDefault(u => u.Login == txtUsername.Text && u.Password == txtPassword.Password);
            if (CurrentUser != null)
            {
                MainWindow window = new MainWindow();
                window.Show();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
