using prac1.BeautySalDataSetTableAdapters;
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


namespace prac1
{
    /// <summary>
    /// Логика взаимодействия для clientsWindow.xaml
    /// </summary>
    public partial class clientsWindow : Window
    {
        ClientsTableAdapter adapter = new ClientsTableAdapter();
        public clientsWindow()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            adapter.InsertQuery(tbSampleA.Text, tbSampleB.Text, tbSampleC.Text, tbSampleD.Text, tbSampleE.Text);
            clients.ItemsSource = adapter.GetData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            object id = (clients.SelectedItem as DataRowView).Row[0];
            adapter.DeleteQuery(Convert.ToInt32(id));
            clients.ItemsSource = adapter.GetData();

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            object id = (clients.SelectedItem as DataRowView).Row[0];
            adapter.UpdateQuery(tbSampleA.Text, tbSampleB.Text, tbSampleC.Text, tbSampleD.Text, tbSampleE.Text, Convert.ToInt32(id));
            clients.ItemsSource = adapter.GetData();
        }
    }
}
