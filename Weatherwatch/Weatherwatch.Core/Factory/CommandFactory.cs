using Weatherwatch.Core.Commands;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core.Factory
{
    public class CommandFactory
    {
        public ICommand[] Create()
        {
            RadarController radar = new RadarController();
            WarningsController warning = new WarningsController();

            ReloadRadarsCommand reloadRadarsCommand = new ReloadRadarsCommand(radar);
            ReloadWarningsCommand reloadWarningsCommand = new ReloadWarningsCommand(warning);
            ReloadAllCommand reloadAllCommand = new ReloadAllCommand(new ICommand[] { reloadRadarsCommand, reloadWarningsCommand });
            SaveRadarsCommand saveRadarsCommand = new SaveRadarsCommand(radar);
            SaveWarningsCommand saveWarningsCommand = new SaveWarningsCommand(warning);
            SaveAllCommand saveAllCommand = new SaveAllCommand(new ICommand[] { saveRadarsCommand, saveWarningsCommand });

            return new ICommand[] { reloadRadarsCommand, reloadWarningsCommand, reloadAllCommand, saveRadarsCommand, saveWarningsCommand, saveAllCommand };
        }
    }
}
