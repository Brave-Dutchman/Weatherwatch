using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Weatherwatch.Core.Controller;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Commands
{
    class SaveWarningsCommand : ICommand
    {
        private readonly WarningsController _warningsController;

        public SaveWarningsCommand(WarningsController warningController)
        {
            _warningsController = warningController;
        }

        public void Execute()
        {
            string fileLocation = FileStorage.CreateFile();

            WarningLocation warningLocation = _warningsController.GetSelectedWarning();
            File.WriteAllText($"{fileLocation}Warnings.json" ,JsonConvert.SerializeObject(warningLocation.GetWarnings()));
        }
    }
}
