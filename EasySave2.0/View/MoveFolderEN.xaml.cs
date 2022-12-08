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

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour MoveFolderPage.xaml
    /// </summary>
    public partial class MoveFolderEN : Window
    {
        public MoveFolderEN()
        {
            InitializeComponent();
        }

        private void Validate(object sender, RoutedEventArgs e)
        {

            string SourceFolderName = SourceFolder.Text;
            string FolderName = Path.GetFileName(SourceFolderName);
            string DestFolderName = DestinationFolder.Text + "\\" + FolderName;
            CreateSaves move = new CreateSaves();
            move.MoveFolder(SourceFolderName, DestFolderName);
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
            ChooseEN window = new ChooseEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void ReturnMenu(object sender, MouseButtonEventArgs e)
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
