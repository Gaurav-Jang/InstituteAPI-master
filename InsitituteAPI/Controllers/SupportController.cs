using System.Diagnostics;
using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.Models.Support;
using Microsoft.AspNetCore.Mvc;

namespace InstituteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportController : ControllerBase
    {

        private readonly ILogger<SupportController> _logger;
        private readonly ISupportService _supportService;
        public SupportController(ILogger<SupportController> logger, ISupportService SupportService)
        {
            _logger = logger;
            _supportService = SupportService;
        }
        
        ///Post
        [HttpPost]
        [Route("SetSupport")]
        public IActionResult SetSupport([FromBody] Support support)
        {

            int SupportId = _supportService.SetSupport(support);
            return Ok(SupportId);
        }
    }
}
