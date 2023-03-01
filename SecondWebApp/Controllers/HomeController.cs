using Microsoft.AspNetCore.Mvc;

namespace SecondWebAppNet5.Controllers
{
    // định nghĩa controller có tên là Home
    public class HomeController : Controller
    {
        // định nghĩa các action Index của controller Home
        public string Index()
        {
            return $"Controller: Home, action: Index";
        }
        public IActionResult List()
        {
            return View(); // return view mặc định của action List()
        }
        public IActionResult Delete() { return View("Views/Default.cshtml"); }
        public void Add() { }
        public string Show() { return "Action Show at controller"; }
    }
}
