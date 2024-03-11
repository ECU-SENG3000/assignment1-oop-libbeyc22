using DEMOOOP.Models.Actuators;

namespace DEMOOOP.Models.Subsystems;

public class TurretSubsystem
{

    public Shooter Shooter { get; set; } = new();

    public Servos Servos { get; set; } = new();

}
