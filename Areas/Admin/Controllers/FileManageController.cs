using Microsoft.AspNetCore.Mvc;

namespace hienv_asp.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
