using CuprumKatDotNetCore.Database;
using CuprumKatDotNetCore.Modeles;
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

namespace CuprumKatDotNetCore.Windows
{
    /// <summary>
    /// Логика взаимодействия для CreateProductWindow.xaml
    /// </summary>
    public partial class CreateProductWindow : Window
    {
        public CreateProductWindow()
        {
            InitializeComponent();
            using (var context = new ApplicationDbContext())
            {
                foreach (var item in context.Manufacturers)
                {
                    ManufBox.Items.Add(item);
                }
                ManufBox.Items.Add(null);
                foreach (var item in context.Storehouses)
                {
                    StoreField.Items.Add(item);
                }
            }

        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                Product product = new Product() {ProductName = NameField.Text, Manufacturers = (ManufBox.SelectedItem as Manufacturer), ProductAmount = int.Parse(AmountField.Text), ProductMeasure = MeasureField.Text, ProductPrice = int.Parse(PriceField.Text), Storehouses = (StoreField.SelectedItem as Storehouse)};
            }

        }
    }
}
