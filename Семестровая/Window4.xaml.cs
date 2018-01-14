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
using System.Data.Entity;
namespace Семестровая
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource usersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usersViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // usersViewSource.Source = [универсальный источник данных]
        }
      public  MainWindow mw;
        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
           

           
        }

        private void window4_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            
            this.Hide();
        }
    }
}
