
using System.Text;
using System.Text.Json;

namespace TodoListApp.Services.WebApi
{
    public class TodoListWebApiService
    {
        private readonly HttpClient _httpClient;
        public TodoListWebApiService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<TodoList>> GetTodoListsAsync()
        {
            var response = await this._httpClient.GetAsync("/api/TodoList");
            _ = response.EnsureSuccessStatusCode();

            var todoLists = await response.Content.ReadAsAsync<List<TodoList>>();
            return todoLists;
        }
        public async Task<TodoList> GetTodoByIdAsync(int id)
        {
            var response = await this._httpClient.GetAsync($"/api/TodoList/{id}");
            _ = response.EnsureSuccessStatusCode();

            var todoList = await response.Content.ReadAsAsync<TodoList>();
            return todoList;
        }

        public async Task<bool> UpdateTodoListAsync(TodoList todoList)
        {
            var json = JsonSerializer.Serialize(todoList);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await this._httpClient.PostAsync($"https://localhost:7144/api/TodoList/{todoList.Id}", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public async Task AddTodoListAsync(TodoList newTodoList)
        {
            var response = await this._httpClient.PostAsJsonAsync("/api/TodoList", newTodoList);
            _ = response.EnsureSuccessStatusCode();
        }
        public async Task DeleteTodoListAsync(int id)
        {
            var response = await this._httpClient.DeleteAsync($"/api/TodoList/{id}");
            _ = response.EnsureSuccessStatusCode();
        }
    }
}
