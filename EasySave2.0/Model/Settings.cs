using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasySave2._0
{
    class Settings
    {
        public void ConfigFile()
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

        public void LogFile()
        {
            Data.Instance.Log = Directory.GetCurrentDirectory();
            if (!Directory.Exists(Data.Instance.Log + "\\LogEasySave"))
            {
                Directory.CreateDirectory(Data.Instance.Log + "\\LogEasySave");
                Data.Instance.LogPath = Data.Instance.Log;
            }
            if (!File.Exists(Data.Instance.Log + "\\LogEasySave\\LogFile.json"))
            {
                StreamWriter log = new StreamWriter(Data.Instance.Log + "\\LogEasySave\\LogFile.json");
                log.WriteLine(Data.Instance.Log);
                log.Close();
            }
            if (File.Exists(Data.Instance.Log + "\\LogEasySave\\ConfigFile.json"))
            {
                StreamReader log = new StreamReader(Data.Instance.Log + "\\LogEasySave\\LogFile.json");
                Data.Instance.LogPath = log.ReadLine();
                log.Close();
            }
        }
    }
}
