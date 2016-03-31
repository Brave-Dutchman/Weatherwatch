using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Commands
{
    class SaveWarningsCommand : ICommand
    {
        public void Execute()
        {
            string fileLocation = FileStorage.CreateFile();

            WarningLocation warningLocation = Storage.GetInstance().GetSelectedWarning();
            File.WriteAllText($"{fileLocation}Warnings.json" ,JsonConvert.SerializeObject(warningLocation.GetWarnings()));
        }
    }
}
