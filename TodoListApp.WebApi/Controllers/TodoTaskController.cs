using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.Services;

namespace TodoListApp.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TodoTaskController : ControllerBase
{
    private readonly ITodoTaskService _todoTaskService;
    public TodoTaskController(ITodoTaskService todoTaskService)
    {
        _todoTaskService = todoTaskService;
    }

    [HttpGet]
    public async Task<IActionResult> GetTodoTasks()
    {
        var todoTasks = await this._todoTaskService.GetTodoTasksAsync();
        return this.Ok(todoTasks);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTodoTaskById(int id)
    {
        var todoTask = await this._todoTaskService.GetTodoTaskByIdAsync(id);
        if (todoTask == null)
        {
            return this.NotFound();
        }

        return this.Ok(todoTask);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTodoTask(TodoTaskPostDto todoTask)
    {
        await this._todoTaskService.CreateTodoTaskAsync(todoTask);
        return this.CreatedAtAction(nameof(GetTodoTaskById), new { id = todoTask.Id }, todoTask);
    }

    [HttpPost("{todoTask.Id}")]
    public async Task<IActionResult> UpdateTodoTask([FromBody] TodoTaskPostDto todoList)
    {
        await this._todoTaskService.UpdateTodoTaskAsync(todoList);
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoTask(int id)
    {
        await this._todoTaskService.DeleteTodoTaskAsync(id);
        return this.NoContent();
    }
}
