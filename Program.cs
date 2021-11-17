using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int POSITION = 0;
            UC_3_CheckForOption obj1 = new UC_3_CheckForOption();
            obj1.checkingForOption();

            UC_4_WinningPosition obj2 = new UC_4_WinningPosition();
            obj2.winPosition();

            UC_5_ExactWinningPosition obj3 = new UC_5_ExactWinningPosition();
            obj3.exactWinPosition();

            UC_6_WiningPositionAndDiceCount obj4 = new UC_6_WiningPositionAndDiceCount();
            obj4.diceCountToWinTheGame();

            UC_7_TwoPlayerGameToWinTheGame obj5 = new UC_7_TwoPlayerGameToWinTheGame();
            obj5.playGame();
        }
    }
}
