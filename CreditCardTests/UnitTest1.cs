using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CreditCardWorld;

namespace CreditCardTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAlgorithmA()
        {
            var cardsManager = new CardsManager();

            const string CARD_ID = "12345";

            //Arrange
            var card1 = new CreditCard(new CardA(), new Club() { Name = "Army" })
                { CardId = CARD_ID, ExpirationDate = DateTime.Now, IdNumber = "0266858969", Name = "Chaim" };

            cardsManager.AddNewCard(card1);

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

            //Act
            var serviceCharge = cardsManager.GetServiceCharge(CARD_ID);

            //Assert
            Assert.AreEqual(0.4, serviceCharge);
        }


        [TestMethod]
        public void TestAlgorithmB()
        {
            var cardsManager = new CardsManager();

            const string CARD_ID = "12345";

            //Arrange
            var card1 = new CreditCard(new CardB(), new Club() { Name = "Army" })
                { CardId = CARD_ID, ExpirationDate = DateTime.Now, IdNumber = "0266858969", Name = "Chaim" };


            cardsManager.AddNewCard(card1);

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

            //Act
            var serviceCharge = cardsManager.GetServiceCharge(CARD_ID);

            //Assert
            Assert.AreEqual(1.44, serviceCharge);
        }

        [TestMethod]
        public void TestAlgorithmC()
        {
            var cardsManager = new CardsManager();

            const string CARD_ID = "12345";

            //Arrange
            var card1 = new CreditCard(new CardC(), new Club() { Name = "Army" })
                { CardId = CARD_ID, ExpirationDate = DateTime.Now, IdNumber = "0266858969", Name = "Chaim" };


            cardsManager.AddNewCard(card1);

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

            //Act
            var serviceCharge = cardsManager.GetServiceCharge(CARD_ID);

            //Assert
            Assert.AreEqual(12, serviceCharge);
        }
    }
}
