using DEMOOOP.Models.Sensors;

namespace DEMOOOP.Models.Subsystems;

public class TargetingSubsystem
{

    public Camera Camera { get; set; } = new();

    public Sonar Sonar { get; set; } = new();

}
