using System;
using GameProApp.Properties;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Shapes;
using GameProApp.Data;

namespace GameProApp
{
    /// <summary>
    /// Логика взаимодействия для TournamentUC.xaml
    /// </summary>
    public partial class TournamentUC : UserControl
    {
        public Tournament Tournament { get; set; }
        public ImageSource ImageSource { get; set; }
        private const string sourcePrefix = "..\\..\\Resources\\Tournaments logo\\";
        public TournamentUC( Tournament tournament)
        {
            InitializeComponent();
            Tournament = tournament;
            DataContext = this;
            var tournaments = AppData.db.Tournaments.ToList();
            imgTournament.Source = Image.SetImage(sourcePrefix + Tournament.tournamentImagePath);
        }
    }
}
