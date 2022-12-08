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
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            string FileName = NameFile.Text;
            string FileSource = SourceFile.Text;
            string FileDestination = DestinationFile.Text;
            string SourceFileName = FileSource + "\\" + FileName + "";
            string DestFileName = FileDestination + "\\" + FileName + "";
            CreateSaves move = new CreateSaves();
            move.MoveFile(SourceFileName, DestFileName);
            SuccessText.Visibility = Visibility.Visible;
            SuccessText.Content = FileName + " has been successfully moved !";
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
