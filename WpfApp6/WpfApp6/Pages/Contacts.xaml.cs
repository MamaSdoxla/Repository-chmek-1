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

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (switch1.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch2.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch3.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else
            {
                //perevod na sled
            }
        }
    }
}
