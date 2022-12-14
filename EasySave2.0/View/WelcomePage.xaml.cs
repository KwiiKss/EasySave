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
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Navigation;

namespace EasySave
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class WelcomePage : Window
    {
        public WelcomePage()
        {
            InitializeComponent(); //Initialisation des composants de la page
            Settings check = new Settings(); // Lacement de la méthode qui vérifie l'existance du fichier config
            check.ConfigFile();
            Settings log = new Settings(); // Lacement de la méthode qui vérifie l'existance du fichier log
            log.LogFile();            
        }

        private void EnglishMenu(object sender, MouseButtonEventArgs e) //Event boutton qui envoie vers le menu anglais
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void FrenchMenu(object sender, MouseButtonEventArgs e) //Event boutton qui envoie vers le menu français
        {
            MenuFR window = new MenuFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
