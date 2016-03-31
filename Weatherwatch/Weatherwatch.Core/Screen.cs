using System.Windows.Controls;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core
{
    public class Screen : UserControl
    {
        protected static MainController Controller { get; private set; }

        static Screen()
        {
            Controller = new MainController();
        }

        public virtual void Set()
        {
            
        }
    }
}