using Exercise2.Models;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TodoList> myLists = new List<TodoList>();

            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine("\n\n======= MAIN MENU =======\n");
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
                        }
                        else
                        {
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
                        Console.Write("\n\n===== Select List =====\n\n");

                        if (myLists.Count() > 0)
                        {
                            Console.Write("Enter List ID: ");
                            int listIndex = Int32.Parse(Console.ReadLine()) - 1;

                            // If 4 is selected, the program should first ask for the id of the list that is to be selected. 
                            // If a list is not found, display the origins menu again. 
                            // If a list is found, display another menu with the following:

                            bool isSelectContinue = true;

                            while (isSelectContinue)
                            {
                                Console.WriteLine("\n\n======= MENU for List # " + myLists[listIndex].Id + " : " + myLists[listIndex].Name + " =======\n");

                                Console.WriteLine("1 -  Display All Items");
                                Console.WriteLine("2 -  Create New Item");
                                Console.WriteLine("3 -  Delete Item");
                                Console.WriteLine("4 -  Update Item");
                                Console.WriteLine("5 -  Go back");

                                Console.Write("\nEnter Number: ");
                                choice = Console.ReadLine();

                                switch (choice)
                                {
                                    case "1":
                                        Console.WriteLine("\n\n======= Display All Items =======\n");

                                        // If 1 is  selected in this secondary menu, then display all items in the list. 
                                        // It should show the id, content and status of the item.

                                        if (myLists[listIndex].countItems() > 0)
                                        {

                                            for (int i = 0; i < myLists[listIndex].countItems(); i++)
                                            {
                                                Console.WriteLine("\nItem #" + myLists[listIndex].getItemId(i) + " : " + myLists[listIndex].getItemName(i));
                                                Console.WriteLine("Status: " + myLists[listIndex].getStatus(i));
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\nNo items found in list: " + myLists[listIndex].Name);
                                        }

                                        break;
                                        
                                    case "2":
                                        Console.WriteLine("\n\n======= Create New Item for " + "List # " + myLists[listIndex].Id + " : " + myLists[listIndex].Name + " =======\n");

                                        // If 2 is selected, ask the user to input content for the new item and 
                                        // create an instance of TodoItem for the list. 
                                        // Take note that the id value should be one number higher than the previous item in the items of the list. 
                                        // If no items are in the list then default to 1. 
                                        // After creating, the program should go back to the secondary menu (item d in logic).

                                        Console.Write("Enter new item: ");
                                        string newItem = Console.ReadLine();

                                        int itemCount = myLists[listIndex].countItems();

                                        TodoItem todoItem = new TodoItem(itemCount + 1, newItem);
                                        myLists[listIndex].AddTodoItem(todoItem);

                                        Console.WriteLine("\nItem Successfully Added!");
                                        Console.WriteLine("There are now " + myLists[listIndex].countItems() + " item/s on the list...");

                                        break;

                                    case "3":
                                        Console.WriteLine("\n\n======= Delete Item for " + "List # " + myLists[listIndex].Id + " : " + myLists[listIndex].Name + " =======\n");

                                        // If 3 is selected, ask the user to input the id of the item to delete. 
                                        // If an item is found, it should delete that item from the list. 
                                        // If not, display “Invalid id” and go back to the secondary menu (item d in logic).

                                        Console.WriteLine("Delete Item ID: ");
                                        int itemId = Int32.Parse(Console.ReadLine());

                                        if (itemId <= 0 || itemId > myLists[listIndex].countItems()){
                                            Console.WriteLine("\nInvalid id. Try Again.");
                                        } else {
                                            Console.WriteLine("\nDeleting item with id: " + itemId + "...");
                                            
                                            myLists[listIndex].RemoveTodoItem(itemId);
                                            
                                            Console.WriteLine("Delete Successful!");
                                        }

                                        //Issue with this, creating new items after deleting results to duplicate itemId

                                        break;

                                    case "4":
                                        Console.WriteLine("\n\n======= Update Item for " + "List # " + myLists[listIndex].Id + " : " + myLists[listIndex].Name + " =======\n");

                                        // If 4 is selected, ask the user to input the id of the item to delete. 
                                        // If an item is found, invoke the update() method of that item changing its status. 
                                        // If an item is not found, display “Invalid id” and go back to the secondary menu (item d in logic).

                                        break;

                                    case "5":
                                        // Go back
                                        isSelectContinue = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid choice. Try again");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nList is EMPTY...");
                        }

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