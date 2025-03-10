using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        // A list to store tasks
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console To-Do App!");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Delete a Task");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting the app. Have a productive day!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Method to add a task
        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        // Method to view all tasks
        static void ViewTasks()
        {
            Console.WriteLine("\nYour Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found. Add some tasks first!");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }

        // Method to delete a task
        static void DeleteTask()
        {
            ViewTasks();

            if (tasks.Count == 0) return;

            Console.Write("Enter the number of the task to delete: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }
    }
}
