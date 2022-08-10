# Mars Rover

You’re part of the team that explores Mars by sending remotely controlled vehicles to the surface of the planet.  
This program translates the commands sent from earth to instructions that are understood by the rover.

## How it works  

 Is given a starting position 0 0 N the rover is facing on the planet map (```Mars``` object).  
 A rover's position and location is represented by X Y coordinates and a cardinal point (N, E, S, W).   
 The planet is divided up into a grid. 
 
 The rover receives a character array of commands with the method ```GetCommands```
  Commands implemented:
 - 'r' : turn 90° right
 - 'l' : turn 90° left
 - 'f' : move forward
 - 'b' : move backward
 - 'j' : move forward by 2
 
 A ```CommandsHandler``` class process every character and return an ```Instructions``` object that the rover can translate into a movement.  
 An instruction contains informations about the next position, the type of movement (turn l/r or move f/b/j) and error if the command is not implemented.
   
 The rover takes the instruction and if the command is impelemented tries to move:
 - Wrap the position to the edge of the grid to another
 - If is not a turning instruction try to detect an obstacle: if it finds one, moves up to the last possible point, aborts the sequence and reports the obstacle
       
## How to run

This project is a C# Console Application (.NET 6 SDK installation required).  
After cloning this repository find the solution file in ```\MarsRover``` folder and enter the command ```dotnet build``` and then ```dotnet run```.
  
## Tests  
[![codecov](https://codecov.io/gh/erydegio/mars-rover/branch/main/graph/badge.svg?token=HDU5H5LOLU)](https://codecov.io/gh/erydegio/mars-rover)  
You can run Tests in the project folder ```\MarsRover``` and run ```dotnet test``` from the console.

