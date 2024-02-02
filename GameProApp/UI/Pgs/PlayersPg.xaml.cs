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
using GameProApp.Data;

namespace GameProApp
{
    /// <summary>
    /// Логика взаимодействия для PlayersPg.xaml
    /// </summary>
    public partial class PlayersPg : Page
    {
        public PlayersPg()
        {
            InitializeComponent();
            var currentPlayer = AppData.db.Players.ToList();
            PageLoaded();

            var allCountries = AppData.db.Countries.Where(c => c.Players.Count != 0).ToList();
            allCountries.Insert(0, new Country { countryName = "Все страны" });
            comboCountries.DisplayMemberPath = "countryName";
            comboCountries.ItemsSource = allCountries;
            comboCountries.SelectedIndex = 0;

            var allPositions = AppData.db.GameRoles.Where(c => c.Players.Count != 0).ToList();
            allPositions.Insert(0, new GameRole { titleRole = "Все позиции" });
            comboPositions.DisplayMemberPath = "titleRole";
            comboPositions.ItemsSource = allPositions;
            comboPositions.SelectedIndex = 0;

            UpdatePlayers();
        }

        public void UpdatePlayers()
        {
            var players = AppData.db.Players.ToList();

            players = players.Where(p => p.gameNickname.Replace(" ", "").ToLower().Contains(tbSearchPlayer.Text.Replace(" ", "").ToLower())).ToList();

            if (comboCountries.SelectedIndex > 0)
                players = players.Where(p => p.Country == comboCountries.SelectedItem as Country).ToList();

            if (comboPositions.SelectedIndex > 0)
                players = players.Where(p => p.GameRole1 == comboPositions.SelectedItem as GameRole).ToList();

            lvPlayers.Items.Clear();
            foreach (var player in players)
                lvPlayers.Items.Add(new PlayerUC(player));

            if (players.Count == 0)
            {
                tbNoResults.Visibility = Visibility.Visible;
            }
            else
            {
                tbNoResults.Visibility = Visibility.Collapsed;
            }
        }

        public void PageLoaded()
        {
            if (Manager.User.idRole == 2)
            {
                adminBtns.Visibility = Visibility.Collapsed;
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AppData.db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                lvPlayers.ItemsSource = AppData.db.Players.ToList();
            }
        }

        private void tbSearchPlayer_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePlayers();
        }

        private void comboCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdatePlayers();
        }

        private void comboPositions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdatePlayers();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddEditPlayerPg(null));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var playerForEdit = lvPlayers.SelectedItem as PlayerUC;
            if (playerForEdit != null)
            {
                var selectedPlayer = playerForEdit.Player;
                Manager.frame.Navigate(new AddEditPlayerPg(selectedPlayer));
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var playersForDelete = lvPlayers.SelectedItems.Cast<PlayerUC>().ToList();

            if (playersForDelete.Count == 0)
            {
                return;
            }

            if (MessageBox.Show($"Вы точно хотите удалить следующие {playersForDelete.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    List<Player> players = new List<Player>();
                    foreach (var player in playersForDelete)
                    {
                        players.Add(player.Player);
                    }
                    AppData.db.Players.RemoveRange(players);
                    AppData.db.SaveChanges();
                    UpdatePlayers();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
