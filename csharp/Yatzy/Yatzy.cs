using System.Linq;

namespace Yatzy
{
    public class Yatzy
    {
        protected int[] dice;
        public Yatzy(int d1, int d2, int d3, int d4, int d5)
        {
            dice = new int[5];
            dice[0] = d1;
            dice[1] = d2;
            dice[2] = d3;
            dice[3] = d4;
            dice[4] = d5;
        }
        public int Chance()
        {
            return this.dice.Sum();
        }
        public int yatzy()
        {
            if (this.dice.Max() == this.dice.Min())
            {
                return 50;
            }
            return 0;
        }
        private int NumberOfSame(int die_value)
        {
            int count = 0;
            for (int i = 0; i < this.dice.Length; i++)
            {
                if (this.dice[i] == die_value)
                {
                    count++;
                }
            }
            return count;
        }
        public int Ones()
        {
            return this.NumberOfSame(1);
        }
        public int Twos()
        {
            return this.NumberOfSame(2) * 2;
        }
        public int Threes()
        {
            return this.NumberOfSame(3) * 3;
        }
        public int Fours()
        {
            return this.NumberOfSame(4) * 4;
        }
        public int Fives()
        {
            return this.NumberOfSame(5) * 5;
        }
        public int Sixes()
        {
            return this.NumberOfSame(6) * 6;
        }
        public int Pair(int max_die_value = 6)
        {
            for (int i = max_die_value; i > 0; i--)
            {
                if (this.NumberOfSame(i) >= 2)
                    return i * 2;
            }
            return 0;
        }
        public int TwoPair()
        {
            var sumOfPair1 = this.Pair();
            if (sumOfPair1 != 0)
            {
                var sumOfPair2 = this.Pair((sumOfPair1 / 2) - 1);
                if (sumOfPair2 != 0)
                    return sumOfPair1 + sumOfPair2;
            }
            return 0;
        }
        public int ThreeOfAKind(int max_die_value = 6)
        {
            for (int i = max_die_value; i > 0; i--)
            {
                if (this.NumberOfSame(i) >= 3)
                    return i * 3;
            }
            return 0;
        }
        public int FourOfAKind(int max_die_value = 6)
        {
            for (int i = max_die_value; i > 0; i--)
            {
                if (this.NumberOfSame(i) >= 4)
                    return i * 4;
            }
            return 0;
        }
        public int SmallStraight()
        {
            if (this.Pair() == 0 && this.dice.Max() == 5)
            {
                return 15;
            }
            return 0;
        }
        public int LargeStraight()
        {
            if (this.Pair() == 0 && this.dice.Max() == 6)
            {
                return 20;
            }
            return 0;
        }
        public int FullHouse()
        {
            var tripleValue = this.ThreeOfAKind() / 3;
            for (int doubleValue = 6; doubleValue > 0; doubleValue--)
            {
                var numberOfSame = this.NumberOfSame(doubleValue);
                if (doubleValue != tripleValue && numberOfSame == 2)
                    return (tripleValue * 3) + (doubleValue * 2);
            }
            return 0;
        }
    }
}