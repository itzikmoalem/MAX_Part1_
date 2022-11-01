using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardsManager = new CardsManager();

            const string CARD_ID = "12345";

            //create card
            var card1 = new CreditCard(new CardC(), new Club() { Name = "Army" })
                { CardId = CARD_ID, ExpirationDate = DateTime.Now, IdNumber = "0266858969", Name = "Chaim" };


            cardsManager.AddNewCard(card1);


            //create transactions
            var transaction1 = new Transaction()
                { CardId = CARD_ID, Cost = 30, Date = DateTime.Now, StoreName = "Castro", TransactionId = "2323" };
            
            var transaction2 = new Transaction()
                { CardId = CARD_ID, Cost = 40, Date = DateTime.Now, StoreName = "BurgersBar", TransactionId = "2343" };
            
            var transaction3 = new Transaction()
                { CardId = CARD_ID, Cost = 50, Date = DateTime.Now, StoreName = "Fox", TransactionId = "4423" };

            var transaction4 = new Transaction()
                { CardId = CARD_ID, Cost = 60, Date = DateTime.Now, StoreName = "H&O", TransactionId = "4323" };

            cardsManager.AddTransactionToCard(CARD_ID, transaction1);
            cardsManager.AddTransactionToCard(CARD_ID, transaction2);
            cardsManager.AddTransactionToCard(CARD_ID, transaction3);
            cardsManager.AddTransactionToCard(CARD_ID, transaction4);

            //question 2.b
            var serviceCharge = cardsManager.GetServiceCharge(CARD_ID);
            Console.WriteLine($"Service charge for card '{CARD_ID}: {serviceCharge} NIS");

            //question 2.c
            var transactionReport = cardsManager.GenerateTransactionReport(CARD_ID);
            Console.WriteLine(transactionReport);

            Console.ReadKey();
        }
    }
}