using System;
using System.Collections.Generic;

namespace CreditCardWorld
{
    public class CreditCard
    {
        private ICalcAlgorithm CalcAlgorithm { get; }

        private Club Club { get; }

        private readonly List<Transaction> _transactions;

        public CreditCard(ICalcAlgorithm calcAlgorithm, Club club)
        {
            CalcAlgorithm = calcAlgorithm;
            Club = club;
            _transactions = new List<Transaction>();
        }

        
        public string IdNumber { get; set; }

        public string Name { get; set; }

        public DateTime ExpirationDate{ get; set; }

        public string CardId { get; set; }

        public double CalcServiceCharge()
        {

           return CalcAlgorithm.Calc(_transactions);
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }


        public List<Transaction> GetTransactions()
        {
            return _transactions;
        }


    }
}
