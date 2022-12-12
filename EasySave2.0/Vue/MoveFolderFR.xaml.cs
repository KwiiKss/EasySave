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

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour MoveFolderFR.xaml
    /// </summary>
    public partial class MoveFolderFR : Window
    {
        public MoveFolderFR()
        {
            InitializeComponent();
            SourceFolder.Text = Data.Instance.DefaultPath;
            DestinationFolder.Text = Data.Instance.DefaultPath;
        }

        private void Valide(object sender, RoutedEventArgs e)
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

        private void SearchSourceFolder(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SourceFolder.Text = dialog.FileName;
                this.Topmost = true;
            }
        }

        private void SearchDestFolder(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DestinationFolder.Text = dialog.FileName;
                this.Topmost = true;
            }
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e)
        {
            ChooseFR window = new ChooseFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void ReturnMenuFR(object sender, MouseButtonEventArgs e)
        {
            MenuFR window = new MenuFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
