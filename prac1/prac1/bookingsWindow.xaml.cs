using System;
using System.Collections.Generic;
using System.Data;
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
using prac1.BeautySalDataSetTableAdapters;

namespace prac1
{
    /// <summary>
    /// Логика взаимодействия для bookingsWindow.xaml
    /// </summary>
    public partial class bookingsWindow : Window
    {
        BookingsTableAdapter adapter = new BookingsTableAdapter();

        public bookingsWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            adapter.InsertQuery(Convert.ToInt32(tbSampleA.Text), Convert.ToInt32(tbSampleB.Text));
            bookings.ItemsSource = adapter.GetData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            object id = (bookings.SelectedItem as DataRowView).Row[0];
            adapter.DeleteQuery(Convert.ToInt32(id));
            bookings.ItemsSource=adapter.GetData(); 
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            object id = (bookings.SelectedItem as DataRowView).Row[0];
            adapter.UpdateQuery(Convert.ToInt32(tbSampleA.Text), Convert.ToInt32(tbSampleB.Text),Convert.ToInt32(id));
            bookings.ItemsSource = adapter.GetData();
        }
    }
}
