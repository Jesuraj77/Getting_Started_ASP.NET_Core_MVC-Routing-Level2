using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ViewResult()
        {
            //implement the code here
            return View();
        }
    }
}