using Microsoft.AspNetCore.Mvc;
namespace razor_fun.Controllers;
public class ListController : Controller
{




    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
}