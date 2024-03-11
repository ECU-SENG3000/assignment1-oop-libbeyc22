namespace DEMOOOP.Models.Actuators;

using DEMOOOP.Models.Sensors;

public class Motor
{
    public Encoder Encoder { get; set; } = new();
    public void Move(float speed)
    {
        // Move the motor at the given speed
        Console.WriteLine($"Motor is moving at {speed} speed");
    }
}
