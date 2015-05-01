using Microsoft.Win32;
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

namespace SecondBackground
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
       
        public Dialog()
        {
            InitializeComponent();
       //     App.Current.Properties[0] = "123";
          //  _xURL.Text = App.Current.Properties[0].ToString();
        }

        private void ClickSave(object sender, RoutedEventArgs e)
        {
            App.Current.Properties[0] = _xURL.Text;
            App.Current.Properties[1] = int.Parse(_xSIZE.Text);
        }

        private void ClickCancel(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }
    }
}
