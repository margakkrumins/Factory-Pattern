using System;

using Interfaces;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Concrete factory of the creator type
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;

            // Get objects through implementation of creator's method
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
                $" and national balance is ${nationalAcct.Balance}");
        }
    }
}
