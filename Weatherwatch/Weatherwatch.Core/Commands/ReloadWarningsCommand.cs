using System;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core.Commands
{
    class ReloadWarningsCommand : ICommand
    {
        private WarningsController warningsController;

        public ReloadWarningsCommand(WarningsController warningsController)
        {
            this.warningsController = warningsController;
        }

        public void Execute()
        {
           warningsController.GetWarnings();
            //TODO aparte reload methode
        }
    }
}
