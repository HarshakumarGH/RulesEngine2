using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Business
{
    public class EmailService : IEmailService
    {
        public ActionResponse SendEmail()
        {
            try
            {
                return new ActionResponse() { Status = true, Message = "Send Email to owner and inform about " };
            }
            catch (Exception ex)
            {
                return new ActionResponse() { Status = false, Message = ex.Message };
            }
        }
    }
}
