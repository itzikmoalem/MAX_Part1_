using System.Collections.Generic;

namespace CreditCardWorld
{
    public class CardA : ICalcAlgorithm
    {
        public double Calc(List<Transaction> transactions)
        {
            return transactions.Count*0.1;
        }
    }
}
