using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
        return View();
        }       
    }
}