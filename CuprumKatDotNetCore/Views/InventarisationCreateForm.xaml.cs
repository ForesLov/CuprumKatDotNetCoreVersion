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
    /// Логика взаимодействия для InventarisationCreateForm.xaml
    /// </summary>
    public partial class InventarisationCreateForm : Window
    {
        private User user;
        public InventarisationCreateForm(User user)
        {
            InitializeComponent();
            this.user = user;
            using (var context = new ApplicationDbContext())
            {
                foreach (var item in context.Products)
                {
                    ProductBox.Items.Add(new Label() { Content = item });
                }
            }
        }

        private void ProductBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SumSpisField.Text = Cost();
        }
        string Cost()
        {
            int.TryParse(Amount_Field.Text, out int amount);
            using (var context = new ApplicationDbContext())
            {
                var cost = context.Products.First(p => p.Id == ((ProductBox.SelectedItem as Label).Content as Product).Id).ProductPrice * amount;
                return cost.ToString();
            }
        }
        private void Amount_SpisField_TextChanged(object sender, TextChangedEventArgs e)
        {
            SumSpisField.Text = Cost();
        }

        private void CreateInvB_Click(object sender, RoutedEventArgs e)
        {
            if (ProductBox.SelectedItem == null

               | string.IsNullOrEmpty(Amount_Field.Text)
               | !int.TryParse(Amount_Field.Text, out int amountoff)
               | amountoff < 0
               )
            {
                MessageBox.Show("Ошибка! Есть какая-то ошибка!");
            }
            else
            {
                using (var context = new ApplicationDbContext())
                {
                    ProductWriteOff productWriteOff = new ProductWriteOff()
                    {
                        DateOff = DateTime.Now,
                        AmountOff = int.Parse(Amount_Field.Text),
                        CostOff = decimal.Parse(SumSpisField.Text),
                        product = context.Products.First(p => p.Id == ((ProductBox.SelectedItem as Label).Content as Product).Id),
                        Users = context.Users.First(u => u.Id == user.Id)
                    };
                    context.ProductWriteOffs.Add(productWriteOff);
                    context.SaveChanges();
                    Close();
                }
            }
        }
    }
}
