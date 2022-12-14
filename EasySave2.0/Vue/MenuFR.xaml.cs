using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasySave
{
    public partial class MenuFR : Window
    {
        public MenuFR()
        {
            InitializeComponent(); // Initialisation des composants de la page
        }

        private void ChooseFR(object sender, MouseButtonEventArgs e) // Event bouton qui envoie vers la page Choose (MoveFile ou MoveFolder)
        {
            ChooseFR window = new ChooseFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
        
        private void ShowPageFR(object sender, MouseButtonEventArgs e) //Event bouton qui envoie vers la page ShowSaves
        {
            ShowPageFR window = new ShowPageFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void OptionsFR(object sender, MouseButtonEventArgs e) //Event bouton qui envoie vers la page Options
        {
            OptionsFR window = new OptionsFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
