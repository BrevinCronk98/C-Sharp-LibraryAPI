using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}