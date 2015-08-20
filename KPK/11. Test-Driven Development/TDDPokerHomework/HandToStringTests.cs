using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TDDPokerHomework
{
    [TestClass]
    public class HandToStringTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Hand_ToString_WhenCardsAreNull_ExpectedToThrow()
        {
            var testHand = new Hand(null);

            testHand.ToString();
        }

        [TestMethod]
        public void Hand_ToString_WhenNoCards_ExpectedToReturnNoCards()
        {
            var testCards = new List<ICard> { };

            var testHand = new Hand(testCards);

            Assert.AreEqual("No cards in this hand!", testHand.ToString(), "Expected to return no cards instead of {0}", testHand.ToString());
        }

        [TestMethod]
        public void Hand_ToString_WhenOneCard_ExpectedToReturnTheCard()
        {
            var testCard = new Card(CardFace.Six, CardSuit.Diamonds);
            var testCards = new List<ICard> { };

            testCards.Add(testCard);
            var testHand = new Hand(testCards);

            Assert.AreEqual(testCard.ToString(), testHand.ToString());
        }

        [TestMethod]
        public void Hand_ToString_WhenManyCards_ExpectedToReturnTheCards()
        {
            var testCard = new Card(CardFace.Six, CardSuit.Diamonds);
            var testCardTwo = new Card(CardFace.King, CardSuit.Spades);
            var testCards = new List<ICard> { };

            testCards.Add(testCard);
            testCards.Add(testCardTwo);

            var testHand = new Hand(testCards);

            var expected = String.Format("{0}, {1}", testCard.ToString(), testCardTwo.ToString());
            Assert.AreEqual(expected, testHand.ToString());
        }
    }
}
