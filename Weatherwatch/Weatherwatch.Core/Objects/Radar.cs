using System.Windows.Controls;

namespace Weatherwatch.Core.Objects
{
    public class Radar
    {
        public string Name { get; private set; }
        private string _url;

        public Radar(string name, string url)
        {
            Name = name;
            _url = url;
        }

        public Image getRadarImage()
        {
            //TODO load image
            return null;
        }

        public bool SaveRadar()
        {
            //TODO save radar
            return false;
        }
    }
}
