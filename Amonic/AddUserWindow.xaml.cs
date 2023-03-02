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
using System.Windows.Shapes;

namespace Amonic
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
       // private Users _currentUsers = new Users();
        public AddUserWindow()
        {
            InitializeComponent();
        //    DataContext = _currentUsers;
            OfficeList.ItemsSource = Session1_XXEntities.GetContext().Offices.ToList();
            OfficeList.DisplayMemberPath = "Title";
            OfficeList.SelectedValuePath = "ID";
            OfficeList.SelectedIndex = 0;


        }

        private void SaveUser_Click(object sender, RoutedEventArgs e)
        {
            if (Email.Text == null || Password.Text == null || LastName.Text == null || FirstName.Text == null)
            { MessageBox.Show("Ошибка заполнения данных! Есть пустые значения"); }
            else
            {
               

            Users user = new Users
            {
                ID = 20,
                Email = Email.Text,
                Password = Password.Text,
                LastName = LastName.Text,
                FirstName = FirstName.Text,
                OfficeID = 5,
                Birthdate = DateTime.Parse(Birthdate.Text),
                RoleID = 2,
                Active = true,
               

            };
            Session1_XXEntities.GetContext().Users.Add(user);
                try
                {
                    Session1_XXEntities.GetContext().SaveChanges();
                }
                catch { }
            }
        }

        private void CancelAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OfficeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
