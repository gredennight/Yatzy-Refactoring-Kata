using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Yatzy;

namespace Yatzy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Chance_scores_sum_of_all_dice()
        {
            var expected = 15;

            var actual = new Yatzy(2, 3, 4, 5, 1).Chance();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(16, new Yatzy(3, 3, 4, 5, 1).Chance());
        }
        [TestMethod]
        public void Yatzy_scores_50()
        {
            var expected = 50;
            var actual = new Yatzy(4, 4, 4, 4, 4).yatzy();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(50, new Yatzy(6, 6, 6, 6, 6).yatzy());
            Assert.AreEqual(0, new Yatzy(6, 6, 6, 6, 3).yatzy());
        }
        [TestMethod]
        public void Fact_1s()
        {
            Assert.IsTrue(new Yatzy(1, 2, 3, 4, 5).Ones() == 1);
            Assert.AreEqual(2, new Yatzy(1, 2, 1, 4, 5).Ones());
            Assert.AreEqual(0, new Yatzy(6, 2, 2, 4, 5).Ones());
            Assert.AreEqual(4, new Yatzy(1, 2, 1, 1, 1).Ones());
        }

        [TestMethod]
        public void Fact_2s()
        {
            Assert.AreEqual(4, new Yatzy(1, 2, 3, 2, 6).Twos());
            Assert.AreEqual(10, new Yatzy(2, 2, 2, 2, 2).Twos());
        }

        [TestMethod]
        public void Fact_threes()
        {
            Assert.AreEqual(6, new Yatzy(1, 2, 3, 2, 3).Threes());
            Assert.AreEqual(12, new Yatzy(2, 3, 3, 3, 3).Threes());
        }
        [TestMethod]
        public void fours_Fact()
        {
            Assert.AreEqual(12, new Yatzy(4, 4, 4, 5, 5).Fours());
            Assert.AreEqual(8, new Yatzy(4, 4, 5, 5, 5).Fours());
            Assert.AreEqual(4, new Yatzy(4, 5, 5, 5, 5).Fours());
        }
        [TestMethod]
        public void fives()
        {
            Assert.AreEqual(10, new Yatzy(4, 4, 4, 5, 5).Fives());
            Assert.AreEqual(15, new Yatzy(4, 4, 5, 5, 5).Fives());
            Assert.AreEqual(20, new Yatzy(4, 5, 5, 5, 5).Fives());
        }
        [TestMethod]
        public void sixes_Fact()
        {
            Assert.AreEqual(0, new Yatzy(4, 4, 4, 5, 5).Sixes());
            Assert.AreEqual(6, new Yatzy(4, 4, 6, 5, 5).Sixes());
            Assert.AreEqual(18, new Yatzy(6, 5, 6, 6, 5).Sixes());
        }
        [TestMethod]
        public void one_pair()
        {
            Assert.AreEqual(6, new Yatzy(3, 4, 3, 5, 6).Pair());
            Assert.AreEqual(10, new Yatzy(5, 3, 3, 3, 5).Pair());
            Assert.AreEqual(12, new Yatzy(5, 3, 6, 6, 5).Pair());
        }
        [TestMethod]
        public void two_Pair()
        {
            Assert.AreEqual(16, new Yatzy(3, 3, 5, 4, 5).TwoPair());
            Assert.AreEqual(16, new Yatzy(3, 3, 5, 5, 5).TwoPair());
            Assert.AreEqual(0, new Yatzy(3, 3, 1, 2, 5).TwoPair());

        }
        [TestMethod]
        public void three_of_a_kind()
        {
            Assert.AreEqual(9, new Yatzy(3, 3, 3, 4, 5).ThreeOfAKind());
            Assert.AreEqual(15, new Yatzy(5, 3, 5, 4, 5).ThreeOfAKind());
            Assert.AreEqual(9, new Yatzy(3, 3, 3, 3, 5).ThreeOfAKind());
        }
        [TestMethod]
        public void four_of_a_knd()
        {
            Assert.AreEqual(12, new Yatzy(3, 3, 3, 3, 5).FourOfAKind());
            Assert.AreEqual(20, new Yatzy(5, 5, 5, 4, 5).FourOfAKind());
            Assert.AreEqual(12, new Yatzy(3, 3, 3, 3, 3).FourOfAKind());
        }
        [TestMethod]
        public void smallStraight()
        {
            Assert.AreEqual(15, new Yatzy(2, 3, 4, 5, 1).SmallStraight());
            Assert.AreEqual(15, new Yatzy(1, 2, 3, 4, 5).SmallStraight());
            Assert.AreEqual(0, new Yatzy(1, 2, 2, 4, 5).SmallStraight());
        }
        [TestMethod]
        public void largeStraight()
        {
            Assert.AreEqual(20, new Yatzy(6, 2, 3, 4, 5).LargeStraight());
            Assert.AreEqual(20, new Yatzy(2, 3, 4, 5, 6).LargeStraight());
            Assert.AreEqual(0, new Yatzy(1, 2, 2, 4, 5).LargeStraight());
        }
        [TestMethod]
        public void fullHouse()
        {
            Assert.AreEqual(18, new Yatzy(6, 2, 2, 2, 6).FullHouse());
            Assert.AreEqual(22, new Yatzy(6, 6, 2, 2, 6).FullHouse());
            Assert.AreEqual(0, new Yatzy(2, 3, 4, 5, 6).FullHouse());
        }
    }

}
