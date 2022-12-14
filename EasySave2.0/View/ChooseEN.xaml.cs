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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasySave
{
    public partial class ChooseEN : Window
    {
        public ChooseEN()
        {
            InitializeComponent(); //Initialisation des composants de la page
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e) //Event boutton pour le retour sur la page Menu
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void MoveFileEN(object sender, MouseButtonEventArgs e) //Event pour le bouton qui envoie sur la page MoveFile
        {
            MoveFileEN window = new MoveFileEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void MoveFolderEN(object sender, MouseButtonEventArgs e) //Event pour le bouton qui envoie sur la page MoveFolder
        {
            MoveFolderEN window = new MoveFolderEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
