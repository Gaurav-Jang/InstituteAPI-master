using System;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InstituteAPI.BusinessServiceLayer.Interfaces;
using InstituteAPI.Models.Support;

namespace InstituteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportController : ControllerBase
    {
        private readonly ILogger<SupportController> _logger;
        private readonly ISupportService _supportService;

        public SupportController(ILogger<SupportController> logger, ISupportService supportService)
        {
            _logger = logger;
            _supportService = supportService;
        }

        [HttpPost]
        [Route("SetSupport")]
        public IActionResult SetSupport([FromBody] Support support)
        {
            _logger.LogInformation("Received support request with data: {@Support}", support);

            int supportId;
            try
            {
                supportId = _supportService.SetSupport(support);
                _logger.LogInformation("Support request saved with ID: {SupportId}", supportId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving support request.");
                return StatusCode(500, "Error saving support request.");
            }

            // Email sending logic
            try
            {
                var fromAddress = new MailAddress("push4ck@gmail.com", "Pushkar Sharma");
                var fromPassword = "Push4ck_$amp@9";

                var toAddress = new MailAddress(support.Email, support.FullName);
                string subject = support.Subject;
                string body = $"Name: {support.FullName}\nEmail: {support.Email}\nMessage: {support.Message}";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                _logger.LogInformation("Email sent successfully to {Email}", support.Email);
            }
            catch (SmtpException smtpEx)
            {
                _logger.LogError(smtpEx, "SMTP Error: {Message}", smtpEx.Message);
                return StatusCode(500, $"Failed to send email due to SMTP error: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "General Error: {Message}", ex.Message);
                return StatusCode(500, "Internal server error");
            }

            return Ok(supportId);
        }
    }
}
