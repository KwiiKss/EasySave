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
    /// Logique d'interaction pour MoveFilePage.xaml
    /// </summary>
    public partial class MoveFilePage : Window
    {
        public MoveFilePage()
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Loading.Visibility = Visibility.Visible ;
            string source = @"c:\" + SourceFile.Text + NameFile.Text;
            string destination = @"c:\" + DestinationFile.Text + NameFile.Text;
            Trysomething.MoveFile(source,destination);
            Loading.Visibility = Visibility.Hidden;

        }
    }
    public class Trysomething
    {

        public static void MoveFile(string sourceFileName, string destFileName) // Method that moves a file form a source folder to a destination folder
        {
            Model json = new Model();
            var sw = new Stopwatch();
            FileInfo fInfo = new FileInfo(sourceFileName);
            float size = fInfo.Length;
            sw.Start();
            File.Move(sourceFileName, destFileName);
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

        public static void MoveFolder(string sourceFolderName,string destFolderName)  // Method that moves a folder form a source folder to a destination folder
        {
            Model json = new Model();
            var sw = new Stopwatch();
            sw.Start();
            Directory.Move(sourceFolderName, destFolderName);
            sw.Stop();
            string Text = json.SetJson(sourceFolderName, destFolderName, 0, sw.ElapsedMilliseconds);
            
            json.FileLog(Text);
            ReadKey(true);
           
        }
        public class Json
        {
            public String name { get; set; }
            public String FileSource { get; set; }
            public String FileTarget { get; set; }
            public String destPath { get; set; }
            public float FileSize { get; set; }
            public long FileTransferTime { get; set; }
            public String time { get; set; }


        }
        public string SetJson(string path, string despath, float size, long time)
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
                FileSize = size,
                FileTransferTime = time,
                time = DateTime.Now.ToString("dd/M/y HH:mm:ss")

            };
            string jsonString = JsonSerializer.Serialize(json, option);
            return jsonString;
        }
        public void FileLog(string json)
        {
            string path = @"C:\Users\corso\OneDrive\Bureau\LOG\Log.txt";
           // if (!File.Exists(path))
            //{
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(json);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
           // }
          /*  else
            {

                try
                {

                    string content;
                    using (StreamReader reader = new StreamReader(path))
                    {
                        content = reader.ReadToEnd();

                        reader.Close();
                    };

                    // Open the stream and read it back.


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
          */
        }

    }
}
