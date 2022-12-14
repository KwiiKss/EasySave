using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave
{
    class Settings
    {
        public void ConfigFile() //Création d'un dossier et fichier config s'il n'existe pas et écriture du chemin par défaut
        {
            Data.Instance.Config = Directory.GetCurrentDirectory();
            if (!Directory.Exists(Data.Instance.Config + "\\ConfigEasySave"))
            {
                Directory.CreateDirectory(Data.Instance.Config + "\\ConfigEasySave");
                Data.Instance.DefaultPath = Data.Instance.Config;
            }
            if (!File.Exists(Data.Instance.Config + "\\ConfigEasySave\\ConfigFile.json"))
            {
                StreamWriter config = new StreamWriter(Data.Instance.Config + "\\ConfigEasySave\\ConfigFile.json");
                config.WriteLine(Data.Instance.Config);
                config.Close();
            }
            if (File.Exists(Data.Instance.Config + "\\ConfigEasySave\\ConfigFile.json"))
            {
                StreamReader config = new StreamReader(Data.Instance.Config + "\\ConfigEasySave\\ConfigFile.json");
                Data.Instance.DefaultPath = config.ReadLine();
                config.Close();
            }
        }

        public void LogFile() //Création d'un dossier et fichier Log s'il n'existe pas et écriture des fichiers logs dans celui ci
        {
            Data.Instance.Log = Directory.GetCurrentDirectory();
            if (!Directory.Exists(Data.Instance.Log + "\\LogEasySave"))
            {
                Directory.CreateDirectory(Data.Instance.Log + "\\LogEasySave");
            }
        }
    }
}
