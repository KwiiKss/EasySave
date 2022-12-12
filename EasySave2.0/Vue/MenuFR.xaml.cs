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
    /// Logique d'interaction pour MenuFR.xaml
    /// </summary>
    public partial class MenuFR : Window
    {
        public MenuFR()
        {
            InitializeComponent();
        }

        private void ChooseFR(object sender, MouseButtonEventArgs e)
        {
            ChooseFR window = new ChooseFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
        
        private void ShowPageFR(object sender, MouseButtonEventArgs e)
        {
            ShowPageFR window = new ShowPageFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void OptionsFR(object sender, MouseButtonEventArgs e)
        {
            OptionsFR window = new OptionsFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
