using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardWorld
{
    public class Transaction
    {
        public string CardId { get; set; }

        public string TransactionId { get; set; }

        public string  StoreName{ get; set; }

        public int Cost { get; set; }

        public DateTime Date { get; set; }
    }
}
