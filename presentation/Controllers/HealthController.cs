using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using presentation.Models.Response;

namespace presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet("Check")]
        public ActionResult Check()
        {
            return Ok(new BaseResponseModel());
        }
    }
}
