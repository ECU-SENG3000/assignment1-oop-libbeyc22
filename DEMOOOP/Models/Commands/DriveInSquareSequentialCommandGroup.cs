using DEMOOOP.Models.Commands;

namespace DEMOOOP;

public class DriveInSquareSequentialCommandGroup: SequentialCommandGroup
{
    public DriveInSquareSequentialCommandGroup()
    {
        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());
        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());
        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());
        AddCommand(new MoveCommand());
        AddCommand(new RotateCommand());
    }
}
