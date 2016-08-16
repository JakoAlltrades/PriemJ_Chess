using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3.Models
{
    public class ChestPiece
    {
        public char Rank { get; set; }
        public char Side { get; set; }
        public char Column { get; set; }
        public int Row { get; set; }
        public ChestPiece(char piece, char color, char col, int row)
        {
            Rank = piece;
            Side = color;
            Column = col;
            Row = row;
        }

        protected int ColToInt(char col)
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

        protected char ColIntToChar(int col)
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
    }
}
