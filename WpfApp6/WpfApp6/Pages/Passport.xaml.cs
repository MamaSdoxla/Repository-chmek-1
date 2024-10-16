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
    /// Логика взаимодействия для Passport.xaml
    /// </summary>
    public partial class Passport : Page
    {
        public Passport()
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
            else if (switch4.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch5.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch6.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch7.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch8.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch9.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch10.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch11.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch12.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch13.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch14.Text == "")
            {
                MessageBox.Show("Ошибка", "Заполните text-box!!!");
            }
            else if (switch15.Text == "")
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
