using System;
using System.Collections.Generic;
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

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour ChooseFR.xaml
    /// </summary>
    public partial class ChooseFR : Window
    {
        public ChooseFR()
        {
            InitializeComponent();
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e)
        {
            MenuFR window = new MenuFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void MoveFileFR(object sender, MouseButtonEventArgs e)
        {
            MoveFileFR window = new MoveFileFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void MoveFolderFR(object sender, MouseButtonEventArgs e)
        {
            MoveFolderFR window = new MoveFolderFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
