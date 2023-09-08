using System;

namespace InterfaceFinanceOperations
{
    public class Bank : IFinanceOperations
    {
        decimal TotalAmount;

        public Bank(decimal totalAmount)
        {
            this.TotalAmount = totalAmount;
        }

        public void CalculateLoanPercent(int month)
        {

            decimal percent = 1.05m;
            decimal result = TotalAmount;

            for(int i = 0; i < month; i++)
            {
                result = result * percent;
            }

            Console.WriteLine($"Your total debt is {result}");

        }

        public bool CheckUserHistory()
        {
            Random random = new Random();
            bool check = random.Next(2) == 0;
            
            return check; 

        }
    }
}
