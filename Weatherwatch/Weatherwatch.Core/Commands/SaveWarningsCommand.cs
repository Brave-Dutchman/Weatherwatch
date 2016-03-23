namespace Weatherwatch.Core.Commands
{
    class SaveWarningsCommand : Command
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
