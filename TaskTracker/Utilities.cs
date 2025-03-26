using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    class Utilities
    {
        static List<string> taskList = new List<string>();

        public static void addTask(string userTask)
        {
            int numOfTasks = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("How many tasks would you like to add? ");

                try
                {
                    numOfTasks = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid input, please enter a number\n");           
                }
            }
            if (numOfTasks != 0)
            {
                for (int i = 0; i < numOfTasks; i++)
                {
                    Console.Write($"Enter task: {i + 1}:  ");
                    userTask = Console.ReadLine();
                    taskList.Add(userTask);
                }
                Console.WriteLine("\nTasks added succesfully! Returning to main menu.");
            }
            else
            {
                Console.WriteLine("\nNo tasks to add returning to selection menu");
                return;
            }
            
        }
        //internal static void deleteTask()
        //{

        //}
        //internal static void viewTask()
        //{

        //}
        //internal static void saveTask()
        //{

        //}

    }
}
