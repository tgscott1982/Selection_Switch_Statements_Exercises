#region Switch Statements Exercise 2

Console.WriteLine("Hi! What's your favorite school subject?");

string subject = Console.ReadLine();

switch (subject.ToLower())
{
    case "math":
        Console.WriteLine("Ugh, math.....J/K! I actually really like numbers!");
        break;
    case "english":
        Console.WriteLine("I should've been an English teacher. Or a professional book-reader! *sigh*");
        break;
    case "gym":
        Console.WriteLine("I was a fat kid.....fat kids don't do gym.");
        break;
    case "history":
        Console.WriteLine("I'm terrible with dates!");
        break;
    case "geography":
        Console.WriteLine("I can barely remember where my car keys are let alone tell you where something is on a map!");
        break;
    default:
        Console.WriteLine("What? What's that? What kind of goofy school did you go to?");
        break;



}

#endregion