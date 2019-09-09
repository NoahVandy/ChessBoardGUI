namespace ChessBoardModel
{
    public class Board
    {
        //the size of the board usually 8x8
        public int size { get; set; }

        // this is the 2D array
        public Cell[,] theGrid { get; set; }

        public Board (int s)
        {
            // initial board size
            size = s;

            //create new 2d array of type cell
            theGrid = new Cell[size, size];

            //fill 2d array with new Cells, each with unique with x and y coord
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    theGrid[i, j] = new Cell(i, j); 
                }
            }
        }


        public void markNextLegalMoves(Cell current, string chessPiece)
        {
            // step 1 - clear all the prievous legal moves

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // this clears the board  
                    theGrid[i, j].legalNextMove = false;
                    theGrid[i, j].currentlyOccupied = false;
                }
            }

            // step 2 - find all legal moves and mark them

            switch (chessPiece)
            {
                case "Knight":
                    if (isSafe(current.rowNum + 2, current.colNum + 1))
                        theGrid[current.rowNum + 2, current.colNum + 1].legalNextMove = true;
                    if (isSafe(current.rowNum + 2, current.colNum - 1))
                        theGrid[current.rowNum + 2, current.colNum - 1].legalNextMove = true;
                    if (isSafe(current.rowNum - 2, current.colNum + 1))
                        theGrid[current.rowNum - 2, current.colNum + 1].legalNextMove = true;
                    if (isSafe(current.rowNum - 2, current.colNum - 1))
                        theGrid[current.rowNum - 2, current.colNum - 1].legalNextMove = true;
                    if (isSafe(current.rowNum + 1, current.colNum + 2))
                        theGrid[current.rowNum + 1, current.colNum + 2].legalNextMove = true;
                    if (isSafe(current.rowNum - 1, current.colNum + 2))
                        theGrid[current.rowNum - 1, current.colNum + 2].legalNextMove = true;
                    if (isSafe(current.rowNum + 1, current.colNum - 2))
                        theGrid[current.rowNum + 1, current.colNum - 2].legalNextMove = true;
                    if (isSafe(current.rowNum - 1, current.colNum - 2))
                        theGrid[current.rowNum - 1, current.colNum - 2].legalNextMove = true;
                    break;

                case "King":
                    if (isSafe(current.rowNum + 1, current.colNum + 1))
                        theGrid[current.rowNum + 1, current.colNum + 1].legalNextMove = true;
                    if (isSafe(current.rowNum - 1, current.colNum - 1))
                        theGrid[current.rowNum - 1, current.colNum - 1].legalNextMove = true;
                    if (isSafe(current.rowNum + 1, current.colNum - 1))
                        theGrid[current.rowNum + 1, current.colNum - 1].legalNextMove = true;
                    if (isSafe(current.rowNum - 1, current.colNum + 1))
                        theGrid[current.rowNum - 1, current.colNum + 1].legalNextMove = true;
                    if (isSafe(current.rowNum + 1, current.colNum + 0))
                        theGrid[current.rowNum + 1, current.colNum + 0].legalNextMove = true;
                    if (isSafe(current.rowNum - 1, current.colNum + 0))
                        theGrid[current.rowNum - 1, current.colNum + 0].legalNextMove = true;
                    if (isSafe(current.rowNum + 0, current.colNum + 1))
                        theGrid[current.rowNum + 0, current.colNum + 1].legalNextMove = true;
                    if (isSafe(current.rowNum + 0, current.colNum - 1))
                        theGrid[current.rowNum + 0, current.colNum - 1].legalNextMove = true;
                    break;

                case "Rook":
                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + 0, current.colNum + i))
                            theGrid[current.rowNum + 0, current.colNum + i].legalNextMove = true;
                    }
                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + i, current.colNum + 0))
                            theGrid[current.rowNum + i, current.colNum + 0].legalNextMove = true;
                    }
                    break;

                case "Queen":
                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + 0, current.colNum + i))
                            theGrid[current.rowNum + 0, current.colNum + i].legalNextMove = true;
                    }
                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + i, current.colNum + 0))
                            theGrid[current.rowNum + i, current.colNum + 0].legalNextMove = true;
                    }

                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + i, current.colNum - i))
                            theGrid[current.rowNum + i, current.colNum - i].legalNextMove = true;
                    }
                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + i, current.colNum + i))
                            theGrid[current.rowNum + i, current.colNum + i].legalNextMove = true;
                    }
                    break;

                case "Bishop":
                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + i, current.colNum - i))
                            theGrid[current.rowNum + i, current.colNum - i].legalNextMove = true;
                    }
                    for (int i = -size; i < size; i++)
                    {
                        if (isSafe(current.rowNum + i, current.colNum + i))
                            theGrid[current.rowNum + i, current.colNum + i].legalNextMove = true;
                    }
                    break;

                default:
                    break;


            }
            theGrid[current.rowNum, current.colNum].currentlyOccupied = true;
        }

        public bool isSafe(int x, int y)
        {
            if (x >= 0 && x < size && y >= 0 && y < size)
            {
                return true;
            }
            else
                return false;


        }
    }
}
