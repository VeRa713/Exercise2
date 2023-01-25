using Exercise2.Models;
using Exercise2.Interfaces;

namespace Exercise2.Services
{
    public class TodoItemServiceContext : ITodoItemService
    {
        // 5.	Create a service that implements ITodoItemService called TodoItemServiceContext 
        // which interacts with ApplicationContext to implement the underlying methods.
        public void Delete(int listId, TodoItem item)
        {
            throw new NotImplementedException();
        }

        public TodoItem FindById(int listId, int id)
        {
            throw new NotImplementedException();
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