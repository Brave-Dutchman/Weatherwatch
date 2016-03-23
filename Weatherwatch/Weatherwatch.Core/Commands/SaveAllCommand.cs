namespace Weatherwatch.Core.Commands
{
    class SaveAllCommand : Command
    {
        private Command[] commands;

        public SaveAllCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (Command command in commands)
            {
                command.Execute();
            }
        }
    }
}
