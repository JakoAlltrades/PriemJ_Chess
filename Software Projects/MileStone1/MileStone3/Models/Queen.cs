using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3.Models
{
    using MileStone3.Interfaces;
    public class Queen : ChestPiece, Piece
    {
        public Queen(char rank, char side, char col, int row) : base(rank, side, col, row)
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
            Column = col;
            Row = row;
            return canMove;
        }

        public int[] ValidRows(int row)
        {
            throw new NotImplementedException();
        }

        bool Piece.Move(char col, int row)
        {
            throw new NotImplementedException();
        }

        char[] Piece.ValidColumns(char col)
        {
            throw new NotImplementedException();
        }
    }
}
