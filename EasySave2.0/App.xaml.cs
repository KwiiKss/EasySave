using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace EasySave2._0
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private App()
        {
            Process[] EasySaveLaunch = Process.GetProcessesByName("EasySave2.0");
            if (EasySaveLaunch.Length >1)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }    
    }
}
