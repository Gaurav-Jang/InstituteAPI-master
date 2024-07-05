using System.Diagnostics;
using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.BusinessServiceLayer.Services;
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

        // get
        [HttpGet]
        [Route("GetActiveFeeStructure")]
        public IActionResult GetActiveFeeStructure()
        {
            List<FeeStructure> feeStructure = _feeStructureService.GetActiveFeeStructure();
            return Ok(feeStructure);
        }

        // delete
        [HttpGet]
        [Route("DeleteFeeStructure")]
        public IActionResult DeleteFeeStructure(int FeeStructureId)
        {
            _feeStructureService.DeleteFeeStructure(FeeStructureId);
            return Ok();
        }

        // edit
        [HttpGet]
        [Route("GetFeeStructureByFeeStructureId")]
        public IActionResult GetFeeStructureByFeeStructureId(int FeeStructureId)
        {
            FeeStructure feeStructure = _feeStructureService.GetFeeStructureByFeeStructureId(FeeStructureId);
            return Ok(feeStructure);
        }

        // update
        [HttpPost]
        [Route("UpdateFeeStructure")]
        public IActionResult UpdateFeeStructure([FromBody] FeeStructure feeStructure)
        {
            var data = _feeStructureService.CheckDuplicateFeeStructure(feeStructure);
            if (data > 0)
            {
                return Ok("Fee Structure already exists, make some changes.");
            }
            else
            {
                int FeeStructureId = _feeStructureService.UpdateFeeStructure(feeStructure);
                return Ok(FeeStructureId);
            }
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