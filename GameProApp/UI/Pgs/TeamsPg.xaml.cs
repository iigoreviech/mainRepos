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
    /// Логика взаимодействия для TeamsPg.xaml
    /// </summary>
    public partial class TeamsPg : Page
    {
        public TeamsPg()
        {
            InitializeComponent();
            var currentTeam = AppData.db.Teams.ToList();

            PageLoaded();
            UpdateTeams();
        }

        public void UpdateTeams()
        {
            var teams = AppData.db.Teams.ToList();

            teams = teams.Where(p => p.teamName.Replace(" ", "").ToLower().Contains(tbSearchTeams.Text.Replace(" ", "").ToLower())).ToList();

            lvTeams.Items.Clear();
            foreach (var team in teams)
                lvTeams.Items.Add(new TeamUC(team));

            if (teams.Count == 0)
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
                lvTeams.ItemsSource = AppData.db.Teams.ToList();
            }
        }

        private void tbSearchTeams_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTeams();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddEditTeamPg(null));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var teamForEdit = lvTeams.SelectedItem as TeamUC;
            if (teamForEdit != null)
            {
                var selectedTeam = teamForEdit.Team;
                Manager.frame.Navigate(new AddEditTeamPg(selectedTeam));
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var teamForDelete = lvTeams.SelectedItems.Cast<TeamUC>().ToList();

            if (teamForDelete.Count == 0)
            {
                return;
            }

            if (MessageBox.Show($"Вы точно хотите удалить следующие {teamForDelete.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    List<Team> teams = new List<Team>();
                    foreach (var team in teamForDelete)
                    {
                        teams.Add(team.Team);
                    }
                    AppData.db.Teams.RemoveRange(teams);
                    AppData.db.SaveChanges();
                    UpdateTeams();
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
