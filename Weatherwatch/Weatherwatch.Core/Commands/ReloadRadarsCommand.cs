﻿using System;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core.Commands
{
    class ReloadRadarsCommand : ICommand
    {
        private readonly RadarController radarController;

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
