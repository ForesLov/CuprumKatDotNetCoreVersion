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
        public long am;
        public double pf;
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
            string itemtext1 = ManufBox.SelectedItem.ToString();
            string itemtext2 = StoreField.SelectedItem.ToString();
            if (string.IsNullOrEmpty(itemtext1)
                | string.IsNullOrEmpty(itemtext2)
                | string.IsNullOrEmpty(NameField.Text)
                | string.IsNullOrEmpty(MeasureField.Text)
                | string.IsNullOrEmpty(AmountField.Text)
                | string.IsNullOrEmpty(PriceField.Text)
                )
            {
                MessageBox.Show("Ошибка! Не все поля заполнены");
                return;
            }
            else if (!long.TryParse(AmountField.Text, out am) | !(double.TryParse(PriceField.Text, out pf)))
            {
                MessageBox.Show("Ошибка! В полях с количеством и ценой дожны быть числа!");
            }
            else
            {
                using (var context = new ApplicationDbContext())
                {
                    Product product = new Product() { ProductName = NameField.Text, Manufacturers = (ManufBox.SelectedItem as Manufacturer), ProductAmount = int.Parse(AmountField.Text), ProductMeasure = MeasureField.Text, ProductPrice = int.Parse(PriceField.Text), Storehouses = (StoreField.SelectedItem as Storehouse) };
                    context.SaveChanges();
                    Close();
                }
            }
        }
    }
}
