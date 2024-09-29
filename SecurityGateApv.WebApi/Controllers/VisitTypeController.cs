using Microsoft.AspNetCore.Mvc;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
