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
    /// Logique d'interaction pour MoveFileFR.xaml
    /// </summary>
    public partial class MoveFileFR : Window
    {
        public MoveFileFR()
        {
            InitializeComponent();
        }
        private void Valide(object sender, RoutedEventArgs e)
        {
            string FileName = NameFile.Text;
            string FileSource = SourceFile.Text;
            string FileDestination = DestinationFile.Text;
            string SourceFileName = FileSource + "\\" + FileName + "";
            string DestFileName = FileDestination + "\\" + FileName + "";
            File.Move(SourceFileName, DestFileName);
            SuccessText.Visibility = Visibility.Visible;
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
