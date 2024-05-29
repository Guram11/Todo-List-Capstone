using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Services;
public class TodoTask
{
    public int Id { get; set; }

    public int TodoListId { get; set; }

    public TodoList? TodoList { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime DueDate { get; set; }
}
