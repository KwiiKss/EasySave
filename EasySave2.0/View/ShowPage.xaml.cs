using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace EasySave2._0
{
    /// <summary>
    /// Interaction logic for ShowPage.xaml
    /// </summary>
    public partial class ShowPage : Window
    {
        public ShowPage()
        {
            InitializeComponent();
        }

        private void ReturnButt(object sender, MouseButtonEventArgs e)
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void LoadSaves(object sender, MouseButtonEventArgs e)
        {
            listbox10.Items.Clear();
            string Path = @"F:\JEUX";
            string[] files = Directory.GetFiles(Path);
            string[] dirs = Directory.GetDirectories(Path);
            foreach (string file in files)
            {
                listbox10.Items.Add(file);
            }
            foreach (string dir in dirs)
            {
                listbox10.Items.Add(dir);
            }

        }
    }
}

