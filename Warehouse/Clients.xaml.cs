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
using System.Windows.Shapes;
using System.Data.Linq;
using Warehouse.Classes;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        DataContext db = new DataContext(Properties.Settings.Default.conn);

        public Clients()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e) //добавление клиента
        {
            if (TBclientFio.Text != "" && TBclientAddress.Text != "" && TBclientNumber.Text != "")
            {
                Table<Client> clients = db.GetTable<Client>();
                Client client = new Client { fio = TBclientFio.Text, address = TBclientAddress.Text, number = TBclientNumber.Text, status = 1 };

                clients.InsertOnSubmit(client);
                db.SubmitChanges();
            }
            else MessageBox.Show("Введите данные о клиенте");
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e) //изменение данных клиента
        {
            try
            {
                Client client = (Client)DG_Clients.SelectedItem;

                TBclientFio.Text = client.fio;
                TBclientAddress.Text = client.address;
                TBclientNumber.Text = client.number;
            }
            catch (Exception)
            {

            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
