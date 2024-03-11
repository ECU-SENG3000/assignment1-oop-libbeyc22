namespace DEMOOOP.Extensions;

public static class CommandGroupExtensions
{
    public static void PrintProgram(this CommandGroup commandGroup, string title = "Program")
    {
        Console.WriteLine($"{title}:");
        foreach (var command in commandGroup.Commands)
        {
            Console.WriteLine(command.GetType().Name);
        }
    }
}
