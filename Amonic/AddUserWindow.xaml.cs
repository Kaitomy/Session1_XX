using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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
        public static string MD5Hash(string text)  
    {  
      MD5 md5 = new MD5CryptoServiceProvider();  

      //compute hash from the bytes of text  
      md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));  
  
      //get hash result after compute it  
      byte[] result = md5.Hash;  

      StringBuilder strBuilder = new StringBuilder();  
      for (int i = 0; i < result.Length; i++)  
      {  
        //change it into 2 hexadecimal digits  
        //for each byte  
        strBuilder.Append(result[i].ToString("x2"));  
      }  

      return strBuilder.ToString();  
    }  
        private void SaveUser_Click(object sender, RoutedEventArgs e)
        {
            if (Email.Text == null || Password.Text == null || LastName.Text == null || FirstName.Text == null)
            { MessageBox.Show("Ошибка заполнения данных! Есть пустые значения"); }
            else
            {

                string hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Password.Text))).Replace("-", "");
                Users user = new Users
            {
                Email = Email.Text,
                Password = hash,
                LastName = LastName.Text,
                FirstName = FirstName.Text,
                OfficeID = int.Parse(OfficeList.SelectedValue.ToString()),
                Birthdate = DateTime.Parse(Birthdate.Text),
                RoleID = 2,
                Active = true,
               

            };
            Session1_XXEntities.GetContext().Users.Add(user);
                try
                {
                    Session1_XXEntities.GetContext().SaveChanges();
                    Window add = new AdminMenu();
                    add.Show();
                    this.Close();
                }

                catch { }
            }
        }

        private void CancelAdd_Click(object sender, RoutedEventArgs e)
        {
            Window add = new AdminMenu();
            add.Show();
            this.Close();
        }

        private void OfficeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
