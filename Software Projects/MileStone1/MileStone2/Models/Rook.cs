using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone2.Models
{
    using MileStone2.Interfaces;
    public class Rook : ChestPiece, Piece
    { 
        public Rook(char rank, char side, char col, int row) : base(rank , side, col, row)
        {  
        }

        public bool CheckColumn(char col)
        {
            throw new NotImplementedException();
        }

        public bool CheckColumn(char[] validColumns, char col)
        {
            throw new NotImplementedException();
        }

        public bool CheckRow(int row)
        {
            throw new NotImplementedException();
        }

        public bool CheckRow(int[] validRows, int row)
        {
            throw new NotImplementedException();
        }

        public bool Move(char col, int row)
        {
            bool canMove = false;
            if(col == this.Column)
            {
                if(row >= 1 && row <= 8)
                {
                    canMove = true;
                }
            }
            else if(row == this.Row)
            {
                if(ColToInt(col) >= 1 && ColToInt(col) <= 8)
                {
                    canMove = true;
                }
            }
            return canMove;
        }

        public char[] ValidColumns(char col)
        {
            throw new NotImplementedException();
        }

        public int[] ValidRows(int row)
        {
            throw new NotImplementedException();
        }
    }
}
