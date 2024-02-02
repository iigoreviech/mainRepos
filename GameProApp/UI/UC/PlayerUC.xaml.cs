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
    /// Логика взаимодействия для PlayerUC.xaml
    /// </summary>
    public partial class PlayerUC : UserControl
    {
        public Player Player { get; set; }
        public ImageSource ImageSource { get; set; }

        private const string sourcePrefix = "..\\..\\Resources\\Country photos\\";
        private const string sourcePrefixLogo = "..\\..\\Resources\\Teams logo\\";
        public PlayerUC(Player player)
        {
            InitializeComponent();
            Player = player;
            DataContext = this;
            var players = AppData.db.Players.ToList();
            imgCountryPlayer.Source = Image.SetImage(sourcePrefix + Player.Country.countryImagePath);
            imgTeamPlayer.Source = Image.SetImage(sourcePrefixLogo + Player.Team.teamLogoPath);
        }
    }
}
