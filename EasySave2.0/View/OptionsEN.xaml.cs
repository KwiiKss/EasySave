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
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class OptionsEN : Window
    {
        public OptionsEN()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void MenuEN(object sender, MouseButtonEventArgs e)
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        //public void AddExtension(object sender, MouseButtonEventArgs e)
        //{
        //    string Extension_Name = Extension.Text;
        //}
    }
}
