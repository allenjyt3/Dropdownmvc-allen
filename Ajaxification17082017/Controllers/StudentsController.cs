using Ajaxification17082017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajaxification17082017.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Create()
        {
            var department = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text="CS",Value="1"
                },
                 new SelectListItem
                {
                    Text="ECE",Value="2"
                },
                  new SelectListItem
                {
                    Text="EEE",Value="3"
                }
            };

            ViewBag.Department = department;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student1 obj)
        {
            StudentEntities studobj = new StudentEntities();
            studobj.Student1.Add(obj);
            studobj.SaveChanges();

            var department = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text="CS",Value="1"
                },
                 new SelectListItem
                {
                    Text="ECE",Value="2"
                },
                  new SelectListItem
                {
                    Text="EEE",Value="3"
                }
            };

            ViewBag.Department = department;

            //Student user = new Student();
            //UpdateModel(user);
            return View();

        }
    }
}

    

            

            
