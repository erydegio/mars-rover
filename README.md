# Mars Rover

You’re part of the team that explores Mars by sending remotely controlled vehicles to the surface of the planet.  
This program translates the commands sent from earth to instructions that are understood by the rover.

## How it works  

 - Is given a starting point 0,0 (x,y) and a direction N (N,S,E,W) the rover is facing on the planet map (```Mars``` object).  
   - The rover receives a character array of commands with its method ```GetCommands()```:
   - The ```CommandsHandler``` class with its method ```HandleCommand()``` translate a single command into an ```Instructions``` object that the rover can understand.
   - With an instruction the rover depending on its position can:
      - Give a message if the command is not implemented.
      - Detect obstacles before each move: if a given sequence of commands encounters an obstacle, the rover moves up to the last possible point, aborts the sequence and reports the obstacle (```DetectObstacles()``` method).
      - If the instructions are correct the rover with its method ```Move()``` can:
        - Move forward/backward (f,b).  
        - Turn left/right (l,r).       
 - Is implemented the wrap from one edge of the grid to another during the creation of the new instruction.
 
## How to run

This project is a C# Console Application (.NET 6 SDK installation required).  
After cloning this repository find the solution file in ```\MarsRover\``` folder and enter the command ```dotnet run```.
  
## Tests
You can run Tests in the project folder ```\MarsRover.Tests\``` and run ```dotnet test``` from the console.

