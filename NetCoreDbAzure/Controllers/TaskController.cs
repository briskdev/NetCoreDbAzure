using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreDbAzure.Logic;

namespace NetCoreDbAzure.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskManager _taskManager;

        public TaskController(TaskManager taskManager)
        {
            _taskManager = taskManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_taskManager.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Logic.Task task)
        {
            if (ModelState.IsValid)
            {
                _taskManager.Create(task.Description);

                return RedirectToAction("Index");
            }

            return View(task);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _taskManager.Delete(id);

            return RedirectToAction("Index");
        }
    }
}