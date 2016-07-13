using System;
using System.Collections.Generic;
using System.Text;

namespace kata.game
{
    public class Game
    {
        private int[] rolls = new int[20];
        private int currentRoll = 0;

        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int score()
        {
            int totalScore = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (this.isSpare(frameIndex))
                {
                    totalScore += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    totalScore += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return totalScore;
        }

        // 判斷是否為補中 (Spare)
        private Boolean isSpare(int frameIndex)
        {
            return rolls[frameIndex] +
                    rolls[frameIndex + 1] == 10;
        }
    }
}