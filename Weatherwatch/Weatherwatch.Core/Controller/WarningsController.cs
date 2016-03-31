using System.Linq;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Controller
{
    public class WarningsController
    {
        private readonly Storage _storage;
        public static string WarningType { get; private set; }
        public static string WarningLevel { get; private set; }
        public static string WarningStart { get; private set; }
        public static string WarningEnd { get; private set; }

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
    }
}
