using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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

       // Environment.Exit(0)
        

        private async void Auth_Click(object sender, RoutedEventArgs e)
        {
            string user = null;
            string hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Password.Text))).Replace("-", "");
            try
            {
                user = Session1_XXEntities.GetContext().Users.Where(a => a.Email == Email.Text && a.Password == hash).Single().ID.ToString();
            }
            catch { user = null; }
            if (user == null || user.Contains("null"))
            {
                i++;
                if (i == 3)
                {

                    form.IsEnabled = false;
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
            else
            {
                i = 0;
                int r = int.Parse(user);
                int role = Session1_XXEntities.GetContext().Users.Where(a => a.ID == r).First().RoleID;
                if (role == 2)
                {

                    Window error = new UserMenu(r);
                    error.Show();
                    this.Close();
                }
                if (role == 1)
                {

                    Window error = new AdminMenu();
                    error.Show();
                    this.Close();
                }
                
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
