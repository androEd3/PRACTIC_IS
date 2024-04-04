using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pawre_eareaf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class User
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        //ВИДИМОСТЬ ПАРОЛЯ
        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        //ВХОД
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string password = pass.Text;

            var loginnn = login.Text;

            var passs = pass.Text;

            var context = new AddDbContecxt();

            if (password.Contains('!') || password.Contains('@') || password.Contains('#') || password.Contains('$') || password.Contains('%') || password.Contains('^') || password.Contains('*') || password.Contains('(') || password.Contains(')') || password.Contains('_') || password.Contains('-') || password.Contains('=') || password.Contains('+'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderThickness = new Thickness(0.5);
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = "";
                pass.BorderBrush = Brushes.Black;
            }

            else
            {
                var user_exeists = context.Users.FirstOrDefault(x => x.Login == loginnn && x.Password == passs);

                if (user_exeists is null)
                {
                    invalid_parol.Text = "Неверные данные";
                    return;
                }
                else
                {
                    Window2 acc = new Window2();
                    acc.Show();
                    Close();
                }
            }
        }

        //РЕГИСТРАЦИЯ

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window1 reg = new();
            reg.Show();
            Close();
        }
    }
}