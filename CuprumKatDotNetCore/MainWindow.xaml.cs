using CuprumKatDotNetCore.Database;
using CuprumKatDotNetCore.Modeles;
using CuprumKatDotNetCore.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace CuprumKatDotNetCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurrentUser = LogIn();
            if (CurrentUser is null) Close();
        }
        void UpdateDataGrid(DataGrid dataGrid, IEnumerable<Object> items)
        {
            dataGrid.Items.Clear();
            dataGrid.ItemsSource= items;

        }
        private User? LogIn()
        {
            Hide();
            var login = new LogginWindow();
            login.ShowDialog();
            Show();
            return login.User;
        }

        private void CreateInventarB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InvUpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateUserB_Click(object sender, RoutedEventArgs e)
        {
                        
            var u = new RegistrationForm(FormType.Create);
            u.ShowDialog();
        }

        private void UserUpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateDelB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DelivUpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportCreateForm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateProductB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductUpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserList_Loaded(object sender, RoutedEventArgs e)
        {
            using (var c = new ApplicationDbContext())
            {
                c.Users.Load();
                UpdateDataGrid(dataGridUsers, c.Users.ToList());
            }
        }

        private void InventorisationList_Loaded(object sender, RoutedEventArgs e)
        {
            /*using (var c = new ApplicationDbContext())
            {
                UpdateDataGrid(dataGridInv, c.writeOffs);
            }*/
        }

        private void DeliveList_Loaded(object sender, RoutedEventArgs e)
        {
           /* using (var c = new ApplicationDbContext())
            {
                UpdateDataGrid(dataGridDeliv, c.deliveryViews);
            }*/
        }

        private void ProdustT_Loaded(object sender, RoutedEventArgs e)
        {
            /*using (var c = new ApplicationDbContext())
            {
                UpdateDataGrid(dataGridProduct, c.Products);
            }*/
        }
        private User? CurrentUser { get; set; }

        private void EditUserB_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridUsers.SelectedItem != null)
            {
                var u = new RegistrationForm(FormType.Edit, dataGridUsers.SelectedItem as User);
                u.ShowDialog();
            }
        }
    }
}
