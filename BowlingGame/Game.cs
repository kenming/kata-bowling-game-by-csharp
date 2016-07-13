using System;
using System.Collections.Generic;
using System.Text;

namespace kata.game
{
    public class Game
    {
        private int totalScore;

        public void roll(int pins)      // 投球
        {
            totalScore += pins;
        }

        public int score()              // 計分
        {
            return totalScore;
        }
    }
}