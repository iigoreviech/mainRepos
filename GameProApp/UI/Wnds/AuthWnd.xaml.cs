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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameProApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWnd : Window
    {
        public AuthWnd()
        {
            InitializeComponent();
        }

        private void btnExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnSvernut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void tbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (tbPassword.Password.Length > 0)
            {
                Watermark.Visibility = Visibility.Collapsed;
            }
            else
            {
                Watermark.Visibility=Visibility.Visible;
            }

            if (VisiblePasswordTextBox != null && tbPassword != null)
            {
                VisiblePasswordTextBox.Text = tbPassword.Password;
            }
        }

        private void TogglePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbPassword != null && VisiblePasswordTextBox != null)
            {
                if (VisiblePasswordTextBox.Visibility == Visibility.Collapsed)
                {
                    tbPassword.Visibility = Visibility.Collapsed;
                    VisiblePasswordTextBox.Visibility = Visibility.Visible;
                    VisiblePasswordTextBox.Text = tbPassword.Password;
                    ShowPasswordImage.Source = new BitmapImage(new Uri("/Resources/Imgs/eye open.png", UriKind.Relative));
                }
                else
                {
                    tbPassword.Visibility = Visibility.Visible;
                    VisiblePasswordTextBox.Visibility = Visibility.Collapsed;
                    tbPassword.Password = VisiblePasswordTextBox.Text;
                    ShowPasswordImage.Source = new BitmapImage(new Uri("/Resources/Imgs/eye hide.png", UriKind.Relative));
                }
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = AppData.db.Users.FirstOrDefault(u => u.login == tbLogin.Text && u.password == tbPassword.Password);

            if (currentUser != null)
            {
                Manager.User = currentUser;
                MenuWnd menuWnd = new MenuWnd();
                menuWnd.Show();
                this.Close();
                if (Manager.User.idRole == 1)
                {
                    MessageBox.Show("С возвращением! Вы зашли в систему в роли Администратор.", "GamePro", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("С возвращением! Вы зашли в систему в роли Пользователь.", "GamePro", MessageBoxButton.OK);
                }

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
