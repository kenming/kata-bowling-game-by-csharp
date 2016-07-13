using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata.game;

namespace kata.game.test
{
    [TestClass]
    public class GameTest
    {
        private Game g;     // 宣告參考變數，指向 Game instance

        [TestInitialize]
        public void setup() {
            g = new Game();
        }

        [TestMethod]
        public void testGutterGame()
        {
            int expected = 0;   // 期望結果值
            int actual;         // 實際結果值

            for (int i = 0; i < 20; i++)
            {
                g.roll(0);
            }
            actual = g.score();

            // 斷言比對
            Assert.AreEqual(expected, actual);
        }
    }
}
