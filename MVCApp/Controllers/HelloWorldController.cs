using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //Get: /HelloWorld/Welcome/
        //public string Welcome(string name , int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
