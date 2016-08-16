using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MileStone2.Models;

namespace MileStone3.Models
{
    public class Board 
    {
        BoardSpot[] board = new BoardSpot[64];
        int rowLength = 8;
        int colLength = 8;
        public void InitBoard()
        {
            for(int r = 0; r < rowLength; r++)
            {
                for(int c = 0; c < colLength; c++)
                {
                    board[(r* colLength) + c] = new BoardSpot(r, ColIntToChar(c));
                }
            }
        }

        public bool Place(ChestPiece p)
        {   
            return PlaceOnBoard(p);
        }

        private bool PlaceOnBoard(ChestPiece p)
        {
            bool placed = false;
            if(p != null)
            {
                board[(boardRow(p.Row) * colLength) + ColToInt(p.Column)].piece = p;
                placed = board[(boardRow(p.Row) * colLength) + ColToInt(p.Column)].isGreen;
            }
            return placed;
        }

        private ChestPiece setPiece(ChestPiece p)
        {
            switch (p.Rank)
            {
                case 'K':
                    return new King(p.Rank, p.Side, p.Column, p.Row);
                case 'Q':
                    return new Queen(p.Rank, p.Side, p.Column, p.Row);
                case 'B':
                    return new Bishop(p.Rank, p.Side, p.Column, p.Row);
                case 'N':
                    return new Knight(p.Rank, p.Side, p.Column, p.Row);
                case 'R':
                    return new Rook(p.Rank, p.Side, p.Column, p.Row);
                case 'P':
                    return new Pawn(p.Rank, p.Side, p.Column, p.Row);
                default:
                    throw new Exception("Not a valid piece! [" + p.Rank + "]");
            }
        }

        public void PrintBoard()
        {
            Console.WriteLine("\nDark");
            for(int b = 0; b < board.Length; b++)
            {
                if((b >= 7) &&((b + 1) % 8 == 0))
                {
                    Console.Write(board[b].Rank + "\n");
                }
                else
                {
                    Console.Write(board[b].Rank);
                }
            }
            Console.WriteLine("Light\n");
        }

        private int ColToInt(char col)
        {
            int c = 0;
            switch (col)
            {
                case 'A':
                    c = 0;
                    break;
                case 'B':
                    c = 1;
                    break;
                case 'C':
                    c = 2;
                    break;
                case 'D':
                    c = 3;
                    break;
                case 'E':
                    c = 4;
                    break;
                case 'F':
                    c = 5;
                    break;
                case 'G':
                    c = 6;
                    break;
                case 'H':
                    c = 7;
                    break;
            }
            return c;
        }

        private char ColIntToChar(int col)
        {
            char c = 'I';
            switch (col)
            {
                case 0:
                    c = 'A';
                    break;
                case 1:
                    c = 'B';
                    break;
                case 2:
                    c = 'C';
                    break;
                case 3:
                    c = 'D';
                    break;
                case 4:
                    c = 'E';
                    break;
                case 5:
                    c = 'F';
                    break;
                case 6:
                    c = 'G';
                    break;
                case 7:
                    c = 'H';
                    break;
            }
            return c;
        }

        public void InitPieces()
        {
            DarkSide();
            LightSide();
        }

        private void DarkSide()
        {
            board[(1 * colLength) + 0].piece = new Pawn('P', 'd', 'A', 7);
            board[(1 * colLength) + 1].piece = new Pawn('P', 'd', 'B', 7);
            board[(1 * colLength) + 2].piece = new Pawn('P', 'd', 'C', 7);
            board[(1 * colLength) + 3].piece = new Pawn('P', 'd', 'D', 7);
            board[(1 * colLength) + 4].piece = new Pawn('P', 'd', 'E', 7);
            board[(1 * colLength) + 5].piece = new Pawn('P', 'd', 'F', 7);
            board[(1 * colLength) + 6].piece = new Pawn('P', 'd', 'G', 7);
            board[(1 * colLength) + 7].piece = new Pawn('P', 'd', 'H', 7);
            board[(0 * colLength) + 0].piece = new Rook('R', 'd', 'A', 8);
            board[(0 * colLength) + 1].piece = new Knight('N', 'd', 'B', 8);
            board[(0 * colLength) + 2].piece = new Bishop('B', 'd', 'C', 8);
            board[(0 * colLength) + 3].piece = new Queen('Q', 'd', 'D', 8);
            board[(0 * colLength) + 4].piece = new King('K', 'd', 'E', 8);
            board[(0 * colLength) + 5].piece = new Bishop('B', 'd', 'F', 8);
            board[(0 * colLength) + 6].piece = new Knight('N', 'd', 'G', 8);
            board[(0 * colLength) + 7].piece = new Rook('R', 'd', 'H', 8);
        }

        private void LightSide()
        {
            board[(6 * colLength) + 0].piece = new Pawn('P', 'l', 'A', 2);
            board[(6 * colLength) + 1].piece = new Pawn('P', 'l', 'B', 2);
            board[(6 * colLength) + 2].piece = new Pawn('P', 'l', 'C', 2);
            board[(6 * colLength) + 3].piece = new Pawn('P', 'l', 'D', 2);
            board[(6 * colLength) + 4].piece = new Pawn('P', 'l', 'E', 2);
            board[(6 * colLength) + 5].piece = new Pawn('P', 'l', 'F', 2);
            board[(6 * colLength) + 6].piece = new Pawn('P', 'l', 'G', 2);
            board[(6 * colLength) + 7].piece = new Pawn('P', 'l', 'H', 2);
            board[(7 * colLength) + 0].piece = new Rook('R', 'l', 'A', 1);
            board[(7 * colLength) + 1].piece = new Knight('N', 'l', 'B', 1);
            board[(7 * colLength) + 2].piece = new Bishop('B', 'l', 'C', 1);
            board[(7 * colLength) + 3].piece = new Queen('Q', 'l', 'D', 1);
            board[(7 * colLength) + 4].piece = new King('K', 'l', 'E', 1);
            board[(7 * colLength) + 5].piece = new Bishop('B', 'l', 'F', 1);
            board[(7 * colLength) + 6].piece = new Knight('N', 'l', 'G', 1);
            board[(7 * colLength) + 7].piece = new Rook('R', 'l', 'H', 1);
        }

        private int boardRow(int Prow)
        {
            int bRow = -1;
            switch (Prow)
            {
                case 8:
                    bRow = 0;
                    break;
                case 7:
                    bRow = 1;
                    break;
                case 6:
                    bRow = 2;
                    break;
                case 5:
                    bRow = 3;
                    break;
                case 4:
                    bRow = 4;
                    break;
                case 3:
                    bRow= 5;
                    break;
                case 2:
                    bRow = 6;
                    break;
                case 1:
                    bRow = 7;
                    break;
            }
            return bRow;
        }
    }
}
