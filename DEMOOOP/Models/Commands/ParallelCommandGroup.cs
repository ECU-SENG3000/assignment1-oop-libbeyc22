namespace DEMOOOP.Models.Commands;

public class ParallelCommandGroup: CommandGroup
{
    public override void Execute()
    {
        Parallel.ForEach(Commands, command => 
        {
            command.Execute();
        });
    }
}
