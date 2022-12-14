using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave
{
    class Data
    {
        public string Config //Variable pour le fichier config
        {
            get; set;
        }

        public string DefaultPath //Variable du chemin par défaut
        {
            get; set;
        }

        public string Log //Variable du chemin des logs
        {
            get; set;
        }

        public string LogPath // Variable pour les logs
        {
            get; set;
        }

        private Data() { }
        public static readonly Data Instance = new Data();
    }
}
