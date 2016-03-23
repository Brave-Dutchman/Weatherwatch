using System.Collections.Generic;
using Weatherwatch.Core.Commands;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Controller
{
    public class MainController
    {
        private WarningsController _warningsController;
        private RadarController _radarController;
        private Command[] _commands;

        public MainController()
        {
            _warningsController = new WarningsController();
            _radarController = new RadarController();

            _commands = new Command[0]; //TODO add Commands
        }

        public List<Radar> GetRadars()
        {
            return _radarController.GetRadars();
        }

        public Radar GetRadar(string name)
        {
            return _radarController.GetRadar(name);
        }

        public Warning GetWarning(string location)
        {
            return _warningsController.GetWarning(location);
        }

        public List<Warning> GetWarnings()
        {
            return _warningsController.GetWarnings();
        }
    }
}
