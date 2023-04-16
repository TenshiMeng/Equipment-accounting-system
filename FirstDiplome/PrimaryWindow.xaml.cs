using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace FirstDiplome
{
    public partial class PrimaryWindow : Window
    {

        private Users _users;
        private int _currentPage = 1;
        private int _maxPage = 0;

        public PrimaryWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            RefreshStudentData();
        }

        //Подсчёт страниц
        public void RefreshStudentData()
        {
            membersDataGrid.ItemsSource = _context.StudentData.OrderBy(x => x.FullNameStudent).ToList();
            _maxPage = Convert.ToInt32(Math.Ceiling(_context.StudentData.ToList().Count * 1.0 / 2));
            var listStudent = _context.StudentData.ToList().Skip(
                (_currentPage - 1) * 2).Take(2).ToList();
            FirstPage.Content = "1";
            SecondPage.Content = "2";
            ThirdPage.Content = "3";
            PenultimatePage2.Content = (_maxPage - 2).ToString();
            PenultimatePage1.Content = (_maxPage - 1).ToString();
            LastPage.Content = _maxPage.ToString();
            membersDataGrid.ItemsSource = listStudent;
        }

        private void FirstLetter()
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }

        //Кнопки страниц начало
        private void GoFirstBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = 1;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            LastPage.Style = (Style)FindResource("pagingButton1");
        }

        private void GoSecondBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = 2;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            LastPage.Style = (Style)FindResource("pagingButton1");
        }

        private void GoThirdBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = 3;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            LastPage.Style = (Style)FindResource("pagingButton1");
        }

        private void PenultimatePage2_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPage - 2;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            LastPage.Style = (Style)FindResource("pagingButton1");
        }

        private void PenultimatePage1_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPage - 1;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            LastPage.Style = (Style)FindResource("pagingButton1");
        }

        private void GoLastBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPage;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            LastPage.Style = (Style)FindResource("pagingButton1");
        }

        private void RightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage + 1 > _maxPage)
            {
                return;
            }
            _currentPage = _currentPage + 1;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            if (_currentPage == _maxPage)
            {
                LastPage.Style = (Style)FindResource("pagingButton3");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == _maxPage - 1)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton3");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == _maxPage - 2)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton3");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == 3)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton3");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == 2)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton3");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == 1)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton3");
            }
            if (_currentPage != 3 && _currentPage != _maxPage - 2)
            {
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
            }

        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage - 1 < 1)
            {
                return;
            }
            _currentPage = _currentPage - 1;
            RefreshStudentData();
            FirstPage.Style = (Style)FindResource("pagingButton1");
            if (_currentPage == _maxPage)
            {
                LastPage.Style = (Style)FindResource("pagingButton3");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == _maxPage - 1)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton3");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == _maxPage - 2)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton3");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == 3)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton3");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == 2)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton3");
                FirstPage.Style = (Style)FindResource("pagingButton1");
            }
            if (_currentPage == 1)
            {
                LastPage.Style = (Style)FindResource("pagingButton1");
                PenultimatePage1.Style = (Style)FindResource("pagingButton1");
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
                SecondPage.Style = (Style)FindResource("pagingButton1");
                FirstPage.Style = (Style)FindResource("pagingButton3");
            }
            if (_currentPage != 3 && _currentPage != _maxPage - 2)
            {
                PenultimatePage2.Style = (Style)FindResource("pagingButton1");
                ThirdPage.Style = (Style)FindResource("pagingButton1");
            }
        }
        //Кнопки странци конец

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
