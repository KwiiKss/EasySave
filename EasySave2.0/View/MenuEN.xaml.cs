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
    public partial class MenuEN : Window
    {
        public MenuEN()
        {
            InitializeComponent();
        }

        private void ChooseEN(object sender, MouseButtonEventArgs e)
        {
            ChooseEN window = new ChooseEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
        
        private void ShowPageEN(object sender, MouseButtonEventArgs e)
        {
            ShowPageEN window = new ShowPageEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void OptionsEN(object sender, MouseButtonEventArgs e)
        {
            OptionsEN window = new OptionsEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
}
