using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.Services;

namespace TodoListApp.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TodoListController : ControllerBase
{
    private readonly ITodoListService _todoListService;
    public TodoListController(ITodoListService todoListService)
    {
        this._todoListService = todoListService;
    }

    [HttpGet]
    public async Task<IActionResult> GetTodoLists()
    {
        var todoLists = await this._todoListService.GetTodoListsAsync();
        return this.Ok(todoLists);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTodoListById(int id)
    {
        var todoList = await this._todoListService.GetTodoListByIdAsync(id);
        if (todoList == null)
        {
            return this.NotFound();
        }

        return this.Ok(todoList);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTodoList(TodoList todoList)
    {
        await this._todoListService.CreateTodoListAsync(todoList);
        return this.CreatedAtAction(nameof(GetTodoListById), new { id = todoList.Id }, todoList);
    }

    [HttpPost("{todoList.Id}")]
    public async Task<IActionResult> UpdateTodoList([FromBody] TodoList todoList)
    {
        await this._todoListService.UpdateTodoListAsync(todoList);
        return this.Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoList(int id)
    {
        await this._todoListService.DeleteTodoListAsync(id);
        return this.NoContent();
    }
}
