using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StringManipulator.Application;

namespace StringManipulator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {
        private readonly IReverseService reverseService;
        public ReverseController(IReverseService reverseService)
        {
            this.reverseService = reverseService;   
        }
        [HttpPost]
        public IActionResult Reverse()
        {
            return Ok(this.reverseService.Reverse());
        }
    }
}
