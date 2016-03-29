﻿using System.Collections.Generic;
using Weatherwatch.Core.Commands;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Controller
{
    public class MainController
    {
        private readonly WarningsController _warningsController;
        private readonly RadarController _radarController;

        private Command[] _commands;

        public MainController()
        {
            _warningsController = new WarningsController();
            _radarController = new RadarController();
            CreateCommands();
        }

        private void CreateCommands()
        {
            ReloadRadarsCommand reloadRadarsCommand = new ReloadRadarsCommand(_radarController);
            ReloadWarningsCommand reloadWarningsCommand = new ReloadWarningsCommand(_warningsController);
            ReloadAllCommand reloadAllCommand = new ReloadAllCommand(new Command[] {reloadRadarsCommand, reloadWarningsCommand});
            SaveRadarsCommand saveRadarsCommand = new SaveRadarsCommand();
            SaveWarningsCommand saveWarningsCommand = new SaveWarningsCommand();
            SaveAllCommand saveAllCommand = new SaveAllCommand(new Command[] { saveRadarsCommand, saveWarningsCommand });

            _commands = new Command[] { reloadRadarsCommand, reloadWarningsCommand, reloadAllCommand, saveRadarsCommand, saveWarningsCommand, saveAllCommand };
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

        public string[] GetWarningNames()
        {
            return _warningsController.GetRadarNames();
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
