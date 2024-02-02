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
    /// Логика взаимодействия для AddEditMatchPg.xaml
    /// </summary>
    public partial class AddEditMatchPg : Page
    {
        private Match _currentMatch = new Match();

        public AddEditMatchPg(Match selectedMatch)
        {
            InitializeComponent();

            if (selectedMatch != null)
                _currentMatch = selectedMatch;

            DataContext = _currentMatch;

            var allTeams = new ObservableCollection<Team>(AppData.db.Teams);
            comboTeamOne.DisplayMemberPath = "teamName";
            comboTeamOne.ItemsSource = allTeams;
            comboTeamOne.SelectedIndex = 0;

            var allCountries = new ObservableCollection<Team>(AppData.db.Teams);
            comboTeamTwo.DisplayMemberPath = "teamName";
            comboTeamTwo.ItemsSource = allCountries;
            comboTeamTwo.SelectedIndex = 0;

            var allPositions = new ObservableCollection<Tournament>(AppData.db.Tournaments);
            comboTournaments.DisplayMemberPath = "title";
            comboTournaments.ItemsSource = allPositions;
            comboTournaments.SelectedIndex = 0;
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentMatch.pointsTeamOne.ToString()))
                errors.AppendLine("Укажите количество очков команды");
            if (string.IsNullOrWhiteSpace(_currentMatch.pointsTeamTwo.ToString()))
                errors.AppendLine("Укажите количество очков команды");
            if (string.IsNullOrWhiteSpace(_currentMatch.matchStage))
                errors.AppendLine("Укажите стадию матча");
            if (comboTeamOne.SelectedItem == null)
                errors.AppendLine("Укажите команду");
            if (comboTeamTwo.SelectedItem == null)
                errors.AppendLine("Укажите команду");
            if (comboTournaments.SelectedItem == null)
                errors.AppendLine("Укажите турнир");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            _currentMatch.Team = comboTeamOne.SelectedItem as Team;
            _currentMatch.Team1 = comboTeamTwo.SelectedItem as Team;
            _currentMatch.Tournament = comboTournaments.SelectedItem as Tournament;


            AppData.db.Matches.Add(_currentMatch);

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
            Manager.frame.Navigate(new MatchesPg());
        }
    }
}
