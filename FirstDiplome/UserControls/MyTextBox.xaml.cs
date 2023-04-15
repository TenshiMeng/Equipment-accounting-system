using System.Windows;
using System.Windows.Controls;

namespace FirstDiplome.UserControls
{
    /// <summary>
    /// Логика взаимодействия для MyTextBox.xaml
    /// </summary>
    public partial class MyTextBox : UserControl
    {
        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register
        ("Hint", typeof(string), typeof(MyTextBox));

    }
}