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
    /// Логика взаимодействия для AddEditTournamentPg.xaml
    /// </summary>
    public partial class AddEditTournamentPg
    {
        private Tournament _currentTournament = new Tournament();

        public AddEditTournamentPg(Tournament selectedTournament)
        {
            InitializeComponent();

            if (selectedTournament != null)
                _currentTournament = selectedTournament;

            DataContext = _currentTournament;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentTournament.title))
                errors.AppendLine("Укажите название турнира");
            if (string.IsNullOrWhiteSpace(_currentTournament.tournamentImagePath))
                errors.AppendLine("Укажите путь к изображению");
            if (_currentTournament.dateStart == DateTime.MinValue)
                errors.AppendLine("Укажите дату начала турнира");
            if (_currentTournament.dateEnd == DateTime.MinValue)
                errors.AppendLine("Укажите дату окончания турнира");
            if (_currentTournament.prizeFund < 999 || _currentTournament.prizeFund > 10000000)
                errors.AppendLine("Призовой фонд - от 1000 до 10 млн. рублей!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentTournament.id == 0)
                AppData.db.Tournaments.Add(_currentTournament);

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
            Manager.frame.Navigate(new TournamentsPg());
        }
    }
}
