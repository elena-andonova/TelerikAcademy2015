using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TDDPokerHomework
{
    [TestClass]
    public class IsValidHandTests
    {
        [TestMethod]
        public void IsValidHand_WhenNoCards_ExpectedToReturnFalse()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard> { };

            var testHand = new Hand(testCards);

            Assert.AreEqual(false, testChecker.IsValidHand(testHand));
        }

        [TestMethod]
        public void IsValidHand_WhenOneCard_ExpectedToReturnFalse()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard> { new Card(CardFace.Ace, CardSuit.Clubs) };

            var testHand = new Hand(testCards);

            Assert.AreEqual(false, testChecker.IsValidHand(testHand));
        }

        [TestMethod]
        public void IsValidHand_WhenTwoCards_ExpectedToReturnFalse()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard>() { new Card(CardFace.Ace, CardSuit.Clubs), new Card(CardFace.Queen, CardSuit.Clubs) };

            var testHand = new Hand(testCards);

            Assert.AreEqual(false, testChecker.IsValidHand(testHand));
        }

        [TestMethod]
        public void IsValidHand_WhenFiveCardsAndTwoAreSame_ExpectedToReturnFalse()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs)
                };

            var testHand = new Hand(testCards);

            Assert.AreEqual(false, testChecker.IsValidHand(testHand));
        }

        [TestMethod]
        public void IsValidHand_WhenFiveDifferentCards_ExpectedToReturnTrue()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)
                };

            var testHand = new Hand(testCards);

            Assert.AreEqual(true, testChecker.IsValidHand(testHand));
        }
    }
}
