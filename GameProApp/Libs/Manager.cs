using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProApp;
using GameProApp.Data;
using System.Windows.Controls;

namespace GameProApp
{

    class AppData
    {
        public static GameProDataBaseEntities8 db = new GameProDataBaseEntities8();
    }

    internal class Manager
    {
        public static Frame frame { get; set; }

        public static User User { get; set; }
    }
}
