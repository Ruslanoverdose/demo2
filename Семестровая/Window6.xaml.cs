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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource groupsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("groupsViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // groupsViewSource.Source = [универсальный источник данных]
        }
         public  Window5 w5;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Groups group = new Groups
            {
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text,
              

            };

            w5.mw.context.Groups.Add(group);
            w5.mw.context.SaveChanges();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
