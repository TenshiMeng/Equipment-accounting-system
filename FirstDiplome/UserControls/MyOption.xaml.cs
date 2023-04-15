using System.Windows;
using System.Windows.Controls;

namespace FirstDiplome.UserControls
{
    public partial class MyOption : UserControl
    {
        public MyOption()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register
            ("Text", typeof(string), typeof (MyOption), new PropertyMetadata(null));

        public FontAwesome.WPF.FontAwesomeIcon Icon
        {
            get { return (FontAwesome.WPF.FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register
            ("Text", typeof(FontAwesome.WPF.FontAwesomeIcon), typeof(MyOption), new PropertyMetadata(null));
    }
}
