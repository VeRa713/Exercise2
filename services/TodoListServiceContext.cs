using Exercise2.Models;
using Exercise2.Interfaces;

namespace Exercise2.Services
{
    public class TodoListServiceContext : ITodoListService
    {
        // 4.	Create a service that implements ITodoListService called TodoListServiceContext 
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