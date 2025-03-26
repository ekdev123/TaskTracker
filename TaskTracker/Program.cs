using System.ComponentModel;
using TaskTracker;

var userSelection ="";
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
    
    userSelection = Console.ReadLine();

    

    switch (userSelection)
    {
        case "1":
            Utilities.addTask(userTask);
            break;
        case "2":
            //logic to delete task from list
            break;
        case "3":
            //logic to Export task to text file
            break;
        case "4":
            //exit app
            break;   
    }

} while (userSelection != "4");

Console.WriteLine("Thank you, have a great day");