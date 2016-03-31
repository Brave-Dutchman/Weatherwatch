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

        public Warning[] GetWarning(string location)
        {
            return _storage.GetWarnings(location);
        }

        public Warning[] GetWarnings(string warningLocation)
        {
            return _storage.GetWarnings(warningLocation);
        }

        public string[] GetWarningLocations()
        {
            return _storage.GetWarningLocations().Select(warning => warning.Location).ToArray();
        }

        public WarningLocation GetSelectedWarning()
        {
            return _storage.GetSelectedWarning();
        }

        public void SetSelectedWarning(string warningLocation)
        {
                _storage.SetSelectWarning(warningLocation);
        }
    }
}
