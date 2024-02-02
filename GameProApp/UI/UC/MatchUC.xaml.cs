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
    /// Логика взаимодействия для MatchUC.xaml
    /// </summary>
    public partial class MatchUC : UserControl
    {
        public Match Match { get; set; }

        private const string sourcePrefixTourLogo = "..\\..\\Resources\\Tournaments logo\\";
        private const string sourcePrefixTeamLogo = "..\\..\\Resources\\Teams logo\\";

        public MatchUC(Match match)
        {
            InitializeComponent();
            Match = match;
            DataContext = this;
            var matches = AppData.db.Matches.ToList();
            imgMatchTournament.Source = Image.SetImage(sourcePrefixTourLogo + Match.Tournament.tournamentImagePath);
            imgTeamOne.Source = Image.SetImage(sourcePrefixTeamLogo + Match.Team.teamLogoPath);
            imgTeamTwo.Source = Image.SetImage(sourcePrefixTeamLogo + Match.Team1.teamLogoPath);
        }
    }
}
