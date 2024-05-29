using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Security.Claims;
using TodoListApp.WebApp.Data;
using TodoListApp.WebApp.Models;
using TodoListApp.WebApp.Utilities;

namespace TodoListApp.WebApp.Controllers
{
    [Authorize]
    public class TodoListController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TodoListController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<TodoList> todoLists = _db.TodoLists.Where(u=> u.AuthorId == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();


            List<TodoList> sharedList = _db.TodoLists.Where(u => u.SharedTo == User.FindFirstValue(ClaimTypes.Email)).ToList();

            var finalList = todoLists.Concat(sharedList).ToList();

            return View(finalList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoList obj)
        {
            if(obj.Title == obj.Description)
            {
                ModelState.AddModelError("Title", "List title and description can not match each other!");
            }

            if (ModelState.IsValid)
            {
             obj.AuthorId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            _db.TodoLists.Add(obj);
            _db.SaveChanges();
                TempData["success"] = "TodoList created successfully!";
            return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id is null || id == 0)
            {
                return NotFound();
            }

            TodoList? todoList = _db.TodoLists.Find(id);

            if(todoList is null)
            {
                return NotFound();
            }

            return View(todoList);
        }

        [HttpPost]
        public IActionResult Edit(TodoList obj)
        {
            if (ModelState.IsValid)
            {
                obj.AuthorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _db.TodoLists.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "TodoList updated successfully!";

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }

            TodoList? todoList = _db.TodoLists.Find(id);

            if (todoList is null)
            {
                return NotFound();
            }

            return View(todoList);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            TodoList? obj = _db.TodoLists.Find(id);

            if (obj is null)
            {
                return NotFound();
            }

            if(obj.AuthorId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                TempData["error"] = "You don't have permission to perform this action!";
                return RedirectToAction("Index");
            }

            _db.TodoLists.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "TodoList deleted successfully!";

            return RedirectToAction("Index");
        }
    }
}
