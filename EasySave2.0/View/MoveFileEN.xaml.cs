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
    public partial class MoveFileEN : Window
    {
        public MoveFileEN()
        {
            InitializeComponent(); //Initialisation des composants de la page
            SourceFile.Text = Data.Instance.DefaultPath; // Ecriture sur la text box du chemin par défaut défini
            DestinationFile.Text = Data.Instance.DefaultPath;
        }

        private void Validate(object sender, RoutedEventArgs e) //Event bouton qui récupére les données des text box, et lance la méthode du déplacement de fichier
        {
            string SourceFileName = SourceFile.Text;
            string FileName = Path.GetFileName(SourceFileName);
            string DestFileName = DestinationFile.Text + "\\" + FileName;
            CreateSaves move = new CreateSaves();

            if (CryptoSoftFile.IsChecked == true)
            {
                var processus = new Process();
                processus.StartInfo.FileName = @"E:\A3\Prog Système\Crypto\1\CryptoSoft.exe";
                processus.StartInfo.Arguments = SourceFileName;
                processus.StartInfo.RedirectStandardOutput = true;
                processus.StartInfo.UseShellExecute = false;
                processus.StartInfo.CreateNoWindow = true;
                processus.Start();
                processus.WaitForExit();
            }

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
            ChooseEN window = new ChooseEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void ReturnMenu(object sender, MouseButtonEventArgs e) //Event bouton pour revenir au menu
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
