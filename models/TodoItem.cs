namespace Exercise2.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }

        public TodoItem(int id, string content){
            this.Id = id;
            this.Content = content;
            this.Status = "pending";
        }

        public bool update(){
            switch(this.Status){
                case "pending":
                    this.Status = "active";
                    return true;
                case "active":
                    this.Status = "done";
                    return true;
                case "done":
                    return false;
                default:
                    return false;            
            }
        }
    }
}