namespace Exercise2.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }

        public TodoItem(int id, string content)
        {
            this.Id = id;
            this.Content = content;
            this.Status = "pending";
        }

        public bool Update()
        {
            switch (this.Status)
            {
                case "pending":
                    this.Status = "active";
                    Console.WriteLine("\nUpdate Successful!");
                    return true;
                case "active":
                    this.Status = "done";
                    Console.WriteLine("\nUpdate Successful!");
                    return true;
                case "done":
                    Console.WriteLine("\nItem already done. No changes.");
                    return false;
                default:
                    return false;
            }
        }
    }
}