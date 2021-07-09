using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Business
{
    public class InvoiceService : IInvoiceService
    {
        public ActionResponse GeneratePackingSlip(string item)
        {
            try
            {
                if (item == "Product")
                {
                    return new ActionResponse() { Status = true, Message = "Packing slip generated for shipping" };
                }
                else if (item == "Book")
                {
                    return new ActionResponse() { Status = true, Message = "Duplicate packing slip generated for royalty department" };
                }
                else if (item == "Video")
                {
                    return new ActionResponse() { Status = true, Message = "Add a free 'First Aid' video to the packing slip" };
                }
                else
                {
                    return new ActionResponse() { Status = true, Message = "Packing slip generated" };
                }
            }
            catch (Exception ex)
            {
                return new ActionResponse() { Status = false, Message = ex.Message };
            }
        }
    }
}
