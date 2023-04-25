// Basic Loops Lab

//Use a do-while loop to output "Hello, World!" in a loop.
//Each time you output "Hello, World!" ask the user whether they would like to continue.
/*
{
    string userInput = "y";
    do
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Would you like to continue? (y/n)");
        userInput = Console.ReadLine();
    } while (userInput == "y");

        Console.WriteLine("Goodbye!");
}
*/


//Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.
//After that loop finishes, use another loop to output all the numbers from 0 to that number.
/*
int userInput;
Console.WriteLine("Please give me a number:");
userInput = int.Parse(Console.ReadLine());

for (int i = userInput; i >= 0; i--)
{ 
    Console.WriteLine(i); 
}

for (int i = 0; i <= userInput; i++)
{
    Console.WriteLine( i);
}
//The instructions don't ask about continuing, but the example shows it.
//Console.WriteLine("Would you like to continue? (y/n)");

Console.WriteLine("Goodbye!");
Console.ReadKey();
*/


//A door has a keypad entry. The combination to get in is 13579.
//Write a while loop (not a do while loop) that asks the user to enter a key code.
//The loop will repeat as long as the user enters the wrong code.
//After the user enters the correct code, the program will print out a welcome message.
//After 5 unsuccessful attempts loop ends with note
/*
int keyCode = -1;
int guessNumber = 0;

while (keyCode != 13579 && guessNumber <= 4)
{
    Console.WriteLine("Please enter the key code.");
    string userEntry = Console.ReadLine();
    keyCode = int.Parse(userEntry);
    guessNumber++;
}

if (guessNumber > 4)
    {
    Console.WriteLine("There have been too many incorrent attempts.");
        }

else if (keyCode == 13579)
{
    Console.WriteLine("Welcome!");
}

Console.ReadKey();
*/

//Start a new console project, and repeat the same exercise as the previous,
//except this time implement it with a do while loop.

int keyCode = -1;
int guessNumber = 0;

do
{
    Console.WriteLine("Please enter the key code.");
    string userEntry = Console.ReadLine();
    keyCode = int.Parse(userEntry);
    guessNumber++;
} while (keyCode != 13579 && guessNumber <= 4);

if (guessNumber > 4)
{
    Console.WriteLine("There have been too many incorrent attempts.");
}

else if (keyCode == 13579)
{
    Console.WriteLine("Welcome!");
}

Console.ReadKey();


//Optional Stretch
//Move the last while loop or the do-while loop into its own function. 
//The function should return a true if access is granted, or a false if the user didn’t enter the correct code within 5 tries.
