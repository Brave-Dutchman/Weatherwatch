using System;

namespace Weatherwatch.Core.Commands
{
    public class ReloadAllCommand : Command
    {
        private readonly Command[] _commands;

        public ReloadAllCommand(Command[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (Command command in _commands)
            {
                command.Execute();
            }
        }
    }
}
