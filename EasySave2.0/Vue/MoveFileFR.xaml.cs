using System;
using System.IO;
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
using Path = System.IO.Path;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace EasySave
{
    public partial class MoveFileFR : Window
    {
        public MoveFileFR()
        {
            InitializeComponent(); //Initialisation des composants de la page
            SourceFile.Text = Data.Instance.DefaultPath; // Ecriture sur la text box du chemin par défaut défini
            DestinationFile.Text = Data.Instance.DefaultPath;
        }

        private void Valide(object sender, RoutedEventArgs e) //Event bouton qui récupére les données des text box, et lance la méthode du déplacement de fichier
        {
            string SourceFileName = SourceFile.Text;
            string FileName = Path.GetFileName(SourceFileName);
            string DestFileName = DestinationFile.Text + "\\" + FileName;
            CreateSaves move = new CreateSaves();
            if (move.MoveFile(SourceFileName, DestFileName) == true)
            {
                SuccessText.Content = SourceFileName + "\n -> " + DestFileName;
            }
        }

        private void SearchSourceFile(object sender, RoutedEventArgs e) //Event bouton pour le choix du fichier source
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SourceFile.Text = dialog.FileName;
                this.Topmost = true;
            }
        }

        private void SearchDestFile(object sender, RoutedEventArgs e) //Event bouton pour le choix du fichier destination
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DestinationFile.Text = dialog.FileName;
                this.Topmost = true;
            }
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e) //Event bouton pour revenir à la page précédente
        {
            ChooseFR window = new ChooseFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void ReturnMenuFR(object sender, MouseButtonEventArgs e) //Event bouton pour revenir au menu
        {
            MenuFR window = new MenuFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
