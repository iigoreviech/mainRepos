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
    /// Логика взаимодействия для TournamentsPg.xaml
    /// </summary>
    public partial class TournamentsPg : Page
    {
        public TournamentsPg()
        {
            InitializeComponent();
            var currentTournament = AppData.db.Tournaments.ToList();

            PageLoaded();
            UpdateTournaments();
        }

        public void UpdateTournaments()
        {
            var tournaments = AppData.db.Tournaments.ToList();

            tournaments = tournaments.Where(p => p.title.Replace(" ", "").ToLower().Contains(tbSearchTournament.Text.Replace(" ", "").ToLower())).ToList();

            lvTournaments.Items.Clear();
            foreach (var tournament in tournaments)
            {
                lvTournaments.Items.Insert(0, new TournamentUC(tournament));
            }

            if (tournaments.Count == 0)
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
                lvTournaments.ItemsSource = AppData.db.Tournaments.ToList();
            }
        }

        private void tbSearchTournament_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTournaments();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddEditTournamentPg(null));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var tournamentForEdit = lvTournaments.SelectedItem as TournamentUC;
            if (tournamentForEdit != null)
            {
                var selectedTournament = tournamentForEdit.Tournament;
                Manager.frame.Navigate(new AddEditTournamentPg(selectedTournament));
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var tournamentsForDelete = lvTournaments.SelectedItems.Cast<TournamentUC>().ToList();

            if (tournamentsForDelete.Count == 0)
            {
                return;
            }

            if (MessageBox.Show($"Вы точно хотите удалить следующие {tournamentsForDelete.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    List<Tournament> tournaments = new List<Tournament>();
                    foreach (var tournament in tournamentsForDelete)
                    {
                        tournaments.Add(tournament.Tournament);
                    }
                    AppData.db.Tournaments.RemoveRange(tournaments);
                    AppData.db.SaveChanges();
                    UpdateTournaments();
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
