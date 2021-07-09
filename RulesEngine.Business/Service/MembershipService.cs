using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Business
{
    public class MembershipService : IMembershipService
    {
        public ActionResponse BuyMembership(string mode = "")
        {
            try
            {
                if (mode == "New")
                {
                    return new ActionResponse() { Status = true, Message = "Activate membership" };
                }
                return new ActionResponse() { Status = true, Message = "Membership upgraded" };
            }
            catch (Exception ex)
            {
                return new ActionResponse() { Status = false, Message = ex.Message };
            }
        }
    }
}
