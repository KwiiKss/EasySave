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
    /// Logique d'interaction pour MoveFilePage.xaml
    /// </summary>
    public partial class MoveFileEN : Window
    {
        public MoveFileEN()
        {
            InitializeComponent();
            SourceFile.Text = Data.Instance.DefaultPath;
            DestinationFile.Text = Data.Instance.DefaultPath;
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            string SourceFileName = SourceFile.Text;
            string FileName = Path.GetFileName(SourceFileName);
            string DestFileName = DestinationFile.Text + "\\" + FileName;
            CreateSaves move = new CreateSaves();
            if(move.MoveFile(SourceFileName, DestFileName) == true)
            {
                SuccessText.Content = SourceFileName + "\n -> " + DestFileName;
            }
        }

        private void SearchSourceFile(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SourceFile.Text = dialog.FileName;
                this.Topmost = true;
            }
        }

        private void SearchDestFile(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DestinationFile.Text = dialog.FileName;
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
