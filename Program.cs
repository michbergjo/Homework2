// See https://aka.ms/new-console-template for more information
//Console Guest Book

string[] names;
string groupLeaderFirstName = "";
int numberOfPeople = 0;

//Ask for first name of user 
Console.WriteLine("Please enter your first name:");
groupLeaderFirstName = Console.ReadLine();
while(groupLeaderFirstName == null)
{
    Console.WriteLine("Please enter a valid first name");
    groupLeaderFirstName= Console.ReadLine();
}


//Ask how many guests in ther party
Console.WriteLine($"{groupLeaderFirstName} please enter the number of people in your party:");
bool isNumOfPeople = Int32.TryParse(Console.ReadLine(), out numberOfPeople);
while(isNumOfPeople == false)
{
    Console.WriteLine("Please enter a valid number of people");
    isNumOfPeople = Int32.TryParse(Console.ReadLine(),out numberOfPeople);
}
names = new string[numberOfPeople];
names[0] = groupLeaderFirstName;

if (numberOfPeople <= 1)
{
    Console.WriteLine($"Welcome {groupLeaderFirstName}! We hope you enjoy your stay");
} else if (numberOfPeople <= 2)
{
    Console.WriteLine($"{groupLeaderFirstName} please enter your guests name:");
    names[1] = Console.ReadLine();
    Console.WriteLine($"Welcome {groupLeaderFirstName} and {names[1]}! We hope you enjoy your stay!");
}
else
{

    //Add names of guests
    for (int i = 1; i < numberOfPeople; i++)
    {
        Console.WriteLine($"Please enter guest #{i}'s name:");
        names[i] = Console.ReadLine();
    }


    //Print Guest List & number of guests 
    Console.WriteLine($"We are looking forward to seeing {numberOfPeople} guests");
    Console.Write($"Welcome {groupLeaderFirstName},");
    for (int i = 1; i < numberOfPeople - 1; i++)
    {
        Console.Write($" {names[i]},");
    }
    Console.Write($"and {names[numberOfPeople - 1]}");
    Console.WriteLine("\nWe hope you enjoy your stay");
}