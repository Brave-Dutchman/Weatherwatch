using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwatch.Core
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
