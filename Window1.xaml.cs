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
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        //ЗАРЕГИСТРИРОВАТЬСЯ
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string password = parol.Text;

            if (loginAGAIN.Text.Length > 16)
            {
                loginAGAIN.Text = "слишком длинный логин";
                loginAGAIN.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                loginAGAIN.Text = "";
                loginAGAIN.BorderBrush = Brushes.Black;
                loginAGAIN.BorderThickness = new Thickness(0.5);
            }
            else if (parol.Text != parolA.Text)
            {
                parol.Text = "пароли не совпадают!";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);

                parolA.Text = "";


            }
            else if (loginAGAIN.Text.Length < 3)
            {
                loginAGAIN.Text = "логин должен содержать хотя бы 3 символа";
                loginAGAIN.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                loginAGAIN.Text = "";
                loginAGAIN.BorderBrush = Brushes.Black;
                loginAGAIN.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('!'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
            }

            else if (password.Contains('@'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('#'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('$'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('%'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }

            else if (password.Contains('^'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('*'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('('))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains(')'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('_'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('-'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('='))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else if (password.Contains('+'))
            {
                parol.Text = "недопустимый символ";
                parol.BorderBrush = Brushes.Red;
                await Task.Delay(2000);
                parol.Text = "";
                parol.BorderBrush = Brushes.Black;
                parol.BorderThickness = new Thickness(0.5);
            }
            else
            {
                
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
