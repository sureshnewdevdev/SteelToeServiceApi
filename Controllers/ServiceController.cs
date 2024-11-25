using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ServiceAPI.Controllers
{
    [ApiController]
    [Route("api/service")]
    public class ServiceController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetSecureData()
        {
            return Ok(new { message = "This is a secure message from the service API." });
        }


        //[HttpGet(Name ="Unsecured")]
        //[Authorize]
        //public IActionResult GetUnSecureData()
        //{
        //    return Ok(new { message = "This is a UNSECURE message from the service API." });
        //}
    }
}
