using System;
using System.Collections.Generic;
using System.Text;

namespace EasySave2._0
{
    class Data
    {
        public string Config
        {
            get; set;
        }

        public string DefaultPath
        {
            get; set;
        }

        public string LanguageSet
        {
            get; set;
        }

        private Data() { }
        public static readonly Data Instance = new Data();
    }
}
