namespace TodoListApp.WebApi.Models
{
    public class TodoList
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public int NumberOfTasks { get; set; }

        public bool IsShared { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
