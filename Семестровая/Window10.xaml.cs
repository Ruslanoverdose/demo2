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
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public Window10()
        {
            InitializeComponent();
        }
        public Window5 w5;
        private void EditButtton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = Int32.Parse(groupIDTextBox.Text);

                var group = w5.mw.context.Groups
                    .Where(c => c.GroupID == k)
                    .FirstOrDefault();
                group.Name = nameTextBox.Text;
                group.Description = descriptionTextBox.Text;
                w5.grViewSource.View.Refresh();
                w5.mw.context.SaveChanges();

            }
            catch
            {
                MessageBox.Show("Проверьте данные");
            }
        }

        private void window10_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
