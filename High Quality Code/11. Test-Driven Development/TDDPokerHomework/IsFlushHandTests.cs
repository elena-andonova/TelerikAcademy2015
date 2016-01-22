using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TDDPokerHomework
{
    [TestClass]
    public class IsFlushHandTests
    {
        [TestMethod]
        public void IsFlushHands_WhenDifferentSuit_ExpectedToReturnFalse()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs)
                };

            var testHand = new Hand(testCards);

            Assert.AreEqual(false, testChecker.IsFlush(testHand));
        }

        [TestMethod]
        public void IsFlushHands_WhenAllSameSuit_ExpectedToReturnTrue()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs)
                };

            var testHand = new Hand(testCards);

            Assert.AreEqual(true, testChecker.IsFlush(testHand));
        }
    }
}
