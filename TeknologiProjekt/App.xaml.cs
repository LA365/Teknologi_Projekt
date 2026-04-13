using System.Configuration;
using System.Data;
using System.Threading;
using System.Windows;

namespace TeknologiProjekt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Mutex _mutex;

        protected override void OnStartup(StartupEventArgs e)
        {
            const string appName = "TeknologiProjekt_Unique_App_String";
            
            _mutex = new Mutex(true, appName, out bool createdNew);

            if (!createdNew)
            {
                Current.Shutdown();
                return;
            }

            base.OnStartup(e);
        }
    }
}
