using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TDDPokerHomework
{
    [TestClass]
    public class IsFourOfAKindTests
    {
        [TestMethod]
        public void IsFourOfAKind_WhenDifferentFaces_ExpectedToReturnFalse()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
                };

            var testHand = new Hand(testCards);

            Assert.AreEqual(false, testChecker.IsFourOfAKind(testHand));
        }

        [TestMethod]
        public void IsFourOfAKind_WhenSameFourFaces_ExpectedToReturnTrue()
        {
            IPokerHandsChecker testChecker = new PokerHandsChecker();
            var testCards = new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds)
                };

            var testHand = new Hand(testCards);

            Assert.AreEqual(true, testChecker.IsFourOfAKind(testHand));
        }
    }
}
