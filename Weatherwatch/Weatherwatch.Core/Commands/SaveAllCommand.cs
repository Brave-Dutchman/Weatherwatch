namespace Weatherwatch.Core.Commands
{
    class SaveAllCommand : ICommand
    {
        private ICommand[] commands;

        public SaveAllCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
        }
    }
}
