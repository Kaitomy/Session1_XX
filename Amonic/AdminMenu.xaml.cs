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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
            
            OfficeList.ItemsSource = Session1_XXEntities.GetContext().Offices.ToList();
        
            AmonicDataUsers.ItemsSource = Session1_XXEntities.GetContext().Users.ToList();
            
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            Window add = new AddUserWindow();
            add.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Window add = new AuthWindow();
            add.Show();
            this.Close();
        }

        private void AmonicDataUsers_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

        }

        private void OfficeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OfficeList.SelectedValue == null)
            {
                AmonicDataUsers.ItemsSource = Session1_XXEntities.GetContext().Users.ToList();
            }
            else {
                int r = int.Parse(OfficeList.SelectedValue.ToString());
               
                AmonicDataUsers.ItemsSource = Session1_XXEntities.GetContext().Users.Where(a => a.OfficeID == r).ToList();
            }
        }
    }
}
