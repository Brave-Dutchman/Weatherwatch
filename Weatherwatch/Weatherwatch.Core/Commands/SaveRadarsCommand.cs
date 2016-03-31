using Weatherwatch.Core.Controller;
using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Commands
{
    class SaveRadarsCommand : ICommand
    {
        private readonly RadarController _radarController;

        public SaveRadarsCommand(RadarController radarController)
        {
            _radarController = radarController;
        }
        
        public void Execute()
        {
            string fileLocation = FileStorage.CreateFile();

            foreach (Radar radar in _radarController.GetRadars())
            {
                radar.SaveRadar(fileLocation);
            }
        }
    }
}
