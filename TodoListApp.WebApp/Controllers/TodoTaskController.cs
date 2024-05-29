using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TodoListApp.WebApp.Data;
using TodoListApp.WebApp.Models;

namespace TodoListApp.WebApp.Controllers
{
    [Authorize]
    public class TodoTaskController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TodoTaskController(ApplicationDbContext db)
        {
            _db = db;
            _db.TodoTasks.Include(u => u.TodoList);
        }

        public IActionResult Index()
        {
            //List<TodoTask> todoTasks = _db.TodoTasks.ToList();

            //IEnumerable<TodoTask> finalList = todoTasks.Where(u => u.TodoList.AuthorId == User.FindFirstValue(ClaimTypes.NameIdentifier));

            //ViewBag.TodoList = finalList;

            return View();
        }

        public IActionResult Details(int id)
        {
           TodoTask? todoTask = _db.TodoTasks.Find(id);

            return View(todoTask);
        }

        public IActionResult Complete(int id)
        {
            TodoTask? todoTask = _db.TodoTasks.Find(id);

            if(todoTask?.IsCompleted is false)
            {
            todoTask.IsCompleted = true;
            }

            _db.TodoTasks.Update(todoTask);
            _db.SaveChanges();
 
            return RedirectToAction("Index");
        }

        public IActionResult Resume(int id)
        {
            TodoTask? todoTask = _db.TodoTasks.Find(id);

            if (todoTask?.IsCompleted is true)
            {
                todoTask.IsCompleted = false;
            }

            _db.TodoTasks.Update(todoTask);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> TodoList = _db.TodoLists.Where(u => u.AuthorId == User.FindFirstValue(ClaimTypes.NameIdentifier)).Select(u => new SelectListItem
            {
                Text = u.Title,
                Value = u.Id.ToString(),
            });

            IEnumerable<SelectListItem> SharedList = _db.TodoLists.Where(u => u.SharedTo == User.FindFirstValue(ClaimTypes.Email)).Select(u => new SelectListItem
            {
                Text = u.Title,
                Value = u.Id.ToString(),
            });


            IEnumerable<TodoList> sharedTasks = _db.TodoLists.Where(u => u.SharedTo == User.FindFirstValue(ClaimTypes.Email)).ToList();

            var finalList = TodoList.Concat(SharedList);

            ViewBag.finalList = finalList;

            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoTask obj)
        {
            if (obj.Title == obj.Description)
            {
                ModelState.AddModelError("Title", "Task title and description can not match each other!");
            }

            if (ModelState.IsValid)
            {
                _db.TodoTasks.Add(obj);
                var list = _db.TodoLists.Find(obj.TodoListId);

                if (list != null)
                {
                    list.NumberOfTasks++;
                }

                _db.SaveChanges();
                TempData["success"] = "TodoTask created successfully!";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }

            TodoTask? todoTask = _db.TodoTasks.Find(id);

            if (todoTask is null)
            {
                return NotFound();
            }

            IEnumerable<SelectListItem> TodoList = _db.TodoLists.Select(u => new SelectListItem
            {
                Text = u.Title,
                Value = u.Id.ToString(),
            });

            ViewBag.TodoList = TodoList;

            return View(todoTask);
        }

        [HttpPost]
        public IActionResult Edit(TodoTask obj)
        {
            if (ModelState.IsValid)
            {
                _db.TodoTasks.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "TodoTask updated successfully!";

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

            TodoTask? todoTask = _db.TodoTasks.Find(id);

            if (todoTask is null)
            {
                return NotFound();
            }

            return View(todoTask);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            TodoTask? obj = _db.TodoTasks.Find(id);

            if (obj is null)
            {
                return NotFound();
            }

            _db.TodoTasks.Remove(obj);

            var list = _db.TodoLists.Find(obj.TodoListId);

            if (list != null)
            {
                list.NumberOfTasks--;
            }

            _db.SaveChanges();
            TempData["success"] = "TodoList deleted successfully!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetAll(int id)
        {
            List<TodoTask> todoTasks = _db.TodoTasks.Include(u => u.TodoList).Where(u => u.TodoList.AuthorId == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();

            List<TodoTask> sharedTasks = _db.TodoTasks.Include(u => u.TodoList).Where(u => u.TodoList.SharedTo == User.FindFirstValue(ClaimTypes.Email)).ToList();

            var finalList = todoTasks.Concat(sharedTasks).ToList();

            return Json(new { data = finalList });
        }
    }
}
