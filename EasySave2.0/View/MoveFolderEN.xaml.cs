﻿using System;
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
    public partial class MoveFolderEN : Window
    {
        public MoveFolderEN()
        {
            InitializeComponent(); //Initialisation des composants de la page
            SourceFolder.Text = Data.Instance.DefaultPath; // Ecriture sur la text box du chemin par défaut défini
            DestinationFolder.Text = Data.Instance.DefaultPath;
        }

        private void Validate(object sender, RoutedEventArgs e) //Event bouton qui récupére les données des text box, et lance la méthode du déplacement de dossier
        {

            string SourceFolderName = SourceFolder.Text;
            string FolderName = Path.GetFileName(SourceFolderName);
            string DestFolderName = DestinationFolder.Text + "\\" + FolderName;
            CreateSaves move = new CreateSaves();
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
            ChooseEN window = new ChooseEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void ReturnMenu(object sender, MouseButtonEventArgs e) //Event bouton pour revenir à menu
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
