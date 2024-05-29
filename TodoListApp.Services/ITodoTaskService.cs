using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Services;
public interface ITodoTaskService
{
    Task<IEnumerable<TodoTask>> GetTodoTasksAsync();

    Task<TodoTask?> GetTodoTaskByIdAsync(int id);

    Task CreateTodoTaskAsync(TodoTaskPostDto todoTask);

    Task UpdateTodoTaskAsync(TodoTaskPostDto todoTask);

    Task DeleteTodoTaskAsync(int id);
}
