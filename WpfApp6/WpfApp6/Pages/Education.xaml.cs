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
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (switchone.IsChecked == false && switchtwo.IsChecked == false && switchthree.IsChecked == false && switchfour.IsChecked == false)
            {
                MessageBox.Show("Ошибка", "Написано же выберите 1!!!");
            }
            else if (switchfive.IsChecked == false && switchsix.IsChecked == false)
            {
                MessageBox.Show("Ошибка", "Написано же выберите 1!!!");
            }
            else if (switchseven.Text == "")
            {
                MessageBox.Show("Ошибка", "Напишите что-нибудь в text-box!");
            }
            else if (switcheight.Text == "")
            {
                MessageBox.Show("Ошибка", "Напишите что-нибудь в text-box!");
            }
            else if (switchnine.Text == "")
            {
                MessageBox.Show("Ошибка", "Напишите что-нибудь в text-box!");
            }
            else
            {
                //perevod na sled
            }
        }
    }
}
