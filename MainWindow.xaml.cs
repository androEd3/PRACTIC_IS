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

        //ВИДИМОСТЬ ПАРОЛЯ
        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        //ВХОД
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string password = pass.Text;

            if (password.Contains('!'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
            }

            else if (password.Contains('@'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('#'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('$'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('%'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('^'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('*'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('('))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains(')'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('_'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('-'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('='))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('+'))
            {
                pass.Text = "Недопустимый символ";
                pass.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                pass.Text = password;
                pass.BorderBrush = Brushes.CadetBlue;
                pass.BorderThickness = new Thickness(0.5);
            }

            else
            {

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