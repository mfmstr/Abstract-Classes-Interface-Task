using System;

namespace InterfaceFinanceOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(500);
            if (bank.CheckUserHistory())
            {
                bank.CalculateLoanPercent(12);
            }

            MicroFinance microFinance = new MicroFinance(500);
            if(microFinance.CheckUserHistory())
            {
                microFinance.CalculateLoanPercent(12);
            }

        }
    }
}
