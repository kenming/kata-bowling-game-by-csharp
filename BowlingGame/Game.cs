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
                if (isStrike(frameIndex))
                {
                    totalScore += 10 + strikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex))
                {
                    totalScore += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    totalScore += sumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return totalScore;
        }

        private Boolean isSpare(int frameIndex)
        {
            return rolls[frameIndex] +
                    rolls[frameIndex + 1] == 10;
        }

        private Boolean isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        private int sumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int strikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
    }
}