using System.Text;

namespace CreditCardWorld
{
    public class CardsManager
    {
        private readonly DataStorage _dataStorage = new DataStorage();


        public string GenerateTransactionReport(string cardId)
        {
            var card = _dataStorage.GetCard(cardId);
            var sb = new StringBuilder();
            var totalDebit = 0;
            foreach (var transaction in card.GetTransactions())
            {
                var transDetails =
                    $"TransactionId: {transaction.TransactionId}, " +
                    $"Cost: {transaction.Cost}, " +
                    $"StoreName: {transaction.StoreName}, " +
                    $"Date: {transaction.Date}, " +
                    $"CardId: {transaction.CardId}\n";
                sb.Append(transDetails);
                totalDebit += transaction.Cost;
            }

            sb.Append($"Total debit for card: {totalDebit}");
            return sb.ToString();
        }

        

        public double GetServiceCharge(string cardId)
        {
            var card = _dataStorage.GetCard(cardId);
            return card.CalcServiceCharge();
        }

        public void AddNewCard(CreditCard card)
        {
            _dataStorage.AddCard(card.CardId,card);
        }

        public void AddTransactionToCard(string cardId, Transaction transaction)
        {
            var card = _dataStorage.GetCard(cardId);
            card.AddTransaction(transaction);
        }
    }
}
