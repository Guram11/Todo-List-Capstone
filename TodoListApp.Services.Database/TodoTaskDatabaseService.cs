using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoListApp.Services.Database;
public class TodoTaskDatabaseService : ITodoTaskService
{
    private readonly TodoListDbContext _context;
    public TodoTaskDatabaseService(TodoListDbContext todoListDbContext)
    {
        _context = todoListDbContext;
    }

    public async Task CreateTodoTaskAsync(Services.TodoTaskPostDto todoTask)
    {
        var entity = new Services.Database.TodoTask
        {
           TodoListId = todoTask.TodoListId,
            Title = todoTask.Title,
            Description = todoTask.Description
        };

        _context.TodoTasks.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTodoTaskAsync(int id)
    {
        var entity = await _context.TodoTasks.FindAsync(id);
        if (entity != null)
        {
            _context.TodoTasks.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Services.TodoTask?> GetTodoTaskByIdAsync(int id)
    {
        var entity = await _context.TodoTasks.FindAsync(id);
        if (entity != null)
        {
            return new Services.TodoTask
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                CreatedAt = entity.CreatedAt,
                DueDate = entity.DueDate
            };
        }

        return null;
    }

    public async Task<IEnumerable<Services.TodoTask>> GetTodoTasksAsync()
    {
        return await this._context.TodoTasks
            .Select(t => new Services.TodoTask
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                CreatedAt = t.CreatedAt,
                DueDate = t.DueDate
            })
            .ToListAsync();
    }

    public async Task UpdateTodoTaskAsync(Services.TodoTaskPostDto todoTask)
    {
        var entity = await this._context.TodoTasks.FindAsync(todoTask.Id);
        if (entity != null)
        {
            entity.Title = todoTask.Title;
            entity.Description = todoTask.Description;

            _ = await this._context.SaveChangesAsync();
        }
    }
}
