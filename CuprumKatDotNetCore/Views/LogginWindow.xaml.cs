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
    /// Логика взаимодействия для LogginWindow.xaml
    /// </summary>
    public partial class LogginWindow : Window
    {
        public LogginWindow()
        {
            InitializeComponent();
        }
        public User User { get; set; }
        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                /*var User = new User() { Id = 228, ULog = "admin", UPass = "admin" };
                context.Users.Add(User);
                var role = new CompanyPose() { Id = 1, PoseName = "Сисадмин" };
                context.CompanyPoses.Add(role);
                var storehouse = new Storehouse() { Id = 1, StorePurpose = "Руда" };
                context.Storehouses.Add(storehouse);
                context.SaveChanges();*/

                User = context.Users.FirstOrDefault(a => a.UPass == PassField.Password && a.ULog == LogField.Text);
                if (User != null)
                {
                    Close();
                }
                else
                {
                    string a = "";
                    foreach (var item in context.Users)
                    {
                        a += $"{item.Id} {item.UName} {item.ULog} {item.UPass}\n";
                    }
                    MessageBox.Show(a);
                }
            }
        }
    }
}
