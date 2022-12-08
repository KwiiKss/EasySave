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
    /// Logique d'interaction pour MoveFolderFR.xaml
    /// </summary>
    public partial class MoveFolderFR : Window
    {
        public MoveFolderFR()
        {
            InitializeComponent();
        }

        private void Valide(object sender, RoutedEventArgs e)
        {
            string FolderName = NameFolder.Text;
            string FolderSource = SourceFolder.Text;
            string FolderDestination = DestinationFolder.Text;
            string SourceFolderName = FolderSource + "\\" + FolderName + "";
            string DestFolderName = FolderDestination + "\\" + FolderName + "";
            CreateSaves move = new CreateSaves();
            move.MoveFolder(SourceFolderName, DestFolderName);
            SuccessText.Visibility = Visibility.Visible;
            SuccessText.Content = FolderName + " a bien été déplacé !";
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
