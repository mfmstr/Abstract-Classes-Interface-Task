using System;

namespace InterfaceFinanceOperations
{
    public class MicroFinance : IFinanceOperations
    {
        decimal TotalAmount;
        public MicroFinance(decimal totalAmount)
        {

            TotalAmount = totalAmount;

        }
        public void CalculateLoanPercent(int month)
        {
            decimal percent = 1.1m;
            decimal result = TotalAmount;

            for (int i = 0; i < month; i++)
            {
                result = result * percent;
            }

            Console.WriteLine($"Your total debt is {result}");
        }

        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
