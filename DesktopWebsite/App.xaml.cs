using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopWebsite
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
                {
                    String tit = "";
                    Uri Arg1 = new Uri(e.Args[0]);
                    if (e.Args.Length == 2) {
                        tit = e.Args[1];
                    }
                    if(tit == "")
                    {
                        tit = Arg1.ToString();
                    }
            MainWindow wnd = new MainWindow(Arg1, tit);                        
                    wnd.Show();
                }
    }
}
