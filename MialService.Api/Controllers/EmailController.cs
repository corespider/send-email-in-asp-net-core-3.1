using MailKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailService.Api.Models;
using MailService.Api.Services;

namespace MailService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService mailService;
        public EmailController(IEmailService mailService)
        {
            this.mailService = mailService;
        }
        [HttpPost("sendEmail")]
        public async Task<IActionResult> SendMail([FromForm] EmailInfo emailInfo)
        {
            try
            {
                
                await mailService.SendEmailAsync(emailInfo);
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpPost("sendEmailTemplate")]
        public async Task<IActionResult> SendWelcomeMail([FromForm] EmailSource source)
        {
            try
            {
                await mailService.SendEmailTemplateAsync(source);
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}