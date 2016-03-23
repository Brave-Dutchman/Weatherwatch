using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Weatherwatch.Core
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
