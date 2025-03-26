using System.ComponentModel;
using TaskTracker;

var userSelection =0;
string userTask = "";

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n**** Task Tracker ****\n\n");
    Console.Write("--- Enter a selection ---\n\n" +
        "1: Add Tasks\n" +
        "2: Delete Task\n" +
        "3: Export tasks to text file\n" +
        "4: Exit\n" +
        "\nSelection: ");
    try
    {
        userSelection = int.Parse(Console.ReadLine());
    }catch (FormatException) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInvalid selection, please enter a number 1-4:\n");
        
    }

    switch (userSelection)
    {
        case 1:
            Utilities.addTask(userTask);
            break;
        case 2:
            //logic to delete task from list
            break;
        case 3:
            //logic to Export task to text file
            break;
        case 4:
            //exit app
            break;

    }

} while (userSelection != 4);

Console.WriteLine("Thank you, have a great day");