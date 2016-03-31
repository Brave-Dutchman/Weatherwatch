using System;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core.Commands
{
    class ReloadRadarsCommand : ICommand
    {
        private readonly RadarController _radarController;

        public ReloadRadarsCommand(RadarController radarController)
        {
            _radarController = radarController;
        }

        public void Execute()
        {
            _radarController.ReloadRadars();
        }
    }
}
