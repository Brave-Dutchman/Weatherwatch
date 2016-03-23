namespace Weatherwatch.Core.Commands
{
    class SaveRadarsCommand : Command
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
