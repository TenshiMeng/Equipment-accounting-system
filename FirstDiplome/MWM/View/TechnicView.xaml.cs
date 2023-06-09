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
    /// Логика взаимодействия для TechnicView.xaml
    /// </summary>

    public partial class TechnicView : UserControl
    {
        private LebedevEnd1Entities2 _context = new LebedevEnd1Entities2();
        public TechnicView()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TechnicGrid.ItemsSource = AppData.lebedevEnd1Entities2.Technic.ToList();
        }
    }
}
