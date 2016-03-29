using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Commands
{
    class SaveRadarsCommand : ICommand
    {
        public void Execute()
        {
            foreach (Radar radar in Storage.GetInstance().GetRadars())
            {
                radar.SaveRadar();
            }
        }
    }
}
