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
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (switchone.IsChecked == true && switchtwo.IsChecked == true)
            {
                MessageBox.Show("Ошибка", "Написано же выберите 1!!!");
            }
            else if (switchone.IsChecked == true && switchtwo.IsChecked == false)
            {
                if (switchthree.IsChecked == true && switchfour.IsChecked == true)
                {
                    MessageBox.Show("Ошибка", "Написано же выберите 1!!!");
                }
                else if (switchfive.Text == "")
                {
                    MessageBox.Show("Ошибка", "Напишите что-нибудь в text-box!");
                }
                else
                {
                    if (switchsix.Text == "")
                    {
                        MessageBox.Show("Ошибка", "Напишите что-нибудь в text-box!");
                    }
                    else
                    {
                        if (switchone.IsChecked == false && switchtwo.IsChecked == false)
                        {
                            MessageBox.Show("Ошибка", "Выберите один из вариантов!");
                        }
                        else if (switchthree.IsChecked == false && switchfour.IsChecked == false)
                        {
                            MessageBox.Show("Ошибка", "Выберите один из вариантов!");
                        }
                        else
                        {
                            //perevod na sled
                        }
                    }
                }
            }
            else
            {
                //perevod na sled
            }
        }
    }
}
