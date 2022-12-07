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

    class Model
    {
        public static void MoveFile() // Method that moves a file form a source folder to a destination folder
        {
            string file = Console.ReadLine();
            string source = Console.ReadLine();
            string sourceFileName = source + "\\" + file + "";
            string dest = Console.ReadLine();
            string destFileName = dest + "\\" + file + "";
            File.Move(sourceFileName, destFileName);
            WriteLine($"\n-> The file moved in {destFileName}.");
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            //ViewEN.RunMainMenuEN();
        }

        public static void MoveFolder()  // Method that moves a folder form a source folder to a destination folder
        {

            string folder = Console.ReadLine();
            Console.WriteLine("Enter the source of your folder :");
            string source = Console.ReadLine();
            string sourceFolderName = source + "\\" + folder + "";
            Console.WriteLine("Enter the destination of your folder :");
            string dest = Console.ReadLine();
            string destFolderName = dest + "\\" + folder + "";
            Directory.Move(sourceFolderName, destFolderName);
            WriteLine($"\n-> The folder moved in {destFolderName}.");
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            //ViewEN.RunMainMenuEN();
        }

        public static void DeplacerFichier() // Méthode qui déplace un fichier d'un dossier source à un dossier destination
        {
            Console.Clear();
            Console.WriteLine("Entrez le nom du fichier avec son type (ex : kilyion.txt) :");
            string file = Console.ReadLine();
            Console.WriteLine("Entrez la source du fichier:");
            string source = Console.ReadLine();
            string sourceFileName = source + "\\" + file + "";
            Console.WriteLine("Entrez la destination du fichier :");
            string dest = Console.ReadLine();
            string destFileName = dest + "\\" + file + "";
            File.Move(sourceFileName, destFileName);
            WriteLine($"\n-> Le fichier a bien été déplacé dans {destFileName}.");
            WriteLine("\n\nAppuyez sur n'importe quel bouton pour revenir au menu...");
            ReadKey(true);
            //ViewEN.RunMainMenuEN();
        }
        public static void DeplacerDossier()  // Méthode qui déplace un dossier ainsi que son contenu d'une source à une destination
        {
            Console.WriteLine("Entrez le nom du dossier :");
            string folder = Console.ReadLine();
            Console.WriteLine("Entrez la source du dossier:");
            string source = Console.ReadLine();
            string sourceFolderName = source + "\\" + folder + "";
            Console.WriteLine("Entrez la destination du dossier :");
            string dest = Console.ReadLine();
            string destFolderName = dest + "\\" + folder + "";
            Directory.Move(sourceFolderName, destFolderName);
            WriteLine($"\n-> Le dossier a bien été déplacé dans {destFolderName}.");
            WriteLine("\n\nAppuyez sur n'importe quel bouton pour revenir au menu...");
            ReadKey(true);
            //ViewEN.RunMainMenuEN();
        }
    }
}
