namespace Exercise2.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TodoItem> todoItems;

        public TodoList(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            todoItems = new List<TodoItem>();
        }

        public void AddTodoItem(TodoItem todoItem)
        {
            this.todoItems.Add(todoItem);
        }

        public int countItems()
        {
            return this.todoItems.Count();
        }

        public void RemoveTodoItem(int itemId)
        {
            this.todoItems = this.todoItems.Where(item => item.Id != itemId).ToList();
        }

        public int getItemId(int index)
        {
            return this.todoItems[index].Id;
        }

        public string getItemName(int index)
        {
            return this.todoItems[index].Content;
        }

        public string getStatus(int index)
        {
            return this.todoItems[index].Status;
        }

        // public void GetToDoItems()
        // {
        //     foreach (TodoItem item in this.todoItems)
        //     {
        //         Console.WriteLine("\n\nItem #" + item.Id + " : " + item.Content);
        //         Console.WriteLine("Status: " + item.Status);
        //     }
        // }

        // public bool FindItemById(int itemId)
        // {
        //     bool isFound = false;

        //     if (this.GetListById(itemId) != null)
        //     {
        //         isFound = true;
        //     }

        //     return isFound;
        // }

        // public TodoItem GetListById(int itemId)
        // {
        //     return this.todoItems.FirstOrDefault(item => item.Id == itemId);
        // }

        public int getLastId(int itemCount)
        {
            if (itemCount > 0)
            {
                return this.todoItems.Last().Id + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}