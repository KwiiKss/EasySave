using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class ShowPageEN : Window
    {
        public ShowPageEN()
        {
            InitializeComponent(); // Initialisation des composants de la page
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e) // Event bouton qui permets de revenir à la page précédente
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void LoadSaves(object sender, RoutedEventArgs e) // Méthode qui permets de récupérer les différents fichiers et dossiers du chemin par défaut
        {
            listviewEN.Items.Clear();
            string Path = Data.Instance.DefaultPath;

            DirectoryInfo dinfo = new DirectoryInfo(Path);

            FileInfo[] Files = dinfo.GetFiles();


            DirectoryInfo[] Dirs = dinfo.GetDirectories();

            foreach (FileInfo file in Files)
            {
                listviewEN.Items.Add(file.Name);
            }
            foreach (DirectoryInfo dir in Dirs)
            {
                listviewEN.Items.Add(dir.Name);
            }
            
        }
    }
}

