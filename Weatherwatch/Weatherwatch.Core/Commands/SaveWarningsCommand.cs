using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Commands
{
    class SaveWarningsCommand : ICommand
    {
        public void Execute()
        {
            foreach (WarningLocation warningLocation in Storage.GetInstance().GetWarningLocations())
            {
                foreach (Warning warning in warningLocation.GetWarnings())
                {
                    warning.SaveWarning();
                }
            }
        }
    }
}
