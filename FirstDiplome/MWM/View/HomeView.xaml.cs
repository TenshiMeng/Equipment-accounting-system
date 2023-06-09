using FirstDiplome.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private LebedevEnd1Entities2 _context = new LebedevEnd1Entities2();
        private int _currentPage = 1;
        private int _maxPage = 0;
        public HomeView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
            this.Close();
        }

        private void ButtonTest1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonTehnicue_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonEmployees_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

