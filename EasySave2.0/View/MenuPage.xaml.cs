using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuPage : Window
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ChoosePage(object sender, MouseButtonEventArgs e)
        {
            ChoosePage window = new ChoosePage();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
        //private void ShowPage(object sender, MouseButtonEventArgs e)
        //{
        //    ShowPage window = new ShowPage();
        //    window.Top = this.Top;
        //    window.Left = this.Left;
        //    this.Close();
        //    window.Show();
        //}
        private void OptionPage(object sender, MouseButtonEventArgs e)
        {
            OptionPage window = new OptionPage();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
