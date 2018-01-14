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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public MainWindow mw;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource usersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usersViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // usersViewSource.Source = [универсальный источник данных]
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = Int32.Parse(userIdTextBox.Text);

                var user = mw.context.Users
                    .Where(c => c.UserId == k)
                    .FirstOrDefault();

                // Внести изменения
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

                mw.usViewSource.View.Refresh();
                // Сохранить изменения
                mw.context.SaveChanges();
            }
            catch { }
        }

        private void window2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void window2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        OpenFileDialog oFile = new OpenFileDialog();
        private void Button_Click(object sender, RoutedEventArgs e)
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
    }
}
