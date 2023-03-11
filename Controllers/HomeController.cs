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

        Person p = new Person();
        p.ID= 1;
        p.Fullname = "windel";

        return View(p);
    }

    public IActionResult Privacy()
    {

        
        Person p = new Person();
        p.ID= 1;
        p.Fullname = "windel";

        Person p2 = new Person();
        p2.ID= 2;
        p2.Fullname = "JEng";

        Person p3 = new Person();
        p3.ID= 2;
        p3.Fullname = "teletubies";

        List<Person> list = new List<Person>();

        list.Add(p);
        list.Add(p2);
        list.Add(p3);


        return View(list);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
