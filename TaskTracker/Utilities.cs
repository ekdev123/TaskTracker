using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    class Utilities
    {
        static List<string> taskList = new List<string>(); //creating list to store user input


        internal static void addTask(string userTask) //method to handle adding tasks to list
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
                    mRed();
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTasks added succesfully! Returning to main menu.");
            }
            else
            {
                Console.WriteLine("\nNo tasks to add returning to selection menu");
                return;
            }
            
        }
        internal static void deleteTask() //delete task method
        {
            
            Console.Write("Printing the tasks...\n");
            for (int i = 0; i < taskList.Count; i++) //logic to iterate through task list and also print position [i] 
            {
                Console.WriteLine($"\t{i + 1}, {taskList[i]}");
            }
            Console.Write("\nWhich task would you like to \u001b[31mDelete?\u001b[0m "); //Being extra, inserting unicode for delete keyword to make it red

            int taskNumberDelete = 0;
            bool validInput = false;

            while (!validInput) //using while to validate user input
            {
                try
                {
                    taskNumberDelete = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    mRed();
                    Console.WriteLine("\nInvalid input, please enter the task number\n");
                }
            } 
            if (taskNumberDelete > 0 && taskNumberDelete <= taskList.Count)
            {
                taskList.RemoveAt(taskNumberDelete - 1);
                Console.WriteLine("\nTask deleted succesfully, returning to main menu");
            }
            else
            {
                mRed();
                Console.Write("Invalid Task number");
            }
            
        }
        //internal static void viewTask()
        //{
        //    Console.WriteLine($"Printing task(s) list...\n");
        //    for (int i-0; i < taskList.Count; i++)
        //    {

        //    }

        //}
        public static void mRed() //got tired of typing Console commands to change console red for invalid input
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

            

            //}
            //internal static void saveTask()
            //{

            //}

    }
}
