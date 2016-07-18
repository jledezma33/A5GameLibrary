using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        int indexOfCurrentPlayer = 0;
        activePlayer = players[indexOfCurrentPlayer];

            while (!GameOver())
            {
                Console.WriteLine("Here is the board:");
                PrintBoard();

                TakeTurn(activePlayer);
        //select the other player
        indexOfCurrentPlayer = (indexOfCurrentPlayer == 0) ? 1 : 0;
                activePlayer = players[indexOfCurrentPlayer];

                //Added this slight delay for user experience.  Without it it's harder to notice the board repaint
                //try commenting it out and check out the difference.  Which do you prefer?
                System.Threading.Thread.Sleep(300);

                Console.Clear();
            }
}
}
