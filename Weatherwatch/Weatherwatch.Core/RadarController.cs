using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwatch.Core
{
    public class RadarController
    {
        private readonly Storage _storage;

        public RadarController()
        {
            _storage = Storage.GetInstance();
        }

        public List<Radar> GetRadars()
        {
            return _storage.GetRadars();
        }

        public Radar GetRadar(string name)
        {
            return _storage.GetRadar(name);
        }
    }
}
