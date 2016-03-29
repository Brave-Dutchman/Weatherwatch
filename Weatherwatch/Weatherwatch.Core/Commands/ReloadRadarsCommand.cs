using System;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core.Commands
{
    class ReloadRadarsCommand : Command
    {
        private RadarController radarController;

        public ReloadRadarsCommand(RadarController radarController)
        {
            this.radarController = radarController;
        }

        public void Execute()
        {
            radarController.ReloadRadars();
        }
    }
}
