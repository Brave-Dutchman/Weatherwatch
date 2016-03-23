using System.Windows.Controls;

namespace Weatherwatch.Core
{
    public class Screen : UserControl
    {
        protected static MainController Controller { get; private set; }

        static Screen()
        {
            Controller = new MainController();
        }
    }
}