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
    /// Логика взаимодействия для DelivWindow.xaml
    /// </summary>
    public partial class DelivWindow : Window
    {
        private User user;

        public DelivWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            using (var context = new ApplicationDbContext())
            {
                foreach (var item in context.Products)
                {
                    NameCombox.Items.Add(new Label() { Content = item });
                }
            }
        }
        string Cost()
        {
            int.TryParse(Amount_Field.Text, out int amount);
            using (var context = new ApplicationDbContext())
            {
                var cost = context.Products.First(p => p.Id == ((NameCombox.SelectedItem as Label).Content as Product).Id).ProductPrice * amount;
                return cost.ToString();
            }
        }

        private void Amount_Field_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameCombox.SelectedItem != null)
                CostField.Text = Cost();
        }

        private void NameCombox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CostField.Text = Cost();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameCombox.SelectedItem == null

               | string.IsNullOrEmpty(Amount_Field.Text)
               | !int.TryParse(Amount_Field.Text, out int amountdelv)
               | amountdelv < 0
               )
            {
                MessageBox.Show("Ошибка! Есть какая-то ошибка!");
            }
            else
            {
                using (var context = new ApplicationDbContext()) 
                {
                    EDelivery delivery = new EDelivery() { DelivAmount = amountdelv,
                        DelivCost = decimal.Parse(CostField.Text),
                        DelivDate = DateTime.Now,
                        Products = context.Products.First( p=> p.Id == ((NameCombox.SelectedItem as Label).Content as Product).Id),
                        UId = context.Users.First(u=> u.Id == user.Id) 
                    };      
                    context.Add(delivery);
                    context.SaveChanges();
                    Close();
                }
            }
        }
    }
}
