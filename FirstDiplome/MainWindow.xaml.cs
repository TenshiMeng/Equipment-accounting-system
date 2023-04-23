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

namespace FirstDiplome
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TheControl.SetIntials(this);
        }

            private void exit_Click(object sender, RoutedEventArgs e)
            {
                TheControl.Exit();
            }

            private void full_Click(object sender, RoutedEventArgs e)
            {
                TheControl.DoFullscreen(this);
            }

            private void max_Click(object sender, RoutedEventArgs e)
            {
                Button btn = (Button)sender;
                TheControl.DoMaximize(this, btn);
            }

            private void min_Click(object sender, RoutedEventArgs e)
            {
                TheControl.Minimize(this);
            }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) => DragMove();
    }
}
