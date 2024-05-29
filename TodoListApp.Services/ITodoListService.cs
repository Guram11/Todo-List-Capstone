namespace TodoListApp.Services
{
    public interface ITodoListService
    {
        Task<IEnumerable<TodoList>> GetTodoListsAsync();

        Task<TodoList?> GetTodoListByIdAsync(int id);

        Task CreateTodoListAsync(TodoList todoList);

        Task UpdateTodoListAsync(TodoList todoList);

        Task DeleteTodoListAsync(int id);
    }
}
