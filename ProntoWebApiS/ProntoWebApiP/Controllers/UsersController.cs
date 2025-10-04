using Microsoft.AspNetCore.Mvc;

namespace ProntoWebApiP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Dje ste Skaljari!!");
        }
    }
}
