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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
namespace Семестровая
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public Users newUser { get; set; }
        public Groups newGroup { get; set; }
        public Albums newAlbum { get; set; }
       public UserEntities context = new UserEntities();

        public CollectionViewSource usViewSource;
        



        public MainWindow()
        {
            InitializeComponent();
            newGroup = new Groups();
            newUser = new Users();
            newAlbum = new Albums();
            usViewSource = ((CollectionViewSource)(FindResource("usersViewSource")));
            DataContext = this;
            w1.mw = this;
            w3.mw = this;
            w2.mw = this;
            w5.mw = this;
            w4.mw = this;
          
        }
        Window1 w1 = new Window1();
        Window3 w3 = new Window3();
      public  Window5 w5 = new Window5();
      
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

          //  System.Windows.Data.CollectionViewSource usersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usersViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // usersViewSource.Source = [универсальный источник данных]

            context.Users.Load();
            usViewSource.Source = context.Users.Local;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            w1.Show();
        }
        Window2 w2 = new Window2();
        private void UpdateBUt_Click(object sender, RoutedEventArgs e)
        {
            w2.Show();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            w3.Show();
        }

        private void usersDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
          
        }

        private void usersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        Window4 w4 = new Window4();
        private void usersDataGrid_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                int Client = -1;


                var selectedCell = usersDataGrid.SelectedCells[0];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                int ind = usersDataGrid.SelectedIndex;
                var ci = new DataGridCellInfo(usersDataGrid.Items[ind], usersDataGrid.Columns[0]);
                var content = ci.Column.GetCellContent(ci.Item) as TextBlock;
                Client = (int)Convert.ToInt32(content.Text);
        
                Users user = context.Users.Find(Client);
                if (user != null)
                {
                    w4.NameLabel.Content = "Имя: " + user.FirstName;
                    w4.LastNameLab.Content = "Фамилия: " + user.LastName;
                    if (user.Gender == true) w4.genLab.Content = "Пол: мужской";
                    else w4.genLab.Content = "Пол: женский";
                    w4.EmailLab.Content = "Email: " + user.Email;
                    // btm.Source. = user.Description;
                    w4.Birthlabel.Content = "Дата рождения: " + user.DataReg.Year + ":" + user.DataReg.Month + ":" + user.DataReg.Day;

                    try
                    {
                        BitmapImage myBitmapImage1 = new BitmapImage();

                        myBitmapImage1.BeginInit();
                        myBitmapImage1.UriSource = new Uri(user.PhotoPath, UriKind.Absolute);
                        myBitmapImage1.EndInit();
                        w4.PhotoImage.Source = myBitmapImage1;
                    }
                    catch
                    {
                        //BitmapImage myBitmapImage1 = new BitmapImage();

                        //myBitmapImage1.BeginInit();
                        //myBitmapImage1.UriSource = new Uri(@"pic.jpg", UriKind.RelativeOrAbsolute);
                        //myBitmapImage1.EndInit();
                        //w4.PhotoImage.Source = myBitmapImage1;
                    }

                }
                w4.Show();
            }
            catch { MessageBox.Show("Ошибка"); }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonGroups_Click(object sender, RoutedEventArgs e)
        {
            w5.Show();
        }

        private void firstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           

         
            
        }

        private void txBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            usViewSource.Filter += CollectionViewSource_Filter;


        }

        private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            if(txBox1.Text != "")
                e.Accepted = ((Users)e.Item).FirstName.Equals(txBox1.Text);
            if (txBox2.Text != "")
                e.Accepted = ((Users)e.Item).FirstName.Equals(txBox2.Text);
      
        }

        private void txBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
                usViewSource.Filter += CollectionViewSource_Filter;
        }
    }
}
