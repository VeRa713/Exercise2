using Exercise2.Models;

namespace Exercise2.Conf
{
    public class ApplicationContext
    {
        private List<TodoList> myLists;

        private static ApplicationContext instance = null;

        public static ApplicationContext Instance
        {
            get {
                if(instance == null) {
                    instance = new ApplicationContext();
                }
                return instance;
            }
        }

        public ApplicationContext()
        {
            this.myLists = new List<TodoList>();
        }

        public List<TodoList> GetList()
        {
            return this.myLists;
        }
    }
}