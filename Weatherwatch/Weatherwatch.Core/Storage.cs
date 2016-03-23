using System.Collections.Generic;
using System.Linq;

namespace Weatherwatch.Core
{
    public class Storage
    {
        private static Storage _instance;
        private readonly List<Radar> _radarList;
        private readonly List<Warning> _warningList;

        private Storage()
        {
            _warningList = new List<Warning>();
            _radarList = new List<Radar>();
        }

        public static Storage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Storage();
            }

            return _instance;
        }

        public void AddRadar(Radar radar)
        {
            _radarList.Add(radar);
        }

        public void AddWarning(Warning warning)
        {
            _warningList.Add(warning);
        }

        public Radar GetRadar(string name)
        {
            return _radarList.FirstOrDefault(x => x.Name == name);
        }

        public Warning GetWarning(string location)
        {
            return _warningList.FirstOrDefault(x => x.Location == location);
        }
    }
}
