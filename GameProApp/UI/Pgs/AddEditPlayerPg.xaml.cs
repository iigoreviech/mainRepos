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
using System.Collections.ObjectModel;

namespace GameProApp
{
    /// <summary>
    /// Логика взаимодействия для AddEditPlayerPg.xaml
    /// </summary>
    public partial class AddEditPlayerPg : Page
    {
        private Player _currentPlayer = new Player();

        public AddEditPlayerPg(Player selectedPlayer)
        {
            InitializeComponent();

            if (selectedPlayer != null)
                _currentPlayer = selectedPlayer;

            DataContext = _currentPlayer;

            var allTeams = new ObservableCollection<Team>(AppData.db.Teams);
            comboTeams.DisplayMemberPath = "teamName";
            comboTeams.ItemsSource = allTeams;
            comboTeams.SelectedIndex = 0;

            var allCountries = new ObservableCollection<Country>(AppData.db.Countries);
            comboCountries.DisplayMemberPath = "countryName";
            comboCountries.ItemsSource = allCountries;
            comboCountries.SelectedIndex = 0;

            var allPositions = new ObservableCollection<GameRole>(AppData.db.GameRoles);
            comboPositions.DisplayMemberPath = "titleRole";
            comboPositions.ItemsSource = allPositions;
            comboPositions.SelectedIndex = 0;
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentPlayer.gameNickname))
                errors.AppendLine("Укажите никнейм игрока");
            if (string.IsNullOrWhiteSpace(_currentPlayer.age.ToString()))
                errors.AppendLine("Укажите возраст игрока");
            if (comboTeams.SelectedItem == null)
                errors.AppendLine("Укажите команду игрока");
            if (comboCountries.SelectedItem == null)
                errors.AppendLine("Укажите страну игрока");
            if (comboPositions.SelectedItem == null)
                errors.AppendLine("Укажите позицию игрока");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            _currentPlayer.Team = comboTeams.SelectedItem as Team;
            _currentPlayer.Country = comboCountries.SelectedItem as Country;
            _currentPlayer.GameRole1 = comboPositions.SelectedItem as GameRole;

            if (_currentPlayer.id == 0)
                AppData.db.Players.Add(_currentPlayer);

            try
            {
                AppData.db.SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new PlayersPg());
        }
    }
}
