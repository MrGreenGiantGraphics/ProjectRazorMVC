using ProjectRazorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectRazorMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.happydayoftheweek = "HAPPY FRIDAY!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.GreetingFromCreate = "Greeting From Create";
            return View();
        }

        public ActionResult Todos()
        {
            ViewBag.Message = "Welcome to Todos";
            ViewBag.TodoGreeting = "MY TASK OF THE DAY";
            // LIST
            TodoIndexVM viewModel = new TodoIndexVM();
            //No Populate the list
            List<Todo> tList = new List<Todo>()
            {
                new Todo(){Id=100,Task = "Wash Dishes", IsCompleted = true, Datecreated=DateTime.Now.AddDays(-7)},
                new Todo(){Id=101,Task = "Clean Car", IsCompleted = false, Datecreated=DateTime.Now.AddDays(-3)},
                new Todo(){Id=102,Task = "Clean Room", IsCompleted = true, Datecreated=DateTime.Now.AddDays(-8)},
                new Todo(){Id=103,Task = "Wash Sheets", IsCompleted = false, Datecreated=DateTime.Now.AddDays(-2)},
                new Todo(){Id=104,Task = "Paint House", IsCompleted = false, Datecreated=DateTime.Now.AddDays(-1)},
            };

            viewModel.MyChores = tList;

            return View(viewModel);
        }

    }
}