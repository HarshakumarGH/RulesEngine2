using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RulesEngine.Business;
using System;

namespace RulesEngine2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Next generation Rules Engine!!!");
            Console.WriteLine("------------------------------------------");

            var serviceProvider = new ServiceCollection()
           .AddLogging()
           .AddSingleton<IInvoiceService, InvoiceService>()
           .AddSingleton<IEmailService, EmailService>()
           .AddSingleton<ICommissionService, CommissionService>()
           .AddSingleton<IMembershipService, MembershipService>()
           .AddSingleton<IVideoService, VideoService>()
           .AddSingleton<Payment>()
           .BuildServiceProvider();


            var paymentInstance = serviceProvider.GetService<Payment>();

            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("\nPlease choose the payment for the below choices");

                    Console.WriteLine("\n1 - Physical Product \n2 - Book \n3 - New Mebership \n4 - Upgrade Membership \n5 - Video -'Learning to Ski' \n6 - Exit \n");
                    int inputValue;
                    bool isValid = int.TryParse(Console.ReadLine(), out inputValue);
                    if (!isValid)
                    {
                        Console.WriteLine("\nInvalid Input");
                        continue;
                    }
                    bool wrongChoice = false;
                    switch (inputValue)
                    {
                        case 1:
                            Console.WriteLine(paymentInstance.PhysicalProduct());
                            break;

                        case 2:
                            Console.WriteLine(paymentInstance.Book());
                            break;

                        case 3:
                            Console.WriteLine(paymentInstance.Membership("New"));
                            break;

                        case 4:
                            Console.WriteLine(paymentInstance.Membership());
                            break;

                        case 5:
                            Console.WriteLine(paymentInstance.Video());
                            break;

                        case 6:
                            exit = true;
                            break;

                        default:
                            wrongChoice = true;
                            break;
                    }
                    if (wrongChoice)
                    {
                        Console.WriteLine("\nInvalid Choice");
                    }
                    Console.WriteLine("---------------------------------------------------------------------------------");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
        }
    }
}
