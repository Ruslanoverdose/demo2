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

namespace Семестровая
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource usersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usersViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // usersViewSource.Source = [универсальный источник данных]
        }
       public MainWindow mw;
        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Users user = new Users();

                if (firstNameTextBox.Text != "")
                    user.FirstName = firstNameTextBox.Text;
                if (lastNameTextBox.Text != "")
                    user.LastName = lastNameTextBox.Text;
                if (logInUsersTextBox.Text != "")
                    user.LogInUsers = logInUsersTextBox.Text;
                if (emailTextBox.Text != "")
                    user.Email = emailTextBox.Text;
                user.Description = descriptionTextBox.Text;
                if (Mrad.IsChecked == true)
                {
                    user.Gender = false;
                }
                else user.Gender = true;




                mw.context.Users.Add(user);
                mw.context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        OpenFileDialog oFile = new OpenFileDialog();
        private void photoPathButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                oFile.DefaultExt = "*.jpg";
                oFile.Filter = "Загрузить изображение|*.jpg|*.gif|*.png";
                if (oFile.ShowDialog() == true)
                {

                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
            }
            catch { }
        }

  
 

        private void Window2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
