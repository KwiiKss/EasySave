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

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour ShowSave.xaml
    /// </summary>
    public partial class ShowSave : Window
    {
        public ShowSave()
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

        private void FetchSave(object sender, EventArgs e)
        {
            string var = OptionsEN.Folder;
            listBoxSaves.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(var);

            FileInfo[] Files = dinfo.GetFiles();

            foreach (FileInfo file in Files)
            {
                listBoxSaves.Items.Add(file.Name);
            }
        }

        private void CryptFile()
        {

        }
    }
}
