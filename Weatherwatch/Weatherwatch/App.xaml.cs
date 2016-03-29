using System.Windows;
using Weatherwatch.Core;
using Weatherwatch.Core.Factory;

namespace Weatherwatch
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            RadarFactory factory = new RadarFactory();
            factory.Create();
        }
    }
}
