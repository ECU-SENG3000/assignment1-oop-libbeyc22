namespace DEMOOOP.Models.Commands;

public class RotateCommand: Command
{
    public override void Setup()
    {
        Console.WriteLine("RotateCommand Setup");
    }

    public override void Execute()
    {
        Console.WriteLine("Rotating...");
    }

    public override void End()
    {
        Console.WriteLine("RotateCommand End");
    }

}
