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
    /// Logique d'interaction pour MoveFileFR.xaml
    /// </summary>
    public partial class MoveFileFR : Window
    {
        public MoveFileFR()
        {
            InitializeComponent();
            SourceFile.Text = Data.Instance.DefaultPath;
            DestinationFile.Text = Data.Instance.DefaultPath;
        }

        private void Valide(object sender, RoutedEventArgs e)
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
