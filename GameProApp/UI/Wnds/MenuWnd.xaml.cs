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
using GameProApp.Data;
using System.Windows.Media.Animation;

namespace GameProApp
{
    /// <summary>
    /// Логика взаимодействия для MenuWnd.xaml
    /// </summary>
    public partial class MenuWnd : Window
    {
        private Brush originalBackground;
        public MenuWnd()
        {
            InitializeComponent();
            Manager.frame = frame;
            Manager.frame.Navigate(new TournamentsPg());

            MenuPanel.Visibility = Visibility.Collapsed;
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

        private void BurgerButton_Click(object sender, RoutedEventArgs e)
        {

            if (MenuPanel.Visibility == Visibility.Collapsed)
            {

                originalBackground = this.Background;

                MenuPanel.Background = originalBackground;

                // Перед открытием панели делаем все кнопки видимыми
                foreach (var button in MenuPanel.Children.OfType<Button>())
                {
                    button.Visibility = Visibility.Visible;
                }

                MenuPanel.Visibility = Visibility.Visible;
                BlurRectangle.Visibility = Visibility.Visible;
                BlurRectangle.Visibility = Visibility.Visible;
                MenuPanel.Width = 0;

                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 0.0;
                animation.To = 200.0;
                animation.Duration = TimeSpan.FromSeconds(1);

                MenuPanel.BeginAnimation(WidthProperty, animation);
            }
            else
            {
                DoubleAnimation closeAnimation = new DoubleAnimation();
                closeAnimation.To = 0;
                closeAnimation.Duration = TimeSpan.FromSeconds(0.3);

                // Создаем задачу для выполнения анимации закрытия
                Task animationTask = Task.Run(() =>
                {
                    // Ожидаем задержку перед анимацией закрытия
                    System.Threading.Thread.Sleep(25);

                    // Выполняем анимацию закрытия
                    Dispatcher.Invoke(() => MenuPanel.BeginAnimation(WidthProperty, closeAnimation));

                    // Ожидаем задержку после анимации закрытия
                    System.Threading.Thread.Sleep(300);
                });

                // При завершении задачи скрываем панель и делаем все кнопки видимыми
                animationTask.ContinueWith(task =>
                {
                    Dispatcher.Invoke(() =>
                    {

                        this.Background = originalBackground;
                        MenuPanel.ClearValue(BackgroundProperty);

                        MenuPanel.Visibility = Visibility.Collapsed;
                        BlurRectangle.Visibility = Visibility.Collapsed;

                        // При скрытии меню делаем все кнопки видимыми
                        foreach (var button in MenuPanel.Children.OfType<Button>())
                        {
                            button.Visibility = Visibility.Visible;
                        }
                    });
                });
            }
        }

        private void MenuPanel_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var button in MenuPanel.Children.OfType<Button>())
            {
                button.Visibility = Visibility.Visible;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            AuthWnd authWnd = new AuthWnd();
            authWnd.Show();
            this.Close();
        }

        private void btnTournaments_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new TournamentsPg());
        }

        private void btnPlayers_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new PlayersPg());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new TeamsPg());
        }

        private void btnMatches_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new MatchesPg());
        }
    }
}
