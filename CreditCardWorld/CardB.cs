using System.Collections.Generic;

namespace CreditCardWorld
{
    public class CardB : ICalcAlgorithm
    {
        public double Calc(List<Transaction> transactions)
        {
            double debit = 0;
            foreach (var transaction in transactions)
            {
                debit += transaction.Cost * 0.8 / 100;
            }

            return debit;
        }
    }
}