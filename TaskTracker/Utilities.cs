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
            Console.Write("How many tasks would you like to add? ");
            int numOfTasks = int.Parse(Console.ReadLine());

            if (numOfTasks != 0)
            {
                for (int i = 0; i < numOfTasks; i++)
                {
                    Console.Write("Enter task: ");
                    userTask = Console.ReadLine();
                    taskList.Add(userTask);
                }
            }
            else 
            {
                Console.WriteLine("\nNo tasks to add returning to selection menu");
                return;
            }
        }
        internal static void deleteTask()
        {

        }
        internal static void viewTask()
        {

        }
        internal static void saveTask()
        {

        }

    }
}
