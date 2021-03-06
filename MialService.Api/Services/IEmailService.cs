using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailService.Api.Models;
namespace MailService.Api.Services
{
   public interface IEmailService
    {
        Task SendEmailAsync(EmailInfo emailInfo);
        Task SendEmailTemplateAsync(EmailSource emailSource);
    }
}
