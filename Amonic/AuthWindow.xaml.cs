using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Amonic
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {

         public int i = 0;
        public AuthWindow()
        {
            InitializeComponent();
        }


        bool tryLogin()
        {
            return false;
        }
       

        private async void Auth_Click(object sender, RoutedEventArgs e)
        {
             var n = tryLogin();
            if (n == false)
            {
                i++;
                if(i == 3)
                {
                   
                    form.IsEnabled= false;
                    tick.Visibility = Visibility.Visible;

                    for (int r = 10; r >= 0; r--)
                    {
                        tick.Content = r.ToString();
                        await Task.Delay(1000);
                    }

                    i = 0;
                    form.IsEnabled = true;
                    tick.Visibility = Visibility.Hidden;
                }
            }
            else {
                i = 0;
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Window error = new AdminMenu();
            error.Show();
            this.Close();

        }
    }
}
