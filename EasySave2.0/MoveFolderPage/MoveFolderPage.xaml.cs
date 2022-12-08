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
using System.IO;
using System.Text.Json;
using System.Diagnostics;
using System.Threading;
using System.Text.Json.Serialization;
using static System.Console;

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour MoveFolderPage.xaml
    /// </summary>
    public partial class MoveFolderPage : Window
    {
        public MoveFolderPage()
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SuccessText.Content = "Loading...";
            string source = System.IO.Path.Combine(SourceFolder.Text, NameFolder.Text);
            string destination = System.IO.Path.Combine(DestinationFolder.Text, NameFolder.Text);

            Tryso.MoveFolder(source, destination);
            SuccessText.Content = "The folder has been successfully moved !";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "Document"; // Default file name
            dialog.DefaultExt = ".txt"; // Default file extension
            dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            bool? result = dialog.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dialog.FileName;
            }
        }
    }
    public class Tryso
    {

        public static void MoveFolder(string sourceFileName, string destFileName) // Method that moves a file form a source folder to a destination folder
        {
            Model json = new Model();
            var sw = new Stopwatch();
            DirectoryInfo fInfo = new DirectoryInfo(sourceFileName);
            long size = Tryso.DirSize(fInfo);
            sw.Start();
            Directory.Move(sourceFileName, destFileName);
            sw.Stop();
            string path = @"C:\Users\corso\OneDrive\Bureau\LOG\Log.txt";

            string Text = json.SetJson(sourceFileName, destFileName, size, sw.ElapsedMilliseconds);
            json.FileLog(Text);
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    Text += reader.ReadToEnd();

                    reader.Close();
                };

            }


            File.WriteAllText(path, Text);


        }


        public static long DirSize(DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Size += DirSize(di);
            }
            return (Size);
        }
        public class Json
        {
            public String name { get; set; }
            public String FileSource { get; set; }
            public String FileTarget { get; set; }
            public String destPath { get; set; }
            public long FolderSize { get; set; }
            public long FileTransferTime { get; set; }
            public String time { get; set; }


        }
        public string SetJson(string path, string despath, long size, long time)
        {
            var option = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = new Json
            {
                name = "Move",
                FileSource = path,
                FileTarget = despath,
                destPath = "",
                FolderSize = size,
                FileTransferTime = time,
                time = DateTime.Now.ToString("dd/M/y HH:mm:ss")

            };
            string jsonString = JsonSerializer.Serialize(json, option);
            return jsonString;
        }

    }
}
    
