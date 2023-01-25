using Exercise2.Models;
using Exercise2.Interfaces;
using Exercise2.Conf;

namespace Exercise2.Services
{
    public class TodoItemServiceContext : ITodoItemService
    {
        // 5.	Create a service that implements ITodoItemService called TodoItemServiceContext 
        // which interacts with ApplicationContext to implement the underlying methods.
        private TodoListServiceContext todoListServiceContext;

        public TodoItemServiceContext() {
            todoListServiceContext = new TodoListServiceContext();
        }

        public void Delete(int listId, TodoItem item)
        {
            TodoList todoList = todoListServiceContext.FindById(listId);
            todoList.RemoveTodoItem(item.Id);
        }

        public TodoItem FindById(int listId, int id)
        {
            TodoList todoList = todoListServiceContext.FindById(listId);

            return todoList.todoItems.Where(item => item.Id == id).FirstOrDefault();
        }

        public List<TodoItem> GetAll(int listId)
        {
            TodoList todoList = todoListServiceContext.FindById(listId);

            return todoList.todoItems;
        }

        public TodoItem Save(int listId, TodoItem item)
        {
            TodoList todoList = todoListServiceContext.FindById(listId);
            todoList.AddTodoItem(item);

            return item;
        }
    }
}