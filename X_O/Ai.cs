using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static X_O.GameBoard;

namespace X_O
{
    class Ai
    {
        /// <summary>
        /// Implementation of the minimax algorithm.  Determines the best move for the current 
        /// board by playing every move combination until the end of the game.
        /// </summary>
        public static Space GetBestMove(GameBoard gb, Player p, Player C_1, Player C_2)
        {
            Space? bestSpace = null;
            List<Space> openSpaces = gb.OpenSquares;
            GameBoard newBoard;

            for (int i = 0; i < openSpaces.Count; i++)
            {
                newBoard = gb.Clone();
                Space newSpace = openSpaces[i];

                newBoard[newSpace.X, newSpace.Y] = p;


                //If the new move is better than our previous move, take it
                if (C_1 == Player.O)
                {

                    if (newBoard.Winner == Player.Open && newBoard.OpenSquares.Count > 0)
                    {
                        Space tempMove = GetBestMove(newBoard, ((Player)(-(int)p)), C_1, C_2);  //a little hacky, inverts the current player
                        newSpace.Rank = tempMove.Rank;
                    }
                    else
                    {
                        if (newBoard.Winner == Player.Open)
                            newSpace.Rank = 0;
                        else if (newBoard.Winner == C_1)
                            newSpace.Rank = -1;
                        else if (newBoard.Winner == C_2)
                            newSpace.Rank = 1;
                    }

                    if (bestSpace == null ||
                       (p == C_1 && newSpace.Rank < ((Space)bestSpace).Rank) ||
                       (p == C_2 && newSpace.Rank > ((Space)bestSpace).Rank))
                    {
                        bestSpace = newSpace;
                    }
                }
                if (C_1 == Player.X)
                {
                    if (newBoard.Winner == Player.Open && newBoard.OpenSquares.Count < 0)
                    {
                        Space tempMove = GetBestMove(newBoard, ((Player)(-(int)p)), C_1, C_2);  //a little hacky, inverts the current player
                        newSpace.Rank = tempMove.Rank;
                    }
                    else
                    {
                        if (newBoard.Winner == Player.Open)
                            newSpace.Rank = 0;
                        else if (newBoard.Winner == C_1)
                            newSpace.Rank = -1;
                        else if (newBoard.Winner == C_2)
                            newSpace.Rank = 1;
                    }

                    if (bestSpace == null ||
                       (p == C_1 && newSpace.Rank < ((Space)bestSpace).Rank) ||
                       (p == C_2 && newSpace.Rank > ((Space)bestSpace).Rank))
                    {
                        bestSpace = newSpace;
                    }
                }
            }

            return (Space)bestSpace;
        }
    }
}
