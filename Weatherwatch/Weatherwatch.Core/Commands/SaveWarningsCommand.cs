using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Commands
{
    class SaveWarningsCommand : ICommand
    {
        public void Execute()
        {
            foreach (Warning warning in Storage.GetInstance().GetWarnings())
            {
               warning.SaveWarning();
            }
        }
    }
}
