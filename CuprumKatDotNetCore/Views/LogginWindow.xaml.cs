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
        public IsUser isUser { get; set; }
        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.WriteOffs
                var account = context.Users.FirstOrDefault(a => a.UPass == PassField.Password && a.ULog == LogIn.Content.ToString());
                if (account != null)
                {
                    Close();
                }
            }
        }
    }
}
