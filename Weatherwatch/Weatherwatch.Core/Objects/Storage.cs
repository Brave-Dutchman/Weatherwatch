using System.Collections.Generic;
using System.Linq;

namespace Weatherwatch.Core.Objects
{
    public class Storage
    {
        private static Storage _instance;
        private readonly List<Radar> _radarList;
        private readonly List<WarningLocation> _warningList;

        private WarningLocation _selectedWarning;

        private Storage()
        {
            _warningList = new List<WarningLocation>();
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

        public void AddWarning(WarningLocation warning)
        {
            _warningList.Add(warning);
        }

        public void SetSelectWarning(string warningLocation)
        {
            _selectedWarning = GetWarningLocation(warningLocation);
        }

        public List<Radar> GetRadars()
        {
            return _radarList;
        }

        public Warning[] GetWarnings(string warningLocation)
        {
           return GetWarningLocation(warningLocation).GetWarnings();
        }

        public List<WarningLocation> GetWarningLocations()
        {
            return _warningList;
        }

        public Radar GetRadar(string name)
        {
            return _radarList.FirstOrDefault(x => x.Name == name);
        }

        public void ReloadRadars()
        {
            foreach (Radar radar in _radarList)
            {
                radar.ReloadRadarImage();
            }
        }

        private WarningLocation GetWarningLocation(string location)
        {
            return _warningList.FirstOrDefault(x => x.Location == location);
        }

        public WarningLocation GetSelectedWarning()
        {
            return _selectedWarning;
        }

        public void ReloadWarnings(string warningLocation)
        {
            _selectedWarning.LoadWarnings();
        }
    }
}
