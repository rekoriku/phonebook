using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using phonebook.Models;

namespace phonebook.Controllers
{
    public class PhoneNumberController : Controller
    {
        public IActionResult Index()
        {
            PhoneBookContext context = HttpContext.RequestServices.GetService(typeof(phonebook.Models.PhoneBookContext)) as PhoneBookContext;

            return View(context.GetAllNumbers());
        }
    }
}