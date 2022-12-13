using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Threading;

namespace EasySave2._0
{
    /// <summary>
    /// Logique d'interaction pour ChoosePage.xaml
    /// </summary>
    public partial class tranfer : Window
    {
        public tranfer()
        {
            InitializeComponent();
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
                        new Deplacement {Id = 1,Name = "test1", Despath = @"C:\Users\Corso\Desktop\Dossier2\test.txt", Sourcepath = @"C:\Users\Corso\Desktop\Dossier1\test.txt"},
                        new Deplacement {Id = 2, Name = "test2", Sourcepath = @"C:\Users\Corso\Desktop\Dossier3\test2.txt",Despath = @"C:\Users\Corso\Desktop\Dossier2\test2.txt",},
                        new Deplacement {Id = 3, Name = "test3", Sourcepath = @"C:\Users\Corso\Desktop\Dossier2\test.txt", Despath =  @"C:\Users\Corso\Desktop\Dossier3\test2.txt",},
                        new Deplacement {Id = 4, Name = "test4", Sourcepath = @"C:\Users\Corso\Desktop\Dossier2\test2.txt", Despath = @"C:\Users\Corso\Desktop\Dossier1\test.txt"},
                    };

            DataContext =
                (from i in _empCollection
                 select new {i.Id, i.Name,i.Despath,  i.Sourcepath }).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateSaves test2 = new CreateSaves(); //recupere les donnée ici et
            string[] source =  { @"C:\Users\Corso\Desktop\Dossier2\test.txt", @"C:\Users\Corso\Desktop\Dossier2\test2.txt" };
            string[] dest = { @"C:\Users\Corso\Desktop\Dossier1\test.txt", @"C:\Users\Corso\Desktop\Dossier1\test2.txt" };

            Thread[] move = new Thread[2];
            for(int i = 0; i < move.Length; i++)
            {

            }
            move[0] = new Thread(new ThreadStart(() =>test2.MoveFile(source[0], dest[0])));
            move[1] = new Thread(new ThreadStart(() => test2.MoveFile(source[1], dest[1])));
            move[0].Start();
            move[1].Start();



        }
    }
}
