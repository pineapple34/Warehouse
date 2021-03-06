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
using System.Data;
using System.Data.Linq;
using Warehouse.Classes;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        DataContext db = new DataContext(Properties.Settings.Default.conn);

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TBlogin.Text != null && TBpass.Text != null)
            {
                int users = (db.GetTable<User>().Where(u => u.login == TBlogin.Text && u.pass == TBpass.Text)).Count();

                if (users == 1)
                {
                    MainWindow w = new MainWindow();
                    w.Show();
                    Hide();
                }
                else MessageBox.Show("Неверные данные");
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
