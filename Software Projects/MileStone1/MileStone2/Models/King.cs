using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone2.Models
{
    using MileStone2.Interfaces;
    public class King : ChestPiece, Piece
    {
        public King(char rank, char side, char col, int row) : base(rank , side, col, row)
        {
        }

        

        public bool CheckColumn(char[] validColumns, char col)
        {
            bool validColumn = false;
            for (int c = 0; c < validColumns.Length; c++)
            {
                if (col == validColumns[c])
                {
                    validColumn = true;
                }
            }
            return validColumn;
        }

        

        public bool CheckRow(int[] validRows, int row)
        {
            bool validRow = false;
            for(int r = 0; r < validRows.Length; r++)
            {
                if(row == validRows[r])
                {
                    validRow = true;
                }
            }
            return validRow;
        }

        public bool Move(char col, int row)
        {
            bool validMove = false;
            if (KingMove(col, row))
            {
                Column = col;
                Row = row;
                validMove = true;
            }

           return validMove;
        }

        public char[] ValidColumns(char col)
        {
            char[] validMoves = new char[3];
            int count = 0;
            for (int c = ColToInt(col) - 1; c < ColToInt(col) + 1; c++)
            {
                validMoves[count] = ColIntToChar(c);
                count++;
            }
            return validMoves;
        }

        public int[] ValidRows(int row)
        {
            int[] validMoves = new int[3];
            int count = 0;
            for (int r = row - 1; r < row + 1; r++)
            {
                validMoves[count] = r;
                count++;
            }
            return validMoves;
        }

        private bool KingMove( char col, int row)
        {
            bool validMove = false;
            char[] validCol = ValidColumns(col);
            int[] validRow = ValidRows(row);
            if(CheckColumn(validCol, col) && CheckRow(validRow, row))
            {
                validMove = true;
            }
            return validMove;
        }
    }
}
