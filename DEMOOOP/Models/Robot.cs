namespace DEMOOOP.Models;

using DEMOOOP.Models.Subsystems;

public class Robot
{
    public DriveSubsystem Drive { get; set; } = new();
    public TurretSubsystem Turret { get; set; } = new();
    public TargetingSubsystem Targeting { get; set; } = new();
}
