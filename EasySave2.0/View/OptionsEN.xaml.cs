using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
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
            DefaultPath.Text = Data.Instance.DefaultPath;
        }

        private void AppFR(object sender, MouseButtonEventArgs e)
        {
            OptionsFR window = new OptionsFR();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }

        private void MenuEN(object sender, MouseButtonEventArgs e)
        {
            MenuEN window = new MenuEN();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
        private void SearchDefPath(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DefaultPath.Text = dialog.FileName;
                this.Topmost = true;
            }
        }

        private void ChangedDefaultPath(object sender, TextChangedEventArgs e)
        {
            Data.Instance.DefaultPath = DefaultPath.Text;
            StreamWriter config = new StreamWriter(Data.Instance.Config + "\\ConfigEasySave\\ConfigFile.json");
            config.WriteLine(Data.Instance.DefaultPath);
            config.Close();
        }
    }
}
