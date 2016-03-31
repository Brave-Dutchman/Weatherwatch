using System;
using Weatherwatch.Core.Controller;

namespace Weatherwatch.Core.Commands
{
    class ReloadWarningsCommand : ICommand
    {
        private readonly WarningsController _warningsController;

        public ReloadWarningsCommand(WarningsController warningsController)
        {
            this._warningsController = warningsController;
        }

        public void Execute()
        {
            _warningsController.GetSelectedWarning().LoadWarnings();
        }
    }
}
