using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bears_ConnectFour
{
    class Board
    {
        public Piece[,] Grid { get; set; }

        public Board()
        {
            InstantiateGrid();
        }

        public void PrintGrid()
        {
            for (int r = 0; r < Grid.GetLength(0); r++)
            {
                for (int c = 0; c < Grid.GetLength(1); c++)
                {
                    Console.ForegroundColor = Grid[r, c].Color;
                    Console.Write(Grid[r,c].Icon);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// fill the grid with blank spaces
        /// </summary>
        private void InstantiateGrid()
        {
            Grid = new Piece[6, 7];
            for (int r = 0; r < Grid.GetLength(0); r++)
            {
                for (int c = 0; c < Grid.GetLength(1); c++)
                {
                    Grid[r, c] = new Piece { Id = 0, Icon='O',Color=ConsoleColor.Red};
                }
            }
        }

        /// <summary>
        /// determine if a player won the game
        /// Function will return an Id of the winning player, or 0 if the move was not a winning move
        /// </summary>
        /// <returns>winning Pieces id</returns>
        public int CheckWin( Piece grid, int [,] moveCoords ) {

            bool win = false;

            // Get row
            int r = moveCoords[0];

            // Get Column
            int c = moveCoords[1];

            // Get the ID of the piece
            int playerId = grid[r,c];

            //
            // Check Vertical
            //
            int piecesConnected = 0;
            for (int r = 0; r < grid.GetLength(0); r++)
			{
                if (grid[r,c].Id == playerId)
	            {
                    piecesConnected++;
                    if (piecesConnected == 4)
	                {
                        win = true;
                        return playerId;
	                }
	            } else {
                    piecesConnected = 0;
                    }
			}

            //
            // Check Horizontal
            //
            piecesConnected = 0;
            for (int c = 0; c < grid.GetLength(1); c++)
			{
                if (grid[r,c].Id == playerId)
	            {
                    piecesConnected++;
                    if (piecesConnected == 4)
	                {
                        win = true;
                        return playerId;
	                }
	            } else {
                    piecesConnected = 0;
                    }
			}

            //
            // Check NW to SE
            //
            piecesConnected = 0;
            for (int i = r; i > 0; i--)
			{
                if ((i > grid.getLength(0)) && ())
	            {

	            }
			}
            // if row not out of bounds AND column not out of bounds, then decrement row and col val by 1










            // 
            if ((r-1) >= 0)
	        {

	        } else {

            }

            // Check currRow - 1

            // Check currCol - 1






            for (int i = 0; i < length; i++)
			{
                if (grid[r,(c + i)].Id == playerId)
	            {
                    piecesConnected++;
	            }
			}

            // if(grid[r,(c + 1)].Id == playerId) => piecesConnected++;
            // 
            //
            //
            //
            //
            //
            //


            // Check NW to SE


            if (win == true)
            {
                return playerId;
            } else {
                return -1;
            }               
        }
    }
}
