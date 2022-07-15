// See https://aka.ms/new-console-template for more information


using MarsRover;

Rover rover = new Rover(new Mars());

char[] a = { 'f', 'l', 'f', 'r', 'f', 'f' };
char[] b = { 'f', 'f', 'r', 'f', 'f', 'f','b' };
char[] d = { 'r', 'f', 'g', 'b','f'};


rover.GetCommands(a);
rover.GetCommands(b);
rover.GetCommands(d);


while (true)
{
    Console.WriteLine("Insert exit to quit....");
    string input = Console.ReadLine();
    if (input == "exit")
    {
        break;  
    }
}