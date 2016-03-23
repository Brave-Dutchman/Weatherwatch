using System;
using System.Windows.Media.Imaging;

namespace Weatherwatch.Core.Objects
{
    public class Radar
    {
        public string Name { get; private set; }

        private readonly string _url;
        private BitmapImage _radarImage;

        public Radar(string name, string url)
        {
            Name = name;
            _url = url;

            ReloadImage();
        }

        public BitmapImage GetRadarImage()
        {
            return _radarImage;
        }

        public void ReloadImage()
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
