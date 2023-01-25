using Exercise2.Models;
using Exercise2.Interfaces;
using Exercise2.Conf;

namespace Exercise2.Services
{
    public class TodoItemServiceContext : ITodoItemService
    {
        // 5.	Create a service that implements ITodoItemService called TodoItemServiceContext 
        // which interacts with ApplicationContext to implement the underlying methods.
        public TodoItemServiceContext()
        {

        }

        public void Delete(int itemId, TodoItem todoItems)
        {
            // this.todoItems = this.todoItems.Where(item => item.Id != itemId).ToList();
        }

        public TodoItem FindById(int listId, int id)
        {
            ApplicationContext context = ApplicationContext.Instance;
            return null;
        }

        public List<TodoItem> GetAll(int listId)
        {
            throw new NotImplementedException();
        }

        public TodoItem Save(int listId, TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}