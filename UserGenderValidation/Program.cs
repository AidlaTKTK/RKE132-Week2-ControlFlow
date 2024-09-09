// Oma lahendus

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

Console.WriteLine("Please, select your gender (m/f/x)");
char userGender = Char.Parse(Console.ReadLine());

switch (userGender)
{
    case 'm':
        Console.WriteLine($"Welcome, Mr. {userLastName}!");
        break;
    case 'f':
        Console.WriteLine($"Welcome, Ms. {userLastName}!");
        break;
    case 'x':
    default:
        Console.WriteLine($"Welcome, Mx. {userLastName}!");
        break;
}

// Video põhjal lahendus
/*
if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}");
}
*/
