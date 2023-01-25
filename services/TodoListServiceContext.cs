using Exercise2.Models;
using Exercise2.Interfaces;
using Exercise2.Conf;

namespace Exercise2.Services
{
    public class TodoListServiceContext : ITodoListService
    {
        // 4.	Create a service that implements ITodoListService called TodoListServiceContext 
        // which interacts with ApplicationContext to implement the underlying methods.

        private ApplicationContext appInstance;
        private List<TodoList> todoList;

        public TodoListServiceContext()
        {
            appInstance = ApplicationContext.Instance;
            todoList = appInstance.GetToDoList();
        }

        public void Delete(int id)
        {
            //no menu yet to delete list
            TodoList todoListMatch = todoList.SingleOrDefault(x => x.Id == id);
            todoList.Remove(todoListMatch);
        }

        public TodoList FindById(int id)
        {
            return todoList.Where(list => list.Id == id).FirstOrDefault();
        }

        public List<TodoList> GetAll()
        {
            return this.todoList;
        }

        public TodoList Save(TodoList list)
        {
            todoList.Add(list);
            
            return list;
        }
    }
}