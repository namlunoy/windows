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

namespace SecondBackground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String _test = @"C:\Users\conghoang\Pictures\vng.jpg";
        BitmapImage _bitmap;
        public MainWindow()
        {
            InitializeComponent();

            //Bước 1: Thực hiện lấy tất cả các file ảnh trong thư mục đó ra
            //Kể cả thư mục con


            //Bước 2: Thực hiện vòng lặp theo số giây quy định
            //Để đổi ảnh


            //Bước 3: Thực hiện đổi kích thước của window với 1 chiều giữ nguyên
            //image.Source = new BitmapImage(new Uri(test));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try { this.window.DragMove(); }
            catch (Exception) { }

            if(e.RightButton == MouseButtonState.Pressed)
            {
                Dialog d = new Dialog();
                d.Owner = this.window;
                d.ShowDialog();
                Debug.WriteLine("Right Click!");
            }
        }
    }
}
