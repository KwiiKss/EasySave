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
    public partial class OptionsFR : Window
    {
        public OptionsFR()
        {
            InitializeComponent(); //Initialisation des composants de la page
            DefaultPath.Text = Data.Instance.DefaultPath; // Ecriture sur la text box du chemin par défaut défini
        }

        private void AppEN(object sender, MouseButtonEventArgs e) // Event bouton qui permets de changer la langue en anglais
        {
            OptionsEN window = new OptionsEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void ReturnMenuFR(object sender, MouseButtonEventArgs e) // Event bouton qui renvoie vers le menu
        {
            MenuFR window = new MenuFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void SearchDefPath(object sender, RoutedEventArgs e) // Event bouton qui permettra de changer le chemin par défaut
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DefaultPath.Text = dialog.FileName;
                this.Topmost = true;
            }
        }
        private void ChangedDefaultPath(object sender, TextChangedEventArgs e) // Event bouton qui permettra de modifier le chemin par défaut dans le fichier config
        {
            Data.Instance.DefaultPath = DefaultPath.Text;
            StreamWriter config = new StreamWriter(Data.Instance.Config + "\\ConfigEasySave\\ConfigFile.json");
            config.WriteLine(Data.Instance.DefaultPath);
            config.Close();
        }
    }
}
