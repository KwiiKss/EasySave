using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace EasySave
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private App()
        {
            Process[] EasySaveLaunch = Process.GetProcessesByName("EasySave2.0"); //Création du processus dans le but de le quantifier afin d'y avoir une mono instance
            if (EasySaveLaunch.Length >1)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }    
    }
}
