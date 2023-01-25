using Exercise2.Models;
using Exercise2.Interfaces;

namespace Exercise2.Services
{
    public class TodoItemServiceContext : ITodoItemService
    {
        // 5.	Create a service that implements ITodoItemService called TodoItemServiceContext 
        // which interacts with ApplicationContext to implement the underlying methods.
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TodoList FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoList> GetAll()
        {
            throw new NotImplementedException();
        }

        public TodoList Save(TodoList list)
        {
            throw new NotImplementedException();
        }
    }
}