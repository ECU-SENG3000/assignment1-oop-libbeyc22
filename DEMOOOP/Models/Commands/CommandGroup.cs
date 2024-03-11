using DEMOOOP.Models.Commands;

namespace DEMOOOP;

public class CommandGroup
{
    public List<Command> Commands { get; set; } = new();

    public virtual void Execute()
    {
        
    }

    public void AddCommand(Command command)
    {
        Commands.Add(command);
    }

}
