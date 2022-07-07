#region Selection Statements Exercise 1


var r = new Random();
var favNumber = r.Next(1, 1000);
int userInput;

do
{
Console.WriteLine("Please pick a number between 1 and 1000.");
userInput = int.Parse(Console.ReadLine());

    if (userInput < favNumber)

    {
        Console.WriteLine($"{userInput} is too low.");
    }
    else if (userInput > favNumber)
    {
        Console.WriteLine($"{userInput} is too high.");
    }
    else
    {
        Console.WriteLine("Heyyyyy, you got it, yo!");
    }
} while (userInput != favNumber);

#endregion