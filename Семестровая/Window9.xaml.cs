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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
        }
        public Window5 w5;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = Int32.Parse(groupIDTextBox.Text);
            Groups group = w5.mw.context.Groups
                .Where(c => c.GroupID == k)
                .FirstOrDefault();

            w5.mw.context.Entry(group)
                .Collection(c => c.Users)
                .Load();

            w5.mw.context.Groups.Remove(group);
            //w5.mw.groupViewSource.View.Refresh();
            w5.mw.context.SaveChanges();
        }

        private void window9_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
