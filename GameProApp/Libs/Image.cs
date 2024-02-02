using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GameProApp
{
    internal class Image
    {
        private static string unknownImageTournamentPath = "..\\..\\Resources\\Tournaments logo\\Unknown.png";
        public static BitmapSource SetImage(string path)
        {
            BitmapImage bi = new BitmapImage();
            try
            {
                bi.BeginInit();
                bi.UriSource = new Uri(System.IO.Path.GetFullPath(path));
                bi.EndInit();
                return bi;
            }
            catch
            {
                bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(System.IO.Path.GetFullPath(unknownImageTournamentPath));
                bi.EndInit();
                return bi;
            }
        }
    }
}
