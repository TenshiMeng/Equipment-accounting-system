using FirstDiplome.Properties;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FirstDiplome
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public LoginWindow()
        {
            InitializeComponent();
        }
        LebedevEnd1Entities1 lebedevEnd1Entities1 = new LebedevEnd1Entities1();
        private void Authorization(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.lebedevEnd1Entities1.Users.FirstOrDefault(u => u.Login == tb1.Text && u.Password == tb2.Password);
            if (CurrentUser != null)
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Данного пользователя нет в базе данных!");
                MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            }
        }

        private void Close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Hide_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (tb2.Password.Length > 0)
            {
                PassTB.Visibility = Visibility.Collapsed;
            }
            else
            {
                PassTB.Visibility = Visibility.Visible;
            }
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            var check = sender as CheckBox;
            if (check.IsChecked.Value)
            {
                PassTB.Text = tb2.Password;
                PassTB.Visibility = Visibility.Visible;
                tb2.Password = "";
            }
            else
            {
                tb2.Password = PassTB.Text;
                PassTB.Visibility = Visibility.Hidden;
                tb2.Visibility = Visibility.Visible;
            }
        }
    }
}