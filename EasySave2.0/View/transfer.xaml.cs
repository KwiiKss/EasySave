using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Text.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;
using static System.Console;
using System.ComponentModel;

namespace EasySave2._0
{
   
    /// <summary>
    /// Logique d'interaction pour ChoosePage.xaml
    /// </summary>
    public partial class tranfer : Window
    { 
        BackgroundWorker worker = new BackgroundWorker();
        public tranfer()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += worker_progress;
            worker.DoWork += Worker_dowork;
        }
        public void Worker_dowork(object sender, DoWorkEventArgs e)
        {
            CreateSaves test2 = new CreateSaves(); //recupere les donnée ici et
            string[] source = { @"C:\Users\Corso\Desktop\Dossier2\test.txt", @"C:\Users\Corso\Desktop\Dossier2\test2.txt", @"C:\Users\Corso\Desktop\Dossier2\test3.txt", @"C:\Users\Corso\Desktop\Dossier2\test4.txt" };
            string[] dest = { @"C:\Users\Corso\Desktop\Dossier1\test.txt", @"C:\Users\Corso\Desktop\Dossier1\test2.txt", @"C:\Users\Corso\Desktop\Dossier1\test3.txt", @"C:\Users\Corso\Desktop\Dossier1\test4.txt" };
            long[] size = {0,0,0,0};
            Thread[] move = new Thread[source.Length];
            int prog = 25;
            move[0] = new Thread(new ThreadStart(() => test2.MoveFile(source[0], dest[0])));
            move[1] = new Thread(new ThreadStart(() => test2.MoveFile(source[1], dest[1])));
            move[2] = new Thread(new ThreadStart(() => test2.MoveFile(source[2], dest[2])));
            move[3] = new Thread(new ThreadStart(() => test2.MoveFile(source[3], dest[3])));
            for (int r = 0; r < move.Length; r++)
            {
                FileInfo file = new FileInfo(source[r]);
                size[r] = file.Length;

            }
                for (int i = 0; i < move.Length; i++)
            {
                if(size[i] < 40) { 
                move[i].Start();
                worker.ReportProgress(prog);
                prog += prog;
                Thread.Sleep(1000);
                }
            }
        }
        public void worker_progress(object sender, ProgressChangedEventArgs e)
        {
            progressbar1.Value = e.ProgressPercentage;
        }
        public class Deplacement
        {
            public int Id { get; set; }
            public string   Name { get; set; }
            public string Despath { get; set; }
            public int Job { get; set; }
            public string Sourcepath { get; set; }
        }

        private ObservableCollection<Deplacement> _empCollection;

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            // Generate test data
            _empCollection =
                new ObservableCollection<Deplacement>
                    {
                        new Deplacement {Id = 1,Name = "test", Sourcepath = @"C:\Users\Corso\Desktop\Dossier1\test.txt", Despath = @"C:\Users\Corso\Desktop\Dossier1\test.txt"},
                        new Deplacement {Id = 2, Name = "test2", Sourcepath = @"C:\Users\Corso\Desktop\Dossier2\test2.txt",Despath = @"C:\Users\Corso\Desktop\Dossier1\test2.txt"},
                        new Deplacement {Id = 3, Name = "test3", Sourcepath = @"C:\Users\Corso\Desktop\Dossier2\test3.txt", Despath =  @"C:\Users\Corso\Desktop\Dossier1\test3.txt"},
                        new Deplacement {Id = 4, Name = "test4", Sourcepath = @"C:\Users\Corso\Desktop\Dossier2\test4.txt", Despath =@"C:\Users\Corso\Desktop\Dossier1\test4.txt"},
                    };

            DataContext =
                (from i in _empCollection
                 select new {i.Name,i.Despath,  i.Sourcepath }).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         worker.RunWorkerAsync();
        }
        //    move[1].Start();
       //     worker.ReportProgress(50);
        //    Thread.Sleep(1000);
        //    move[2].Start();
        //    worker.ReportProgress(75);
         //   Thread.Sleep(1000);
         //   move[3].Start();
         //   worker.ReportProgress(100);


        }
    }

