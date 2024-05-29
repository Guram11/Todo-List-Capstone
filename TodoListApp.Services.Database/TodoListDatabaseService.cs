using Microsoft.EntityFrameworkCore;

namespace TodoListApp.Services.Database;
public class TodoListDatabaseService : ITodoListService
{
    private readonly TodoListDbContext _context;

    public TodoListDatabaseService(TodoListDbContext dbContext)
    {
        this._context = dbContext;
    }

    public async Task CreateTodoListAsync(Services.TodoList todoList)
    {
        var entity = new TodoList
        {
            Title = todoList.Title,
            Description = todoList.Description,
            CreatedAt = todoList.CreatedAt,
            NumberOfTasks = todoList.NumberOfTasks,
            IsShared = todoList.IsShared,
        };

        this._context.TodoLists.Add(entity);

        _ = await this._context.SaveChangesAsync();
    }

    public async Task DeleteTodoListAsync(int id)
    {
        var entity = await this._context.TodoLists.FindAsync(id);
        if (entity != null)
        {
            _ = this._context.TodoLists.Remove(entity);
            _ = await this._context.SaveChangesAsync();
        }
    }

    public async Task<Services.TodoList?> GetTodoListByIdAsync(int id)
    {
        var entity = await this._context.TodoLists.FindAsync(id);
        if (entity != null)
        {
            return new Services.TodoList
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                CreatedAt = entity.CreatedAt,
                NumberOfTasks = entity.NumberOfTasks,
                IsShared = entity.IsShared,
            };
        }

        return null;
    }

    public async Task<IEnumerable<Services.TodoList>> GetTodoListsAsync()
    {
        return await this._context.TodoLists
            .Select(t => new Services.TodoList
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                CreatedAt = t.CreatedAt,
                NumberOfTasks = t.NumberOfTasks,
                IsShared = t.IsShared
            })
            .ToListAsync();
    }

    public async Task UpdateTodoListAsync(Services.TodoList todoList)
    {
        var entity = await this._context.TodoLists.FindAsync(todoList.Id);
        if (entity != null)
        {
            entity.Title = todoList.Title;
            entity.Description = todoList.Description;

            _ = await this._context.SaveChangesAsync();
        }
    }
}
