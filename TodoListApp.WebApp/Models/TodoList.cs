using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApp.Models
{
    public class TodoList
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter list title.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please enter list description.")]
        public string? Description { get; set; }

        public int NumberOfTasks { get; set; }

        public string? AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public ApplicationUser? Author { get; set; }

        public string? SharedTo {  get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
