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

namespace EasySave
{
    public partial class MenuEN : Window
    {
        public MenuEN()
        {
            InitializeComponent(); //Initialisation des composants de la page
        }

        private void ChooseEN(object sender, MouseButtonEventArgs e) //Event bouton qui envoie vers la page Choose (MoveFile ou MoveFolder)
        {
            ChooseEN window = new ChooseEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
        
        private void ShowPageEN(object sender, MouseButtonEventArgs e) //Event bouton qui envoie vers la page ShowSaves
        {
            ShowPageEN window = new ShowPageEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void OptionsEN(object sender, MouseButtonEventArgs e) //Event bouton qui envoie vers la page Options
        {
            OptionsEN window = new OptionsEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
