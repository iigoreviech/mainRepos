using System;
using System.Collections.Generic;
using GameProApp.Properties;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
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
    /// Логика взаимодействия для TeamUC.xaml
    /// </summary>
    public partial class TeamUC : UserControl
    {
        public Team Team { get; set; }
        public ImageSource ImageSource { get; set; }

        private const string sourcePrefixLogo = "..\\..\\Resources\\Teams logo\\";
        public TeamUC(Team team)
        {
            InitializeComponent();
            Team = team;
            DataContext = this;
            var players = AppData.db.Players.ToList();
            imgTeam.Source = Image.SetImage(sourcePrefixLogo + Team.teamLogoPath);
        }
    }
}
