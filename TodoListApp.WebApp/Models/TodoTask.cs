using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApp.Models
{
    public class TodoTask
    {
        [Key]
        public int Id { get; set; }

        public int TodoListId { get; set; }

        [ForeignKey("TodoListId")]
        public TodoList? TodoList { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public string? Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime DueDate { get; set; }
    }
}
