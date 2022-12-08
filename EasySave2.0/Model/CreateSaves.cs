using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Diagnostics;
using System.Threading;
using System.Text.Json.Serialization;
using static System.Console;

namespace EasySave2._0
{

    class CreateSaves
    {
        public void MoveFile(string SourceFileName, string DestFileName)
        {
            File.Move(SourceFileName, DestFileName);
        }

        public void MoveFolder(string SourceFolderName, string DestFolderName)
        {
            Directory.Move(SourceFolderName, DestFolderName);
        }
    }    
}
