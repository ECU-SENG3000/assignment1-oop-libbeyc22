using DEMOOOP.Models.Actuators;

namespace DEMOOOP.Models.Subsystems;

public class DriveSubsystem
{
    public Motor LeftMotor { get; set; } = new();

    public Motor RightMotor { get; set; } = new();


}
