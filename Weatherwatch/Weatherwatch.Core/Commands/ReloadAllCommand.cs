using System;

namespace Weatherwatch.Core.Commands
{
    public class ReloadAllCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public ReloadAllCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand command in _commands)
            {
                command.Execute();
            }
        }
    }
}
