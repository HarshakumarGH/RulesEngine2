using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Business
{
    public class VideoService : IVideoService
    {
        public ActionResponse OrderVideo()
        {
            try
            {
                return new ActionResponse() { Status = true, Message = "Payment made for 'Learning to Ski' video" };
            }
            catch (Exception ex)
            {
                return new ActionResponse() { Status = false, Message = ex.Message };
            }
        }
    }
}
