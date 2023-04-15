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
        LebedevEnd1Entities lebedevEnd1Entities = new LebedevEnd1Entities();
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
            var CurrentUser = AppData.lebedevEnd1Entities.Users.FirstOrDefault(u => u.UserLogin == txtUsername.Text && u.UserPassword == txtPassword.Password);
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

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            this.Close();
            regWindow.ShowDialog();
        }


        private void Check_Click(object sender, RoutedEventArgs e)
        {
            var check = sender as CheckBox;
            if (check.IsChecked.Value)
            {
                //txt.Text = txtPassword.Password;
                //txtPassword.Visibility = Visibility.Visible;
                ////txtPassword.Password = "";
            }
            else
            {
                //tb2.Password = PassTB.Text;
                //PassTB.Visibility = Visibility.Hidden;
                //tb2.Visibility = Visibility.Visible;
            }
        }
    }
}
