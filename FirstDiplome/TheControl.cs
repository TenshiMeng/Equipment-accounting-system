using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FirstDiplome
{
    static class TheControl
    {
        static bool isMax = false, isFull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static void SetIntials(Window win)
        {
            old_size = new Size(win.Width, win.Height);
            old_loc = new Point(win.Top, win.Left);
            default_size = new Size(win.Width, win.Height);
            default_loc = new Point(win.Top, win.Left);
        }

        public static void DoMaximize(Window win, Button btn)
        {
            if (isMax == false) // app is currently not maximized ; then maximize it!
            {
                old_size = new Size(win.Width, win.Height);
                old_loc = new Point(win.Top, win.Left);
                Maximize(win);
                isMax = true;
                isFull = false;
                btn.Content = "2";
            }

            else // app is currentlly maximized ; then we make it normal
            {
                if (old_size.Width >= SystemParameters.WorkArea.Width ||
                    old_size.Height >= SystemParameters.WorkArea.Height)
                {
                    win.Top = default_loc.Y;
                    win.Left = default_loc.X;
                    win.Width = default_size.Width;
                    win.Height = default_size.Height;
                }

                else
                {
                    win.Top = old_loc.Y;
                    win.Left = old_loc.X;
                    win.Width = old_size.Width;
                    win.Height = old_size.Height;
                }
                isMax = false;
                isFull = false;
                btn.Content = "1";
            }
        }

        public static void DoFullscreen(Window win)
        {
            if (isMax == false) // app is currently not fullscreen ; then fullscreen it!
            {
                old_size = new Size(win.Width, win.Height);
                old_loc = new Point(win.Top, win.Left);
                Fullscreen(win);
                isMax = false;
                isFull = true;
            }

            else // app is currentlly fullscreen ; then we make it normal
            {
                if (old_size.Width >= SystemParameters.WorkArea.Width ||
                    old_size.Height >= SystemParameters.WorkArea.Height)
                {
                    win.Top = default_loc.Y;
                    win.Left = default_loc.X;
                    win.Width = default_size.Width;
                    win.Height = default_size.Height;
                }

                else
                {
                    win.Top = old_loc.Y;
                    win.Left = old_loc.X;
                    win.Width = old_size.Width;
                    win.Height = old_size.Height;
                }
                isMax = false;
                isFull = false;
            }
        }

        static void Fullscreen(Window win)
        {
            if (win.WindowState == WindowState.Normal)
                win.WindowState = WindowState.Maximized;
            else
                win.WindowState = WindowState.Normal;
        }

        static void Maximize(Window win)
        {
            double x = SystemParameters.WorkArea.Width;
            double y = SystemParameters.WorkArea.Height;
            win.WindowState = WindowState.Normal;
            win.Top = 0;
            win.Left = 0;
            win.Width = x;
            win.Height = y;
        }

        public static void Minimize(Window win)
        {
            win.WindowState = WindowState.Minimized;
        }

        public static void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
