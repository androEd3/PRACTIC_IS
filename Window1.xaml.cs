using Microsoft.EntityFrameworkCore;
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

namespace pawre_eareaf
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class AddDbContecxt : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=pensil;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        //ЗАРЕГИСТРИРОВАТЬСЯ
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string password1 = parol.Text;
            string password2 = parolA.Text;
            string loginn = loginAGAIN.Text;

            if (loginAGAIN.Text.Length > 16 || loginAGAIN.Text.Length < 3)
            {
                loginAGAIN.Text = "Логин должен содержать от 3 до 16 символов";
                loginAGAIN.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                loginAGAIN.Text = loginn;
                loginAGAIN.BorderBrush = Brushes.Black;
                loginAGAIN.BorderThickness = new Thickness(0.5);
            }

            else if (parol.Text != parolA.Text)
            {
                parol.Text = "Пароли не совпадают!";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = password1;
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);

                parolA.Text = password2;
            }

            else if (password1.Contains('!') || password1.Contains('@') || password1.Contains('#') || password1.Contains('$') || password1.Contains('%') || password1.Contains('^') || password1.Contains('*') || password1.Contains('(') || password1.Contains(')') || password1.Contains('_') || password1.Contains('-') || password1.Contains('=') || password1.Contains('+'))
            {
                parol.Text = "Недопустимый символ";
                parol.BorderThickness = new Thickness(0.5);
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
            }

            else
            {
                var login = loginAGAIN.Text;
                
                var PochtaPolz = pochta.Text;

                var pass = parol.Text;

                var context = new AddDbContecxt();

                var user_exeists = context.Users.FirstOrDefault(x => x.Login == login);

                if (user_exeists is not null)
                {
                    MessageBox.Show("Этот пользователь уже зареган");
                    return;
                }

                else
                {
                    var user = new User { Login = login, Email = PochtaPolz, Password = pass };
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Вы успешно зарегистрированны");

                    MainWindow vhod = new MainWindow();
                    vhod.Show();
                    Close();
                }
            }
        }

        //НАЗАД
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow vhod = new ();
            vhod.Show();
            this.Close();
        }
    }
}
