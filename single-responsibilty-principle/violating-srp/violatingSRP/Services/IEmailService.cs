using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace violatingSRP.Services
{
    public interface IEmailService
    {
        void SendEmail(string email, string product, string message);
    }
}