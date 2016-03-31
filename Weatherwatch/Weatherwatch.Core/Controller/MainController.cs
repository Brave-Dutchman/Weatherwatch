using System.Collections.Generic;
using Weatherwatch.Core.Commands;
using Weatherwatch.Core.Factory;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Controller
{
    public class MainController
    {
        private readonly WarningsController _warningsController;
        private readonly RadarController _radarController;

        private readonly ICommand[] _commands;

        public MainController()
        {
            _warningsController = new WarningsController();
            _radarController = new RadarController();
            _commands = new CommandFactory().Create();
        }

        public void ExecuteCommand(CommandsEnum command)
        {
            _commands[(int) command].Execute();
        }

        public List<Radar> GetRadars()
        {
            return _radarController.GetRadars();
        }

        public Radar GetRadar(string name)
        {
            return _radarController.GetRadar(name);
        }

        public string[] GetRadarNames()
        {
            return _radarController.GetRadarNames();
        }

        public string[] GetWarningLocations()
        {
            return _warningsController.GetWarningLocations();
        }

        public Warning[] GetWarnings(string warningLocation)
        {
            return _warningsController.GetWarnings(warningLocation);
        }
    }
}
