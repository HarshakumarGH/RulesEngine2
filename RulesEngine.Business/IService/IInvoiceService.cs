﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Business
{
    public interface IInvoiceService
    {
        public ActionResponse GeneratePackingSlip(string item);
    }
}
