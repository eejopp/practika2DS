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
    /// Логика взаимодействия для servicessWindow.xaml
    /// </summary>
    public partial class servicessWindow : Window
    {

        ServicessTableAdapter adapter = new ServicessTableAdapter();

        public servicessWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            adapter.InsertQuery(tbSampleA.Text,decimal.Parse(tbSampleB.Text),int.Parse(tbSampleDuration.Text));
            servicess.ItemsSource = adapter.GetData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            object id = (servicess.SelectedItem as DataRowView).Row[0];
            adapter.DeleteQuery(Convert.ToInt32(id));
            servicess.ItemsSource = adapter.GetData();

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            object id = (servicess.SelectedItem as DataRowView).Row[0];
            adapter.UpdateQuery(tbSampleA.Text, decimal.Parse(tbSampleB.Text), int.Parse(tbSampleDuration.Text), Convert.ToInt32(id));
            servicess.ItemsSource = adapter.GetData();
        }
    }
}
