﻿using System;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Commands
{
    class SaveRadarsCommand : ICommand
    {
        public void Execute()
        {
            string fileLocation = FileStorage.CreateFile();

            foreach (Radar radar in Storage.GetInstance().GetRadars())
            {
                radar.SaveRadar(fileLocation);
            }
        }
    }
}
