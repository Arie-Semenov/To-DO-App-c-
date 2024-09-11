using System;
using System.Collections.Generic; // Add this namespace for List<T>

namespace ToDoAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ToDoList = new List<string>();
            List<bool> status = new List<bool>();
            string ToDoItem;
            bool ext = false;
            int choice;
            int indexToRemove;
            int marker;

            System.Console.WriteLine("Welcome to the ToDO APP");
            System.Console.WriteLine("Please select one of the options:");
            
            while (!ext)
            {
                System.Console.WriteLine("1) ADD A TO DO\n2) REMOVE A TO DO\n3) MARK AS DONE/UNDONE\n4) SHOW ALL TO DO'S\n5) EXIT");
                choice = int.Parse(Console.ReadLine());
                System.Console.WriteLine();
                System.Console.WriteLine();
                if (choice == 5)
                {
                    ext = true;
                }
                switch (choice)
                {
                    case 1:// Add item to the list
                        System.Console.WriteLine("Please add what you want to do:");
                        ToDoItem = Console.ReadLine();
                        System.Console.WriteLine();
                        ToDoList.Add(ToDoItem);
                        status.Add(false);
                        System.Console.WriteLine("Task Added");
                        System.Console.WriteLine();
                        break;
                    case 2:// Remove item from list by index
                        System.Console.WriteLine("Please enter the index of the ToDo item you want to remove (1-based index):");
                         indexToRemove = int.Parse(Console.ReadLine()) - 1; // Convert to 0-based index
                         System.Console.WriteLine();
                        if (indexToRemove >= 0 && indexToRemove < ToDoList.Count)
                        if (indexToRemove >= 0 && indexToRemove < status.Count)
                        {
                            ToDoList.RemoveAt(indexToRemove); 
                            System.Console.WriteLine("Task removed.");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid index.");
                            System.Console.WriteLine();
                        }
                        break;
                    case 3://mark the task done or undone
                        System.Console.WriteLine("For Done press 1\nFor UnDone press 2:");
                        int input = int.Parse(Console.ReadLine());
                        System.Console.WriteLine();
                        if (input == 1){//mark the task as done
                            System.Console.WriteLine("Please enter the number of the Task:");
                            marker = int.Parse(Console.ReadLine()) -1;
                            System.Console.WriteLine();
                            if (marker >= 0 && marker < status.Count)
                            {
                            status[marker] = true;
                            System.Console.WriteLine("Task marked as Done");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid index.");
                            System.Console.WriteLine();
                        }
                        }
                        if (input == 2){//mark the task as undone
                            System.Console.WriteLine("Please enter the number of the Task:");
                            marker = int.Parse(Console.ReadLine()) -1;
                            System.Console.WriteLine();
                            if (marker >= 0 && marker < status.Count)
                            {
                            status[marker] = false; 
                            System.Console.WriteLine("Task marked as UnDone");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid index.");
                            System.Console.WriteLine();
                        } 
                        }
                        break;
                    case 4:// Display all ToDo items
                        if (ToDoList.Count == 0)
                        {
                            System.Console.WriteLine("No ToDo items.");
                            System.Console.WriteLine();
                        }
                        else
                        {
                            for (int i = 0; i < ToDoList.Count; i++)
                            {
                                System.Console.Write($"{i + 1}. {ToDoList[i]}");
                                if(status[i] == true)
                                    System.Console.WriteLine(" Done");
                                if(status[i] == false)
                                    System.Console.WriteLine(" UnDone");
                            }
                            System.Console.WriteLine();
                        }
                        break;
                }
            }
        }
    }
}
