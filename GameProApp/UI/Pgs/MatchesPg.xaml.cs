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
using System.ComponentModel;
using GameProApp.Data;

namespace GameProApp
{
    /// <summary>
    /// Логика взаимодействия для MatchesPg.xaml
    /// </summary>
    public partial class MatchesPg : Page
    {
        public MatchesPg()
        {
            InitializeComponent();
            var currentMatch = AppData.db.Matches.ToList();

            PageLoaded();
            UpdateMatches();
        }

        public void UpdateMatches()
        {
            var matches = AppData.db.Matches.ToList();

            string searchText = tbSearchMatches.Text.Replace(" ", "").ToLower();

            matches = matches.Where(p =>
                p.Tournament.title.Replace(" ", "").ToLower().Contains(searchText) ||
                p.Team.teamName.Replace(" ", "").ToLower().Contains(searchText) ||
                p.Team1.teamName.Replace(" ", "").ToLower().Contains(searchText)
            ).ToList();

            lvMatches.Items.Clear();
            foreach (var match in matches)
            {
                lvMatches.Items.Insert(0, new MatchUC(match));
            }

            if (matches.Count == 0)
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
                lvMatches.ItemsSource = AppData.db.Matches.ToList();
            }
        }

        private void tbSearchMatches_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateMatches();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddEditMatchPg(null));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var matchForEdit = lvMatches.SelectedItem as MatchUC;
            if (matchForEdit != null)
            {
                var selectedMatch = matchForEdit.Match;
                Manager.frame.Navigate(new AddEditMatchPg(selectedMatch));
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var matchesForDelete = lvMatches.SelectedItems.Cast<MatchUC>().ToList();

            if (matchesForDelete.Count == 0)
            {
                return;
            }

            if (MessageBox.Show($"Вы точно хотите удалить следующие {matchesForDelete.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    List<Match> matches = new List<Match>();
                    foreach (var match in matchesForDelete)
                    {
                        matches.Add(match.Match);
                    }
                    AppData.db.Matches.RemoveRange(matches);
                    AppData.db.SaveChanges();
                    UpdateMatches();
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
