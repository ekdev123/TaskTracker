

//Initializing local var
var userSelection ="";


do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("**** Task Tracker ****\n\n");
    Console.Write("--- Enter a selection ---\n\n" +
        "1: Add Task\n" +
        "2: Delete Task\n" +
        "3: View Tasks\n" +
        "4: Export tasks to text file\n" +
        "5: Exit\t");
    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            //logic to add task to list
            break;
        case "2":
            //logic to delete task from list
            break;
        case "3":
            //logic to view tasks stored to list
            break;
        case "4":
            //logic to export task list to file
            break;
        case "5":
            break;      
    }

} while (userSelection != "5");
