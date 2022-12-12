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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class OptionPage : Window
    {
        public OptionPage()
        {
            InitializeComponent();
            string fileName = "C:/Users/nicol/Desktop/option.json";
            string jsonString = File.ReadAllText(fileName);
            option InitOption = JsonSerializer.Deserialize<option>(jsonString)!;
            DataContext = InitOption;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void MenuPage(object sender, MouseButtonEventArgs e)
        {
            var newoption = new option()
            {
                Defaultpath = DefaultPath.Text,
                Logtype = LogType.SelectedValue.ToString(),
            };


            var option = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(newoption, option);
            string fileName = "C:/Users/nicol/Desktop/option.json";
            File.WriteAllText(fileName, jsonString);

            MenuPage window = new MenuPage();
            window.Top = this.Top;
            window.Left = this.Left;
            this.Close();
            window.Show();
        }
    }
    public class option
    {
        public string Defaultpath { get; set; }
        public string Logtype { get; set; }
    }
}
