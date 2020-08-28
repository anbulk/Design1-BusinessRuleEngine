using System;
using System.Collections.Generic;
using OrderProcessing;

namespace RunOrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Order Processing System --");
            Order firstOrder = new Order();
            firstOrder.Product = new Book();
            List<IRule> rules = new List<IRule>();
            rules.Add(new PackagingSlipRule());
            firstOrder.rules = rules;
            firstOrder.ProcessOrder(new GPayPayment());
            foreach(var r in firstOrder.ProcessingOutcome)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
