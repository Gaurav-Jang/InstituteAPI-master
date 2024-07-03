using System.Diagnostics;
using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.Models.FeeStructure;
using Microsoft.AspNetCore.Mvc;

namespace InstituteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeStructureController : ControllerBase
    {
        private readonly ILogger<FeeStructureController> _logger;
        private readonly IFeeStructureService _feeStructureService;
        public FeeStructureController(ILogger<FeeStructureController> logger, IFeeStructureService feeStructureService)
        {
            _logger = logger;
            _feeStructureService = feeStructureService;
        }

        // post
        [HttpPost]
        [Route("SetFeeStructure")]
        public IActionResult SetFeeStructure([FromBody] FeeStructure feeStructure)
        {
            int FeeStructureId = _feeStructureService.SetFeeStructure(feeStructure);
            return Ok(FeeStructureId);
        }

    }
}