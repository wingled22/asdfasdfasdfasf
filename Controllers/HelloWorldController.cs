using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pelayoApp.Models;

namespace pelayoApp.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index(){
        return View();
    }
}
