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
using System.Data;
using System.Data.Linq;
using Warehouse.Classes;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        DataContext db = new DataContext(Properties.Settings.Default.conn);

        public Registration()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if (TBfio.Text != null && TBlogin.Text != null && TBpass.Text != null)
            {
                Table<User> users = db.GetTable<User>();
                User user = new User { fio = TBfio.Text, login = TBlogin.Text, pass = TBpass.Text, admin = 0 };

                int check = (from u in users where u.login == user.login select u).Count();

                if (check == 0)
                {
                    users.InsertOnSubmit(user);
                    db.SubmitChanges();

                    MessageBox.Show("Регистрация прошла успешно");

                    Close();
                }
                else MessageBox.Show("Пользователь с таким именем существует");
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

