using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MTLS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get() => "The action works fine without a certificate";

        [Authorize]
        [HttpPost]
        public string Post() => "The action works fine only with a certificate";
    }
}