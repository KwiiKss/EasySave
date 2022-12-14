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
using Microsoft.WindowsAPICodePack.Dialogs;
using Path = System.IO.Path;
using System.Diagnostics;


namespace EasySave
{
    public partial class MoveFolderFR : Window
    {
        public MoveFolderFR()
        {
            InitializeComponent(); //Initialisation des composants de la page
            SourceFolder.Text = Data.Instance.DefaultPath; // Ecriture sur la text box du chemin par défaut défini
            DestinationFolder.Text = Data.Instance.DefaultPath;
        }

        private void Valide(object sender, RoutedEventArgs e) //Event bouton qui récupére les données des text box, et lance la méthode du déplacement de dossier
        {
            string SourceFolderName = SourceFolder.Text;
            string FolderName = Path.GetFileName(SourceFolderName);
            string DestFolderName = DestinationFolder.Text + "\\" + FolderName;
            CreateSaves move = new CreateSaves();

            if (CryptoSoftDossier.IsChecked == true)
            {
                var processus = new Process();
                processus.StartInfo.FileName = @"E:\A3\Prog Système\Crypto\1\CryptoSoft.exe";
                processus.StartInfo.Arguments = SourceFolderName;
                processus.StartInfo.RedirectStandardOutput = true;
                processus.StartInfo.UseShellExecute = false;
                processus.StartInfo.CreateNoWindow = true;
                processus.Start();
                processus.WaitForExit();
            }

            if (move.MoveFolder(SourceFolderName, DestFolderName) == true)
            {
                SuccessText.Content = SourceFolderName + "\n -> " + DestFolderName;
            }
        }

        private void SearchSourceFolder(object sender, RoutedEventArgs e) //Event bouton pour le choix du dossier source
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SourceFolder.Text = dialog.FileName;
                this.Topmost = true;
            }
        }

        private void SearchDestFolder(object sender, RoutedEventArgs e) //Event bouton pour le choix du dossier destination
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DestinationFolder.Text = dialog.FileName;
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

        private void ReturnMenuFR(object sender, MouseButtonEventArgs e) //Event bouton pour revenir à menu
        {
            MenuFR window = new MenuFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
