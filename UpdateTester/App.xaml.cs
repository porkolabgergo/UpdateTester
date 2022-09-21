using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Squirrel;

namespace UpdateTester
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override async void OnStartup(StartupEventArgs e)
        {
            using (var mgr = new UpdateManager("C:\\Users\\porkg\\OneDrive\\Documents\\GitHub\\UpdateTester\\Releases"))
            {
                await mgr.UpdateApp();
            }
        }
    }
}
