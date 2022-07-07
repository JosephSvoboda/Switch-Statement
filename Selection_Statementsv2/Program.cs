

Console.WriteLine("What is your favorite school subject?");
var userInput = Console.ReadLine();

switch (userInput)
{
    case "Math":
        Console.WriteLine("My favorite!");
        break;

    case "Science":
        Console.WriteLine("Very nice.");
        break;

    case "English":
        Console.WriteLine("Eh, my least favorite");
        break;

    case "Band":
        Console.WriteLine("Is this even a real subject?");
        break;

    case "P.E.":
        Console.WriteLine("Ah, the best of the best!");
        break;
        
        default:
        Console.WriteLine("Try again.");
        break;
}