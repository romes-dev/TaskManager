using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services;



namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskManagerService _taskManagerService;

        public HomeController()
        {
            _taskManagerService = new TaskManagerService();
        }

        public IActionResult Index()
        {
            var tasks = _taskManagerService.GetTasks();
            return View(tasks);
        }

        [HttpPost]
        public IActionResult AddTask(string title, string description, DateTime dueTime)
        {
            _taskManagerService.AddTask(title, description, dueTime);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CompleteTask(int id)
        {
            _taskManagerService.MarkTaskAsCompleted(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveTask(int id)
        {
            _taskManagerService.RemoveTask(id);
            return RedirectToAction("Index");
        }

    }

        
}
