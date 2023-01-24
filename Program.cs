using TodoItem.Models;

namespace TodoItem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TodoList> myLists = new List<TodoList>();

            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine("\n\n======= MENU =======\n");
                Console.WriteLine("1 -  Display All Lists");
                Console.WriteLine("2 -  Show Items");
                Console.WriteLine("3 -  Create New List");
                Console.WriteLine("4 -  Select List");
                Console.WriteLine("5 -  Quit");

                Console.Write("\nEnter Number: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("\n\n===== Displaying All Lists =====");

                        // If 1 is selected, it displays all the current TodoLists in myLists. 
                        // The interface should display the id and name of a list together with the number of items.
                        if (myLists.Count() > 0)
                        {

                            for (int i = 0; i < myLists.Count(); i++)
                            {
                                Console.WriteLine("\n\nList #" + myLists[i].Id + " : " + myLists[i].Name);
                            }
                        } else {
                            Console.WriteLine("\n\nList is EMPTY...");
                        }

                        break;

                    case "2":
                        Console.Write("Show Items");

                        // If 2 is selected, as the user to enter an id of a list. 
                        // If the list is not found, display the original menu again. 
                        // If found, then display all the items in the list. 
                        // If there are no items in the list, the program should display 
                        // “No items found for list [name of list]”.

                        break;

                    case "3":
                        Console.Write("\n\n===== Create List =====\n\n");

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        int todoListId = myLists.Count() + 1;

                        TodoList todoList = new TodoList(todoListId, name);

                        myLists.Add(todoList);

                        // If 3 is selected, ask the user to enter a name and 
                        // create a new instance of TodoList to be added to myLists. 
                        // The id of the list should be 1 number higher than the previous list in myLists. 
                        // If there are no current lists in myList, the starting id is 1.

                        break;

                    case "4":
                        Console.Write("Select");

                        // If 4 is selected, the program should first ask for the id of the list that is to be selected. 
                        // If a list is not found, display the origins menu again. 
                        // If a list is found, display another menu with the following:

                        // 1 - Display all Items
                        // 2 - Create New Item
                        // 3 - Delete Item
                        // 4 - Update Item
                        // 5 - Go back

                        break;

                    case "5":
                        Console.Write("Quit");
                        isContinue = false;
                        break;

                    default:
                        Console.Write("Invalid Choice. Try Again");
                        break;
                }

            }
        }
    }
}