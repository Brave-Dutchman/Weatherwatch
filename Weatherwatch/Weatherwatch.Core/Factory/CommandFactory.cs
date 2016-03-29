using Weatherwatch.Core.Commands;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core.Factory
{
    public class CommandFactory
    {
        public ICommand[] Create()
        {
            ReloadRadarsCommand reloadRadarsCommand = new ReloadRadarsCommand(new RadarController());
            ReloadWarningsCommand reloadWarningsCommand = new ReloadWarningsCommand(new WarningsController());
            ReloadAllCommand reloadAllCommand = new ReloadAllCommand(new ICommand[] { reloadRadarsCommand, reloadWarningsCommand });
            SaveRadarsCommand saveRadarsCommand = new SaveRadarsCommand();
            SaveWarningsCommand saveWarningsCommand = new SaveWarningsCommand();
            SaveAllCommand saveAllCommand = new SaveAllCommand(new ICommand[] { saveRadarsCommand, saveWarningsCommand });

            return new ICommand[] { reloadRadarsCommand, reloadWarningsCommand, reloadAllCommand, saveRadarsCommand, saveWarningsCommand, saveAllCommand };
        }
    }
}
