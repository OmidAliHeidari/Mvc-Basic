using Microsoft.AspNetCore.Mvc;
using MVCBasic.Models;

namespace MVCBasic.Controllers;

// home
public class HomeController : Controller
{
    // home
    // home/index => Bu view'a gider
    public IActionResult Index()
    {
        return View(Repository.Courses);
    }

    // home/contact => Bu view'a gider
    public IActionResult Contact()
    {
        return View();
    } 
}
