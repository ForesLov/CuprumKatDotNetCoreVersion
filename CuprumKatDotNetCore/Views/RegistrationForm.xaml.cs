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
    public enum FormType
    {
        Edit, Create
    }
    /// <summary>
    /// Логика взаимодействия для RegistrationForm.xaml
    /// </summary>

    public partial class RegistrationForm : Window
    {
        FormType formType;
        User formUser;
        public RegistrationForm(FormType ft, User? user = null)
        {
            InitializeComponent();
            if (ft == FormType.Create || user is null)
            {
                formType = FormType.Create;
                formUser = new User();
            }
            else if(ft == FormType.Edit&&user!=null)
            {
                formType = FormType.Edit;
                formUser = user;
            }
            this.DataContext = user;
            using (var context = new ApplicationDbContext())
            {
                foreach (var item in context.CompanyPoses)
                {
                    PoseBox.Items.Add(item);
                }
                PoseBox.Items.Add(null); 
            }
        }

        private void CreationUserButton_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                User user = new User() { ULname = LNameField.Text, UName = UNameField.Text, USname = SNameField.Text, UAddress = AdressField.Text, UEmail = EmailField.Text, UphoneNumber = PhoneNumberField.Text, ULog = U_Log_Field.Text, UPass = U_Pass_Field.Text };

                context.SaveChanges();
            }
        }
    }
}
