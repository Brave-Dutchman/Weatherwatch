namespace Weatherwatch.Core.Commands
{
    class SaveAllCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public SaveAllCommand(ICommand[] commands)
        {
            this._commands = commands;
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
