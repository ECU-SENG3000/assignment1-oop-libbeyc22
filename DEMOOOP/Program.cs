// See https://aka.ms/new-console-template for more information

using DEMOOOP.Models.Commands;
using DEMOOOP.Models;
using DEMOOOP;
using DEMOOOP.Extensions;
using DEMOOOP.Models.Actuators;

// Console.WriteLine("Hello, World!");

Robot robot = new();

#region "Static vs Instance Members"
    
// robot.Drive.LeftMotor.Move(0.5f);
// robot.Drive.RightMotor.Move(0.5f);

// float distance = robot.Drive.LeftMotor.Encoder.GetDistance();
// Console.WriteLine($"Distance: {distance} feet");

// MoveCommand.StaticProperty = 1;

// MoveCommand moveCommand = new();
// Console.WriteLine($"MoveCommand.StaticProperty: {MoveCommand.StaticProperty}");
// MoveCommand moveCommand1 = new();
// Console.WriteLine($"MoveCommand.StaticProperty: {MoveCommand.StaticProperty}");
// MoveCommand moveCommand2 = new();
// Console.WriteLine($"MoveCommand.StaticProperty: {MoveCommand.StaticProperty}");

// moveCommand.WriteStaticProperty();
// moveCommand1.WriteStaticProperty(); 
// moveCommand2.WriteStaticProperty(); 

// moveCommand.InstanceProperty = 1;
#endregion

//SequentialCommandGroup sequentialProgram = new();

//MoveCommand movecommand1 = new();
//sequentialProgram.AddCommand(movecommand1);

//RotateCommand rotatecommand1 = new();
//sequentialProgram.AddCommand(rotatecommand1);

//MoveCommand movecommand2 = new();  
//sequentialProgram.AddCommand(movecommand2);

//RotateCommand rotatecommand2 = new();
//sequentialProgram.AddCommand(rotatecommand2);

//MoveCommand movecommand3 = new();  
//sequentialProgram.AddCommand(movecommand3);

//RotateCommand rotatecommand3 = new();
//sequentialProgram.AddCommand(rotatecommand3);

//MoveCommand movecommand4 = new();
//sequentialProgram.AddCommand(movecommand4);

//RotateCommand rotatecommand4 = new();
//sequentialProgram.AddCommand(rotatecommand4);

//sequentialProgram.Execute();

// DriveInSquareSequentialCommandGroup driveInSquare = new();
// driveInSquare.Execute();

// driveInSquare.PrintProgram(title:"Drive In Square");

// CommandGroup sequentialProgram = new();
// sequentialProgram.PrintProgram("Sequential Program");

robot.Turret.Shooter.Shoot();

robot.Targeting.Camera.Capture();

robot.Targeting.Sonar.Ping();

robot.Turret.Servos.MoveServo(0.5f);