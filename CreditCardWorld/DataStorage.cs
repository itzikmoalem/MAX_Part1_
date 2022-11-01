using System.Collections.Generic;

namespace CreditCardWorld
{
    class DataStorage
    {
        private readonly Dictionary<string, CreditCard> _allCards = new Dictionary<string, CreditCard>();

        public CreditCard GetCard(string Id)
        {
            _allCards.TryGetValue(Id, out var card);
            return card;
        }

        public void AddCard(string Id, CreditCard creditCard)
        {
            _allCards.Add(Id, creditCard);
        }
    }
}