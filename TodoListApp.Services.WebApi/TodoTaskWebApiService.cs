using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoListApp.Services.WebApi;
public class TodoTaskWebApiService
{
    private readonly HttpClient _httpClient;
    public TodoTaskWebApiService(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    public async Task<List<TodoTask>> GetTodoTasksAsync()
    {
        var response = await this._httpClient.GetAsync("/api/TodoTask");
        _ = response.EnsureSuccessStatusCode();

        var todoTasks = await response.Content.ReadAsAsync<List<TodoTask>>();
        return todoTasks;
    }
    public async Task<TodoTask> GetTodoByIdAsync(int id)
    {
        var response = await this._httpClient.GetAsync($"/api/TodoTask/{id}");
        _ = response.EnsureSuccessStatusCode();

        var todoTask = await response.Content.ReadAsAsync<TodoTask>();
        return todoTask;
    }

    public async Task<bool> UpdateTodoTaskAsync(TodoTask todoTask)
    {
        var json = JsonSerializer.Serialize(todoTask);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this._httpClient.PostAsync($"https://localhost:7144/api/TodoTask/{todoTask.Id}", content);

        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        return false;
    }

    public async Task AddTodoTaskAsync(TodoTask newTodoTask)
    {
        var response = await this._httpClient.PostAsJsonAsync("/api/TodoTask", newTodoTask);
        _ = response.EnsureSuccessStatusCode();
    }
    public async Task DeleteTodoTaskAsync(int id)
    {
        var response = await this._httpClient.DeleteAsync($"/api/TodoTask/{id}");
        _ = response.EnsureSuccessStatusCode();
    }
}
