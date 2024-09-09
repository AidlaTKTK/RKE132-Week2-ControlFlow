Console.WriteLine("Please enter your age:");

string userAge = Console.ReadLine();
int userAgeNum = 0;
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (!isAgeNumber)
{
    Console.WriteLine("Could not read age"); return;
}
else
{
    if (userAgeNum >= 13) Console.WriteLine("Welcome!");
    else Console.WriteLine("Access denied.");
}