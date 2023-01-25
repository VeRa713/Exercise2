using Exercise2.Models;
using Exercise2.Interfaces;
using Exercise2.Conf;

namespace Exercise2.Services
{
    public class TodoListServiceContext : ITodoListService
    {
        // 4.	Create a service that implements ITodoListService called TodoListServiceContext 
        // which interacts with ApplicationContext to implement the underlying methods.

        public TodoListServiceContext()
        {

        }

        public void Delete(int id)
        {
            //no menu yet to delete list
            throw new NotImplementedException();
        }

        public TodoList FindById(int id)
        {
            ApplicationContext context = ApplicationContext.Instance;
            return context.GetAll().Where(contact => contact.Id == id).FirstOrDefault();
        }

        public List<TodoList> GetAll()
        {
            ApplicationContext context = ApplicationContext.Instance;

            return context.GetAll();
        }

        public TodoList Save(TodoList list)
        {
            ApplicationContext context = ApplicationContext.Instance;

            context.GetAll().Add(list);
            
            return list;
        }
    }
}