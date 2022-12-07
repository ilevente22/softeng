using _9gyak.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _9gyak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("/questions/all")]
        public IActionResult mindegy()
        {
            HajosContext context = new();
            var kerdesek = from x in context.Questions select x.Question1;

            return Ok(kerdesek);
        }
    }
}
