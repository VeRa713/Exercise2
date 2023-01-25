using Exercise2.Models;
using Exercise2.Services;
using Exercise2.Interfaces;

namespace Exercise2
{
    public class Program
    {
        public static List<TodoList> GetAllLists(ITodoListService todoListService)
        {
            List<TodoList> myLists = todoListService.GetAll();

            return myLists;
        }

        static void Main(string[] args)
        {
            ITodoListService todoListService = new TodoListServiceContext();
            List<TodoList> myLists = GetAllLists(todoListService);

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
                        Console.Write("\n\n===== Show Items =====");

                        // If 2 is selected, as the user to enter an id of a list. 
                        // If the list is not found, display the original menu again. 
                        // If found, then display all the items in the list. 
                        // If there are no items in the list, the program should display 
                        // “No items found for list [name of list]”.

                        Console.Write("\n\nEnter List Id: ");
                        int listId = Int32.Parse(Console.ReadLine());

                        var showList = myLists.FirstOrDefault(list => list.Id == listId);

                        if (showList != null)
                        {
                            if (showList.countItems() > 0)
                            {
                                Console.Write("\n\n===== Showing Items for " + myLists[listId - 1].Name + " =====");
                                showList.GetToDoItems();
                            }
                            else
                            {
                                Console.WriteLine("\nNo items found for list " + showList.Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nList does not exist.");
                        }


                        break;

                    case "3":
                        Console.Write("\n\n===== Create List =====\n\n");

                        // If 3 is selected, ask the user to enter a name and 
                        // create a new instance of TodoList to be added to myLists. 
                        // The id of the list should be 1 number higher than the previous list in myLists. 
                        // If there are no current lists in myList, the starting id is 1.

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        int todoListId = myLists.Count() + 1; //should get id of last element in list instead

                        TodoList todoList = new TodoList(todoListId, name);

                        myLists.Add(todoList);

                        break;

                    case "4":
                        Console.Write("\n\n===== Select List =====\n\n");

                        if (myLists.Count() > 0)
                        {
                            Console.Write("Enter List ID: ");
                            int listIndex = Int32.Parse(Console.ReadLine());

                            // var selectList = myLists.FirstOrDefault(list => list.Id == listIndex);
                            var selectList = todoListService.FindById(listIndex);

                            // If 4 is selected, the program should first ask for the id of the list that is to be selected. 
                            // If a list is not found, display the origins menu again. 
                            // If a list is found, display another menu with the following:

                            if (selectList != null)
                            {
                                bool isSelectContinue = true;

                                while (isSelectContinue)
                                {
                                    Console.WriteLine("\n\n======= MENU for List # " + selectList.Id + " : " + selectList.Name + " =======\n");

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

                                            if (selectList.countItems() > 0)
                                            {

                                                for (int i = 0; i < selectList.countItems(); i++)
                                                {
                                                    Console.WriteLine("\nItem #" + selectList.getItemId(i) + " : " + selectList.getItemName(i));
                                                    Console.WriteLine("Status: " + selectList.getStatus(i));
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\nNo items found in list: " + selectList.Name);
                                            }

                                            break;

                                        case "2":
                                            Console.WriteLine("\n\n======= Create New Item for " + "List # " + selectList.Id + " : " + selectList.Name + " =======\n");

                                            // If 2 is selected, ask the user to input content for the new item and 
                                            // create an instance of TodoItem for the list. 
                                            // Take note that the id value should be one number higher than the previous item in the items of the list. 
                                            // If no items are in the list then default to 1. 
                                            // After creating, the program should go back to the secondary menu (item d in logic).

                                            Console.Write("Enter new item: ");
                                            string newItem = Console.ReadLine();

                                            int itemCount = selectList.countItems();

                                            int newId = selectList.getLastId(itemCount);

                                            TodoItem todoItem = new TodoItem(newId, newItem); 
                                            selectList.AddTodoItem(todoItem);

                                            Console.WriteLine("\nItem Successfully Added!");
                                            Console.WriteLine("There are now " + selectList.countItems() + " item/s on the list...");

                                            break;

                                        case "3":
                                            Console.WriteLine("\n\n======= Delete Item for " + "List # " + selectList.Id + " : " + selectList.Name + " =======\n");

                                            // If 3 is selected, ask the user to input the id of the item to delete. 
                                            // If an item is found, it should delete that item from the list. 
                                            // If not, display “Invalid id” and go back to the secondary menu (item d in logic).

                                            Console.WriteLine("Delete Item ID: ");
                                            int deleteId = Int32.Parse(Console.ReadLine());

                                            if (deleteId <= 0 || deleteId > selectList.countItems())
                                            {
                                                Console.WriteLine("\nInvalid id. Try Again.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nDeleting item with id: " + deleteId + "...");

                                                selectList.RemoveTodoItem(deleteId);

                                                Console.WriteLine("Delete Successful!");
                                            }

                                            break;

                                        case "4":
                                            Console.WriteLine("\n\n======= Update Item for " + "List # " + selectList.Id + " : " + selectList.Name + " =======\n");

                                            // If 4 is selected, ask the user to input the id of the item to delete. 
                                            // If an item is found, invoke the update() method of that item changing its status. 
                                            // If an item is not found, display “Invalid id” and go back to the secondary menu (item d in logic).

                                            Console.Write("Enter Item Id: ");
                                            int updateId = Int32.Parse(Console.ReadLine());

                                            if (selectList.FindItemById(updateId))
                                            {
                                                var item = selectList.GetListById(updateId);

                                                item.Update();
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nInvalid id.");
                                            }

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
                            } else {
                                Console.WriteLine("\n\nList does not exist.");
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