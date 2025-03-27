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
        static List<string> taskList = new List<string>(); //creating list to store user input


        public static void addTask(string userTask) //method to handle adding tasks to list
        {
            int numOfTasks = 0;
            bool validInput = false;

            while (!validInput) //using while to implement try/catch for user input validation
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
            if (numOfTasks != 0) //setting up logic to append items to taskList
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
        public static void deleteTask() //delete task method
        {
            int taskNumberDelete = 0;
            bool validInput = false;

            while (!validInput) //using while to force iteration through logic
            {

                for (int i = 0; i < taskList.Count; i++) //logic to iterate through task list and also print position [i] 
                {
                    Console.WriteLine($"{i + 1}, {taskList[i]}");
                }
                Console.WriteLine("Which task would you like to \u001b[31mDelete\u001b[0m? "); //Being extra, inserting unicode for delete keyword to make it red
                taskNumberDelete = int.Parse(Console.ReadLine());
            }
        }

            //}
            //internal static void viewTask()
            //{

            //}
            //internal static void saveTask()
            //{

            //}

        }
}
