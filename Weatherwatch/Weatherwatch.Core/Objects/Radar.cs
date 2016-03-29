using System;
using System.Windows.Media.Imaging;

namespace Weatherwatch.Core.Objects
{
    public class Radar
    {
        public string Name { get; private set; }

        private readonly string _url;
        private BitmapImage _radarImage;

        private Radar()
        {
            ReloadRadarImage();
        }

        public Radar(string name, string url) : this()
        {
            Name = name;
            _url = url;
        }

        public BitmapImage GetRadarImage()
        {
            return _radarImage;
        }

        public void ReloadRadarImage()
        {
            _radarImage = new BitmapImage(new Uri(_url));
        }

        public bool SaveRadar()
        {
            //TODO save radar
            return false;
        }
    }
}
