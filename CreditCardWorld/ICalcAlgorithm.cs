using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardWorld
{
    public interface ICalcAlgorithm
    {
        double Calc(List<Transaction> transactions);
    }
}
