using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace TDDPokerHomework
{
    [TestClass]
    public class CardToStringTests
    {
        [TestMethod]
        public void Card_ToString_ToBeValid()
        {
            var testCard = new Card(CardFace.Ace, CardSuit.Clubs);

            var expected = String.Format("{0} of {1}", testCard.Face, testCard.Suit);

            Assert.AreEqual(expected, testCard.ToString());
        }

         [TestMethod]
        public void Card_ToString_ToBeValidAgain()
        {
            var testCard = new Card(CardFace.Ten, CardSuit.Hearts);         

            var expected = String.Format("{0} of {1}", CardFace.Ten, CardSuit.Hearts);

            Assert.AreEqual(expected, testCard.ToString());
        }
    }

}
