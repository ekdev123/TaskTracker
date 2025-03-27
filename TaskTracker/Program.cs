using System.ComponentModel;
using TaskTracker;

var userSelection =0;
string userTask = "";

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n**** Task Tracker ****\n\n");
    Console.Write("--- Enter a selection ---\n\n" +
        "1: Add Task(s)\n" +
        "2: Delete Task(s)\n" +
        "3: View Task(s)\n" +
        "4: Send Task(s) to text file\n" +
        "5: Exit\n" +
        "\nSelection: ");
    try
    {
        userSelection = int.Parse(Console.ReadLine());
    }catch (FormatException) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInvalid selection, please enter a number 1-4:\n");
        continue;
        
    }

    switch (userSelection)
    {
        case 1:
            Utilities.addTask(userTask);
            break;
        case 2:
            Utilities.deleteTask();
            break;
        case 3:
            Utilities.viewTask();
            break;
        case 4:
            //future method call
            break;
        case 5:
            break;

    }

} while (userSelection != 4);

Console.WriteLine("\nThank you, have a great day");