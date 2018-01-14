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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        
        public Window5()
        {
            InitializeComponent();
            
            w6.w5 = this;
            w9.w5 = this;
            w10.w5 = this;
         
        }
        Window6 w6 = new Window6();
        Window9 w9 = new Window9();
        Window10 w10 = new Window10();
       
        public MainWindow mw;
        public CollectionViewSource grViewSource;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //  System.Windows.Data.CollectionViewSource groupsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("groupsViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            //groupsViewSource.Source = [универсальный источник данных]
            grViewSource = ((CollectionViewSource)(FindResource("groupsViewSource")));
            mw.context.Groups.Load();
            grViewSource.Source = mw.context.Groups.Local;
            System.Windows.Data.CollectionViewSource usersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usersViewSource")));

        }

        private void CreateBut_Click(object sender, RoutedEventArgs e)
        {
            w6.Show();
        }
    
        private void DeleteGroupBut_Click(object sender, RoutedEventArgs e)
        {
            w9.Show();
        }
        private void DeleteGroupBut_Copy_Click(object sender, RoutedEventArgs e)
        {
        }

        private void groupsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
        private void EditButt_Click(object sender, RoutedEventArgs e)
        {
            w10.Show();
        }

        private void groupsDataGrid_PreviewMouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            //int Client = -1;
            //var selectedCell = groupsDataGrid.SelectedCells[0];
            //var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            //int ind = groupsDataGrid.SelectedIndex;
            //var ci = new DataGridCellInfo(groupsDataGrid.Items[ind], groupsDataGrid.Columns[0]);
            //var content = ci.Column.GetCellContent(ci.Item) as TextBlock;
            //Client = (int)Convert.ToInt32(content.Text);
            
        }

        private void window5_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //int k = Int32.Parse(userIdTextBox.Text);
            //    Users user = mw.context.Users
            //    .Where(c => c.UserId == k)
            //    .FirstOrDefault();
            //MessageBox.Show(user.Groups[1].ToString());
            //mw.usViewSource.View.Refresh();
            //// Сохранить изменения
            //mw.context.SaveChanges();
        }
    }
}
