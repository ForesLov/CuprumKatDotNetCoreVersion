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

namespace CuprumKatDotNetCore.Views
{
    /// <summary>
    /// Логика взаимодействия для ManufacturerCreateForm.xaml
    /// </summary>
    public partial class ManufacturerCreateForm : Window
    {
        public ManufacturerCreateForm()
        {
            InitializeComponent();
        }

        private void CreateCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            if (
                string.IsNullOrEmpty(companyNameTextBox.Text)
                | string.IsNullOrEmpty(companyPhoneTextBox.Text)
                | string.IsNullOrEmpty(companyLocationTextBox.Text)
                | string.IsNullOrEmpty(mailTextBox.Text)
                | string.IsNullOrEmpty(OGRNTextBox.Text)
                | string.IsNullOrEmpty(INNTextBox.Text)
                | string.IsNullOrEmpty(OKPOTextBox.Text)
                | string.IsNullOrEmpty(OKVEDTextBox.Text)
                | string.IsNullOrEmpty(representativeFirstNameTextBox.Text)
                | string.IsNullOrEmpty(representativeSurnameTextBox.Text)
                | string.IsNullOrEmpty(representativeLastNameTextBox.Text)
                | string.IsNullOrEmpty(representativePhone.Text)
                | string.IsNullOrEmpty(representativeMailTextBox.Text)
                | string.IsNullOrEmpty(CEOFirstNameTextBox.Text)
                | string.IsNullOrEmpty(CEOSurnameTextBox.Text)
                | string.IsNullOrEmpty(CEOLastNameTextBox.Text)
                )
            {
                MessageBox.Show("не все поля заполнены.");
                return;
            }
            if (
                !long.TryParse(representativePhone.Text, out long num)
                | !long.TryParse(companyPhoneTextBox.Text, out num)
                )
            {
                MessageBox.Show("В поля типа \"Номер телефона\" можно вводить только числа без пробелов и иных символов.");
                return;
            }
            else
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    Manufacturer manufacturer = new Manufacturer() { CeoLname = CEOLastNameTextBox.Text, CeoName = CEOFirstNameTextBox.Text, CeoSname = CEOSurnameTextBox.Text, CompanyName = companyNameTextBox.Text, Email = mailTextBox.Text, Inn = INNTextBox.Text, Okpo = OKPOTextBox.Text, Ogrn = OGRNTextBox.Text, Okved = OKVEDTextBox.Text, PhoneNumber = companyPhoneTextBox.Text, RepresLname = representativeLastNameTextBox.Text, RespersName = representativeFirstNameTextBox.Text, RespersPhone = representativePhone.Text, RespersSname = representativeSurnameTextBox.Text, UrAddress = companyLocationTextBox.Text };
                    context.Manufacturers.Add(manufacturer);
                    context.SaveChanges();
                    Close();
                }
            }
        }
    }
}
