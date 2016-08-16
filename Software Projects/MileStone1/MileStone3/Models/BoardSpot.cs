using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3.Models
{
    public class BoardSpot
    {
        private ChestPiece _piece = null;
        private char _rank = '-';
        public bool isGreen { get; set; }
        public int boardRow { get; set; }
        public char boardCol { get; set; }
        public ChestPiece piece { get { return _piece; } set { _piece = value; if (_piece != null) { CheckRank(); } } }
        public char Rank { get { return _rank; } set { _rank = value; } }
        
        public BoardSpot(int row, char col, ChestPiece p = null)
        {
            boardRow = row;
            boardCol = col;
            piece = p;
            isGreen = checkIsGreen(piece);
        }

        public bool checkIsGreen(ChestPiece p)
        {
            bool isEmpty = true;
            if(p != null)
            {
                isEmpty = false;
                Rank = p.Rank;
                isEmpty = false;
            }
            return isEmpty;
        }

        private void CheckRank()
        {
            switch (piece.Rank)
            {
                case 'K':
                    Rank = 'K';
                    break;
                case 'Q':
                    Rank = 'Q';
                    break;
                case 'B':
                    Rank = 'B';
                    break;
                case 'N':
                    Rank = 'N';
                    break;
                case 'R':
                    Rank = 'R';
                    break;
                case 'P':
                    Rank = 'P';
                    break;
            }
        }
    }
}
