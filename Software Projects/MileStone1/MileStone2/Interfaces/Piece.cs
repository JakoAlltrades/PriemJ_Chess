using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone2.Interfaces
{
    public interface Piece
    {
        bool Move(char col, int row);
        char[] ValidColumns(char col);
        int[] ValidRows(int row);
        bool CheckColumn(char[] validColumns, char col);
        bool CheckRow(int[] validRows, int row);
    }
}
