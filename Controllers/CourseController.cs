using Microsoft.AspNetCore.Mvc;
using MVCBasic.Models;

namespace MVCBasic.Controllers;

// course
public class CourseController : Controller
{
    public IActionResult Details(int? id)
    {
        if(id == null)
        {
            // return Redirect("/course/list");
            return RedirectToAction("List", "Course");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);
    }

    // course/list => Bu view'a gider
    public IActionResult List()
    {
        return View(Repository.Courses);
    }
}