using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Cell
    {
        public int rowNum { get; set; }
        public int colNum { get; set; }
        public bool currentlyOccupied { get; set; }
        public bool legalNextMove { get; set; }



        public Cell(int x, int y)
        {
            rowNum = x;
            colNum = y;

        }
    }
}
