using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RulesEngine.Business;
using RulesEngine2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Test
{
    [TestClass]
    public class PaymentTest
    {

        private Mock<IEmailService> _mockEmailService = new Mock<IEmailService>();
        private Mock<ICommissionService> _mockCommissionService = new Mock<ICommissionService>();
        private Mock<IInvoiceService> _mockInvoiceService = new Mock<IInvoiceService>();
        private Mock<IMembershipService> _mockMembershipService = new Mock<IMembershipService>();
        private Mock<IVideoService> _mockVideoService = new Mock<IVideoService>();

        [TestMethod]
        public void TestPhysicalProduct()
        {
            Payment payment = new Payment(_mockEmailService.Object, _mockCommissionService.Object, _mockInvoiceService.Object, _mockMembershipService.Object, _mockVideoService.Object);
            var data = payment.PhysicalProduct();

            Assert.AreEqual(data, "Packing slip generated for shipping, Generated commission payment to the agent");
        }

        [TestMethod]
        public void TestBook()
        {
            Payment payment = new Payment(_mockEmailService.Object, _mockCommissionService.Object, _mockInvoiceService.Object, _mockMembershipService.Object, _mockVideoService.Object);
            var data = payment.Book();

            Assert.AreEqual(data, "Duplicate packing slip generated for royalty department, Generated commission payment to the agent");
        }
        [TestMethod]
        public void TestNewMembership()
        {
            Payment payment = new Payment(_mockEmailService.Object, _mockCommissionService.Object, _mockInvoiceService.Object, _mockMembershipService.Object, _mockVideoService.Object);
            var data = payment.Membership("New");

            Assert.AreEqual(data, "Activate membership, Send Email to owner and inform about activation");
        }
        [TestMethod]
        public void TestRenewMembership()
        {
            Payment payment = new Payment(_mockEmailService.Object, _mockCommissionService.Object, _mockInvoiceService.Object, _mockMembershipService.Object, _mockVideoService.Object);
            var data = payment.Membership();

            Assert.AreEqual(data, "Membership upgraded, Send Email to owner and inform about upgrade");
        }
        [TestMethod]
        public void TestVideo()
        {
            Payment payment = new Payment(_mockEmailService.Object, _mockCommissionService.Object, _mockInvoiceService.Object, _mockMembershipService.Object, _mockVideoService.Object);
            var data = payment.Video();

            Assert.AreEqual(data, "Payment made for 'Learning to Ski' video, Add a free 'First Aid' video to the packing slip");
        }


    }
}
