using Exercise2.Models;

namespace Exercise2.Interfaces
{
    public interface ITodoListService
    {
        public List<TodoList> GetAll();
        public TodoList FindById(int id);
        public TodoList Save(TodoList list);
        public void Delete(int id);
    }
}