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
using System.IO;
using System.Xml.Serialization;

namespace HWork_10._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Account> accounts = new List<Account>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Account acc = new Account();
            acc = new Konsult();
            
            //добавление новых счетов
            //(acc as Konsult).Add(Convert.ToString(surname.Text), Convert.ToString(firstname.Text), Convert.ToString(lastname.Text), 
            //    Convert.ToInt64(phnumber.Text), Convert.ToString(pasport.Text));
            //accounts.Add(acc);

            accounts = (acc as Konsult).read(); //чтение данных из файла
            Grid.Items.Refresh();
            Grid.ItemsSource = accounts;        //вывод данных в датагрид
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Account acc = new Account();
            acc.write(accounts);                //перезапись файла с изменениями
        }

    }
}
