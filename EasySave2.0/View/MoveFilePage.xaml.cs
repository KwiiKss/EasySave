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
using System.Windows.Shapes;

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour MoveFilePage.xaml
    /// </summary>
    public partial class MoveFilePage : Window
    {
        public MoveFilePage()
        {
            InitializeComponent();
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e)
        {
            ChoosePage window = new ChoosePage();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
        private void ReturnMenu(object sender, MouseButtonEventArgs e)
        {
            MenuPage window = new MenuPage();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }


    }
}
