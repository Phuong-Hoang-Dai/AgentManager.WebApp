using Microsoft.AspNetCore.Mvc;

namespace AgentManager.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
    }
}
