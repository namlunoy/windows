using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            txtTime.Text = namlunoy.config.Time.ToString();
            txtUrl.Text = namlunoy.config.Directory;
        }

        private void ClickSave(object sender, RoutedEventArgs e)
        {
            if(!Directory.Exists(txtUrl.Text))
            {
                MessageBox.Show("The directory is invalid!");
            }
            else
            {
                int time;
                if(int.TryParse(txtTime.Text,out time))
                {
                  if(namlunoy.GetImages(txtUrl.Text).Count == 0)
                  {
                      MessageBox.Show("The directory has no image!");
                  }
                  else
                  {
                      namlunoy.config.Directory = txtUrl.Text;
                      namlunoy.config.Time = time;
                      namlunoy.SaveConfig();
                      MainWindow.Instance.Reload();
                      this.Close();

                  }
                }
                else
                {
                    MessageBox.Show("Time is invalid!");
                }
                
            }
        }

        private void ClickCancel(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }
    }
}
