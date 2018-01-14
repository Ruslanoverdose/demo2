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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = Int32.Parse(userIdTextBox.Text);
                Users user = mw.context.Users
                    .Where(c => c.UserId == k)
                    .FirstOrDefault();

                mw.context.Entry(user)
                    .Collection(c => c.Groups)
                    .Load();

                mw.context.Users.Remove(user);
                mw.usViewSource.View.Refresh();
                mw.context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void window3_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
