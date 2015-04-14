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
using System.Windows.Shapes;

namespace MyTimer
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        MainWindow mainWindow;
        public Dialog(MainWindow m)
        {
            mainWindow = m;
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
         
        }

        private void ClickYes(object sender, RoutedEventArgs e)
        {
            mainWindow.Result = true;
            Close();
        }

        private void ClickNo(object sender, RoutedEventArgs e)
        {
            mainWindow.Result = false;
            Close();
        }
    }
}
