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
using prac1.BeautySalDataSetTableAdapters;

namespace prac1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookingsTableAdapter bookings = new BookingsTableAdapter();
        private ClientsTableAdapter clients = new ClientsTableAdapter();
        private ServicessTableAdapter servicess = new ServicessTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new bookingsWindow();
            window.bookings.ItemsSource = bookings.GetData();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new clientsWindow();
            window.clients.ItemsSource = clients.GetData();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var window = new servicessWindow();
            window.servicess.ItemsSource = servicess.GetData();
            window.Show();
        }
    }
}
