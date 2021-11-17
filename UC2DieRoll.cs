using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class UC2DieRoll
    {
        public void playerRolledDie()
        {
            Console.WriteLine("Snake And Ladder");
            Random random = new Random();
            int player = random.Next(0, 6) + 1;
            Console.WriteLine("Outcome is : " + player);
        }
    }
}
