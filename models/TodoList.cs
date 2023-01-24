namespace TodoItem.Models
{
    public class TodoList
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TodoItem> todoItems;

        public TodoList(int id, string name){
            this.Id = id;
            this.Name = name;
            todoItems = new List<TodoItem>();
        }

        public void AddTodoItem(){
            //add item to list
        }

        public void RemoveTodoItem(){
            //remove item from list
        }
    }
}