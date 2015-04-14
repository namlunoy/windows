using MyTimer.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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


namespace MyTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string message = "HoangCuong, I love you!";

        private bool clickPlay = true;
        DispatcherTimer timer = new DispatcherTimer();
        private long count = 0;
        public long h = 0, m = 0, s = 0;
        SolidColorBrush _Black = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF282828"));
        SolidColorBrush _White = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A2A2A2A2"));
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            count++;
            UpdateUI();
        }

        void UpdateUI()
        {
            m = count / 60;
            h = m / 60;
            m = m % 60;
            s = count % 60;

            Hour.Text = h.ToString("D2");
            Minute.Text = m.ToString("D2");
            Second.Text = s.ToString("D2");
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try { this.window.DragMove(); }
            catch (Exception) { }
        }



        private void Click_Play(object sender, MouseButtonEventArgs e)
        {
            if (clickPlay)
                Start();
            else
                Pause();
            clickPlay = !clickPlay;

        }
        public bool Result { get; set; }
        private void Click_Stop(object sender, MouseButtonEventArgs e)
        {
            Dialog d = new Dialog(this);
            d.Owner = this.window;
            d.ShowDialog();
            if (Result)
            {
                Reset();
                window.Background = _Black;
            }
        }

        void Start()
        {
            timer.IsEnabled = true;
            timer.Start();
            btPlay.Source = new BitmapImage(new Uri("/Images/pause.png", UriKind.Relative));
            window.Background = _Black;
        }

        void Pause()
        {
            timer.IsEnabled = false;
            btPlay.Source = new BitmapImage(new Uri("/Images/play.png", UriKind.Relative));
            window.Background = _White;
        }

        void Reset()
        {
            timer.IsEnabled = false;
            count = 0;

            clickPlay = true;
            btPlay.Source = new BitmapImage(new Uri("/Images/play.png", UriKind.Relative));
            UpdateUI();
        }

        private void Click_Minimize(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void Click_Close(object sender, System.ComponentModel.CancelEventArgs e)
        {

            Save();
        }

        private void Save()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("MyTimer.data", FileMode.OpenOrCreate, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    writer.WriteLine(count.ToString());
                    //Console.WriteLine("You have written to the file.");
                }
            }

        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                if (isoStore.FileExists("MyTimer.data"))
                {
                    // Console.WriteLine("The file already exists!");
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("MyTimer.data", FileMode.Open, isoStore))
                    {
                        using (StreamReader reader = new StreamReader(isoStream))
                        {
                            String s = reader.ReadToEnd();
                            count = long.Parse(s);
                            if (count > 0)
                            {
                                window.Background = _White;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                count = 0;
            }


            UpdateUI();
        }

        private string FilePath
        {//Directory.GetCurrentDirectory()
            get { return Directory.GetCurrentDirectory() + @"\MyTimer.data"; }
        }

    }
}