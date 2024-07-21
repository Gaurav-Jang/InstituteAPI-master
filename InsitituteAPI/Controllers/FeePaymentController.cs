using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.Models.FeesPayment;
using Microsoft.AspNetCore.Mvc;

namespace InstituteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeePaymentController : ControllerBase
    {
        private readonly ILogger<FeePaymentController> _logger;
        private readonly IFeePaymentService _feePaymentService;
        public FeePaymentController(ILogger<FeePaymentController> logger, IFeePaymentService feePaymentService)
        {
            _logger = logger;
            _feePaymentService = feePaymentService;
        }

        // Get
        [HttpGet]
        [Route("GetActiveFeesPayment")]
        public IActionResult GetActiveFeesPayment()
        {
            List<FeePayment> feePayments = _feePaymentService.GetActiveFeesPayment();
            return Ok(feePayments);
        }

        // delete
        [HttpGet]
        [Route("DeleteFeesPayment")]
        public IActionResult DeleteFeesPayment(int feePaymentId)
        {
            _feePaymentService.DeleteFeesPayment(feePaymentId);
            return Ok();
        }

        // edit
        [HttpGet]
        [Route("GetFeesPaymentByFeesPaymentId")]
        public IActionResult GetFeesPaymentByFeesPaymentId(int feesPaymentId)
        {
            FeePayment feePayment = _feePaymentService.GetFeesPaymentByFeesPaymentId(feesPaymentId);
            return Ok(feePayment);
        }

        // update
        [HttpPost]
        [Route("UpdateFeesPayment")]
        public IActionResult UpdateFeesPayment([FromBody] FeePayment feePayment)
        {
            var data = _feePaymentService.CheckDuplicateFeesPayment(feePayment);
            if (data > 0)
            {
                return Ok("student fees payment already exists.");
            }
            else
            {
                int FeePaymentId = _feePaymentService.UpdateFeesPayment(feePayment);
                return Ok(FeePaymentId);
            }
        }

        // Post
        [HttpPost]
        [Route("SetFeesPayment")]
        public IActionResult SetFeesPayment([FromBody] FeePayment feePayment)
        {
            var data = _feePaymentService.CheckDuplicateFeesPayment(feePayment);
            if (data > 0)
            {
                return Ok("student fees payment already exists.");
            }
            else
            {
                int FeePaymentId = _feePaymentService.SetFeesPayment(feePayment);
                return Ok(FeePaymentId);
            }
        }
    }
}
