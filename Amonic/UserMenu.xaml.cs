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

namespace Amonic
{
    /// <summary>
    /// Логика взаимодействия для UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        public int user = 0;
        public UserMenu(int ID)
        {
            InitializeComponent();
            user= ID;
            Name.Content = Session1_XXEntities.GetContext().Users.Where(a => a.ID == user).First().FirstName;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            Window error = new AuthWindow();
            error.Show();
            this.Close();
        }

        private void AmonicDataUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
