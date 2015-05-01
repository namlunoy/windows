using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace SecondBackground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public DispatcherTimer timer = null;
        public MainWindow()
        {
            Instance = this;
            InitializeComponent();
            namlunoy.LoadConfigFile();
            Closing += MainWindow_Closing;
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (namlunoy.config.PosSize != null)
            {
                window.Top = namlunoy.config.PosSize.Top;
                window.Left = namlunoy.config.PosSize.Left;
                window.Height = namlunoy.config.PosSize.Heigh;
                window.Width = namlunoy.config.PosSize.Width;
            }
            Reload();

        }

        public void Reload()
        {
            if (namlunoy.config.Directory.Length < 1)
            {
                MessageBox.Show("Right click to select directory!");
            }
            else
            {
                namlunoy.GetImages(namlunoy.config.Directory);

                if (namlunoy.images.Count > 0)
                {
                    if (timer == null)
                    {
                        timer = new DispatcherTimer();
                        timer.Tick += ChangePicture;
                    }
                    else
                    {
                        timer.Stop();
                    }
                    _image.Source = new BitmapImage(namlunoy.GetNextImage());
                    timer.Interval = new TimeSpan(0, 0, namlunoy.config.Time);
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Directory has no image!");
                }
            }
        }

        void ChangePicture(object sender, EventArgs e)
        {
            _image.Source = new BitmapImage(namlunoy.GetNextImage());
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (window.WindowState == System.Windows.WindowState.Normal)
            {
                LocationAndSize p = new LocationAndSize() { Left = window.Left, Top = window.Top, Heigh = window.Height, Width = window.Width };
                namlunoy.config.PosSize = p;
                namlunoy.SaveConfig();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try { this.window.DragMove(); }
            catch (Exception) { }

            if (e.RightButton == MouseButtonState.Pressed)
            {
                Dialog d = new Dialog();
                d.Owner = this.window;
                d.ShowDialog();
                Debug.WriteLine("Right Click!");
            }
        }

        private void ClickMoreApps(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/developer?id=The+Brown+Box");
            System.Diagnostics.Process.Start("https://www.windowsphone.com/en-US/store/publishers?publisherId=The%2BBrown%2BBox");
        }

        private void ClickFacebook(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/thebrownboxx");
        }
    }
}
