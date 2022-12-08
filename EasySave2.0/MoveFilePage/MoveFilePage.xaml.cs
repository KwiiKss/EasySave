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
using System.ComponentModel;

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour MoveFilePage.xaml
    /// 
    /// </summary>

    public partial class MoveFilePage : Window
    {
        BackgroundWorker worker = new BackgroundWorker();
        public MoveFilePage()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += worker_progress;
            worker.DoWork += Worker_dowork;


        }
        public void Worker_dowork(object sender, DoWorkEventArgs e)
        {
            filecopy(@"C:\Users\corso\OneDrive\Bureau\Dossier1\test3.iso", @"C:\Users\corso\OneDrive\Bureau\Dossier2\test3.iso");
        }
        public void worker_progress(object sender, ProgressChangedEventArgs e)
        {
            progressbar1.Value = e.ProgressPercentage;

        }

    public void filecopy(string des, string source)
        {
            FileStream fsout = new FileStream(des, FileMode.Create);
            FileStream fsin = new FileStream(source, FileMode.Open);
            Byte[] bt = new byte[1048756];
            int readbyte; 

            while((readbyte = fsin.Read(bt,0,bt.Length)) > 0)
            {
                fsout.Write(bt, 0, readbyte);
                worker.ReportProgress((int)((fsin.Position * 100)/fsin.Length));
            };
            fsin.Close();
            fsout.Close();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();

            SuccessText.Content = "Loading...";
        ///    string source = System.IO.Path.Combine(SourceFile.Text, NameFile.Text);
           // string destination = System.IO.Path.Combine(DestinationFile.Text, NameFile.Text);

          //  Trysomething.MoveFile(source, destination);
            SuccessText.Content = "The folder has been successfully moved !";




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

            public static void MoveFolder(string sourceFolderName, string destFolderName)  // Method that moves a folder form a source folder to a destination folder
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

        }

     
    }
}