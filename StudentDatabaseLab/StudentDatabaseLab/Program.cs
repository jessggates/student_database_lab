
using System.ComponentModel.DataAnnotations;

string[] name = new string[5] { "Harry Styles", "Taylor Swift", "Beyonce Knowles", "Travis Kelce", "Travis Barker" };
string[] hometown = new string[5] { "Worcestershire", "West Reading", "Houston", "Westlake", "Fontana" };
string[] favoriteFood = new string[5] { "Burgers", "Pizza", "Pasta", "Steak", "Salad" };

bool playAgain = true;


while (playAgain == true)
{
    Console.WriteLine("Ask about a student by number (1-5)");
    int userStudentChoice = int.Parse(Console.ReadLine());

    if (ValidateUserNumber(userStudentChoice) == true)
    {

        int indexCounter = userStudentChoice - 1;
        string selectedName = name[indexCounter];
        bool needValidFact = true;

        while (needValidFact == true)
        {
            Console.WriteLine();
            Console.WriteLine($"Student {userStudentChoice} is {name[indexCounter]}. " +
            $"What would you like to know about {selectedName}? Enter 'hometown' or 'favorite food': ");
            string userFactChoice = Console.ReadLine().ToLower().Trim();

            if (ValidCategory(userFactChoice) == true)
            {
                needValidFact = false;
                if (userFactChoice == "hometown")
                {
                    Console.WriteLine($"{selectedName} is from {hometown[indexCounter]}!");
                }
                else if (userFactChoice == "favorite food")
                {
                    Console.WriteLine($"{selectedName}'s favorite food is {favoriteFood[indexCounter]}!");
                }
            }
            else Console.WriteLine("Please try again! Enter 'hometown' or 'favorite food'");
        }
        Console.WriteLine();
        Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n': ");
        string userAnswer = Console.ReadLine();
        if (userAnswer == "y")
            playAgain = true;
        else playAgain = false;
    }
    else Console.WriteLine("Please try again! Enter a valid number (1-5).");
}
Console.WriteLine();
Console.WriteLine("Thanks!");

bool ValidateUserNumber(int userNumber)
{
    if (userNumber < 1 || userNumber > name.Length)
        return false;
    else return true;
}

bool ValidCategory(string category)
{
    if (category == "hometown" || category == "favorite food")
        return true;
    else return false;
}

Console.ReadKey();