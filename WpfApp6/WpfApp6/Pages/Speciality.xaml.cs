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
    /// Логика взаимодействия для Speciality.xaml
    /// </summary>
    public partial class Speciality : Page
    {
        public Speciality()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (switch1.IsChecked == false && switch2.IsChecked == false && switch3.IsChecked == false && switch4.IsChecked == false && switch5.IsChecked == false && switch6.IsChecked == false && switch7.IsChecked == false && switch8.IsChecked == false && switch9.IsChecked == false && switch10.IsChecked == false)
            {
                MessageBox.Show("Ошибка", "Написано же выберите 1 или несколько!!!");
            }
            else if (switch11.IsChecked == false && switch12.IsChecked == false)
            {
                MessageBox.Show("Ошибка", "Написано же выберите 1!!!");
            }
            else if (switch13.IsChecked == false)
            {
                MessageBox.Show("Ошибка", "Вы не подписали лицензию!!!");
            }
            else if (switch14.IsChecked == false)
            {
                MessageBox.Show("Ошибка", "Вы не ознакомились!!!");
            }
            else
            {
                //perevod na sled
            }
        }
    }
}
