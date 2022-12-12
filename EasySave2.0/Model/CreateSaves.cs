using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Diagnostics;
using System.Threading;
using System.Text.Json.Serialization;
using static System.Console;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace EasySave2._0
{

    class CreateSaves
    {
        public bool MoveFile(string SourceFileName, string DestFileName)
        {
            var sw = new Stopwatch();
            Process[] proc = Process.GetProcessesByName("CalculatorApp");
            if (proc.Length == 0)
            {
                FileInfo Filesize = new FileInfo(SourceFileName);
                float size = Filesize.Length;
                sw.Start(); 
                File.Move(SourceFileName, DestFileName);
                sw.Stop();
                FileLog(SourceFileName, DestFileName, size, sw.ElapsedMilliseconds, @"C:\Users\Corso\Desktop\Log\", "XML"); 
                return true;
            }
            else
            {
                MessageBox.Show("Calculator is running. Close it to continue.\nCalculatrice en cours d'éxécution. Fermez l'application pour continuer.", "EasySave", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            
        }

        public bool MoveFolder(string SourceFolderName, string DestFolderName)
        {  
             var sw = new Stopwatch();
            Process[] proc = Process.GetProcessesByName("CalculatorApp");
            if (proc.Length == 0)
            {

                sw.Start();
                Directory.Move(SourceFolderName, DestFolderName);
                 sw.Stop();
                FileLog(SourceFolderName, DestFolderName,0, sw.ElapsedMilliseconds, @"C:\Users\Corso\Desktop\Log\", "XML");
                return true;
            }
            else
            {
                MessageBox.Show("Calculator is running. Close it to continue.\nCalculatrice en cours d'éxécution. Fermez l'application pour continuer.", "EasySave", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        public void FileLog(string SourceFileName, string DestFileName, float size, long time, string delfaultpath, string type) 
        {

            CreateSaves json = new CreateSaves();
            if (type == "JSON")
            {
                string path = delfaultpath + "daylog.txt";
                string Text = SetJson(SourceFileName, DestFileName, size, time);

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
            else if (type == "XML")
            {
                LogdayXMLType("logday", SourceFileName, DestFileName, size, delfaultpath + "daylog.xml");
            }

            if (type == "JSON")
            {
                {
                    string path = delfaultpath + "statelog.txt";

                    string Text2 = SetJsonState("statelog", SourceFileName, DestFileName, size);

                    if (File.Exists(path))
                    {
                        using (StreamReader reader = new StreamReader(path))
                        {
                            Text2 += reader.ReadToEnd();

                            reader.Close();
                        };

                    }
                    File.WriteAllText(path, Text2);
                }
            }
            else if (type == "XML")
            {
                statedayXMLType("logday", SourceFileName, DestFileName, size, delfaultpath + "statelog.xml");
            }
        }


        private string SetJson(string path, string despath, float size, long time) 
        {
            var option = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = new Json
            {
                name = "Move",
                FileSource = path,
                FileTarget = "",
                destPath = despath,
                FileSize = size,
                FileTransferTime = time,
                time = DateTime.Now.ToString("dd/M/y HH:mm:ss")

            };
            string jsonString = JsonSerializer.Serialize(json, option);
            return jsonString;
        }

        public string SetJsonState(string name, string path, string despath, float Filesize) 
        {

            var option = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = new JsonState
            {
                name = name,
                FileSource = path,
                FileTarget = despath,
                State = "end",
                TotalFilesToCopy = 0,
                TotalFilesSize = Filesize,
                NbFilesLeftToDo = 0,
                progression = 0,

            };
            string jsonString = JsonSerializer.Serialize(json, option);
            return jsonString;
        }
        public static void statedayXMLType(string name, string sourcepath, string despath, float Filesize, string defaultpath)
        {
            XDocument document = new XDocument
    (
        new XDeclaration("1.0", "utf-8", "yes"),
        new XComment("XML for stateLog"),

        new XElement("statelog",
            new XElement("data",
                new XElement("backupname", name),
                new XElement("sourcefilepath", sourcepath),
                new XElement("targetfilepath", despath),
                new XElement("time", DateTime.Now.ToString("dd/M/y HH:mm:ss")),
                new XElement("filesize", Filesize)))
    );
            string path = defaultpath;
            document.Save(path);
        }

        public static void LogdayXMLType(string name, string sourcepath, string despath, float Filesize, string defaultpath)
        {
            XDocument document = new XDocument
    (
        new XDeclaration("1.0", "utf-8", "yes"),
        new XComment("XML for stateLog"),

        new XElement("statelog",
            new XElement("data",
                new XElement("backupname", name),
                new XElement("sourcefilepath", sourcepath),
                new XElement("targetfilepath", despath),
                new XElement("time", DateTime.Now.ToString("dd/M/y HH:mm:ss")),
                new XElement("state", "end"),
                new XElement("totalfilestocopy", 0),
                new XElement("totalfilesize", Filesize),
                new XElement("nbfileslefttodo", 0),
                new XElement("progression", 0)))
    );
            string path = defaultpath;
            document.Save(path);
        }

    }

    public class JsonState
    {
        public String name { get; set; }
        public String FileSource { get; set; }
        public String FileTarget { get; set; }
        public String State { get; set; }
        public float TotalFilesToCopy { get; set; }
        public float TotalFilesSize { get; set; }
        public float NbFilesLeftToDo { get; set; }
        public float progression { get; set; }


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



}
