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

namespace EasySave2._0
{

    class CreateSaves
    {
        public bool MoveFile(string SourceFileName, string DestFileName)
        {
            Process[] proc = Process.GetProcessesByName("CalculatorApp");
            if (proc.Length == 0)
            {
                File.Move(SourceFileName, DestFileName);
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
            Process[] proc = Process.GetProcessesByName("CalculatorApp");
            if (proc.Length == 0)
            {
                Directory.Move(SourceFolderName, DestFolderName);
                return true;
            }
            else
            {
                MessageBox.Show("Calculator is running. Close it to continue.\nCalculatrice en cours d'éxécution. Fermez l'application pour continuer.", "EasySave", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }    
}
