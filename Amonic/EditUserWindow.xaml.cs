using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
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
    /// Логика взаимодействия для EditUserWindow.xaml
    /// </summary>
    public partial class EditUserWindow : Window
    {
        public int Ad = 0;
        public EditUserWindow(int ID)
        {

            InitializeComponent();
            OfficeList.ItemsSource = Session1_XXEntities.GetContext().Offices.ToList();
             Ad = ID;
            int role = Session1_XXEntities.GetContext().Users.Where(a => a.ID == Ad).Single().RoleID ;
            Email.Text = Session1_XXEntities.GetContext().Users.Where(a => a.ID == Ad ).Single().Email.ToString();
            LastName.Text = Session1_XXEntities.GetContext().Users.Where(a => a.ID == Ad).Single().LastName.ToString();
            FirstName.Text = Session1_XXEntities.GetContext().Users.Where(a => a.ID == Ad).Single().FirstName.ToString();
            
            OfficeList.SelectedValue = Session1_XXEntities.GetContext().Users.Where(a => a.ID == Ad).Single().OfficeID;

            if (role == 2) { 
            users.IsChecked= true;
            }
            if (role == 1)
            {
                admins.IsChecked = true;
            }
        }

        private void SaveUser_Click(object sender, RoutedEventArgs e)
        {


            if (users.IsChecked == true) {



                var Update = Session1_XXEntities.GetContext().Users.Find(Ad);
                Update.RoleID = 2;

                // Mark as Changed
                Session1_XXEntities.GetContext().Entry(Update).State = System.Data.Entity.EntityState.Modified;
                Session1_XXEntities.GetContext().SaveChanges();
                Window add = new AdminMenu();
                add.Show();
                this.Close();
            }
            if (admins.IsChecked == true)
            { 



                var Update = Session1_XXEntities.GetContext().Users.Find(Ad);
                Update.RoleID = 1;

                // Mark as Changed
                Session1_XXEntities.GetContext().Entry(Update).State = System.Data.Entity.EntityState.Modified;
                Session1_XXEntities.GetContext().SaveChanges();
                Window add = new AdminMenu();
                add.Show();
                this.Close();
            }

        }

        private void CancelAdd_Click(object sender, RoutedEventArgs e)
        {
            Window add = new AdminMenu();
            add.Show();
            this.Close();
        }
    }
}
