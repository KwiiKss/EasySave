﻿using System;
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
    /// Logique d'interaction pour MoveFolderPage.xaml
    /// </summary>
    public partial class MoveFolderEN : Window
    {
        public MoveFolderEN()
        {
            InitializeComponent();
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            string FolderName = NameFolder.Text;
            string FolderSource = SourceFolder.Text;
            string FolderDestination = DestinationFolder.Text;
            string SourceFolderName = FolderSource + "\\" + FolderName + "";
            string DestFolderName = FolderDestination + "\\" + FolderName + "";
            Directory.Move(SourceFolderName, DestFolderName);
            SuccessText.Visibility = Visibility.Visible;
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
