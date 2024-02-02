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
    /// Логика взаимодействия для AddEditTeamPg.xaml
    /// </summary>
    public partial class AddEditTeamPg : Page
    {
        private Team _currentTeam = new Team();

        public AddEditTeamPg(Team selectedTeam)
        {
            InitializeComponent();

            if (selectedTeam != null)
                _currentTeam = selectedTeam;

            DataContext = _currentTeam;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentTeam.teamName))
                errors.AppendLine("Укажите название команды");
            if (string.IsNullOrWhiteSpace(_currentTeam.teamLogoPath))
                errors.AppendLine("Укажите путь к изображению");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentTeam.id == 0)
                AppData.db.Teams.Add(_currentTeam);

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
            Manager.frame.Navigate(new TeamsPg());
        }
    }
}
