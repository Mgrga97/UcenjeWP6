using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {

        // koristi se dependency injection
        // 1. definiramo privatno svojstvo
        private readonly EdunovaContext _context;

        // 2. u konstruktoru definiramo kako će se to svojstvo popuniti

        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Smjerovi);
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }


        }
    }
}
