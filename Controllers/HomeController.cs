using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pelayoApp.Models;

namespace pelayoApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // //ViewData & Viewbag
        // ViewData["var1"] = "asdf";
        // ViewBag.var2 = 2;

        Person p = new Person();
        p.Id = 1;
        p.Fullname = "windel";
        p.Age = 25;

        return View(p);
    }

    public IActionResult Privacy()
    {
        Person p = new Person(){
            Id = 2,
            Fullname = "another fullname",
            Age= 60
        };
        
        Person p2 = new Person(){
            Id = 3,
            Fullname = "si junior",
            Age= 31
        };  

        Person p3 = new Person(){
            Id = 4,
            Fullname = "si sister",
            Age= 45
        };  

        List<Person> listP = new List<Person>();
        listP.Add(p);
        listP.Add(p2);
        listP.Add(p3);

        return View(listP);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
