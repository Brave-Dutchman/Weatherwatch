using System.Collections.Generic;
using System.Linq;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Controller
{
    public class WarningsController
    {
        private readonly Storage _storage;

        public WarningsController()
        {
            _storage = Storage.GetInstance();
        }

        public Warning GetWarning(string location)
        {
            return _storage.GetWarning(location);
        }

        public List<Warning> GetWarnings()
        {
            return _storage.GetWarnings();
        }

        public string[] GetRadarNames()
        {
            return GetWarnings().Select(warning => warning.Location).ToArray();
        }
    }
}
