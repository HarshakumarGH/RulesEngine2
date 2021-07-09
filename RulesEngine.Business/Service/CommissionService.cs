using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Business
{
    public class CommissionService : ICommissionService
    {
        public ActionResponse GenerateCommission()
        {
            try
            {
                return new ActionResponse() { Status = true, Message = "Generated commission payment to the agent" };
            }
            catch (Exception ex)
            {
                return new ActionResponse() { Status = false, Message = ex.Message };
            }
        }
    }
}
