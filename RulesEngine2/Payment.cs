using RulesEngine.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine2
{
    public class Payment
    {
        public IEmailService _emailService;
        public ICommissionService _commissionService;
        public IInvoiceService _invoiceService;
        public IMembershipService _membershipService;
        public IVideoService _videoService;
        public Payment(IEmailService emailService, ICommissionService commissionService, IInvoiceService invoiceService, IMembershipService membershipService, IVideoService videoService)
        {
            _emailService = emailService;
            _commissionService = commissionService;
            _invoiceService = invoiceService;
            _membershipService = membershipService;
            _videoService = videoService;
        }

        public string PhysicalProduct()
        {
            string packageSlip = _invoiceService.GeneratePackingSlip("Product").Message;
            string commission = _commissionService.GenerateCommission().Message;

            return packageSlip + ", " + commission;
        }

        public string Book()
        {
            string packageSlip = _invoiceService.GeneratePackingSlip("Book").Message;
            string commission = _commissionService.GenerateCommission().Message;

            return packageSlip + ", " + commission;
        }

        public string Membership(string mode = "")
        {
            string action = string.Empty;
            if (mode == "New")
            {
                action = "activation";
            }
            else
            {
                action = "upgrade";
            }

            string membershipDetails = _membershipService.BuyMembership(mode).Message;
            string email = _emailService.SendEmail().Message;
            return membershipDetails + ", " + email + action;
        }

        public string Video()
        {
            string videoOrder = _videoService.OrderVideo().Message;
            string packageSlip = _invoiceService.GeneratePackingSlip("Video").Message;
            return videoOrder + ", " + packageSlip;
        }
    }
}
