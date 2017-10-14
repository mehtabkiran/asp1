using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using databaseconnection.Models;

namespace databaseconnection.Controllers
{
    public class DesgController : Controller
    {

        finalprojectContext MyDBContext = null;

        public DesgController(finalprojectContext _MyDBContext)
        {
            MyDBContext = _MyDBContext;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewStudent(Designation S)
        {
            MyDBContext.Designation.Add(S);
            //MyDBContext.Teacher.Add(T);

            MyDBContext.SaveChanges();

            ViewBag.Message = "Student is Saved Successfully!";
            return View();

        }
    }
}